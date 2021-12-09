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
    public class RegisterDatatable
    {
        MySqlConnection connection = new MySqlConnection(Conncetion.conncetionString);
        
        public bool Insert(RegisterData admin)
        {
            try
            {
                string sql = "INSERT INTO userinfo(FullName,DoB,Password,Gender,PhoneNumber,Address,Email) VALUES(@FullName,@DoB,@Password,@Gender,@PhoneNumber,@Address,@Email)";
                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("@FullName", admin.FullName);
                command.Parameters.AddWithValue("@DoB", admin.DoB);
                command.Parameters.AddWithValue("@Password", admin.Password);
                command.Parameters.AddWithValue("@Gender", admin.Gender);
                command.Parameters.AddWithValue("@PhoneNumber", admin.PhoneNumber);
                command.Parameters.AddWithValue("@Address", admin.Address);
                command.Parameters.AddWithValue("@Email", admin.Email);
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch(Exception ex)
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

