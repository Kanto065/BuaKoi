using DAL.Entities;
using DAL.Tables;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuaDaw
{
    public partial class UserUpdateInfo : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=buakoiprotik");


        public UserUpdateInfo()
        {
            InitializeComponent();
        }

        RegisterData registerData = new RegisterData();
        RegisterDatatable registerDatatable = new RegisterDatatable();

        private void BackToUserHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var userHome = (UserHome)Tag;
            userHome.Show();
            this.Close();
        }

        private void UserUpdateInfo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = selectData();
        }

        public DataTable selectData()   //select data from database
        {
            DataTable table = new DataTable();
            try
            {
                string email = LogIn.userEmail;
                string sql = "SELECT * FROM userinfo where email= '" + email + "';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return table;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            fname.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            email.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            pass.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            userid.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            phone.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            //dob. = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            location.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fname.Text != "" && email.Text != "" && pass.Text != "" && userid.Text != "")
            {
                int UserID = int.Parse(userid.Text);
                registerData.UserID = UserID;
                registerData.FullName = fname.Text;
                registerData.Email = email.Text;
                registerData.Password = pass.Text;
                registerData.Address = location.Text;
                registerData.PhoneNumber = phone.Text;
                registerData.DoB = dob.Value;
                if (male.Checked)
                {
                    registerData.Gender = "Male";
                }
                else if (female.Checked)
                {
                    registerData.Gender = "Female";
                }
                else if (other.Checked)
                {
                    registerData.Gender = "Other";
                }

                if (registerDatatable.Update(registerData))
                {
                    MessageBox.Show("Entry Successful");
                }
                DataTable table = selectData();
                dataGridView1.DataSource = table;
                //reset();
            }
        }
    }
}
