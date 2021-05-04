using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;
using MySql.Data.MySqlClient;


namespace MP4Carver
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=mp4_carver;";


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //saveImg();
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
               dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                   imageBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public void saveImg()
        {
            MemoryStream ms = new MemoryStream();
            imageBox.Image.Save(ms, imageBox.Image.RawFormat);
            byte[] img = ms.ToArray();

            String insertQuery = "INSERT INTO users(image)";

            MySqlConnection dbconnection = new MySqlConnection(conn);
            MySqlCommand commandDB = new MySqlCommand(insertQuery, dbconnection);
            commandDB.CommandTimeout = 60;

            dbconnection.Open();

            commandDB.Parameters.Add("@img", MySqlDbType.Blob);
            commandDB.Parameters["@img"].Value = img;

            if(commandDB.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data inserted");
            }

            dbconnection.Close();

            
        }

        private void imageBox_Click(object sender, EventArgs e)
        {

        }

        private void file_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void carveActivity_Click(object sender, EventArgs e)
        {

        }

        private void carveFile_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFolder = new CommonOpenFileDialog();
            openFolder.IsFolderPicker = true;
            if(openFolder.ShowDialog() == CommonFileDialogResult.Ok )
            {
                txtCarveFile.Text = openFolder.FileName;
            }

        }

        //OpenFileDialog fileOpen = new OpenFileDialog();


        private void button2_Click(object sender, EventArgs e)
        {

            String imagePlace = "";
            try
            {
                OpenFileDialog fileOpen= new OpenFileDialog();
                fileOpen.Filter = "GPD|*.gpd";
                //dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagePlace = fileOpen.FileName;
                    saveImagePanel.Text = imagePlace;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void viewFile_Click(object sender, EventArgs e)
        {

        }
    }
}
