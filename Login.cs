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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string conn = "datasource=localhost;port=3306;username=root;password=;database=mp4_carver;";
        
        public void userLogin()
        {
            string query = "SELECT * FROM users WHERE name='" + txtUser + "' AND password='" + txtPassword + "' ";
            //connection mysql XAMPP
            MySqlConnection dbconnection = new MySqlConnection(conn);
            MySqlCommand commandDB = new MySqlCommand(query, dbconnection);
            commandDB.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                dbconnection.Open();
                reader = commandDB.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Login to MP4Carver");
                        Profile from2 = new Profile();
                        from2.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Please try again");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userLogin();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
