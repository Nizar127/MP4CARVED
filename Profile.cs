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
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using CsvHelper;
using System.Runtime.InteropServices;
using System.Diagnostics;


//using WindowsFormsApplication1.DAL;

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

            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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

            if (commandDB.ExecuteNonQuery() == 1)
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
            Process.Start("E:\\zue_project\\carve.exe");
            //OpenFileDialog dv = new OpenFileDialog();
            //string filter = "csv file (*.csv)|*.csv| all files (*.*)|*.*";
            //dv.Filter = filter;
            //dv.ShowDialog();
            //txtCarveFile.Text = dv.FileName;
            //BindDataIntoCSV(txtCarveFile.Text);
           // BindTheDataCSV(txtCarveFile.Text);

        }

        //public class BindRawData
        //{

        //    [DllImport("CarveTheFile.C", EntryPoint = "carveFile")]

        //    static extern void carveFile(string message);

        //    [DllImport("CarveTheFile.C", EntryPoint = "WriteToBinary")]

        //    static extern void WriteToBinary(string message);

        //    public static void Main(string[] args)
        //    {
        //        carveFile("Carving Successful"))
        //        WriteToBinary("File Created");
        //    }
        //}



        private void BindTheDataCSV(string filepath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filepath);
            if (lines.Length > 0)
            {
                string firstline = lines[0];
                string[] headerlabels = firstline.Split('\t');
                foreach (string headerword in headerlabels)
                {
                    dt.Columns.Add(new DataColumn(headerword));
                }

                for (int r = 1; r < lines.Length; r++)
                {
                    string[] DataWords = lines[r].Split('\t');
                    DataRow dr = dt.NewRow();
                    int columnindex = 0;
                    foreach (string headerword in headerlabels)
                    {
                        dr[headerword] = DataWords[columnindex++];
                    }
                    dt.Rows.Add(dr);
                }
            }

            if (dt.Rows.Count > 0)
            {
                //.DataSource = dt;
                DGItem3.DataSource = dt;
                DataView dv;
                dv = new DataView(dt, "Filename LIKE '%.mp4'", "Filename Desc", DataViewRowState.CurrentRows);
                DGItem3.DataSource = dv.ToTable();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"C:\ProgramData\File.mp4";
           
            FileStream fStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            byte[] content = new byte[16 * 1024];
            //fStream.Write(content, 0, content.Length);
            fStream.Write(content, 0, content.Length);
            fStream.Close();

            //Console.WriteLine(string.Join("", readRecord(".mp4", "yes",9)));
            //MessageBox.Show(string.Join("",readRecord("yes", txtCarveFile.Text,7)));

           


        }

        private static string[] readRecord(string searchTerm, string filepath, int position)
        {
            position--;
            string[] recordNotFound = { "Record not found",filepath };
            try
            {
                string[] lines = File.ReadAllLines(filepath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split('\t');
                    MessageBox.Show(" "+fields[position]);
                    if( recordMathes(searchTerm, fields, position))
                    {
                        Console.WriteLine("Record Found");
                        return fields;
                    }

                }

                return recordNotFound;
            }
            catch(Exception ex)
            {
                Console.WriteLine("This program pissing me off");
                return recordNotFound;
               // return " " +ex.Message;
                throw new ApplicationException("This seriously looking for trouble", ex);
            }

        }

        public static bool recordMathes(string searchTerm, string[] record, int position)
        {
            if (record[position].Equals(searchTerm))
            {
                return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            OpenFileDialog dg = new OpenFileDialog();
            string filter = "csv file (*.csv)|*.csv| all files (*.*)|*.*";
            dg.Filter = filter;
            dg.ShowDialog();
            txtFile.Text = dg.FileName;
            //BindDataCSV(txtFile.Text);
            //BindRawData(txtFile.Text);



        }

        private void BindRawdData(string filepath)
        {
            FileStream fs = new FileStream(filepath, FileMode.Open);
            BinaryReader bs = new BinaryReader(fs);
            //BinaryReader binReader = new BinaryReader(File.Open(filepath, FileMode.Open));

            

            //Encoding ascii = Encoding.ASCII;
            //BinaryWriter bwEncoder = new BinaryWriter(new FileStream(filepath, FileMode.Create), ascii);
            //DataTable dt = new DataTable();
            //string[] lines = System.IO.File.ReadAllLines(filepath);
            //if (lines.Length > 0)
            //{
            //    string firstline = lines[0];
            //    string[] headerlabels = firstline.Split('\t');
            //    foreach (string headerword in headerlabels)
            //    {
            //        dt.Columns.Add(new DataColumn(headerword));
            //    }

            //    for (int r = 1; r < lines.Length; r++)
            //    {
            //        string[] DataWords = lines[r].Split('\t');
            //        DataRow dr = dt.NewRow();
            //        int columnindex = 0;
            //        foreach (string headerword in headerlabels)
            //        {
            //            dr[headerword] = DataWords[columnindex++];
            //        }
            //        dt.Rows.Add(dr);
            //    }
            //}

            //if (dt.Rows.Count > 0)
            //{
            //    DGItems.DataSource = dt;
            //}
        }

        private void BindDataCSV(string filepath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filepath);
            if (lines.Length > 0)
            {
                string firstline = lines[0];
                string[] headerlabels = firstline.Split('\t');
                foreach (string headerword in headerlabels)
                {
                    dt.Columns.Add(new DataColumn(headerword));
                }

                for (int r = 1; r < lines.Length; r++)
                {
                    string[] DataWords = lines[r].Split('\t');
                    DataRow dr = dt.NewRow();
                    int columnindex = 0;
                    foreach (string headerword in headerlabels)
                    {
                        dr[headerword] = DataWords[columnindex++];
                    }
                    dt.Rows.Add(dr);
                }
            }

            if (dt.Rows.Count > 0)
            {
                DGItems.DataSource = dt;
            }

        }

        private void viewFile_Click(object sender, EventArgs e)
        {

        }

        private void EditName_Click(object sender, EventArgs e)
        {
            EditProfile fo = new EditProfile();
            fo.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
;
           //generate file based on textbox file
            string filepath = txtFile.Text;
                
            //create destination path
                string destination = @"C:\\Users\User\mp4_carver";

            //generate UUID
               string newFileName = $@"{DateTime.Now.Ticks}.raw";
                if (!Directory.Exists(destination))
                {
                //create new directory if not exist
                    Directory.CreateDirectory(@"C:\\Users\User\mp4_carver");
                }

                //copy or save the data in other destination
                File.Copy(filepath, destination + "/" + newFileName);

            MessageBox.Show("Files Transferred");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void loadImg_Click(object sender, EventArgs e)
        {

            //delete file from filesystem

            string rootFolder = @"C:\\Users\User\mp4_carver";

            string filepath = txtFile.Text;

            try
            {
                if(File.Exists(Path.Combine(rootFolder, filepath)))
                {
                    File.Delete(Path.Combine(rootFolder, filepath));
                    MessageBox.Show("Files Deleted");
                    this.DGItems.DataSource = null;
                    this.DGItems.Rows.Clear();

                }
                else MessageBox.Show("Files Unable to be Deleted");

            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void nameData_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void testMP4_Click(object sender, EventArgs e)
        {
            Upload_file uploadFile = new Upload_file();
            uploadFile.Show();
        }

        private void mp4btn_Click(object sender, EventArgs e)
        {
            Upload_file uploadFile = new Upload_file();
            uploadFile.Show();
        }

        private void mp4Btn_Click_1(object sender, EventArgs e)
        {
            Upload_file vidUpload = new Upload_file();
            vidUpload.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void DisplayName_Click(object sender, EventArgs e)
        {

            MySqlConnection dbconnection = new MySqlConnection(conn);
            dbconnection.Open();
            if (idUsr.Text != "")
            {
                string nameQuery = "SELECT `name`, `matric_no` FROM users WHERE id =@id";
                MySqlCommand commandDB = new MySqlCommand(nameQuery, dbconnection);
                commandDB.Parameters.AddWithValue("@id", int.Parse(idUsr.Text));
                MySqlDataReader reader;
                reader = commandDB.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("working");
                    nameUsr.Text = reader.GetValue(0).ToString();
                    matricNoUsr.Text = reader.GetValue(1).ToString();
                }
            }

            dbconnection.Close();
        }

        private void matricNo_Click(object sender, EventArgs e)
        {

        }

        private void usernameProfile_Click(object sender, EventArgs e)
        {
            MySqlConnection dbconnection = new MySqlConnection(conn);
            dbconnection.Open();
            string nameQuery = "SELECT `name` FROM users WHERE id =@id";
            MySqlCommand commandDB = new MySqlCommand(nameQuery, dbconnection);
            //commandDB.Parameters.AddWithValue("@id", int.Parse(idUsr.Text));
            MySqlDataReader reader;
            reader = commandDB.ExecuteReader();
            if(reader.Read())
            {
                usernameprofile.Text = reader["name"].ToString();
               
            }
            else
            {
                usernameprofile.Text = "Record Unknown";
            }
           
        }

        private void DGItem3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("E:\\zue_project\\heston.MKV");

        }

        private void logutBtnFile_Click(object sender, EventArgs e)
        {
            //this.Close();
            MessageBox.Show("You Have Logout");
            this.Close();
            //System.Windows.Forms.Application.ExitThread();
            //Login lg = new Login();
           // lg.Show();
        }
    }
   
}

