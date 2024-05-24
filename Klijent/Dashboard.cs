using Klijent.GuiController;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pbNamirnica_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowNamirnicaPage();
        }

        private void pbJelo_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowJeloPage();
        }

        private void pbRecept_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowReceptPage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.LogOut();
        }

        public void CloseForm()
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.Close();
            });
        }
        //private void lblNamirnica_Click(object sender, EventArgs e)
        //{
        //    MainCoordinator.Instance.ShowNamirnicaPage();

        //}

        //private void lblJelo_Click(object sender, EventArgs e)
        //{
        //    MainCoordinator.Instance.ShowJeloPage();
        //}
    }
}
