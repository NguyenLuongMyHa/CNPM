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
            frmUser user = new frmUser();
            user.ShowDialog();
            this.Show();
        }
        private void ToolbarRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRoom room = new frmRoom();
            room.ShowDialog();
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
                this.ToolBarGuest.Text = "Edit Information";
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
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void ToolbarReserve_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReserve reserve = new frmReserve();
            reserve.ShowDialog();
            this.Show();
        }
    }
}
