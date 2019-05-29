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
    public partial class frmSelectReceptionist : Form
    {
        DataTable dtReceptionist = null;
        BLUser dbReceptionist = new BLUser();

        public frmSelectReceptionist()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            try
            {
                dtReceptionist = new DataTable();
                dtReceptionist.Clear();
                DataSet ds = dbReceptionist.GetReceptionistUserHasID();
                dtReceptionist = ds.Tables[0];
                dgvReceptionist.DataSource = dtReceptionist;
                dgvReceptionist.AutoResizeColumns();

                dgvReceptionist.AutoResizeColumns();
                dgvReceptionist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (SqlException)
            {
                MessageBox.Show("Get Receptionist Data Failed");
            }
        }

        private void dgvReceptionist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvReceptionist.CurrentCell.RowIndex;
            int ID = int.Parse(dgvReceptionist.Rows[r].Cells[0].Value.ToString());
            string FName = dgvReceptionist.Rows[r].Cells[1].Value.ToString();
            string MName = dgvReceptionist.Rows[r].Cells[2].Value.ToString();
            string LName = dgvReceptionist.Rows[r].Cells[3].Value.ToString();
            string Address = dgvReceptionist.Rows[r].Cells[4].Value.ToString();
            string ContactNum = dgvReceptionist.Rows[r].Cells[5].Value.ToString();
            string Gender = dgvReceptionist.Rows[r].Cells[6].Value.ToString();
            string Email = dgvReceptionist.Rows[r].Cells[7].Value.ToString();
            string Remark = dgvReceptionist.Rows[r].Cells[8].Value.ToString();
            string Username = dgvReceptionist.Rows[r].Cells[9].Value.ToString();

            User ReceptionistSelected = new User();
            ReceptionistSelected.SetUser(ID, FName, MName, LName, Address, ContactNum, Gender, Email, Remark, Username);
            // bien toan cuc luu Receptionist nao duoc chon
            public_class.userSelected = ReceptionistSelected;
            public_class.isUserSelected = true;
            MessageBox.Show("Receptionist " + public_class.userSelected.UserFName + " " + public_class.userSelected.UserMName + " " + public_class.userSelected.UserLName + " Selected");
            this.Close();
        }

        private void FrmSelectReceptionist_Load(object sender, EventArgs e)
        {
            LoadData();
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
