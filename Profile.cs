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
            AddImage btnAddImg = new AddImage();
            btnAddImg.Show();
            //saveImg();
            // String imageLocation = "";
            //try
            //{
            //  OpenFileDialog dialog = new OpenFileDialog();
            // dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            //  if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //  {
            //      imageLocation = dialog.FileName;
            //     imageBox.ImageLocation = imageLocation;
            //  }
            // }
            // catch (Exception)
            // {
            //   MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }


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

            OpenFileDialog dv = new OpenFileDialog();
            string filter = "csv file (*.csv)|*.csv| all files (*.*)|*.*";
            dv.Filter = filter;
            dv.ShowDialog();
            txtCarveFile.Text = dv.FileName;
            BindDataIntoCSV(txtCarveFile.Text);

        }


        private void BindDataIntoCSV(string filepath)
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
                DGItem2.DataSource = dt;
                //if(dt.Columns = "Filename")
                DataView dv;
                dv = new DataView(dt, "Filename = '%.mp4%'", "Filename Desc", DataViewRowState.CurrentRows);
               
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Console.WriteLine(string.Join("", readRecord(".mp4", "yes",9)));
            MessageBox.Show(string.Join("", readRecord("yes", txtCarveFile.Text,7)));

          

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
            BindDataCSV(txtFile.Text);



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

        public static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {
                if (csv_file_path.EndsWith(".csv"))
                {
                    using (Microsoft.VisualBasic.FileIO.TextFieldParser csvReader = new Microsoft.VisualBasic.FileIO.TextFieldParser(csv_file_path))
                    {
                        csvReader.SetDelimiters(new string[] { "," });
                        csvReader.HasFieldsEnclosedInQuotes = true;
                        //read column
                        string[] colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            csvData.Columns.Add(datecolumn);
                        }
                        while (!csvReader.EndOfData)
                        {
                            string[] fieldData = csvReader.ReadFields();
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }
                            csvData.Rows.Add(fieldData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exce " + ex);
            }
            return csvData;
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
               string newFileName = $@"{DateTime.Now.Ticks}.csv";
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

            string rootFolder = @"C:\\Users\User\mp4_carver";

            string filepath = txtFile.Text;

            try
            {
                if(File.Exists(Path.Combine(rootFolder, filepath)))
                {
                    File.Delete(Path.Combine(rootFolder, filepath));
                    MessageBox.Show("Files Deleted");
                    //DGItems.ClearSelection();
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
            MySqlConnection dbconnection = new MySqlConnection(conn);
            dbconnection.Open();
            string nameQuery = "SELECT name FROM user";
            MySqlCommand commandDB = new MySqlCommand(nameQuery, dbconnection);
            MySqlDataReader nameUsr = commandDB.ExecuteReader();
            if (nameUsr.Read())
            {
                textBox1.Text = (nameUsr["name"].ToString());
            }
            dbconnection.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection dbconnection = new MySqlConnection(conn);
            dbconnection.Open();
            string nameQuery = "SELECT matric_no FROM user";
            MySqlCommand commandDB = new MySqlCommand(nameQuery, dbconnection);
            MySqlDataReader nameUsr = commandDB.ExecuteReader();
            if (nameUsr.Read())
            {
                textBox2.Text = (nameUsr["matric_no"].ToString());
            }
            dbconnection.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection dbconnection = new MySqlConnection(conn);
            dbconnection.Open();
            string nameQuery = "SELECT carving_file_data FROM user";
            MySqlCommand commandDB = new MySqlCommand(nameQuery, dbconnection);
            MySqlDataReader nameUsr = commandDB.ExecuteReader();
            if (nameUsr.Read())
            {
                textBox3.Text = (nameUsr["carving_file_name"].ToString());
            }
            dbconnection.Close();
        }





    }
   
}

