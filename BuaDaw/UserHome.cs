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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserUpdateInfoButton_Click(object sender, EventArgs e)
        {
            UserUpdateInfo userUpdateInfo = new UserUpdateInfo();
            userUpdateInfo.Tag = this;
            userUpdateInfo.Show(this);
            this.Hide();
        }

        private void UserLogOutButton_Click(object sender, EventArgs e)
        {
            var logIn = (LogIn)Tag;
            logIn.Show();
            this.Close();
        }
    }
}
