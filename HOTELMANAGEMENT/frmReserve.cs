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
                this.TabControl1.TabPages.Remove(TabPage2);
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

        private void Amount()
        {
            try
            {
                int Date = int.Parse(this.txtDaysNumber.Text);
                int Payment = dbReserve.GetPrice(public_class.roomSelected.RoomNumber) * 1000 * Date;
                this.txtPayment.Text = Payment.ToString();
                double Discount = Payment * int.Parse(this.txtDiscountRate.Text) / 100.0;
                this.txtDiscountPayment.Text = Discount.ToString();
                double Total = Payment - Discount;
                this.txtTotal.Text = Total.ToString();
            }
            catch
            {
                MessageBox.Show("Please select Room Available");
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
            string itemSelected = this.cboDiscount.SelectedItem.ToString();
            this.txtDiscountRate.Text =  dbReserve.GetDiscountRate(itemSelected).ToString();
            if(int.Parse(this.txtDaysNumber.Text) !=0)
                Amount();

        }

        private void BttnReserve_Click(object sender, EventArgs e)
        {
            bool flag = true;
            int NumberGuest = int.Parse(this.txtAdults.Text) + int.Parse(this.txtChildren.Text);
            if (NumberGuest == 0)
            {
                MessageBox.Show("Please select number of guest");
                flag = false;
            }
            int NoOfOccurency = dbReserve.GetNoOfOccurancy(this.txtRoomNumber.Text);
            if (NumberGuest > NoOfOccurency)
            {
                MessageBox.Show("Please select the number of guests less than " + NoOfOccurency);
                flag = false;
            }
            Reservation newReservation = new Reservation();
            int ID = dbReserve.AutoGenerateID();
            int GuestID;
            if (public_class.role == "Guest")
            {
                GuestID = public_class.user.ID;
            }
            else
                GuestID = public_class.userSelected.ID;


            if (public_class.roomSelected == null)
            {
                MessageBox.Show("Please Select Room!");
                flag = false;
            }
            if(Convert.ToInt16(this.txtDaysNumber.Text)==0)
            {
                MessageBox.Show("Please select number of day you stay in our Hotel");
                flag = false;
            }

            if(flag == true)
            {
                int RoomID = public_class.roomSelected.ID;

                DateTime CheckInDate = dtCheckInDate.Value;
                DateTime CheckOutDate = dtCheckOutDate.Value;
                int NoOfChild = Convert.ToInt16(this.txtChildren.Text);
                int NoOfAdults = Convert.ToInt16(this.txtAdults.Text);
                int DiscountID = dbReserve.GetDiscountID(this.cboDiscount.SelectedItem.ToString());
                string Remark = "Reserve";
                try
                {
                    dbReserve.MakeReservation(ID, GuestID, RoomID, CheckInDate, CheckOutDate, NoOfChild, NoOfAdults, DiscountID, Remark, ref err);
                    MessageBox.Show("Congratulations!" + Environment.NewLine + "successful booking");
                }
                catch
                {
                    MessageBox.Show("Sorry, we cannot book this room");
                }
            }
            


        }

        private void TxtDaysNumber_TextChanged(object sender, EventArgs e)
        {
            Amount();
        }

        private void BtnSubAdults_Click(object sender, EventArgs e)
        {
            int Adults = int.Parse(this.txtAdults.Text);
            if (Adults > 0)
            {
                Adults -= 1;
                this.txtAdults.Text = Adults.ToString();
            }

        }

        private void BtnAddAdults_Click(object sender, EventArgs e)
        {
            int Adults = int.Parse(this.txtAdults.Text) + 1;
            this.txtAdults.Text = Adults.ToString();

        }

        private void BtnSubChildren_Click(object sender, EventArgs e)
        {
            int Children = int.Parse(this.txtChildren.Text);
            if (Children > 0)
            {
                Children -= 1;
                this.txtChildren.Text = Children.ToString();
            }
        }

        private void BtnAddChildren_Click(object sender, EventArgs e)
        {
            int Children = int.Parse(this.txtChildren.Text)+1;
            this.txtChildren.Text = Children.ToString();
        }

        private void BttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
