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
    }
}
