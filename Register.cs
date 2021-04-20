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
using System.Security.Cryptography;

namespace MP4Carver
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            obj_system = new Encryption();
        }

        Encryption obj_system;

        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=mp4_carver;";


        public void UserRegister()
        {
            string query = "INSERT INTO users(name,password,matric_no) VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtMatricNo.Text + "') ";
           // string query = "INSERT INTO users(name,password,matric_no) VALUES ('try', 'je0121', '0111') ";

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
                        MessageBox.Show("Welcome to MP4Carver");
                        Login loginSys = new Login();
                        loginSys.Show();
                        this.Hide();
                        //Profile from2 = new Profile();
                        // from2.Show();
                        // this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Please try again");
                }
                dbconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (string.IsNullOrEmpty(txtUsername.Text) || (string.IsNullOrEmpty(txtPassword.Text)) || (string.IsNullOrEmpty(txtMatricNo.Text)))
            {
                MessageBox.Show("Please Fill Username and Password and Matric No", "Error");
            }
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegister();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //txtPassword_cipher.Text = obj_system.encrypt(txtPassword.clear_text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
