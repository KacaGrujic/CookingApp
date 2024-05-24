using Common;
using Common.Model;
using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                txtUsername.BackColor = Color.Salmon;
                txtPassword.BackColor = Color.Salmon;
                return;
            }


            Korisnik korisnik = new Korisnik
            {
                Username = username,
                Password = password
            };

            try
            {
                Controller controller = Controller.Instance;
                //korisnik = controller.Login(korisnik); //

                //if (korisnik != null)
                //{
                //    MessageBox.Show($"Welcome {Korisnik.ImePrezime}!");
                //    this.DialogResult = DialogResult.OK;
                //}
                //else
                //{
                //    MessageBox.Show("GRESKA");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
