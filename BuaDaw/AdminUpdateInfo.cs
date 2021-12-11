using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entities;
using DAL.Tables;
using MySql.Data.MySqlClient;

namespace BuaDaw
{
    public partial class AdminUpdateInfo : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=buakoiprotik");
        //MySqlConnection connection = new MySqlConnection(Conncetion.conncetionString);
        public AdminUpdateInfo()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var adminHome = (AdminHome)Tag;
            adminHome.Show();
            this.Close();
        }
        AdminData adminData = new AdminData();
        AdminDatatable adminDatatable = new AdminDatatable();

        //string email = LogIn.getEmail;


        private void AdminUpdateInfo_Load(object sender, EventArgs e)
        {
            //string email = LogIn.getEmail;
            //DataTable table = adminDatatable.selectData();
            
            dataGridView1.DataSource = selectData();
        }

        public DataTable selectData()   //select data from database
        {
            DataTable table = new DataTable();
            try
            {
                string email = LogIn.adminEmail;
                string sql = "SELECT * FROM admin where email= '" + email + "';";
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
            email.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            pass.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            adminid.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fname.Text != "" && email.Text != "" && pass.Text != "" && adminid.Text != "")
            {
                int AdminID = int.Parse(adminid.Text);
                adminData.AdminID = AdminID;
                adminData.FullName = fname.Text;
                adminData.Email = email.Text;
                adminData.Password = pass.Text;
                
                if (adminDatatable.Update(adminData))
                {
                    MessageBox.Show("Entry Successful");
                    
                }
                DataTable table = selectData();
                dataGridView1.DataSource = table;
                reset();
            }
        }
        public void reset()   //reset function
        {
            email.Text = "";
            pass.Text = "";
            fname.Text = "";
            adminid.Text = "";
        }
    }

}
