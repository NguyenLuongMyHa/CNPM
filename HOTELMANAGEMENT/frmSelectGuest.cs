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
    public partial class frmSelectGuest : Form
    {
        DataTable dtGuest = null;
        BLUser dbGuest = new BLUser();

        public frmSelectGuest()
        {
            InitializeComponent();
        }

        private void FrmSelectGuest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dtGuest = new DataTable();
                dtGuest.Clear();
                DataSet ds = dbGuest.GetGuestUserHasID();
                dtGuest = ds.Tables[0];
                dgvGuest.DataSource = dtGuest;
                dgvGuest.AutoResizeColumns();
                
                dgvGuest.AutoResizeColumns();
                dgvGuest.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (SqlException)
            {
                MessageBox.Show("Get Guest Data Failed");
            }
        }

        private void DgvGuest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvGuest.CurrentCell.RowIndex;
            int ID = int.Parse(dgvGuest.Rows[r].Cells[0].Value.ToString());
            string FName = dgvGuest.Rows[r].Cells[1].Value.ToString();
            string MName = dgvGuest.Rows[r].Cells[2].Value.ToString();
            string LName = dgvGuest.Rows[r].Cells[3].Value.ToString();
            string Address = dgvGuest.Rows[r].Cells[4].Value.ToString();
            string ContactNum = dgvGuest.Rows[r].Cells[5].Value.ToString();
            string Gender = dgvGuest.Rows[r].Cells[6].Value.ToString();
            string Email = dgvGuest.Rows[r].Cells[7].Value.ToString();
            string Remark = dgvGuest.Rows[r].Cells[8].Value.ToString();
            string Username = dgvGuest.Rows[r].Cells[9].Value.ToString();

            User GuestSelected = new User();
            GuestSelected.SetUser(ID, FName, MName, LName, Address, ContactNum, Gender, Email, Remark, Username);
            // bien toan cuc luu guest nao duoc chon
            public_class.userSelected = GuestSelected;
            public_class.isUserSelected = true;
            MessageBox.Show("Guest " + public_class.userSelected.UserFName + " " + public_class.userSelected.UserMName + " " + public_class.userSelected.UserLName + " Selected");
            this.Close();
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
    }
}
