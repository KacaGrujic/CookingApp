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
    public class LoginGuiController
    {
        private UCLogin frmLogin;

        public LoginGuiController()
        {

        }

        internal Control CreateFrmLogin()
        {
            frmLogin = new UCLogin();
            frmLogin.BtnLogin.Click += Login;

            return frmLogin;

        }
        
        private void Login(object sender, EventArgs e)
        {
            try
            {
                string username = frmLogin.TxtUsername.Text;
                string password = frmLogin.TxtPassword.Text;
                string confirmedPass = frmLogin.TxtConfirmPassword.Text;

                if (!Validate()) return;

                Korisnik korisnik = Communication.Communication.Instance.Login(username, password);
                if(korisnik == null)
                {
                    MessageBox.Show("Neuspesno prijavljivanje na sistem");
                }
                else
                {
                    MessageBox.Show("Uspesno prijavljivanje na sistem!");
                    MainCoordinator.Instance.ShowHomePage(korisnik);


                }

            }
            catch (Exception)
            {
                MessageBox.Show("Neuspesno prijavljivanje na sistem!");
                return;
            }
        }

        private bool Validate()
        {
            string username = frmLogin.TxtUsername.Text;
            string password = frmLogin.TxtPassword.Text;
            string confirmedPass = frmLogin.TxtConfirmPassword.Text;

            string message = "";
            if (string.IsNullOrEmpty(username))
            {
                message += "Username ne sme biti prazno polje!\n";
                frmLogin.TxtUsername.BackColor = Color.Salmon;
            }
            if (string.IsNullOrEmpty(password))
            {
                message += "Password ne sme biti prazno polje!\n";
                frmLogin.TxtPassword.BackColor = Color.Salmon;
            }
            if (string.IsNullOrEmpty(confirmedPass))
            {
                message += "Morate potvrditi lozinku!\n";
                frmLogin.TxtConfirmPassword.BackColor = Color.Salmon;
            }
            if (message != "")
            {
                MessageBox.Show(message);
                return false;
            }
            return true;

        }


    }
}
