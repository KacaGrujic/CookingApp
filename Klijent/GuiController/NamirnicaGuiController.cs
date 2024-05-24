using Common.Model;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GuiController
{
    public class NamirnicaGuiController
    {
        UCPrikazNamirnica prikaz;
        UCNamirnicaMain main;
        UCUnosNamirnice unos;
        UCIzmenaNamirnice izmena;

        List<Namirnica> listaNamirnica = new List<Namirnica>();

        //Sugestija alergena za txtBox

        private List<string> alergeni = new List<string>
        {
            "Gluten",
            "Mlecni proizvodi",
            "Orasasti plodovi",
            "Morski plodovi",
            "Jaja",
            "Kikiriki",
            "Soja",
            "Riba",
            "Skoljke",
        };

        //public NamirnicaGuiController()
        //{
        //    unos.TxtAlergeni.TextChanged += (sender, e) => AlergeniSuggestions(unos.TxtAlergeni);
        //    izmena.TxtAlergeni.TextChanged += (sender, e) => AlergeniSuggestions(izmena.TxtAlergeni);


        //}

      

        internal Control DodajNamirnicu()
        {
            unos = new UCUnosNamirnice();

            unos.BtnAdd.Click += UnesiNamirnicu;
            //  unos.TxtAlergeni.TextChanged += (sender, e) => AlergeniSuggestions(unos.TxtAlergeni);

            unos.BtnCancel.Click += (sender, args) =>
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da otkažete unos namirnice?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MainCoordinator.Instance.ShowNamirnica();
                }

            };

            return unos;
        }

        int idZaIzmenu;

        internal Control IzmeniNamirnicu(Namirnica nam)
        {
            izmena = new UCIzmenaNamirnice();
            izmena.TxtNaziv.Text = nam.Naziv;
            idZaIzmenu = nam.NamirnicaID;
            izmena.TxtAlergeni.Text = nam.Alergeni;
            izmena.TxtKalorije.Text = nam.Kalorije.ToString();
            Console.WriteLine("ID namirnice NamGuiController : " + nam.NamirnicaID);

            // Unsubscribe before subscribing
            izmena.BtnUpdate.Click -= IzmeniNamirnicu;
            izmena.BtnUpdate.Click += IzmeniNamirnicu;

            izmena.BtnCancel.Click += (sender, args) =>
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da otkažete unos namirnice?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Cleanup();
                    MainCoordinator.Instance.ShowNamirnica();
                }
            };

            Console.WriteLine("ID namirnice NamGuiController : " + nam.NamirnicaID);
            return izmena;
        }

        private void IzmeniNamirnicu(object sender, EventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder();
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }

            if (string.IsNullOrEmpty(izmena.TxtNaziv.Text))
            {
                izmena.TxtNaziv.BackColor = Color.LightSalmon;
                errorMessages.AppendLine("Naziv ne moze biti prazno polje! ");
            }
            else
            {
                izmena.TxtNaziv.BackColor = SystemColors.Window;
            }
            if (string.IsNullOrEmpty(izmena.TxtAlergeni.Text))
            {
                izmena.TxtAlergeni.BackColor = Color.LightSalmon;
                errorMessages.AppendLine("Alergeni ne moze biti prazno polje! ");
            }
            else
            {
                izmena.TxtAlergeni.BackColor = SystemColors.Window;

            }
            if (string.IsNullOrEmpty(izmena.TxtKalorije.Text))
            {
                izmena.TxtKalorije.BackColor = Color.LightSalmon;
                errorMessages.AppendLine("Kalorije ne moze biti prazno polje! ");
            }
            else
            {
                izmena.TxtKalorije.BackColor = SystemColors.Window;

            }

            if (errorMessages.Length > 0)
            {
                MessageBox.Show(errorMessages.ToString(), "Greska pri izmeni namirnice ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Namirnica namirnica = new Namirnica();
            namirnica.NamirnicaID = idZaIzmenu;
            namirnica.Naziv = izmena.TxtNaziv.Text;
            namirnica.Alergeni = izmena.TxtAlergeni.Text;
            namirnica.Kalorije = Int32.Parse(izmena.TxtKalorije.Text);

            Communication.Communication.Instance.ZapamtiNamirnicu(namirnica);

            MainCoordinator.Instance.namirnica.ChangePanel(PrikaziNamirnice());


        }

        private void UnesiNamirnicu(object sender, EventArgs e)
        {
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }

            StringBuilder errorMessages = new StringBuilder();

            bool fieldsEmpty = string.IsNullOrEmpty(unos.TxtNaziv.Text) || string.IsNullOrEmpty(unos.TxtAlergeni.Text) ||
                string.IsNullOrEmpty(unos.TxtKalorije.Text);

            if (fieldsEmpty)
            {
                errorMessages.AppendLine("Molimo vas popunite sva polja.");

                if (string.IsNullOrEmpty(unos.TxtAlergeni.Text))
                    unos.TxtAlergeni.BackColor = Color.LightSalmon;
                if (string.IsNullOrEmpty(unos.TxtNaziv.Text))
                    unos.TxtNaziv.BackColor = Color.LightSalmon;
                if (string.IsNullOrEmpty(unos.TxtKalorije.Text))
                    unos.TxtKalorije.BackColor = Color.LightSalmon;


                MessageBox.Show(errorMessages.ToString(), "Greska pri unosu namirnice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Namirnica n = new Namirnica();
            n.Naziv = unos.TxtNaziv.Text;
            n.Alergeni = unos.TxtAlergeni.Text;

            int kalorije;
            if (!string.IsNullOrEmpty(unos.TxtKalorije.Text) && int.TryParse(unos.TxtKalorije.Text, out kalorije))
            {
                n.Kalorije = kalorije;
                Console.WriteLine("KALORIJE : " + n.Kalorije);
                Console.WriteLine("KALORIJE TYPE : " + unos.TxtKalorije.GetType());
            }
            else
            {
                MessageBox.Show("Invalid input for calories. Please enter a valid integer.");
            }

            Communication.Communication.Instance.UnosNamirnice(n);
            
            Console.WriteLine("Naziv : " + n.Naziv);

            DialogResult result = MessageBox.Show("Da li zelite da dodate jos neku namirnicu?", "Dodavanje namirnice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                unos.TxtAlergeni.Clear();
                unos.TxtNaziv.Clear();
                unos.TxtKalorije.Clear();
;
            }
            else if (result == DialogResult.No)
            {
                Console.WriteLine("Gotovo");
                MainCoordinator.Instance.namirnica.ChangePanel(PrikaziNamirnice());
                Console.WriteLine("Showed nam page");

            }

        }
        EventHandler izmeniNamirnicaHandler = null;

        internal Control PrikaziNamirnice()
        {
            prikaz = new UCPrikazNamirnica();

            var namirnice = Communication.Communication.Instance.VratiNamirnice();

            if(namirnice == null)
            {
                MessageBox.Show("Niste konektovani na server");
            }
            else
            {
                foreach(Namirnica nam in namirnice)
                {
                    listaNamirnica.Add(nam);
                }
                prikaz.DgvNamirniceList.DataSource = namirnice;
                
            }

            prikaz.TxtPretraga.TextChanged += Pretraga;

            izmeniNamirnicaHandler = (sender, args) =>
            {
                if (prikaz.DgvNamirniceList.SelectedRows.Count > 0)
                {
                    Namirnica namirnicaZaIzmenu = (Namirnica)prikaz.DgvNamirniceList.SelectedRows[0].DataBoundItem;
                    Console.WriteLine("Namirnica za izmenu id : " + namirnicaZaIzmenu.NamirnicaID);
                    Namirnica namirnica = Communication.Communication.Instance.UcitajNamirnicu(namirnicaZaIzmenu);
                    MessageBox.Show("Sistem je ucitao namirnicu");
                    MainCoordinator.Instance.ShowIzmeniNamirnicu(MainCoordinator.Instance.namirnica, namirnica);
                }
                else
                {
                    MessageBox.Show("Morate odabrati namirnicu za izmenu!");
                }
            };

            MainCoordinator.Instance.namirnica.BtnIzmeni.Click += izmeniNamirnicaHandler;


            return prikaz;
        }

        public void Cleanup()
        {
            MainCoordinator.Instance.namirnica.BtnIzmeni.Click -= izmeniNamirnicaHandler;
        }

        private void Pretraga(object sender, EventArgs e)
        {
            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }

            string filter = prikaz.TxtPretraga.Text;

            if (filter.Length > 0)
            {
                Namirnica n = new Namirnica()
                {
                    SearchQuery = $" lower(Namirnica.Naziv) like '%{filter}%'"
                };

                List<Namirnica> filtrirani = Communication.Communication.Instance.NadjiNamirnice(n);

                prikaz.DgvNamirniceList.DataSource = filtrirani;

                //if(filtrirani.Count == 0)
                //{
                //    MessageBox.Show("Sistem ne moze da nadje jela po zadatoj vrednosti");
                //}
            }
            else
            {
                List<Namirnica> namirnice = Communication.Communication.Instance.VratiNamirnice();
                prikaz.DgvNamirniceList.DataSource = namirnice;
            }
        }

    }
}
