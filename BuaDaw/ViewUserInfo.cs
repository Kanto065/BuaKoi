using DAL.Tables;
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
    public partial class ViewUserInfo : Form
    {
        public ViewUserInfo()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var adminHome = (AdminHome)Tag;
            adminHome.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        RegisterDatatable registerDatatable = new RegisterDatatable();


        private void searchboxx_TextChanged(object sender, EventArgs e)
        {
            if (searchboxx.Text == "")
            {
                DataTable table = registerDatatable.selectData2();
                dataGridView1.DataSource = table;
            }
            else
            {
                DataTable table = registerDatatable.Search2(searchboxx.Text);
                dataGridView1.DataSource = table;
            }
        }

        private void ViewUserInfo_Load(object sender, EventArgs e)
        {
            DataTable table = registerDatatable.selectData2();
            dataGridView1.DataSource = table;
        }
    }
}
