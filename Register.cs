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
using System.Text.RegularExpressions;
using AesEncDec;
using System.IO;

namespace MP4Carver
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            //obj_system = new Encryption();
        }

        //Encryption obj_system;

        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=mp4_carver;";
        
        static string Encrypted(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        public void UserRegister()
        {
            //string query = "INSERT INTO users(name,password,matric_no) VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtMatricNo.Text + "') ";
           //string query = "INSERT INTO users(name,password,matric_no) VALUES ('try', 'je0121', '0111') ";

            //connection mysql XAMPP
            //MySqlConnection dbconnection = new MySqlConnection(conn);
           // MySqlCommand commandDB = new MySqlCommand(query, dbconnection);
           // commandDB.CommandTimeout = 60;
            //MySqlDataReader reader;

            try
            {

                var txtInput = txtPassword.Text;

                if(txtInput == "")
                {
                    MessageBox.Show("Password Should not be empty");
                    return;
                }

                var hasNumber = new Regex(@"[0-9]+");
                var hasUpperCase = new Regex(@"[A-Z]+");
                var hasLowerCase = new Regex(@"[a-z]+");
                var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+");

                if (!hasNumber.IsMatch(txtInput))
                {
                    MessageBox.Show("Password should have at least ONE Number Value");
                    return;
                }


                else if (!hasUpperCase.IsMatch(txtInput))
                {
                    MessageBox.Show("Password should have at least ONE upper case letter Value");
                    return;
                }


                else if (!hasLowerCase.IsMatch(txtInput))
                {
                    MessageBox.Show("Password should have at least ONE lower case letter Value");
                    return;
                }


                else if (!hasSymbols.IsMatch(txtInput))
                {
                    MessageBox.Show("Password should have at least ONE symbol Value");
                    return;
                }


               else  if (string.IsNullOrEmpty(txtUsername.Text) || (string.IsNullOrEmpty(txtPassword.Text)) || (string.IsNullOrEmpty(txtMatricNo.Text)))
                {
                    MessageBox.Show("Please Fill Username and Password and Matric No", "Error");
                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please enter your password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string dir = txtUsername.Text;
                Directory.CreateDirectory("data\\" + dir);
                var sw = new StreamWriter("data\\" + dir + "\\data.ls");

                string encusr = AesCryp.Encrypt(txtUsername.Text);
                string encpass = AesCryp.Encrypt(txtPassword.Text);

                sw.WriteLine(encusr);
                sw.WriteLine(encpass);
                sw.Close();


                string query = "INSERT INTO users(name,password,matric_no) VALUES ('" + encusr + "', '" + encpass + "', '" + txtMatricNo.Text + "') ";
                //string query = "INSERT INTO users(name,password,matric_no) VALUES ('try', 'je0121', '0111') ";

                //connection mysql XAMPP
                MySqlConnection dbconnection = new MySqlConnection(conn);
                dbconnection.Open();
                MySqlCommand commandDB = new MySqlCommand(query, dbconnection);
                commandDB.CommandTimeout = 60;
                commandDB.ExecuteNonQuery();
                //MySqlDataReader reader;
               
       
                
                    MessageBox.Show("Welcome to MP4Carver");
                        Login loginSys = new Login();
                        loginSys.Show();
                        this.Hide();
                        //Profile from2 = new Profile();
                        // from2.Show();
                        // this.Hide();
                    

            
                dbconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("User was successfully created.", txtUsername.Text);
            this.Close();
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
            
        }

        //public Boolean ValidatePassword(string password)
        //{
        //    String patternPassword = @”^(?=.[0 - 9])(?=.[a - z])(?=.*[A - Z]).{ 8,}$”,
        //    if (!string.IsNullOrEmpty(password))
        //        {
        //    if (!Regex.IsMatch(password, patternPassword))
        //        (
        //      return false;
        //    )
        //        return true;
        //     )
        // }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void showPass_Click(object sender, EventArgs e)
        {
      
           // if (txtPassword.PasswordChar == '*')
            //{
              //  showPass.BringToFront();
                //hidePass.BringToFront();
              // txtPassword.PasswordChar = '\0';
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
