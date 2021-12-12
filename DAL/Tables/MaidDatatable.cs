using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DAL.Entities;
using System.Windows.Forms;
using System.Data;

namespace DAL.Tables
{
    public class MaidDatatable
    {
        MySqlConnection connection = new MySqlConnection(Conncetion.conncetionString);



        public bool Add(MaidData admin) //inserting data
        {
            try
            {
                string sql = "INSERT INTO maidinfo(FullName,DoB,Gender,PhoneNumber,WorkAddress,WorkTime,WorkExperience,ExpectedSalary) VALUES(@FullName,@DoB,@Gender,@PhoneNumber,@WorkAddress,@WorkTime,@WorkExperience,@ExpectedSalary)";
                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("@FullName", admin.FullName);
                command.Parameters.AddWithValue("@DoB", admin.DoB);
                command.Parameters.AddWithValue("@Gender", admin.Gender);
                command.Parameters.AddWithValue("@WorkAddress", admin.WorkAddress);
                command.Parameters.AddWithValue("@PhoneNumber", admin.PhoneNumber);
                command.Parameters.AddWithValue("@WorkTime", admin.WorkTime);

                command.Parameters.AddWithValue("@WorkExperience", admin.WorkExperience);
                command.Parameters.AddWithValue("@ExpectedSalary", admin.ExpectedSalary);

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
        
        public DataTable selectData()   //select data from database
        {
            DataTable table = new DataTable();
            try
            {
                
                string sql = "SELECT * FROM maidinfo";
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


        public bool Update(MaidData admin)  //update
        {
            try
            {

                string sql = "UPDATE maidinfo SET FullName=@FullName,DoB=@DoB,Gender=@Gender,PhoneNumber=@PhoneNumber,WorkAddress=@WorkAddress,WorkTime=@WorkTime,WorkExperience=@WorkExperience,ExpectedSalary=@ExpectedSalary WHERE MaidID=@MaidID";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@FullName", admin.FullName);
                command.Parameters.AddWithValue("@MaidID", admin.MaidID);
                command.Parameters.AddWithValue("@DoB", admin.DoB);
                command.Parameters.AddWithValue("@Gender", admin.Gender);
                command.Parameters.AddWithValue("@WorkAddress", admin.WorkAddress);
                command.Parameters.AddWithValue("@PhoneNumber", admin.PhoneNumber);
                command.Parameters.AddWithValue("@WorkTime", admin.WorkTime);


                command.Parameters.AddWithValue("@WorkExperience", admin.WorkExperience);
                command.Parameters.AddWithValue("@ExpectedSalary", admin.ExpectedSalary);
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

        public bool Delete(MaidData admin)   //delete
        {
            try
            {
                string sql = "DELETE FROM maidinfo WHERE MaidID=@MaidID";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaidID", admin.MaidID);
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


        public DataTable Search(string key)   //search
        {
            DataTable table = new DataTable();
            try
            {
                string sql = "SELECT * FROM maidinfo where MaidID LIKE '%" + key + "%' OR Fullname LIKE '%" + key + "%' OR WorkAddress LIKE '%" + key + "%' ";
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

        public DataTable selectDataHire()   //select data from database
        {
            DataTable table = new DataTable();
            try
            {

                string sql = "SELECT * FROM hiringstatus";
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


        public DataTable SearchHire(string key)   //search
        {
            DataTable table = new DataTable();
            try
            {
                string sql = "SELECT * FROM hiringstatus where MaidID LIKE '%" + key + "%' OR UserID LIKE '%" + key + "%'";
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
