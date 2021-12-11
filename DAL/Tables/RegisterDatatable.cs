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

        public bool Update(RegisterData admin)  //update
        {
            try
            {

                string sql = "UPDATE userinfo SET FullName=@FullName,DoB=@DoB,Gender=@Gender,PhoneNumber=@PhoneNumber,Address=@Address,Email=@Email WHERE UserID=@UserID";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@FullName", admin.FullName);
                command.Parameters.AddWithValue("@UserID", admin.UserID);
                command.Parameters.AddWithValue("@DoB", admin.DoB);
                command.Parameters.AddWithValue("@Gender", admin.Gender);
                command.Parameters.AddWithValue("@Email", admin.Email);
                command.Parameters.AddWithValue("@PhoneNumber", admin.PhoneNumber);
                command.Parameters.AddWithValue("@Password", admin.Password);
                command.Parameters.AddWithValue("@Address", admin.Address);
                //command.Parameters.AddWithValue("@ExpectedSalary", admin.ExpectedSalary);
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
        public DataTable selectData2()   //select data from database
        {
            DataTable table = new DataTable();
            try
            {
                string sql = "SELECT UserID,FullName,DoB,Gender,PhoneNumber,Address,Email FROM userinfo";
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
        public DataTable Search2(string key)   //search
        {
            DataTable table = new DataTable();
            try
            {
                string sql = "SELECT UserID,FullName,DoB,Gender,PhoneNumber,Address,Email FROM userinfo where UserID LIKE '%" + key + "%' OR Fullname LIKE '%" + key + "%' ";
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



    }
        
}

