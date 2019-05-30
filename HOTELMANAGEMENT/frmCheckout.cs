using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOTELMANAGEMENT.BL;

namespace HOTELMANAGEMENT
{
    public partial class frmCheckout : Form
    {
        BLReserve dbReserve = new BLReserve();
        string err;
        private int ReserveID = -1;
        private int GuestID;
        private int RoomID;
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void FrmCheckout_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            if (dbReserve.GetCheckinList() != null)
            {
                DataTable dtReservation = new DataTable();
                dtReservation = dbReserve.GetCheckinList().Tables[0];
                this.dgvCheckoutList.DataSource = dtReservation;
            }
        }
        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            if (ReserveID == -1)
            {
                MessageBox.Show("Please select the guest checkout request");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ready for checkout?", "Checkout", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        dbReserve.ChangeUserRemarkAvailable(this.GuestID, ref err);
                        dbReserve.ChangeRoomStatusAvailable(this.RoomID, ref err);
                        dbReserve.CancelReservation(ref err, this.ReserveID);
                        ReserveID = -1;
                        MessageBox.Show("Checkout successfully");
                        LoadData();
                    }
                    catch
                    {
                        MessageBox.Show("Checkout fail");
                    }
                }
            }
        }

        private void DgvCheckoutList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCheckoutList.CurrentCell.RowIndex;
            this.ReserveID = int.Parse(dgvCheckoutList.Rows[r].Cells["ID"].Value.ToString());
            this.GuestID = int.Parse(dgvCheckoutList.Rows[r].Cells["GuestID"].Value.ToString());
            this.RoomID = int.Parse(dgvCheckoutList.Rows[r].Cells["RoomID"].Value.ToString());
        }
    }
}
