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
        DataTable dtLogin = null;
        DataTable dtUser = null;

        BLLogin dbLogin = new BLLogin();
        BLUser dbUser = new BLUser();
        bool isLogin = false;

        private void OK_Click(object sender, EventArgs e)
        {

            bool loginsuccess = CheckLogin(this.UsernameTextBox.Text, this.PasswordTextBox.Text, this.role);
            if (loginsuccess)
            {
                public_class.role = this.role;
                public_class.islogin = true;
                MessageBox.Show("Welcome " + public_class.role + " " + public_class.user.UserName);
                Redirect();
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
        public bool CheckLogin(string username, string password, string role)
        {
            try
            {
                dtLogin = new DataTable();
                dtLogin.Clear();
                DataSet dslogin = dbLogin.GetUserLogin(username, password, role);
                dtLogin = dslogin.Tables[0];
            }
            catch
            {
                MessageBox.Show("Get User Data Failed");
                isLogin = false;
                return isLogin;
            }
            if (dtLogin.Rows.Count != 0)
            {
                dtUser = new DataTable();
                dtUser.Clear();
                DataSet ds = dbUser.GetUserByUsername(username);
                dtUser = ds.Tables[0];
                User UserLogin = new User();

                foreach (DataRow dr in dtUser.Rows)
                {
                    UserLogin.SetUser
                    (
                        int.Parse(dr[0].ToString()),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        dr[3].ToString(),
                        dr[4].ToString(),
                        dr[5].ToString(),
                        dr[6].ToString(),
                        dr[7].ToString(),
                        dr[8].ToString(),
                        dr[9].ToString(),
                        dr[10].ToString()
                    );
                    public_class.user = UserLogin;
                    isLogin = true;
                }
            }
            else
                isLogin = false;
            
            return isLogin;
        }

        public void Redirect()
        {
            this.Hide();
            frmMain guest = new frmMain();
            guest.ShowDialog();
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
