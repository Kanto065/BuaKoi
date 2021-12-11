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
    public partial class AdminUpdateInfo : Form
    {
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
        //AdminData maidData = new AdminData();
        //MaidDatatable maidDatatable = new MaidDatatable();

        private void AdminUpdateInfo_Load(object sender, EventArgs e)
        {
            //DataTable table = adminDatatable.selectData();
            //dataGridView1.DataSource = table;
        }
    }
}
