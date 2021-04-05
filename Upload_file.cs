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
    public partial class Upload_file : Form
    {
        public Upload_file()
        {
            InitializeComponent();
        }

        private void uploadfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox_path.Text = openFileDialog1.FileName;
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = textBox_path.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();

        }
    }
}
