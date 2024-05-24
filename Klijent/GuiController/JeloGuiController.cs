using Common.Model;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GuiController
{
    public class JeloGuiController
    {

        UCPrikazJela prikaz;
        UCUnosJela unos;
        UCIzmenaJela izmena;

        Jelo j = new Jelo();

        List<Jelo> listaJela = new List<Jelo>();

        internal Control PrikaziJela()
        {
            prikaz = new UCPrikazJela();

            var jela = Communication.Communication.Instance.VratiJela();

            if (jela == null)
            {
                MessageBox.Show("Niste konektovani na server");
            }
            else
            {
                foreach (Jelo jelo in jela)
                {
                    listaJela.Add(jelo);
                }
                prikaz.DgvPrikazJela.DataSource = jela;

            }

            prikaz.TxtPretraga.TextChanged += Pretraga;

            MainCoordinator.Instance.jelo.BtnIzmeni.Click += (sender, args) =>
            {
                if (prikaz.DgvPrikazJela.SelectedRows.Count > 0)
                {
                    Jelo jeloZaIzmenu = (Jelo)prikaz.DgvPrikazJela.SelectedRows[0].DataBoundItem;
                    Console.WriteLine("Jelo za izmenu id : " + jeloZaIzmenu.JeloID);
                    // j = Communication.Communication.Instance.UcitajJelo(jeloZaIzmenu);
                    // MessageBox.Show("Sistem je ucitao jelo "); 
                    //// Console.WriteLine("Odabrano jelo : : : " + odabrano.Naziv);
                    // MainCoordinator.Instance.ShowIzmeniJelo(MainCoordinator.Instance.jelo, j);
                    Jelo izmeniJelo = Communication.Communication.Instance.UcitajJelo(jeloZaIzmenu);
                    MessageBox.Show("Sistem je ucitao jelo");
                    MainCoordinator.Instance.ShowIzmeniJelo(MainCoordinator.Instance.jelo, izmeniJelo);

                }
                else
                {
                    MessageBox.Show("Morate odabrati jelo za izmenu!");
                }
            };

            return prikaz;
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
                Jelo j = new Jelo()
                {
                    SearchQuery = $" lower(Jelo.Naziv) like '%{filter}%'"
                };

                List<Jelo> filtrirani = Communication.Communication.Instance.NadjiJela(j);

                prikaz.DgvPrikazJela.DataSource = filtrirani;
  
            }
            else
            {
                List<Jelo> jela = Communication.Communication.Instance.VratiJela();
                prikaz.DgvPrikazJela.DataSource = jela;
            }
        }


        internal Control DodajJelo()
        {
            unos = new UCUnosJela();
            List<VrstaJela> vrsteJela = Communication.Communication.Instance.VratiVrsteJela();
            
            var kuhinjeEnum = Enum.GetValues(typeof(Kuhinja));
            var kuhinje = new List<object>();

            foreach(Kuhinja k in kuhinjeEnum)
            {
                kuhinje.Add(k);
            }

            unos.BtnAdd.Click += UnesiJelo;
            unos.CbVrstaJela.DataSource = vrsteJela.Select(x => (object)x).ToList();
            unos.CbKuhinja.DataSource = kuhinje;

            unos.CbVrstaJela.SelectedIndex = -1;
            unos.CbKuhinja.SelectedIndex = -1;

            unos.CbKuhinja.Texts = "Odaberite kuhinju:";
            unos.CbVrstaJela.Texts = "Odaberite vrstu jela:";

            unos.BtnCancel.Click += (sender, args) =>
            {

                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da otkažete unos jela?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MainCoordinator.Instance.ShowJelo();

                    MessageBox.Show("Otkazano");
                }
            };

            return unos;
        }

        private void UnesiJelo(object sender, EventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder();
            bool fieldsEmpty = string.IsNullOrEmpty(unos.TxtNaziv.Text) ||
                               unos.CbVrstaJela.SelectedIndex == -1 ||
                               unos.CbKuhinja.SelectedIndex == -1;


            if (!Communication.Communication.Instance.SocketConnected())
            {
                MessageBox.Show("Niste konektovani na server!");
                return;
            }

            if (fieldsEmpty)
            {
                errorMessages.AppendLine("Molimo vas popunite sva polja.");


                if (string.IsNullOrEmpty(unos.TxtNaziv.Text))
                    unos.TxtNaziv.BackColor = Color.Salmon;
               
                if (unos.CbKuhinja.SelectedIndex == -1)
                    unos.CbKuhinja.BackColor = Color.Salmon;
                if (unos.CbVrstaJela.SelectedIndex == -1)
                    unos.CbVrstaJela.BackColor = Color.Salmon;

                MessageBox.Show(errorMessages.ToString(), "Greška pri unosu jela", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (unos.CbVrstaJela.SelectedIndex == -1)
            {
                errorMessages.AppendLine("Izaberite vrstu jela!");
                unos.CbVrstaJela.BackColor = Color.Salmon;
                MessageBox.Show(errorMessages.ToString(), "Greška pri unosu jela", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (unos.CbKuhinja.SelectedIndex == -1)
            {
                errorMessages.AppendLine("Izaberite kuhinju!");
                unos.CbKuhinja.BackColor = Color.Salmon;
                MessageBox.Show(errorMessages.ToString(), "Greška pri unosu vozila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Jelo jelo = new Jelo();
            jelo.Naziv = unos.TxtNaziv.Text;
            jelo.Kuhinja = unos.CbKuhinja.SelectedItem.ToString();
            jelo.VrstaJela = unos.CbVrstaJela.SelectedItem as VrstaJela;

            Communication.Communication.Instance.UnosJela(jelo);

            DialogResult result = MessageBox.Show("Da li želite da dodate još neko jelo?", "Dodavanje jela", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                unos.TxtNaziv.Clear();
                unos.CbKuhinja.SelectedIndex = -1;
                unos.CbVrstaJela.SelectedIndex = -1;
            }

            else if (result == DialogResult.No)
            {
                MainCoordinator.Instance.jelo.ChangePanel(PrikaziJela());

            }

        }

        int idZaIzmenu;

        internal Control IzmeniJelo(Jelo jelo)
        {
            izmena = new UCIzmenaJela();
            izmena.TxtNaziv.Text = jelo.Naziv;
            idZaIzmenu = jelo.JeloID;

            var kuhinjeEnum = Enum.GetValues(typeof(Kuhinja));
            var kuhinje = new List<object>();
            List<VrstaJela> vrsteJela = Communication.Communication.Instance.VratiVrsteJela();

            foreach (Kuhinja k in kuhinjeEnum)
            {
                kuhinje.Add(k);
            }

            izmena.CbVrstaJela.DataSource = vrsteJela.Select(x => (object)x).ToList();
            izmena.CbKuhinja.DataSource = kuhinje;

            Console.WriteLine("Kuhinja > " + jelo.Kuhinja);
            Console.WriteLine("VS > " + jelo.VrstaJela);


            izmena.CbKuhinja.Texts = jelo.Kuhinja;
            izmena.CbVrstaJela.Texts = jelo.VrstaJela.ToString();

            izmena.CbKuhinja.SelectedItem = jelo.Kuhinja;
            izmena.CbVrstaJela.SelectedItem = jelo.VrstaJela;


            izmena.BtnIzmeni.Click += (s, a) =>
            {
                Izmeni(jelo);
            };

            izmena.BtnCancel.Click += (sender, args) =>
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da otkažete izmenu jela?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Cleanup();
                    MainCoordinator.Instance.ShowJelo();
                }
            };

            return izmena;
        }

        private void Izmeni(Jelo jelo)
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
            if (izmena.CbKuhinja.SelectedIndex == -1)
            {
                izmena.CbKuhinja.BackColor = Color.LightSalmon;
                errorMessages.AppendLine("Kuhinja mora biti izabrana! ");
            }
            else
            {
                izmena.CbKuhinja.BackColor = SystemColors.Window;

            }
            if (izmena.CbVrstaJela.SelectedIndex == -1)
            {
                izmena.CbVrstaJela.BackColor = Color.LightSalmon;
                errorMessages.AppendLine("Vrsta Jela mora biti izabrana! ");
            }
            else
            {
                izmena.CbVrstaJela.BackColor = SystemColors.Window;

            }

            if (errorMessages.Length > 0)
            {
                MessageBox.Show(errorMessages.ToString(), "Greska pri izmeni jela ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            jelo.JeloID = idZaIzmenu;
            jelo.Naziv = izmena.TxtNaziv.Text;
            jelo.Kuhinja = izmena.CbKuhinja.SelectedItem.ToString();
            jelo.VrstaJela = izmena.CbVrstaJela.SelectedItem as VrstaJela;

            Communication.Communication.Instance.ZapamtiJelo(jelo);

            MainCoordinator.Instance.jelo.ChangePanel(PrikaziJela());
           
        }

        private void IzmeniJeloHandler(object sender, EventArgs e)
        {
            if (prikaz.DgvPrikazJela.SelectedRows.Count > 0)
            {
                Jelo jeloZaIzmenu = (Jelo)prikaz.DgvPrikazJela.SelectedRows[0].DataBoundItem;
                Console.WriteLine("Jelo za izmenu id : " + jeloZaIzmenu.JeloID);
                Jelo izmeniJelo = Communication.Communication.Instance.UcitajJelo(jeloZaIzmenu);
                MessageBox.Show("Sistem je ucitao jelo");
                MainCoordinator.Instance.ShowIzmeniJelo(MainCoordinator.Instance.jelo, izmeniJelo);
            }
            else
            {
                MessageBox.Show("Morate odabrati jelo za izmenu!");
            }
        }

        public void Cleanup()
        {
            if (prikaz != null)
            {
                prikaz.TxtPretraga.TextChanged -= Pretraga;
            }

            if (MainCoordinator.Instance != null && MainCoordinator.Instance.jelo != null)
            {
                MainCoordinator.Instance.jelo.BtnIzmeni.Click -= IzmeniJeloHandler;
            }

        }


        //private void IzmeniJelo(object sender, EventArgs e)
        //{
        //    StringBuilder errorMessages = new StringBuilder();
        //    if (!Communication.Communication.Instance.SocketConnected())
        //    {
        //        MessageBox.Show("Niste konektovani na server!");
        //        return;
        //    }

        //    if (string.IsNullOrEmpty(izmena.TxtNaziv.Text))
        //    {
        //        izmena.TxtNaziv.BackColor = Color.LightSalmon;
        //        errorMessages.AppendLine("Naziv ne moze biti prazno polje! ");
        //    }
        //    else
        //    {
        //        izmena.TxtNaziv.BackColor = SystemColors.Window;
        //    }
        //    if(izmena.CbKuhinja.SelectedIndex == -1)
        //    {
        //        izmena.CbKuhinja.BackColor = Color.LightSalmon;
        //        errorMessages.AppendLine("Kuhinja mora biti izabrana! ");
        //    }
        //    else
        //    {
        //        izmena.CbKuhinja.BackColor = SystemColors.Window;

        //    }
        //    if (izmena.CbVrstaJela.SelectedIndex == -1)
        //    {
        //        izmena.CbVrstaJela.BackColor = Color.LightSalmon;
        //        errorMessages.AppendLine("Vrsta Jela mora biti izabrana! ");
        //    }
        //    else
        //    {
        //        izmena.CbVrstaJela.BackColor = SystemColors.Window;

        //    }

        //    if (errorMessages.Length > 0)
        //    {
        //        MessageBox.Show(errorMessages.ToString(), "Greska pri izmeni jela ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    Jelo jelo = new Jelo();
        //    jelo.JeloID = idZaIzmenu;
        //    jelo.Naziv = izmena.TxtNaziv.Text;
        //    jelo.Kuhinja = izmena.CbKuhinja.SelectedItem.ToString();
        //    jelo.VrstaJela = izmena.CbVrstaJela.SelectedItem as VrstaJela;

        //    Communication.Communication.Instance.ZapamtiJelo(jelo);

        //    MainCoordinator.Instance.namirnica.ChangePanel(PrikaziJela());
        //}






    }
}
