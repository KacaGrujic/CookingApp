using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.UserControls
{
    public partial class UCNamirnicaMain : UserControl
    {
        public UCNamirnicaMain()
        {
            InitializeComponent();
        }

        public void ChangePanel(Control control)
        {
            panel.Controls.Clear();
            panel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
