using Common.Model;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Klijent.GuiController
{
    public class MainCoordinator
    {
        private static MainCoordinator instance;
        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }
        private MainCoordinator()
        {

            loginGuiController = new LoginGuiController();
            namirnicaGuiController = new NamirnicaGuiController();
            receptGuiController = new ReceptGuiController();

        }

        public MainForm main;
        private LoginGuiController loginGuiController;
        public NamirnicaMainForm namirnicaMain = new NamirnicaMainForm();
        NamirnicaGuiController namirnicaGuiController;
        ReceptGuiController receptGuiController;

        public bool ConnectToServer()
        {
            Communication.Communication.Instance.Connect();
            return Communication.Communication.Instance.SocketConnected();
        }

        internal void ShowMain()
        {
            Communication.Communication.Instance.Connect();
            Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
            main = new MainForm();
            //main.ShowDialog();
            main.ChangePanel(loginGuiController.CreateFrmLogin());
            main.AutoSize = true;
            Application.Run(main);

        }
        internal Korisnik k = new Korisnik();
        Dashboard dash;

        internal void LogOut()
        {
            Console.WriteLine("Prijavljen " + k);
            Communication.Communication.Instance.Odjavljivanje(k);

            if (dash != null)
            {
                dash.Hide(); 
            }

            main.Show();
            main.ChangePanel(loginGuiController.CreateFrmLogin());
        }

        internal void ShowHomePage(Korisnik korisnik)
        {
            main.pnlMain.Controls.Clear();
            main.Hide();
            k = korisnik;

            if (dash == null || dash.IsDisposed)
            {
                dash = new Dashboard();
            }

            dash.Show();
            dash.Label1.Text += " " + k.ImePrezime + ", what are we doing today?";
        }

        internal void ShowNamirnicaPage()
        {
            OpenNamirnicaPage();
            //dash.PBNamirnica.Click += (sender, e) =>
            //{
            //    OpenNamirnicaPage();
            //};
        }

        internal NamirnicaMainForm namirnica;


        internal void OpenNamirnicaPage()
        {
            namirnica = new NamirnicaMainForm();
            namirnica.Show();
            namirnica.ChangePanel(namirnicaGuiController.PrikaziNamirnice());

            namirnica.BtnDodaj.Click += (btnSender, btnEvent) => { ShowDodajNamirnicu(namirnica); };
            //Console.WriteLine("Usao u dodaj nam");

            
            //namirnica.BtnIzmeni.Click += (btnSender, btnEvent) => { S}
           
        }

        internal void ShowDodajNamirnicu(NamirnicaMainForm namMain)
        {

            namMain.ChangePanel(namirnicaGuiController.DodajNamirnicu());
        }

        internal void ShowIzmeniNamirnicu(NamirnicaMainForm namMain, Namirnica nam)
        {

            namMain.ChangePanel(namirnicaGuiController.IzmeniNamirnicu(nam));
        }


        // Jelo Koordinisanje

        JeloGuiController jeloGuiController = new JeloGuiController();

        internal void ShowJeloPage()
        {
            OpenJeloPage();
            //dash.PBJelo.Click += (sender, e) =>
            //{
            //    OpenJeloPage();
            //};
        }

        internal JeloMainForm jelo;


        internal void OpenJeloPage()
        {
            jelo = new JeloMainForm();
            jelo.Show();
            jelo.ChangePanel(jeloGuiController.PrikaziJela());

            jelo.BtnDodaj.Click += (btnSender, btnEvent) => { ShowDodajJelo(jelo); };

            //VRATI SE OVDE !!!

        }

        internal void ShowJelo()
        {
            jelo.ChangePanel(jeloGuiController.PrikaziJela());
        }

        private void ShowDodajJelo(JeloMainForm jelo)
        {
            jelo.ChangePanel(jeloGuiController.DodajJelo());
        }

        internal void ShowIzmeniJelo(JeloMainForm jeloMain, Jelo jelo)
        {
            jeloMain.ChangePanel(jeloGuiController.IzmeniJelo(jelo));
        }


        // Recept koordinisanje

        internal void ShowReceptPage()
        {
            OpenReceptPage();
           
        }

        internal ReceptMainForm recept;


        internal void OpenReceptPage()
        {
            recept = new ReceptMainForm();
            recept.Show();
            recept.WindowState = FormWindowState.Normal;
            recept.Bounds = new Rectangle(recept.Bounds.Left, 0, recept.Bounds.Width, Screen.PrimaryScreen.WorkingArea.Height);
            recept.ChangePanel(receptGuiController.PrikaziRecepte());
            Console.WriteLine("Korisnik recept page : " + k.KorisnikID);
            recept.BtnDodaj.Click += (btnSender, btnEvent) => { ShowDodajRecept(recept); recept.Panel3.Height = recept.BtnDodaj.Height; recept.Panel3.Top = recept.BtnDodaj.Top; };



            //VRATI SE OVDE !!!

        }

        internal void ShowRecept()
        {
            recept.ChangePanel(receptGuiController.PrikaziRecepte());
            recept.Panel3.Height = recept.BtnHome.Height; recept.Panel3.Top = recept.BtnHome.Top;
        }

        private void ShowDodajRecept(ReceptMainForm recept)
        {
            recept.ChangePanel(receptGuiController.DodajRecept(k));
            recept.Panel3.Height = recept.BtnDodaj.Height; recept.Panel3.Top = recept.BtnDodaj.Top;


        }

        internal void ShowIzmeniRecept(ReceptMainForm recept, Recept receptZaIzmenu)
        {
            recept.ChangePanel(receptGuiController.IzmeniRecept(receptZaIzmenu));
            recept.Panel3.Height = recept.BtnIzmeni.Height; recept.Panel3.Top = recept.BtnIzmeni.Top;

        }

        internal void ShowNamirnica()
        {
            namirnica.ChangePanel(namirnicaGuiController.PrikaziNamirnice());
        }

       
    }
}
