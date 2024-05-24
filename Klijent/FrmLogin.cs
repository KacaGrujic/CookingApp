using Common;
using Common.Model;
using Server;
using System;
using System.Data.Common;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }

        public void ChangeForm(Form form)
        {

        }

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    string username = txtUsername.Text;
        //    string password = txtPassword.Text;
        //    string confirmed = txtConfirmPassword.Text;

        //    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmed))
        //    {
        //        txtUsername.BackColor = Color.Salmon;
        //        txtPassword.BackColor = Color.Salmon;
        //        txtConfirmPassword.BackColor = Color.Salmon;
        //        MessageBox.Show("All fields are mandatory!", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        return;
        //    }

        //    if (password != confirmed)
        //    {
        //        MessageBox.Show("Passwords do not match!", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        password = "";
        //        confirmed = "";
        //        txtPassword.Focus(); txtConfirmPassword.Focus();
        //    }

        //    // MessageBox.Show($"{username},{password}");


        //    //conn.OpenConnection();
        //    //string login = "SELECT * FROM KORISNIK WHERE  USERNAME='"+txtUsername+"' AND PASSWORD = '"+txtPassword+"'";
        //    //DbCommand cmd = conn.CreateCommand(login);
        //    //DbDataReader reader = cmd.ExecuteReader();

        //    try
        //    {
        //        Korisnik korisnik = new Korisnik();
        //        korisnik.Username = username;
        //        korisnik.Password = password;

        //        //Communication.Instance.Connect();
        //        //Communication.Instance.Login(korisnik);

        //        //Korisnik k = Controller.Instance.Login(korisnik);

        //        if (korisnik != null)
        //        {
        //           // MessageBox.Show($"Welcome, {k.ImePrezime}!", "Login successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            DialogResult = DialogResult.OK;
        //        }
        //       // new FrmDashboard().Show();
        //        this.Hide();

        //    }
        //    catch (SocketException se)
        //    {
        //        MessageBox.Show("Greska pri radu sa serverom");
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show("Korisnik ne postoji!", "Login not successfull", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }



        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show("Greska!" + ex.Message);
        //    //}


        //}

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•'; //alt + 7 
                txtConfirmPassword.PasswordChar = '•';
            }
        }

        //private void label6_Click(object sender, EventArgs e)
        //{
        //    new FrmRegister().Show();
        //    this.Hide();
        //}
    }
}
