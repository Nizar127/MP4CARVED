using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MP4Carver
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=mp4_carver;";


        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        public void EditData()
        {
            MySqlConnection dbconnection = new MySqlConnection(conn);
            string query = "UPDATE users SET name = '"+txtName.Text+"' , matric_no = '"+txtMatricNumber.Text+"'";

            dbconnection.Open();
            MySqlCommand commandDB = new MySqlCommand(query, dbconnection);
            if(commandDB.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Updated");
                Profile loginSys = new Profile();
                loginSys.Show();
                this.Hide();
            }

            dbconnection.Close();
        }

        private void btnSubmitProfile_Click(object sender, EventArgs e)
        {
            EditData();
        }
    }
}
