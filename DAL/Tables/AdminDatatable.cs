using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DAL.Entities;
using System.Data;
using System.Windows.Forms;

namespace DAL.Tables
{
    class AdminDatatable
    {
        MySqlConnection connection = new MySqlConnection(Conncetion.conncetionString);

        public DataTable selectData()   //select data from database
        {
            DataTable table = new DataTable();
            try
            {
                string sql = "SELECT * FROM admin";
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

        public bool Update(AdminData admin)  //update
        {
            try
            {

                string sql = "UPDATE admin SET FullName=@FullName,Email=@Email,Password=@Password, WHERE AdminID=@AdminID";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@FullName", admin.FullName);
                command.Parameters.AddWithValue("@MaidID", admin.Password);
                command.Parameters.AddWithValue("@DoB", admin.Email);
                connection.Open();
                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
    }
}
