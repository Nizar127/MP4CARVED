using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MP4Carver
{
    public partial class AddImage : Form
    {
        public AddImage()
        {
            InitializeComponent();
        }

        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=mp4_carver;";

        private void browseImg_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
              OpenFileDialog dialog = new OpenFileDialog();
              dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
              if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
              {
                  imageLocation = dialog.FileName;
                  changeImgBox.ImageLocation = imageLocation;
              }
             }
             catch (Exception)
             {
               MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void saveImgButton_Click(object sender, EventArgs e)
        {
            SaveImg();
        }

        private void SaveImg()
        {
            MemoryStream ms = new MemoryStream();
            changeImgBox.Image.Save(ms, changeImgBox.Image.RawFormat);
            byte[] img = ms.ToArray();

            String insertQuery = "INSERT INTO users(image)";

            MySqlConnection dbconnection = new MySqlConnection(conn);
            MySqlCommand commandDB = new MySqlCommand(insertQuery, dbconnection);
            commandDB.CommandTimeout = 60;
           

            dbconnection.Open();

            commandDB.Parameters.Add("@img", MySqlDbType.Blob);
            commandDB.Parameters["@img"].Value = img;
            commandDB.ExecuteNonQuery();

            if (commandDB.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data inserted");
            }

            dbconnection.Close();
        }

        private void changeImgBox_Click(object sender, EventArgs e)
        {

        }
    }
}
