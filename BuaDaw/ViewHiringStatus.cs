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
    public partial class ViewHiringStatus : Form
    {
        public ViewHiringStatus()
        {
            InitializeComponent();
        }

        private void BackToAdminHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var adminHome = (AdminHome)Tag;
            adminHome.Show();
            this.Close();
        }

        MaidDatatable maidDatatable = new MaidDatatable();

        private void ViewHiringStatus_Load(object sender, EventArgs e)
        {
            DataTable table = maidDatatable.selectDataHire();
            dataGridView1.DataSource = table;

        }

        private void hiringSearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (hiringSearchTxt.Text == "")
            {
                DataTable table = maidDatatable.selectDataHire();
                dataGridView1.DataSource = table;
            }
            else
            {
                DataTable table = maidDatatable.SearchHire(hiringSearchTxt.Text);
                dataGridView1.DataSource = table;
            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }
    }
}
