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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            Login btnLogin1 = new Login();
            btnLogin1.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register btnUserRegister = new Register();
            btnUserRegister.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile btnProfile = new Profile();
            btnProfile.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Upload_file uploadFile = new Upload_file();
            uploadFile.Show();
        }

        private void carveFile_Click(object sender, EventArgs e)
        {

        }
    }
}
