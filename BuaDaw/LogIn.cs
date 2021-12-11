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
namespace BuaDaw
{
    public partial class LogIn : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=buakoiprotik");
        MySqlCommand command;
        MySqlDataReader mdr;

        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public LogIn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FAQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Tag = this;
            register.Show();
            this.Hide();
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pass.Text) == true)
            {
                pass.Focus();
                errorProvider2.SetError(this.pass, "Please enter password");

            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(email.Text.Trim(), pattern) == false)
            {
                email.Focus();
                errorProvider1.SetError(this.email, "Invalid email or empty");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
        public void reset()   //reset function
        {
            email.Text = "";
            pass.Text = "";
        }


        private void GetStarted_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM userinfo WHERE Email = '" + email.Text + "' AND Password = '" + pass.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                //MessageBox.Show("Login Successful!");
                userEmail = (email.Text).ToString();
                UserHome userHome = new UserHome();
                userHome.Tag = this;
                userHome.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Login Information! Try again.");
            }

            connection.Close();

            if (string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(pass.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            reset();


        }

        private void BackToLandingPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var landingPage = (LandingPage)Tag;
            landingPage.Show();
            this.Close();
        }

        private void BackToLandingPageB_Click(object sender, EventArgs e)
        {
            var landingPage = (LandingPage)Tag;
            landingPage.Show();
            this.Close();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        public static string adminEmail, userEmail;
        

        public void AdminLogInButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM admin WHERE Email = '" + email.Text + "' AND Password = '" + pass.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                //MessageBox.Show("Login Successful!");
                adminEmail = (email.Text).ToString();

                AdminHome adminHome = new AdminHome();
                adminHome.Tag = this;
                adminHome.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Login Information! Try again.");
            }

            connection.Close();

            if (string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(pass.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            reset();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgottenPassword forgottenPassword = new forgottenPassword();
            forgottenPassword.Tag = this;
            forgottenPassword.Show(this);
            //this.Hide();
        }
    }
}
