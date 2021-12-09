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
    }
}
