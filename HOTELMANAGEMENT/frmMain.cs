using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTELMANAGEMENT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ToolBarGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUser guest = new frmUser();
            guest.ShowDialog();
            this.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RolePermission(public_class.role);
            this.toolStripInfo.Text = public_class.role.ToUpper() + " " + public_class.user.UserFName + " " + public_class.user.UserMName + " " + public_class.user.UserLName;

        }

        private void RolePermission(string role)
        {
            if (public_class.role == "Guest"|| public_class.role == "Receptionist")
            {
                this.MenuStripManager.Visible = false;
            }
           
        }

        private void ToolBarLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Logout from application?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }

        }

        private void ToolBarExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Exit application?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
