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
    public partial class frmReserve : Form
    {
        public frmReserve()
        {
            InitializeComponent();
        }
        string err;
        BLReserve dbReserve = new BLReserve();

        private void FrmReserve_Load(object sender, EventArgs e)
        {
            RolePermission(public_class.role);
            LoadData();
        }
        private void RolePermission(string role)
        {
            //Guest
            if (public_class.role == "Guest" && public_class.islogin == true)
            {
                this.bttnSearchGuest.Visible = false;
                this.txtGuestName.Text = public_class.user.UserFName + " " + public_class.user.UserMName + " " + public_class.user.UserLName;

            }
        }

        private void LoadData()
        {
            if (dbReserve.GetDiscountActive() != null)
            {
                DataTable dtDiscount = new DataTable();
                dtDiscount = dbReserve.GetDiscountActive().Tables[0];
                List<string> discountList = new List<string>();

                for (int i = 0; i < dtDiscount.Rows.Count; i++)
                {
                    discountList.Add(dtDiscount.Rows[i]["DiscountType"].ToString());
                }
                cboDiscount.DataSource = discountList;
            }

        }

        private void BttnSearchRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRoom room = new frmRoom();
            room.ShowDialog();
            this.Show();

            if (public_class.roomSelected != null && public_class.isRoomSelected == true)
            {
                this.txtRoomNumber.Text = public_class.roomSelected.RoomNumber;
                this.txtRoomRate.Text = public_class.roomSelected.RoomRate.ToString();
                this.txtRoomType.Text = public_class.roomSelected.RoomType;
            }
        }

        private void BttnSearchGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectGuest guest = new frmSelectGuest();
            guest.ShowDialog();
            this.Show();
            this.txtGuestName.Text = public_class.userSelected.UserFName + " " + public_class.userSelected.UserMName + " " + public_class.userSelected.UserLName;
        }

        private void DtCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime t = dtCheckInDate.Value;
            if (t.Date < DateTime.Now.Date)
            {
                dtCheckInDate.Value = DateTime.Now.Date;
            }
            else
            {
                dtCheckOutDate.Value = dtCheckInDate.Value.Date.AddDays(1);
            }
        }

        private void DtCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan T = dtCheckOutDate.Value - dtCheckInDate.Value;
            if (T.Days < 1)
            {
                dtCheckOutDate.Text = System.Convert.ToString(dtCheckInDate.Value.Date.AddDays(1));
                txtDaysNumber.Text = "1";
            }
            else
            {
                txtDaysNumber.Text = T.Days.ToString();
            }
            /*
            lblTotal.Text = Convert.ToString(Convert.ToInt32(txtRoomRate.Text) * Convert.ToInt32(txtDaysNumber.Text));
            txtSubTotal.Text = Convert.ToString(Convert.ToInt32(txtRoomRate.Text) * Convert.ToInt32(txtDaysNumber.Text));
            lblDateNow.Text = DateTime.Now.Date.ToString();
            */    
        }

        private void CboDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
