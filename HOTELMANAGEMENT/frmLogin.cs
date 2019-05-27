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
using HOTELMANAGEMENT.BL;

namespace HOTELMANAGEMENT
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string role;
        
        BLLogin dbLogin = new BLLogin();

        private void OK_Click(object sender, EventArgs e)
        {

            bool loginsuccess = dbLogin.CheckLogin(this.UsernameTextBox.Text, this.PasswordTextBox.Text, this.role);
            if (loginsuccess)
            {
                public_class.role = this.role;
                public_class.islogin = true;
                MessageBox.Show("Welcome " + public_class.role + " " + public_class.user.UserName);
                FormMainRedirect();
            }
            else
            {
                MessageBox.Show("Guest Login Fail. " + Environment.NewLine + "Please check your Role, Username and Password");
                public_class.islogin = false;
            }
            this.UsernameTextBox.ResetText();
            this.PasswordTextBox.ResetText();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        public void FormMainRedirect()
        {
            this.Hide();
            frmMain formMain = new frmMain();
            formMain.ShowDialog();
        }
        private void rbt_Receptionist_CheckedChanged(object sender, EventArgs e)
        {
            this.role = "Receptionist";
        }

        private void Rbt_Guest_CheckedChanged(object sender, EventArgs e)
        {
            this.role = "Guest";
        }

        private void Rbt_Manager_CheckedChanged(object sender, EventArgs e)
        {
            this.role = "Manager";
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
      
        }

        private void Lbl_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            public_class.role = "Guest";
            public_class.islogin = false;
            this.Hide();
            frmUser guest = new frmUser();
            guest.ShowDialog();
            this.Show();
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OK.PerformClick();
            }
        }
    }
}
