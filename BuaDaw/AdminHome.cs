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

namespace BuaDaw
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ViewUserInfo viewUserInfo = new ViewUserInfo();
            viewUserInfo.Tag = this;
            viewUserInfo.Show(this);
            this.Hide();
        }

        private void UpdateInfoButton_Click(object sender, EventArgs e)
        {
            AdminUpdateInfo adminUpdateInfo = new AdminUpdateInfo();
            adminUpdateInfo.Tag = this;
            adminUpdateInfo.Show(this);
            this.Hide();
        }

        private void AdminLogOutButton_Click(object sender, EventArgs e)
        {
            var logIn = (LogIn)Tag;
            logIn.Show();
            this.Close();
        }

        private void ViewHiringStatusButton_Click(object sender, EventArgs e)
        {
            ViewHiringStatus viewHiringStatus = new ViewHiringStatus();
            viewHiringStatus.Tag = this;
            viewHiringStatus.Show(this);
            this.Hide();
        }

        MaidData maidData = new MaidData();
        MaidDatatable maidDatatable = new MaidDatatable();

        private void Add_Click(object sender, EventArgs e)
        {
            if (Mfname.Text != "" && dateTimePicker1.Value != null && TextSalary.Text != "" && Textphone.Text != "" && TextmWorkLocation.Text != "" && TextmWorkTIme.Text != "" && TextmWorkExperience.Text != "")
            {
                maidData.FullName = Mfname.Text;
                maidData.DoB = dateTimePicker1.Value;
                maidData.ExpectedSalary = TextSalary.Text;
                maidData.PhoneNumber = Textphone.Text;
                maidData.WorkAddress = TextmWorkLocation.Text;

                maidData.WorkTime = TextmWorkTIme.Text;
                maidData.WorkExperience = TextmWorkExperience.Text;
                /*try
                {
                    maidData.MaidID = int.Parse(TextMaidID.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/

                if (male.Checked)
                {
                    maidData.Gender = "Male";
                }
                else if (female.Checked)
                {
                    maidData.Gender = "Female";
                }
                else if (other.Checked)
                {
                    maidData.Gender = "Other";
                }

                if (maidDatatable.Add(maidData))
                {
                    MessageBox.Show("Entry Successful");
                    //changes done

                }
                DataTable table = maidDatatable.selectData();
                dataGridView1.DataSource = table;
                reset();

            }
            else
            {
                MessageBox.Show("Please fill all the requirements for adding data");
            }
        }

        public void reset()   //reset function
        {
            Mfname.Text = "";

            TextSalary.Text = "";
            Textphone.Text = "";
            TextmWorkLocation.Text = "";
            TextmWorkTIme.Text = "";
            TextmWorkExperience.Text = "";
            TextMaidID.Text = "";
            male.Checked = false;
            female.Checked = false;
            other.Checked = false;
        }
   

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Mfname.Text != "" && dateTimePicker1.Value != null && TextSalary.Text != "" && Textphone.Text != "" && TextmWorkLocation.Text != "" && TextmWorkTIme.Text != "" && TextmWorkExperience.Text != "")
            {
                int MaidID = int.Parse(TextMaidID.Text);
                maidData.MaidID = MaidID;
                maidData.FullName = Mfname.Text;
                maidData.DoB = dateTimePicker1.Value;
                maidData.ExpectedSalary = TextSalary.Text;
                maidData.PhoneNumber = Textphone.Text;
                maidData.WorkAddress = TextmWorkLocation.Text;

                maidData.WorkTime = TextmWorkTIme.Text;
                maidData.WorkExperience = TextmWorkExperience.Text;

                if (male.Checked)
                {
                    maidData.Gender = "Male";
                }
                else if (female.Checked)
                {
                    maidData.Gender = "Female";
                }
                else if (other.Checked)
                {
                    maidData.Gender = "Other";
                }

                if (maidDatatable.Update(maidData))
                {
                    MessageBox.Show("Entry Successful");
                    //changes done

                }
                DataTable table = maidDatatable.selectData();
                dataGridView1.DataSource = table;
                reset();

            }

            else
            {
                MessageBox.Show("Please fill all the requirements for adding data");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (TextMaidID.Text != "")
            {
                maidData.MaidID = int.Parse(TextMaidID.Text);
                if (maidDatatable.Delete(maidData))
                {
                    MessageBox.Show("Deleted");
                    DataTable table = maidDatatable.selectData();
                    dataGridView1.DataSource = table;
                    reset();
                }
            }
            else
            {
                MessageBox.Show("Please select for delete first");
            }
        }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
            if (Searchbox.Text == "")
            {
                DataTable table = maidDatatable.selectData();
                dataGridView1.DataSource = table;
            }
            else
            {
                DataTable table = maidDatatable.Search(Searchbox.Text);
                dataGridView1.DataSource = table;
            }
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            DataTable table = maidDatatable.selectData();
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            Mfname.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            TextmWorkTIme.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            TextMaidID.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            TextmWorkExperience.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            TextmWorkLocation.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            Textphone.Text = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
            TextSalary.Text = dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            if (Mfname.Text != "" && dateTimePicker1.Value != null && TextSalary.Text != "" && Textphone.Text != "" && TextmWorkLocation.Text != "" && TextmWorkTIme.Text != "" && TextmWorkExperience.Text != "")
            {
                maidData.FullName = Mfname.Text;
                maidData.DoB = dateTimePicker1.Value;
                maidData.ExpectedSalary = TextSalary.Text;
                maidData.PhoneNumber = Textphone.Text;
                maidData.WorkAddress = TextmWorkLocation.Text;

                maidData.WorkTime = TextmWorkTIme.Text;
                maidData.WorkExperience = TextmWorkExperience.Text;
                /*try
                {
                    maidData.MaidID = int.Parse(TextMaidID.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/

                if (male.Checked)
                {
                    maidData.Gender = "Male";
                }
                else if (female.Checked)
                {
                    maidData.Gender = "Female";
                }
                else if (other.Checked)
                {
                    maidData.Gender = "Other";
                }

                if (maidDatatable.Add(maidData))
                {
                    MessageBox.Show("Entry Successful");
                    //changes done

                }
                DataTable table = maidDatatable.selectData();
                dataGridView1.DataSource = table;
                reset();

            }
            else
            {
                MessageBox.Show("Please fill all the requirements for adding data");
            }
        }
    }
}
