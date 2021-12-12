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
using DAL.Entities;
using DAL.Tables;

namespace BuaDaw
{
    public partial class UserHome : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;Convert Zero Datetime=True;password=";

        public UserHome()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserUpdateInfoButton_Click(object sender, EventArgs e)
        {
            UserUpdateInfo userUpdateInfo = new UserUpdateInfo();
            userUpdateInfo.Tag = this;
            userUpdateInfo.Show(this);
            this.Hide();
        }

        private void UserLogOutButton_Click(object sender, EventArgs e)
        {
            var logIn = (LogIn)Tag;
            logIn.Show();
            this.Close();
        }
        string temp = LogIn.passEmail;

        //username

        
        private void btnHireMaid_Click(object sender, EventArgs e)
        {
            //username

            /*MySqlConnection databaseConnection3 = new MySqlConnection(connectionString);
            databaseConnection3.Open();
            string iquery3 = "SELECT * FROM buakoi.userinfo WHERE Email = '" + temp + "';";

            MySqlCommand commandDatabase3 = new MySqlCommand(iquery3, databaseConnection3);
            MySqlDataReader myReader3 = commandDatabase3.ExecuteReader();

            string hsts3 = "";
            if (myReader3.Read())
            {
                hsts3 = myReader3.GetValue(0).ToString();
                databaseConnection3.Close();
            }

            MessageBox.Show(hsts3);
            //label1.Text = hsts3;*/

            //string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=buakoi;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            string iquery = "SELECT * FROM buakoiprotik.hiringstatus WHERE MaidID = '" + txtHireMaidID.Text + "';";

            MySqlCommand commandDatabase = new MySqlCommand(iquery, databaseConnection);
            //commandDatabase.CommandTimeout = 60;   
            MySqlDataReader myReader = commandDatabase.ExecuteReader();
            int flag = 1;
            if (myReader.Read())
            {
                string hsts = myReader.GetValue(2).ToString();
                databaseConnection.Close();

                if (hsts == "1")
                {
                    MessageBox.Show("The Maid is alredy been hired!");
                    flag = 0;

                }
            }

            MySqlConnection databaseConnection4 = new MySqlConnection(connectionString);
            databaseConnection4.Open();
            string iquery4 = "SELECT * FROM buakoiprotik.maidinfo WHERE MaidID = '" + txtHireMaidID + "';";

            MySqlCommand commandDatabase4 = new MySqlCommand(iquery4, databaseConnection4);
            MySqlDataReader myReader4 = commandDatabase4.ExecuteReader();

            //string hsts4 = "";
            if (myReader4.Read() == true)
            {
                MessageBox.Show("Wrong Maid ID");
            }

            else if (flag == 1)
            {

                //userid
                MySqlConnection databaseConnection2 = new MySqlConnection(connectionString);
                databaseConnection2.Open();
                string iquery2 = "SELECT * FROM buakoiprotik.userinfo WHERE Email = '" + temp + "';";

                MySqlCommand commandDatabase2 = new MySqlCommand(iquery2, databaseConnection2);
                MySqlDataReader myReader2 = commandDatabase2.ExecuteReader();

                string hsts2 = "";
                if (myReader2.Read())
                {
                    hsts2 = myReader2.GetValue(6).ToString();
                    databaseConnection2.Close();
                }

                
                //int userID = Int32.Parse(hsts2);

                //string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=buakoi;";
                //string iquery = "INSERT INTO hiringstatus(`MaidID`,`AdminID`,`UserID`,`HiringStatus`,`DoB`,`Gender`,`PhoneNumber`) VALUES ('" + email.Text + "','" + password.Text + "', '" + fname.Text + "', '" + lname.Text + "', '" + datetime.Text + "', '" + gender.Text + "', '" + phone.Text + "')";
                string iquery1 = "INSERT INTO buakoiprotik.hiringstatus(`MaidID`,`HiringStatus`) VALUES ('" + txtHireMaidID.Text + "','" + 1 + "')";

                MySqlConnection databaseConnection1 = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase1 = new MySqlCommand(iquery1, databaseConnection1);
                commandDatabase1.CommandTimeout = 60;

                try
                {
                    databaseConnection1.Open();
                    MySqlDataReader myReader1 = commandDatabase1.ExecuteReader();
                    databaseConnection1.Close();
                }
                catch (Exception ex)
                {
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Maid Successfully Hired!");
            }

            if (string.IsNullOrEmpty(txtHireMaidID.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            //username

            MySqlConnection databaseConnection3 = new MySqlConnection(connectionString);
            databaseConnection3.Open();
            string iquery3 = "SELECT * FROM buakoiprotik.userinfo WHERE Email = '" + temp + "';";

            MySqlCommand commandDatabase3 = new MySqlCommand(iquery3, databaseConnection3);
            MySqlDataReader myReader3 = commandDatabase3.ExecuteReader();

            string hsts3 = "";
            if (myReader3.Read())
            {
                hsts3 = myReader3.GetValue(0).ToString();
                databaseConnection3.Close();
            }

            label1.Text = hsts3;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM buakoiprotik.maidinfo", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //e.Row.Cells[1].Visible = false;
                //dataGridView1.ColumnCount = 10;
                dataGridView1.AutoGenerateColumns = false;
                //dataGridView1.Columns[3].Visible = false;
                dataGridView1.DataSource = dt;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }
    }
}
