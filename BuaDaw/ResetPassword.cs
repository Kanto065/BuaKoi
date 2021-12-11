using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BuaDaw
{
    public partial class ResetPassword : Form
    {
        string username = forgottenPassword.to;

        public ResetPassword()
        {
            InitializeComponent();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            if (txtResetPass.Text == txtResetPassVer.Text)
            {
                SqlConnection con = new SqlConnection("server=localhost;user id=root;database=buakoiprotik");
                SqlCommand cmd = new SqlCommand("UPDATE admin SET [Password] = '" + txtResetPassVer.Text + "' WHERE Email='" + username + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("reset successfully");
            }
            else
            {
                MessageBox.Show("the new password do not match so enter same password");
            }
        }
    }
}
