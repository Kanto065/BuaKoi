using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using DAL.Entities;
using DAL.Tables;

namespace BuaDaw
{
    public partial class Register : Form
    {
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string pattern2 = "^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\\s\\./0-9]*$";
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fname.Text) == true)
            {
                fname.Focus();
                errorProvider1.SetError(this.fname, "Please enter first name");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        /*private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lname.Text) == true)
            {
                lname.Focus();
                errorProvider2.SetError(this.lname, "Please enter last name");

            }
            else
            {
                errorProvider2.Clear();
            }
        }*/

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(email.Text.Trim(), pattern) == false)
            {
                email.Focus();
                errorProvider3.SetError(this.email, "Invalid email or empty");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phone.Text) == true)
            {
                phone.Focus();
                errorProvider4.SetError(this.phone, "Please enter valid number");

            }
            else if (Regex.IsMatch(phone.Text.Trim(), pattern2) == false)
            {
                phone.Focus();
                errorProvider4.SetError(this.phone, "Invalid Phone number or empty");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void GetStarted_Click(object sender, EventArgs e)
        {
            // CREATE BUTTON
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            MySqlCommand command;
            MySqlDataReader mdr;

            connection.Open();
            string selectQuery = "SELECT * FROM buakoi.userinfo WHERE Email = '" + email.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("The email has already been registered");

            }
            else
            {

                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=buakoi;";
                string iquery = "INSERT INTO userinfo(`Email`,`Password`,`FirstName`,`LastName`,`DoB`,`Gender`,`PhoneNumber`) VALUES ('" + email.Text + "','" + password.Text + "', '" + fname.Text + "', '" + lname.Text + "', '" + datetime.Text + "', '" + gender.Text + "', '" + phone.Text + "')";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(iquery, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Account Successfully Created!");
            }

            connection.Close();

            if (string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            //lastline
        }*/

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void BackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var logIn = (LogIn)Tag;
            logIn.Show();
            this.Close();
        }

        RegisterData registerData = new RegisterData();
        RegisterDatatable registerDatatable = new RegisterDatatable();
        private void GetStarted_Click(object sender, EventArgs e)
        {
            registerData.FullName = fname.Text;
            registerData.DoB = datetime.Value;
            registerData.Password = password.Text;
            if(male.Checked)
            {
                registerData.Gender = "Male";
            }
            else if(female.Checked)
            {
                registerData.Gender = "Female";
            }
            else if(other.Checked)
            {
                registerData.Gender = "Other";
            }
            
            registerData.PhoneNumber = phone.Text;
            registerData.Address = location.Text;
            registerData.Email = email.Text;
            if (registerDatatable.Insert(registerData))
            {
                UserHome userHome = new UserHome();
                userHome.Tag = this;
                userHome.Show(this);
                this.Hide();

            }
        }
    }
}
