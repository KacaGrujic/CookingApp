using Common.Model;
using Klijent.UserControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Klijent.GuiController
{
    public class ReceptGuiController
    {
        UCUnosRecepta unos;
        Korisnik korisnik = new Korisnik();
        List<Jelo> listaJela = new List<Jelo>();
        List<Namirnica> listaNamirnica = new List<Namirnica>();
        UCPrikazRecepata prikaz;
        List<Recept> listaRecepata = new List<Recept>();
        List<StavkaRecepta> listaSR = new List<StavkaRecepta>();
        UCIzmenaRecepta izmena;

        internal Control DodajRecept(Korisnik korisnik)
        {
            unos = new UCUnosRecepta();
            listaJela = Communication.Communication.Instance.VratiJela();
            listaNamirnica = Communication.Communication.Instance.VratiNamirnice();

            unos.CbJelo.DataSource = listaJela.Cast<object>().ToList();
            unos.CbNamirnica.DataSource = listaNamirnica.Cast<object>().ToList();

            var MJEnum = Enum.GetValues(typeof(MernaJedinica));
            var mj = new List<object>();

            foreach (MernaJedinica m in MJEnum)
            {
                mj.Add(m);
            }

            unos.CbMJ.DataSource = mj;

            Console.WriteLine("vrstaa jela " + listaJela.Count);

            unos.CbJelo.SelectedIndex = -1; 
            unos.CbNamirnica.SelectedIndex = -1;
            unos.CbMJ.SelectedIndex = -1; 


            //events
            unos.BtnDodaj.Click += DodajStavku;
            unos.BtnObrisi.Click += ObrisiStavku;
            unos.BtnKreiraj.Click += (sender, e) => Sacuvaj(sender, e, korisnik);

            unos.BtnCancel.Click += (sender, args) =>
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da otkažete unos recepta?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
                {
                    MainCoordinator.Instance.ShowRecept();
                }

            };

            return unos;

        }

        private void Sacuvaj(object sender, EventArgs e, Korisnik korisnik)
        {
            if (string.IsNullOrWhiteSpace(unos.TxtNaziv.Text) || string.IsNullOrWhiteSpace(unos.TxtProfilIshrane.Text) ||  listaSR.Count == 0 || string.IsNullOrWhiteSpace(unos.TxtVremeKuvanja.Text))
            {
                MessageBox.Show("Molimo da popunite sva polja i unesete barem jednu stavku recepta!");
                return;
            }

            Recept r = new Recept();

            r.Naziv = unos.TxtNaziv.Text;
            r.Opis = unos.TxtOpis.Text;
            r.VremeKuvanja = (int)int.Parse(unos.TxtVremeKuvanja.Text);
            if (unos.RbLak.Checked)
            {
                r.Tezina = "Lak";
            }
            else if (unos.RbSrednji.Checked)
            {
                r.Tezina = "Srednji";
            }
            else if (unos.RbTezak.Checked)
            {
                r.Tezina = "Tezak";
            }
            else
            {
                MessageBox.Show("Molimo izaberite tezinu!");
                return;
            }

            //unos.ChkLak.CheckedChanged += CheckboxCheckedChanged;
            //unos.ChkSrednji.CheckedChanged += CheckboxCheckedChanged;
            //unos.ChkTezak.CheckedChanged += CheckboxCheckedChanged;

            unos.RbLak.CheckedChanged += TezinaRadioButton_CheckedChanged;
            unos.RbSrednji.CheckedChanged += TezinaRadioButton_CheckedChanged;
            unos.RbTezak.CheckedChanged += TezinaRadioButton_CheckedChanged;

            unos.RbLak.Checked = true;


            r.Jelo = unos.CbJelo.SelectedItem as Jelo;
            r.Korisnik = korisnik;
            r.UkupneKalorije = int.Parse(unos.TxtUkupneKalorije.Text);
            r.profili = new List<ProfilIshrane>();

            ProfilIshrane profil = new ProfilIshrane();
            profil.Naziv = unos.TxtProfilIshrane.Text;

            r.ProfilIshrane = profil;
            r.profili.Add(profil);
            //profil.Recept = r;

            
            foreach(Jelo jelo in listaJela)
            {
                if(jelo.JeloID == r.Jelo.JeloID)
                {
                    profil.VrstaJelaID = jelo.VrstaJela.VrstaJelaID;
                    Console.WriteLine("ID vrste jela u profilu ishrane : " + profil.VrstaJelaID);
                }
            }

            //dodaj u listu alergena
            r.StavkeRecepta = listaSR;

            Communication.Communication.Instance.ZapamtiRecept(r);
  

            MainCoordinator.Instance.recept.ChangePanel(PrikaziRecepte());

        }

        private void TezinaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            Control container = radioButton.Parent; 

            if (container != null && container.Controls.Count > 0)
            {
                foreach (Control control in container.Controls)
                {
                    if (control is RadioButton otherRadioButton && otherRadioButton != radioButton)
                    {
                        otherRadioButton.Checked = false;
                    }
                }
            }
        }



        private void ObrisiStavku(object sender, EventArgs e)
        {
            if (unos.DataGridView1.SelectedRows.Count > 0)
            {
                StavkaRecepta s = (StavkaRecepta)unos.DataGridView1.SelectedRows[0].DataBoundItem;

                DialogResult result = MessageBox.Show("Sistem je ucitao stavku recepta.Da li ste sigurni da želite da je obrisete?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    listaSR.Remove(s);
                    osveziDataGridView();
                    MessageBox.Show("Sistem je obrisao stavku recepta");
                }
                else
                {
                    MessageBox.Show("Stavka nije obrisana");
                }


                unos.TxtUkupneKalorije.Text = izracunajUkupneKalorije().ToString();
            }
        }

        private void DodajStavku(object sender, EventArgs e)
        {
            if(unos.CbMJ.SelectedItem == null || 
                unos.CbNamirnica.SelectedItem == null ||
                unos.NumericKolicina.Value < 1)
            {
                MessageBox.Show("Obavezna su sva polja za unos stavke recepta");
                return;
            }

            StavkaRecepta stavka = new StavkaRecepta();

            Namirnica nam = unos.CbNamirnica.SelectedItem as Namirnica;
            stavka.Namirnica = nam;
            stavka.Kolicina = (int)unos.NumericKolicina.Value;

            //int ukupneKal = stavka.Kolicina * stavka.Namirnica.Kalorije;
            //stavka.UkupneKalorije = ukupneKal;

            switch ((MernaJedinica)unos.CbMJ.SelectedItem)
            {
                case MernaJedinica.g:
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije;
                    break;
                case MernaJedinica.Kg:
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije * 10;
                    break;
                case MernaJedinica.ml:
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije;

                    break;
                case MernaJedinica.l:
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije * 10;

                    break;
                case MernaJedinica.Pcs:
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije;

                    break;

                default:
                    MessageBox.Show("Nepoznata merna jedinica.");
                    return;
            }

            MernaJedinica mernajedinica = (MernaJedinica)unos.CbMJ.SelectedItem;
            stavka.MernaJedinica = mernajedinica;

            listaSR.Add(stavka);

            osveziDataGridView();

            unos.TxtUkupneKalorije.Text = izracunajUkupneKalorije().ToString();
        }

        private int izracunajUkupneKalorije()
        {
            int total = 0;
            foreach(var stavka in listaSR)
            {
                total += stavka.UkupneKalorije;
            }
            return total;
        }

        private void osveziDataGridView()
        {
            unos.DataGridView1.DataSource = null;
            unos.DataGridView1.DataSource = listaSR;
        }

        internal Control PrikaziRecepte()
        {
            prikaz = new UCPrikazRecepata();

            listaRecepata = Communication.Communication.Instance.VratiRecepte();

            prikaz.DgvPrikazRecepata.DataSource = listaRecepata;

            listaNamirnica = Communication.Communication.Instance.VratiNamirnice();

            prikaz.CheckedListNamirnice.DataSource = listaNamirnica;
            Console.WriteLine("Lista nam : " + listaNamirnica.Count);
            prikaz.CheckedListNamirnice.DisplayMember = "Naziv";
            prikaz.CheckedListNamirnice.ItemCheck += CheckedListNamirnice_ItemCheck;

            prikaz.TxtNamirnicaFilter.TextChanged += TxtNamirnicaFilter_TextChanged;

            foreach (Recept r in listaRecepata)
            {
                Console.WriteLine(r.StavkeRecepta.Count);
            }

            prikaz.TxtPretragaNaziv.TextChanged += Pretrazi;

            prikaz.ChkLak.CheckedChanged += CheckBoxes_CheckedChanged;
            prikaz.ChkSrednji.CheckedChanged += CheckBoxes_CheckedChanged;
            prikaz.ChkTezak.CheckedChanged += CheckBoxes_CheckedChanged;

            prikaz.BtnDetalji.Click += Detalji;


            EventHandler izmeniReceptHandler = null;

            izmeniReceptHandler = (sender, args) =>
            {
                if (prikaz.DgvPrikazRecepata.SelectedRows.Count > 0)
                {
                    Recept receptZaIzmenu = (Recept)prikaz.DgvPrikazRecepata.SelectedRows[0].DataBoundItem;
                    Console.WriteLine("recept za izmenu id : " + receptZaIzmenu.ReceptID);

                    Recept rec = Communication.Communication.Instance.UcitajRecept(receptZaIzmenu);
                    MessageBox.Show("Sistem je ucitao recept ");
                    MainCoordinator.Instance.ShowIzmeniRecept(MainCoordinator.Instance.recept, rec);
                }
                else
                {
                    MessageBox.Show("Morate odabrati recept za izmenu!");
                };

                MainCoordinator.Instance.recept.BtnIzmeni.Click -= izmeniReceptHandler;
            };

            MainCoordinator.Instance.recept.BtnIzmeni.Click += izmeniReceptHandler;

            MainCoordinator.Instance.recept.BtnObrisi.Click += (sender, args) =>
            {
                if (prikaz.DgvPrikazRecepata.SelectedRows.Count > 0)
                {

                    MainCoordinator.Instance.recept.Panel3.Height = MainCoordinator.Instance.recept.BtnObrisi.Height; MainCoordinator.Instance.recept.Panel3.Top = MainCoordinator.Instance.recept.BtnObrisi.Top;

                    Recept receptZaBrisanje = (Recept)prikaz.DgvPrikazRecepata.SelectedRows[0].DataBoundItem;
                    Console.WriteLine("recept za brisanje id : " + receptZaBrisanje.ReceptID);

                    Recept rec = Communication.Communication.Instance.UcitajRecept(receptZaBrisanje);
                    MessageBox.Show("Sistem je ucitao recept!");

                    DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete recept?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Communication.Communication.Instance.ObrisiRecept(rec);
                        MessageBox.Show("Recept uspešno obrisan.");

                        listaRecepata = Communication.Communication.Instance.VratiRecepte();

                        prikaz.DgvPrikazRecepata.DataSource = listaRecepata;
                        MainCoordinator.Instance.recept.Panel3.Height = MainCoordinator.Instance.recept.BtnHome.Height; MainCoordinator.Instance.recept.Panel3.Top = MainCoordinator.Instance.recept.BtnHome.Top;
                    }
                    else
                    {
                        MainCoordinator.Instance.recept.Panel3.Height = MainCoordinator.Instance.recept.BtnHome.Height; MainCoordinator.Instance.recept.Panel3.Top = MainCoordinator.Instance.recept.BtnHome.Top;
                    }
                }
                else
                {
                    MessageBox.Show("Morate odabrati recept za brisanje!");
                }
            };

            return prikaz;
        }

        private void Detalji(object sender, EventArgs e)
        {
            if (prikaz.DgvPrikazRecepata.SelectedRows.Count > 0)
            {
                DataGridViewRow red = prikaz.DgvPrikazRecepata.SelectedRows[0];

                Recept selectedRecept = (Recept)red.DataBoundItem;

                DisplayReceptDetails(selectedRecept);
            }
            else MessageBox.Show("Morate odabrati recept da biste videli detalje!");
        }

        private void DisplayReceptDetails(Recept selectedRecept)
        {
            prikaz.Panel1.Visible = false;
            prikaz.GbDetalji.Visible = true;
            prikaz.BtnNazad.Visible = true;

            prikaz.TxtNaziv.Text = selectedRecept.Naziv;
            prikaz.TxtTezina.Text = selectedRecept.Tezina;
            prikaz.TxtJelo.Text = selectedRecept.Jelo.Naziv;
            prikaz.TxtTezina.Text = selectedRecept.Tezina;
            prikaz.TxtProfilIshrane.Text = selectedRecept.profili[0].ToString();
            prikaz.TxtUkupneKalorije.Text = selectedRecept.UkupneKalorije.ToString();
            prikaz.TxtOpis.Text= selectedRecept.Opis.ToString();
            prikaz.TxtVreme.Text = selectedRecept.VremeKuvanja.ToString();
            prikaz.TxtKorisnik.Text = selectedRecept.Korisnik.ToString();
            prikaz.DgvStavke.DataSource = selectedRecept.StavkeRecepta;


            //Hash za unikatne
            HashSet<string> allergens = new HashSet<string>();

            foreach (StavkaRecepta stavka in selectedRecept.StavkeRecepta)
            {
                if (stavka.Namirnica.Alergeni != "Ne")
                {
                    if (!allergens.Contains(stavka.Namirnica.Alergeni))
                    {
                        allergens.Add(stavka.Namirnica.Alergeni);
                    }
                }
            }

            prikaz.LblAlergeni.Text = string.Join(", ", allergens);

            prikaz.BtnNazad.Click += BtnNazad_Click;
        }

        private void BtnNazad_Click(object sender, EventArgs e)
        {
            prikaz.Panel1.Visible = true;
            prikaz.GbDetalji.Visible = false;
            prikaz.BtnNazad.Visible = false;
        }


        private void TxtNamirnicaFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = prikaz.TxtNamirnicaFilter.Text.ToLower();

            List<Namirnica> filteredNamirnice = listaNamirnica
                .Where(namirnica => namirnica.Naziv.ToLower().Contains(filterText))
                .ToList();

            prikaz.CheckedListNamirnice.DataSource = null;
            prikaz.CheckedListNamirnice.DataSource = filteredNamirnice;
        }

        private void CheckedListNamirnice_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<Namirnica> checkedNamirnice = new List<Namirnica>();

            foreach (int index in prikaz.CheckedListNamirnice.CheckedIndices)
            {
                checkedNamirnice.Add((Namirnica)prikaz.CheckedListNamirnice.Items[index]);
            }

            if (e.NewValue != e.CurrentValue)
            {
                Namirnica selectedNamirnica = (Namirnica)prikaz.CheckedListNamirnice.Items[e.Index];

                if (e.NewValue == CheckState.Checked)
                {
                    checkedNamirnice.Add(selectedNamirnica);
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    checkedNamirnice.Remove(selectedNamirnica);
                }
            }

            Console.WriteLine("Checked Namirnice: " + checkedNamirnice.Count);
            foreach (Namirnica namirnica in checkedNamirnice)
            {
                Console.WriteLine("Cekirana Namirnica: " + namirnica.Naziv);
            }

            Console.WriteLine("Lista recepata count " + listaRecepata.Count);
            Console.WriteLine("Lista nam count " + listaNamirnica.Count);
            Console.WriteLine("Lista banana sladoled nam count: " +
                listaRecepata.Where(recept => recept.Naziv == "Banana sladoled" && recept.StavkeRecepta != null)
                            .SelectMany(recept => recept.StavkeRecepta)
                            .Count());

            List<Recept> filteredRecepti;

            if (checkedNamirnice.Count > 0)
            {
                filteredRecepti = listaRecepata
                    .Where(recept =>
                        recept.StavkeRecepta.Any(stavka =>
                            checkedNamirnice.Any(cn => stavka.Namirnica.Naziv == cn.Naziv)
                        )
                    )
                    .ToList();
            }
            else
            {
                filteredRecepti = listaRecepata;
            }

            prikaz.DgvPrikazRecepata.DataSource = null;
            prikaz.DgvPrikazRecepata.DataSource = filteredRecepti;

        }





        private void Pretrazi(object sender, EventArgs e)
        {
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }

            string filter = prikaz.TxtPretragaNaziv.Text.ToLower(); 

            List<Recept> filtrirani;


            if (filter.Length > 0)
            {
                Recept r = new Recept()
                {
                    SearchQuery = $" lower(Recept.Naziv) like '%{filter}%'"
                };

                filtrirani = Communication.Communication.Instance.PretraziRecepte(r);

                if(filtrirani.Count <= 0)
                {
                  List<Recept> filtriranirec =  listaRecepata.Where(recept =>
                  recept.Jelo.Naziv.ToLower().Contains(prikaz.TxtPretragaNaziv.Text.ToLower()) ||
                  recept.profili.Any(profil => profil.Naziv.ToLower().Contains(prikaz.TxtPretragaNaziv.Text.ToLower()))
                ).ToList();
                    prikaz.DgvPrikazRecepata.DataSource = filtriranirec;
                }
                else
                prikaz.DgvPrikazRecepata.DataSource = filtrirani;
                //filtrirani = listaRecepata.Where(recept =>
                //  recept.Jelo.Naziv.ToLower().Contains(prikaz.TxtPretragaNaziv.Text.ToLower()) ||
                //  recept.profili.Any(profil => profil.Naziv.ToLower().Contains(prikaz.TxtPretragaNaziv.Text.ToLower()))
                //).ToList();

            }
            else
            {
                filtrirani = Communication.Communication.Instance.VratiRecepte();
            }

            

            
        }


        //private void Cekirano(object sender, EventArgs e)
        //{
        //    List<Recept> filteredRecepti = listaRecepata.Where(recept =>
        //       ((prikaz.ChkLak.Checked && recept.Tezina == "Lak") ||
        //       (prikaz.ChkSrednji.Checked && recept.Tezina == "Srednji") ||
        //       (prikaz.ChkTezak.Checked && recept.Tezina == "Tezak"))
        //   ).ToList();
        //}

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                List<Recept> filteredRecepti = listaRecepata.Where(recept =>
                    ((prikaz.ChkLak.Checked && recept.Tezina == "Lak") ||
                    (prikaz.ChkSrednji.Checked && recept.Tezina == "Srednji") ||
                    (prikaz.ChkTezak.Checked && recept.Tezina == "Tezak"))
                ).ToList();

                prikaz.DgvPrikazRecepata.DataSource = null;
                prikaz.DgvPrikazRecepata.DataSource = filteredRecepti;
            }
            else
            {
                prikaz.DgvPrikazRecepata.DataSource = null;
                prikaz.DgvPrikazRecepata.DataSource = listaRecepata;
            }
        }

        //Izmena


        int idZaIzmenu;


        internal Control IzmeniRecept(Recept receptZaIzmenu)
        {
            izmena = new UCIzmenaRecepta();
            idZaIzmenu = receptZaIzmenu.ReceptID;

            listaJela = Communication.Communication.Instance.VratiJela();
            listaNamirnica = Communication.Communication.Instance.VratiNamirnice();

            izmena.CbJelo.DataSource = listaJela.Cast<object>().ToList();
            izmena.CbNamirnica.DataSource = listaNamirnica.Cast<object>().ToList();

            var MJEnum = Enum.GetValues(typeof(MernaJedinica));
            var mj = new List<object>();

            foreach (MernaJedinica m in MJEnum)
            {
                mj.Add(m);
            }

            izmena.CbMJ.DataSource = mj;



            izmena.CbJela.SelectedItem = receptZaIzmenu.Jelo;


            izmena.TxtNaziv.Text = receptZaIzmenu.Naziv;

            switch (receptZaIzmenu.Tezina)
            {
                case "Lak":
                    izmena.RbLak.Checked = true;
                    break;
                case "Srednji":
                    izmena.RbSrednji.Checked = true;
                    break;
                case "Tezak":
                    izmena.RbTezak.Checked = true;
                    break;
                default:

                    break;
            }

            izmena.RbLak.CheckedChanged += TezinaRadioButton_CheckedChanged1;
            izmena.RbSrednji.CheckedChanged += TezinaRadioButton_CheckedChanged1;
            izmena.RbTezak.CheckedChanged += TezinaRadioButton_CheckedChanged1;


            izmena.TxtVremeKuvanja.Text = receptZaIzmenu.VremeKuvanja.ToString();
            izmena.TxtOpis.Text = receptZaIzmenu.Opis;
            izmena.TxtProfilIshrane.Text = receptZaIzmenu.profili[0].ToString();

            izmena.TxtUkupneKalorije.Text = receptZaIzmenu.UkupneKalorije.ToString();

            kopijaStavki = new List<StavkaRecepta>();

            foreach (StavkaRecepta s in receptZaIzmenu.StavkeRecepta)
            {
                StavkaRecepta stavka = new StavkaRecepta
                {
                    StavkeReceptaID = s.StavkeReceptaID,
                    ReceptID = receptZaIzmenu.ReceptID,
                    Namirnica = s.Namirnica,
                    MernaJedinica = s.MernaJedinica,
                    Kolicina = s.Kolicina,
                };
                kopijaStavki.Add(s);
            }
            
            // kopijaStavki = receptZaIzmenu.StavkeRecepta;

            // izmena.DataGridView1.DataSource = receptZaIzmenu.StavkeRecepta;
            izmena.DataGridView1.DataSource = kopijaStavki;
            izmena.CbNamirnica.SelectedIndex = -1;
            izmena.CbMJ.SelectedIndex = -1;

            //izmena.CbJelo.Texts = receptZaIzmenu.Jelo.Naziv;
            int selectedIndex = izmena.CbJelo.FindStringExact(receptZaIzmenu.Jelo.Naziv);
            if (selectedIndex != -1)
            {
                izmena.CbJelo.SelectedIndex = selectedIndex;
            }

            foreach(StavkaRecepta st in receptZaIzmenu.StavkeRecepta)
            {
                if(st.CrudStatus == Common.CrudStatus.Update)
                {
                    Console.WriteLine("Yes");

                }
            }

            StavkaRecepta stIzmena;

            izmena.BtnIzmeniStavku.Click += (sender, e) =>
            {
                if (izmena.DataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = izmena.DataGridView1.SelectedRows[0];
                    izmena.BtnSacuvajIzmenuStavke.Enabled = true;

                    StavkaRecepta stavkaRecepta = (StavkaRecepta)selectedRow.DataBoundItem;
                    stIzmena = stavkaRecepta;
                    izmena.CbNamirnica.SelectedItem = stavkaRecepta.Namirnica;
                    izmena.NumericKolicina.Value = stavkaRecepta.Kolicina;
                    izmena.CbMJ.SelectedItem = stavkaRecepta.MernaJedinica;
                    //stavkaRecepta.CrudStatus = Common.CrudStatus.Update;

                    foreach(StavkaRecepta st in receptZaIzmenu.StavkeRecepta)
                    {
                        if(st.StavkeReceptaID == stavkaRecepta.StavkeReceptaID)
                        {
                            st.CrudStatus = Common.CrudStatus.Update;
                            st.Namirnica = izmena.CbNamirnica.SelectedItem as Namirnica;
                            st.Kolicina = (int)izmena.NumericKolicina.Value ;
                            st.MernaJedinica = (MernaJedinica)izmena.CbMJ.SelectedItem;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Morate odabrati stavku recepta za izmenu!");
                }
            };

            izmena.BtnDodaj.Click += (sender, e) => DodajStavkuIzmena(sender, e, receptZaIzmenu);
            izmena.BtnObrisi.Click += (sender, e) => ObrisiStavkuIzmena(sender, e, receptZaIzmenu);
            izmena.BtnSacuvajIzmenuStavke.Click += (sender, e) => IzmeniStavku(sender, e, receptZaIzmenu);
            izmena.BtnIzmeni.Click += (s, a) =>
            {
                Izmeni(receptZaIzmenu);
            };

            izmena.BtnCancel.Click += (sender, args) =>
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da otkažete izmenu recepta?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MainCoordinator.Instance.ShowRecept();
                }

            };

            return izmena;
        }


        private void TezinaRadioButton_CheckedChanged1(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            Control container = radioButton.Parent; 

            if (container != null && container.Controls.Count > 0)
            {
                foreach (Control control in container.Controls)
                {
                    if (control is RadioButton otherRadioButton && otherRadioButton != radioButton)
                    {
                        otherRadioButton.Checked = false;
                    }
                }
            }
        }

        private int RecalculateTotalCalories(Recept recept)
        {
            int total = recept.UkupneKalorije;

            foreach (var stavka in recept.StavkeRecepta)
            {
                if (stavka.CrudStatus == Common.CrudStatus.Create)
                {
                    total += stavka.UkupneKalorije;
                }
                else if (stavka.CrudStatus == Common.CrudStatus.Delete)
                {
                    total -= stavka.UkupneKalorije;
                }
                else if (stavka.CrudStatus == Common.CrudStatus.Update)
                {
                    total -= stavka.UkupneKalorijeBeforeUpdate;

                    total += stavka.UkupneKalorije;
                }
            }

            recept.UkupneKalorije = total;
            return total;
        }

        private int CalculateCalories(StavkaRecepta stavka)
        {
            stavka.UkupneKalorije = 0;

            switch (stavka.MernaJedinica)
            {
                case MernaJedinica.g:
                    stavka.UkupneKalorije = 0;
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije;
                    return stavka.Kolicina * stavka.Namirnica.Kalorije;
                case MernaJedinica.Kg:
                    stavka.UkupneKalorije = 0;
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije * 10;
                    return stavka.Kolicina * stavka.Namirnica.Kalorije * 10;
                case MernaJedinica.ml:
                    stavka.UkupneKalorije = 0;
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije;
                    return stavka.Kolicina * stavka.Namirnica.Kalorije;
                case MernaJedinica.l:
                    stavka.UkupneKalorije = 0;
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije * 10;
                    return stavka.Kolicina * stavka.Namirnica.Kalorije * 10;
                case MernaJedinica.Pcs:
                    stavka.UkupneKalorije = 0;
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije;
                    return stavka.Kolicina * stavka.Namirnica.Kalorije;
                default:
                    MessageBox.Show("Nepoznata merna jedinica.");
                    return 0;
            }
        }

        private void IzmeniStavku(object sender, EventArgs e, Recept receptZaIzmenu)
        {
            if (izmena.CbMJ.SelectedItem == null ||
                 izmena.CbNamirnica.SelectedItem == null ||
                 izmena.NumericKolicina.Value < 1)
            {
                MessageBox.Show("Obavezna su sva polja za unos stavke recepta");
                return;
            }



            foreach (StavkaRecepta s in receptZaIzmenu.StavkeRecepta)
            {
                if (s.CrudStatus == Common.CrudStatus.Update)
                {
                    if(s.MernaJedinica == MernaJedinica.Kg || s.MernaJedinica == MernaJedinica.l)
                    {
                        s.UkupneKalorije = s.Kolicina * s.Namirnica.Kalorije * 10;
                    }
                    else
                    {
                        s.UkupneKalorije = s.Namirnica.Kalorije * s.Kolicina;
                    }
                    //s.UkupneKalorijeBeforeUpdate = s.Namirnica.Kalorije * s.Kolicina;
                    s.UkupneKalorijeBeforeUpdate = s.UkupneKalorije;

                    if (!IsCompatibleUnit(s))
                    {
                        MessageBox.Show("Izabrana merna jedinica nije kompatibilna sa trenutnom.");
                        return;
                    }

                    s.MernaJedinica = (MernaJedinica)izmena.CbMJ.SelectedItem;
                    s.Kolicina = (int)izmena.NumericKolicina.Value;
                    s.Namirnica = izmena.CbNamirnica.SelectedItem as Namirnica;

                    s.UkupneKalorije = 0;

                    s.UkupneKalorije = CalculateCalories(s);
                    Console.WriteLine(" pre i posle " + s.UkupneKalorije + " " + s.UkupneKalorijeBeforeUpdate);

                }
            }

            foreach (StavkaRecepta st in kopijaStavki)
            {
                if (st.CrudStatus == Common.CrudStatus.Update)
                {
                    st.MernaJedinica = (MernaJedinica)izmena.CbMJ.SelectedItem;
                    st.Kolicina = (int)izmena.NumericKolicina.Value;
                    st.Namirnica = izmena.CbNamirnica.SelectedItem as Namirnica;
                }
            }

            izmena.CbNamirnica.SelectedIndex = -1;
            izmena.NumericKolicina.Value = 0;
            izmena.CbMJ.SelectedIndex = -1;
            osveziDataGridViewIzmena(receptZaIzmenu);
            izmena.BtnSacuvajIzmenuStavke.Enabled = false;
            izmena.TxtUkupneKalorije.Text = RecalculateTotalCalories(receptZaIzmenu).ToString();
        }

        private bool IsCompatibleUnit(StavkaRecepta stavka)
        {
            MernaJedinica selectedUnit = (MernaJedinica)izmena.CbMJ.SelectedItem;
            MernaJedinica currentUnit = stavka.MernaJedinica;

            switch (currentUnit)
            {
                case MernaJedinica.g:
                    if(selectedUnit == MernaJedinica.g || selectedUnit == MernaJedinica.Pcs || selectedUnit == MernaJedinica.Kg)
                    return true;
                    break;
                case MernaJedinica.Kg:
                    if(selectedUnit == MernaJedinica.g || selectedUnit == MernaJedinica.Pcs || selectedUnit == MernaJedinica.Kg)
                    return true;
                    break;
                case MernaJedinica.ml:
                    if(selectedUnit == MernaJedinica.ml || selectedUnit == MernaJedinica.l)
                    return true;
                    break;
                case MernaJedinica.l:
                    if (selectedUnit == MernaJedinica.ml || selectedUnit == MernaJedinica.l)
                        return true;
                    break;
                case MernaJedinica.Pcs:
                    if (selectedUnit == MernaJedinica.g || selectedUnit == MernaJedinica.Pcs || selectedUnit == MernaJedinica.Kg)
                        return true;
                    break;
                default:
                    return false;
            }
            return false;
        }



        List<StavkaRecepta> kopijaStavki = new List<StavkaRecepta>();

        private void ObrisiStavkuIzmena(object sender, EventArgs e, Recept receptZaIzmenu)
        {
            if (izmena.DataGridView1.SelectedRows.Count > 0)
            {
                StavkaRecepta s = (StavkaRecepta)izmena.DataGridView1.SelectedRows[0].DataBoundItem;

                DialogResult result = MessageBox.Show("Sistem je ucitao stavku recepta.Da li ste sigurni da želite da je obrisete?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //receptZaIzmenu.StavkeRecepta.Remove(s);
                    List<StavkaRecepta> itemsToRemove = new List<StavkaRecepta>();

                    foreach (StavkaRecepta st in receptZaIzmenu.StavkeRecepta)
                    {
                        if (st.StavkeReceptaID == s.StavkeReceptaID)
                        {
                            st.CrudStatus = Common.CrudStatus.Delete;
                            st.UkupneKalorije = st.Kolicina * st.Namirnica.Kalorije;
                            itemsToRemove.Add(st);
                        }
                    }


                    foreach (StavkaRecepta st in itemsToRemove)
                    {
                        //receptZaIzmenu.StavkeRecepta.Remove(st);
                        kopijaStavki.Remove(st);

                    }

                    osveziDataGridViewIzmena(receptZaIzmenu);
                    MessageBox.Show("Sistem je obrisao stavku recepta");

                    foreach(StavkaRecepta st in receptZaIzmenu.StavkeRecepta)
                    {
                        Console.WriteLine("Crud status stavke : " + st.CrudStatus);
                    }
                }
                else
                {
                    MessageBox.Show("Stavka nije obrisana");
                }
                izmena.TxtUkupneKalorije.Text = RecalculateTotalCalories(receptZaIzmenu).ToString();
                //izmena.TxtUkupneKalorije.Text = izracunajUkupneKalorije().ToString();
            }
        }

        private void osveziDataGridViewIzmena(Recept receptZaIzmenu)
        {
            izmena.DataGridView1.DataSource = null;
            izmena.DataGridView1.DataSource = kopijaStavki;
        }

        private void DodajStavkuIzmena(object sender, EventArgs e, Recept receptZaIzmenu)
        {
            if (izmena.CbMJ.SelectedItem == null ||
               izmena.CbNamirnica.SelectedItem == null ||
               izmena.NumericKolicina.Value < 1)
            {
                MessageBox.Show("Obavezna su sva polja za unos stavke recepta");
                return;
            }

            StavkaRecepta stavka = new StavkaRecepta();

            Namirnica nam = izmena.CbNamirnica.SelectedItem as Namirnica;
            stavka.Namirnica = nam;
            stavka.Kolicina = (int)izmena.NumericKolicina.Value;

            int ukupneKal = stavka.Kolicina * stavka.Namirnica.Kalorije;
            stavka.UkupneKalorije = ukupneKal;

            MernaJedinica mernajedinica = (MernaJedinica)izmena.CbMJ.SelectedItem;
            stavka.MernaJedinica = mernajedinica;
            stavka.CrudStatus = Common.CrudStatus.Create;
            //stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije;
            switch ((MernaJedinica)izmena.CbMJ.SelectedItem)
            {
                case MernaJedinica.g:
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije;
                    break;
                case MernaJedinica.Kg:
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije * 10;
                    break;
                case MernaJedinica.ml:
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije;

                    break;
                case MernaJedinica.l:
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije * 10;

                    break;
                case MernaJedinica.Pcs:
                    stavka.UkupneKalorije = stavka.Kolicina * stavka.Namirnica.Kalorije;

                    break;

                default:
                    MessageBox.Show("Nepoznata merna jedinica.");
                    return;
            }
            receptZaIzmenu.StavkeRecepta.Add(stavka);
            kopijaStavki.Add(stavka);
            //listaSR.Add(stavka);
            osveziDataGridViewIzmena(receptZaIzmenu);

            izmena.TxtUkupneKalorije.Text = RecalculateTotalCalories(receptZaIzmenu).ToString();

            //unos.TxtUkupneKalorije.Text = izracunajUkupneKalorije().ToString();

        }

        private void Izmeni(Recept receptZaIzmenu)
        {
            StringBuilder errorMessages = new StringBuilder();
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }

            if (string.IsNullOrWhiteSpace(izmena.TxtNaziv.Text) || string.IsNullOrWhiteSpace(izmena.TxtProfilIshrane.Text) || receptZaIzmenu.StavkeRecepta.Count <= 0 || string.IsNullOrWhiteSpace(izmena.TxtVremeKuvanja.Text))
            {
                MessageBox.Show("Molimo da popunite sva polja i unesete barem jednu stavku recepta!");
                return;
            }

            receptZaIzmenu.Naziv = izmena.TxtNaziv.Text;
            receptZaIzmenu.Opis = izmena.TxtOpis.Text;
            receptZaIzmenu.VremeKuvanja = int.Parse(izmena.TxtVremeKuvanja.Text);
            receptZaIzmenu.UkupneKalorije = int.Parse(izmena.TxtUkupneKalorije.Text);
            if (izmena.RbLak.Checked)
            {
                receptZaIzmenu.Tezina = "Lak";
            }
            else if (izmena.RbSrednji.Checked)
            {
                receptZaIzmenu.Tezina = "Srednji";
            }
            else if (izmena.RbTezak.Checked)
            {
                receptZaIzmenu.Tezina = "Tezak";
            }
            else
            {
                MessageBox.Show("Molimo izaberite tezinu!");
                return;
            }

            receptZaIzmenu.profili[0].Naziv = izmena.TxtProfilIshrane.Text;

            if (errorMessages.Length > 0)
            {
                MessageBox.Show(errorMessages.ToString(), "Greska pri izmeni recepta ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Communication.Communication.Instance.IzmeniRecept(receptZaIzmenu);
            kopijaStavki.Clear();
            MainCoordinator.Instance.recept.ChangePanel(PrikaziRecepte());

        }
    }
}
