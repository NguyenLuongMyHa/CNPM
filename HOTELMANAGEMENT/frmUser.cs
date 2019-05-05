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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        string err;
        DataTable dtUser = null;
        DataTable dtGuestUser = null;
        DataTable dtReceptionistUser = null;

        BLUser dbUser = new BLUser();
        BLLogin dbLogin = new BLLogin();

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            RolePermission(public_class.role);
            LoadData();
        }
      
        private void LoadData()
        {
            try
            {
                dtUser = new DataTable();
                dtUser.Clear();
                DataSet ds = dbUser.GetUser();
                dtUser = ds.Tables[0];

                dtGuestUser = new DataTable();
                dtGuestUser.Clear();
                DataSet dsguest = dbUser.GetGuestUser();
                dtGuestUser = dsguest.Tables[0];
                dgv_GuestList.DataSource = dtGuestUser;
                dgv_GuestList.AutoResizeColumns();

                dtReceptionistUser = new DataTable();
                dtReceptionistUser.Clear();
                DataSet dsreceptionist = dbUser.GetReceptionistUser();
                dtReceptionistUser = dsreceptionist.Tables[0];
                dgv_ReceptionistList.DataSource = dtReceptionistUser;
                dgv_ReceptionistList.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Get User Data Failed");
                
            }
        }
        //Guest register
        private void BtnGuestSave_Click(object sender, EventArgs e)
        {

            string UserFName = this.txtGuestFName.Text;
            string UserMName = this.txtGuestMName.Text;
            string UserLName = this.txtGuestLName.Text;
            string UserAddress = this.txtGuestAddress.Text;
            string UserContactNumber = this.txtGuestNumber.Text;
            string UserGender = this.cboGuestGender.SelectedItem.ToString();
            string UserEmail = this.txtGuestEmail.Text;
            string Status = "Active";
            string Remarks = "Available";
            string UserName = this.txt_GuestUserName.Text;
            string Password = this.txt_GuestPassword.Text;

            try
            {
                if (dbLogin.FindUserName(UserName) == true)
                {
                    MessageBox.Show("Username already exists." + Environment.NewLine + "Please enter another Username!");
                }
                else
                {
                    LoadData();
                    int ID = dbUser.AutoGenerateID(dtUser);

                    dbLogin.AddUser(UserName, Password, "Guest", ref err);
                    dbUser.AddUser(ID, UserFName, UserMName, UserLName, UserAddress, UserContactNumber, UserGender, UserEmail, Status, Remarks, UserName, ref err);
                    MessageBox.Show("Registered!");
                    LoadData();


                }
            }
            catch
            {
                MessageBox.Show("Register Failed");
            }
        }

        private void BtnGuestCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ReceptCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_RecepEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_EditGuestCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //---------------------------------------------
        private void RolePermission(string role)
        {
            //Guest register
            if (public_class.role == "Guest" && public_class.islogin == false)
            {
                TabControl1.TabPages.Remove(TabPageGuestList);
                TabControl1.TabPages.Remove(tabPageGuestEdit);
                TabControl1.TabPages.Remove(tabPageNewReceptionist);
                TabControl1.TabPages.Remove(tabPageReceptionistList);
                TabControl1.TabPages.Remove(tabPageEditReceptionist);

            }
            //Guest edit info
            if (public_class.role == "Guest" && public_class.islogin == true)
            {
                TabControl1.TabPages.Remove(TabPageGuestList);
                TabControl1.TabPages.Remove(TabPageNewGuest);
                TabControl1.TabPages.Remove(tabPageNewReceptionist);
                TabControl1.TabPages.Remove(tabPageReceptionistList);
                TabControl1.TabPages.Remove(tabPageEditReceptionist);
                this.lblSelectGuest.Visible = false;
                this.btnEditGuestSelect.Visible = false;
            }
            //Receptionist add guest, view list guest

            if (public_class.role == "Receptionist" && public_class.islogin == true)
            {
                txt_EditGuestPassword.Visible = false;
                lblEditGuestPass.Visible = false;
                TabControl1.TabPages.Remove(tabPageReceptionistList);
                TabControl1.TabPages.Remove(tabPageNewReceptionist);
            }
        }

        private void btn_SelectGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectGuest guest = new frmSelectGuest();
            guest.ShowDialog();
            this.Show();
        }
    }
}
