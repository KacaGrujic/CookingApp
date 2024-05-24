using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server server;
        private bool end = false;


        public FrmServer()
        {
            InitializeComponent();

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                lblText.Text = "Server is up and running...";
                lblText.ForeColor = Color.DarkSeaGreen;
                timer1.Start();
                server = new Server();

                server.Start();
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
        //    timer1.Stop();
            try
            {
                lblText.Text = "Server is down.";
                lblText.ForeColor = Color.DarkRed;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                timer1.Stop();
                server.Stop();
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {

        }
    }
}
