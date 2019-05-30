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
    public partial class frmCheckin : Form
    {
        BLReserve dbReserve = new BLReserve();
        string err;
        private int ReserveID = -1;
        private int GuestID;
        private int RoomID;
        public frmCheckin()
        {
            InitializeComponent();
        }

        private void FrmCheckin_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            if (dbReserve.GetReservationList() != null)
            {
                DataTable dtReservation = new DataTable();
                dtReservation = dbReserve.GetReservationList().Tables[0];
                this.dgvCheckinList.DataSource = dtReservation;
            }
        }
        private void BttnCheckin_Click(object sender, EventArgs e)
        {
            if (ReserveID == -1)
            {
                MessageBox.Show("Please select the guest checkin request");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ready for checkin?", "Checkin", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        dbReserve.ChangeUserRemarkCheckin(this.GuestID, ref err);
                        dbReserve.ChangeRoomStatusOccupied(this.RoomID, ref err);
                        dbReserve.ChangeReserveRemarkCheckin(this.ReserveID, ref err);
                        ReserveID = -1;
                        MessageBox.Show("Checkin successfully");
                        LoadData();
                    }
                    catch
                    {
                        MessageBox.Show("Checkin fail");
                    }
                }
            }
        }



        private void DgvCheckinList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCheckinList.CurrentCell.RowIndex;
            this.ReserveID = int.Parse(dgvCheckinList.Rows[r].Cells["ID"].Value.ToString());
            this.GuestID = int.Parse(dgvCheckinList.Rows[r].Cells["GuestID"].Value.ToString());
            this.RoomID = int.Parse(dgvCheckinList.Rows[r].Cells["RoomID"].Value.ToString());
        }

        private void BttnCancelReserve_Click(object sender, EventArgs e)
        {
            if (ReserveID == -1)
            {
                MessageBox.Show("Please select the guest checkin request for Cancel");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Cancel this reservation?", "Cancel", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        dbReserve.ChangeUserRemarkAvailable(this.GuestID, ref err);
                        dbReserve.ChangeRoomStatusAvailable(this.RoomID, ref err);
                        dbReserve.CancelReservationBilling(ref err, this.ReserveID);
                        dbReserve.CancelReservation(ref err, this.ReserveID);
                        ReserveID = -1;
                        MessageBox.Show("Cancel reservation successfully");
                        LoadData();
                    }
                    catch
                    {
                        MessageBox.Show("Cancel reservation fail");
                    }
                }
            }
        }
    }
}
