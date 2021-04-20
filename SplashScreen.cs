using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP4Carver
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void progressbar_Paint(object sender, PaintEventArgs e)
        {
            bar.Width += 1;

            if(bar.Width >= 599)
            {
                timer1.Stop();
                Main main_screen = new Main();
                main_screen.Show();
                this.Hide();
            }
        }
    }
}
