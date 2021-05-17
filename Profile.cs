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
            CommonOpenFileDialog openFolder = new CommonOpenFileDialog();
            openFolder.IsFolderPicker = true;
            if (openFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtCarveFile.Text = openFolder.FileName;
            }

        }

        //OpenFileDialog fileOpen = new OpenFileDialog();


        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dg = new OpenFileDialog();
            string filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            dg.Filter = filter;
            dg.ShowDialog();
            txtFile.Text = dg.FileName;



            //    try
            //    {
            //        OpenFileDialog dialog = new OpenFileDialog();
            //        string filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            //        dialog.Filter = filter;
            //        dialog.Filter = "Microsoft Excel Comma Separated Values File (*.csv)|*.csv|";
            //        dialog.ShowDialog();
            //        int ImportedRecord = 0, inValidItem = 0;
            //        string SourceURl = "";

            //        if (dialog.FileName != "")
            //        {
            //            if (dialog.FileName.EndsWith(".csv"))
            //            {
            //                DataTable dtNew = new DataTable();
            //                dtNew = GetDataTabletFromCSVFile(dialog.FileName);
            //                if (Convert.ToString(dtNew.Columns[0]).ToLower() != "filename")
            //                {
            //                    MessageBox.Show("Invalid Items File");
            //                    MessageBox.Show(dtNew.ToString);
            //                    btnSaveData.Enabled = false;
            //                    return;
            //                }
            //                txtFile.Text = dialog.SafeFileName;
            //                SourceURl = dialog.FileName;
            //                Console.WriteLine(dtNew);
            //                if (dtNew.Rows != null && dtNew.Rows.ToString() != String.Empty)
            //                {
            //                    DGItems.DataSource = dtNew;
            //                }
            //                foreach (DataGridViewRow row in DGItems.Rows)
            //                {
            //                    if (Convert.ToString(row.Cells["Filename"].Value) == "" || row.Cells["Filename"].Value == null
            //                        || Convert.ToString(row.Cells["Full Path"].Value) == "" || row.Cells["Full Path"].Value == null
            //                        || Convert.ToString(row.Cells["Size(bytes)"].Value) == "" || row.Cells["Size(bytes)"].Value == null
            //                        || Convert.ToString(row.Cells["Created"].Value) == "" || row.Cells["Created"].Value == null
            //                        || Convert.ToString(row.Cells["Modified"].Value) == "" || row.Cells["Modified"].Value == null
            //                        || Convert.ToString(row.Cells["Is Deleted"].Value) == "" || row.Cells["Is Deleted"].Value == null)
            //                    {
            //                        row.DefaultCellStyle.BackColor = Color.Red;
            //                        inValidItem += 1;
            //                    }
            //                    else
            //                    {
            //                        ImportedRecord += 1;
            //                    }
            //                }
            //                if (DGItems.Rows.Count == 0)
            //                {
            //                    btnSave.Enabled = false;
            //                    MessageBox.Show("There is no data in this file", "GAUTAM POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Selected File is Invalid, Please Select valid csv file.", "GAUTAM POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Exception " + ex);
            //    }
            //    String imagePlace = "";
            //    try
            //    {
            //        OpenFileDialog fileOpen = new OpenFileDialog();
            //        fileOpen.Filter = "GPD|*.gpd";
            //        dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            //        if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //        {
            //            imagePlace = fileOpen.FileName;
            //            saveImagePanel.Text = imagePlace;
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

        }

        public List<Item> LoadCSV(string csvFile)
        {
            var query = from test in File.ReadAllLines(csvFile)
                        let data = test.Split(',')
                        select new Item
                        {
                            filename=data[0],
                            Fullpath=data[1],
                            Sizes=int.Parse(data[2]),
                            Created=data[3],
                            Modified=data[4],
                            Accessed=data[5],
                            IsDeleted=bool.Parse(data[6])

            
                        };

            return query.ToList();
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
            try
            {
                DataTable dtItem = (DataTable)(DGItems.DataSource);
                string Filename, Path, Created, Modified, Is_Deleted;
                string InsertItemQry = "";
                int count = 0;
                foreach (DataRow dr in dtItem.Rows)
                {
                    Filename = Convert.ToString(dr["Filename"]);
                    Path = Convert.ToString(dr["Path"]);
                    Created = Convert.ToString(dr["Created"]);
                    Modified = Convert.ToString(dr["Modified"]);
                    Is_Deleted = Convert.ToString(dr["Is_Deleted"]);
                    if (Filename != "" && Path != "" && Created != "" && Modified !="" && Is_Deleted != "")
                    {
                        InsertItemQry += "Insert into disk_image(Filename,Path,Created,Modified,IsDeleted,EntryDate)Values('" + Filename + "','" + Path + "','" + Created + "','" + Modified + "','" + Is_Deleted + "' ,GETDATE()); ";
                        count++;
                    }
                }
                //if (InsertItemQry.Length > 5)
               // {
                   // bool isSuccess = DBAccess.ExecuteQuery(InsertItemQry);
                    //if (isSuccess)
                    //{
                      //  MessageBox.Show("Item Imported Successfully, Total Imported Records : " + count + "", "GAUTAM POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //DGItems.DataSource = null;
                    //}
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public class Item
        {
            public string filename { get; set; }

            public string Fullpath { get; set; }

            public int Sizes { get; set; }

            public string Created { get; set; }

            public string Modified { get; set; }

            public string Accessed { get; set; }

            public bool IsDeleted { get; set; }
        }

        private void loadImg_Click(object sender, EventArgs e)
        {
            DGItems.DataSource = LoadCSV(txtFile.Text);
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
    
