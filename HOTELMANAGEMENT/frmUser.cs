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
                lbl_SelectEditRecep.Visible = false;
                btn_EditSelectReceptionist.Visible = false;
                TabControl1.TabPages.Remove(tabPageReceptionistList);
                TabControl1.TabPages.Remove(tabPageNewReceptionist);
            }

            if(public_class.role == "Manager" && public_class.islogin == true)
            {
                lblEditGuestPass.Visible = false;
                this.txt_EditGuestPassword.Visible = false;
            }
        }
        //---------------------------------------------
        private void BtnGuestSave_Click(object sender, EventArgs e)//register guest
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

        private void Btn_ReceptSave_Click(object sender, EventArgs e)// Register new Receptionist (Manager)
        {
            string UserFName = this.txtRecepFName.Text;
            string UserMName = this.txtRecepMName.Text;
            string UserLName = this.txtRecepLname.Text;
            string UserAddress = this.txtRecepAddress.Text;
            string UserContactNumber = this.txtRecepNumber.Text;
            string UserGender = this.cbx_ReceptGender.SelectedItem.ToString();
            string UserEmail = this.txtRecepEmail.Text;
            string Status = "Active";
            string Remarks = "Available";
            string UserName = this.txt_RecepUserName.Text;
            string Password = this.txt_ReceptPassword.Text;

            try
            {
                if (dbLogin.FindUserName(UserName) == true)
                {
                    MessageBox.Show("Receptionist Username already exists." + Environment.NewLine + "Please enter another Username!");
                }
                else
                {
                    LoadData();
                    int ID = dbUser.AutoGenerateID(dtUser);

                    dbLogin.AddUser(UserName, Password, "Receptionist", ref err);
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

        
        private void btn_SelectGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectGuest guest = new frmSelectGuest();
            guest.ShowDialog();
            this.Show();
            if(public_class.guestSelected != null && public_class.isGuestSelected==true)
            {
                this.txt_EditGuestFName.Text = public_class.guestSelected.UserFName;
                this.txt_EditGuestMName.Text = public_class.guestSelected.UserMName;
                this.txt_EditGuestLName.Text = public_class.guestSelected.UserLName;
                this.txt_EditGuestEmail.Text = public_class.guestSelected.UserEmail;
                this.txt_EditGuestAddress.Text = public_class.guestSelected.UserAddress;
                this.txt_EditGuestNumber.Text = public_class.guestSelected.UserContactNumber;
                public_class.isGuestSelected = false;
            }
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
        private void Btn_RecepListCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_GuestListCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_EditGuestSave_Click(object sender, EventArgs e)//Edit Guest
        {
            string UserFName;
            string UserMName;
            string UserLName;
            string UserAddress;
            string UserContactNumber;
            string UserGender;
            string UserEmail;
            string Status = "Active";
            string Remarks = "Available";

            if (this.txt_EditGuestFName.Text=="")
                UserFName = public_class.user.UserFName;
            else
                UserFName = this.txt_EditGuestFName.Text;
            if (this.txt_EditGuestMName.Text == "")
                UserMName = public_class.user.UserMName;
            else
                UserMName = this.txt_EditGuestMName.Text;
            if (this.txt_EditGuestLName.Text == "")
                UserLName = public_class.user.UserLName;
            else
                UserLName = this.txt_EditGuestLName.Text;
            if (this.txt_EditGuestAddress.Text == "")
                UserAddress = public_class.user.UserAddress;
            else
                UserAddress = this.txt_EditGuestAddress.Text;
            if (this.txt_EditGuestNumber.Text == "")
                UserContactNumber = public_class.user.UserContactNumber;
            else
                UserContactNumber = this.txt_EditGuestNumber.Text;
            if (this.txt_EditGuestEmail.Text == "")
                UserEmail = public_class.user.UserEmail;
            else
                UserEmail = this.txt_EditGuestEmail.Text;
            UserGender = this.cbx_EditGuestGender.SelectedItem.ToString();

            string Password = this.txt_EditGuestPassword.Text;
            string Username = public_class.user.UserName;
            int ID = public_class.user.ID;
            if (public_class.role == "Receptionist"|| public_class.role == "Manager")
            {
                Username = public_class.guestSelected.UserName;
                ID = public_class.guestSelected.ID;
            }

            try
            {
                if(public_class.role=="Guest")
                    dbLogin.EditUser(Username, Password, "Guest", ref err);
                dbUser.EditUser(ID, UserFName, UserMName, UserLName, UserAddress, UserContactNumber, UserGender, UserEmail, Status, Remarks, Username, ref err);
                MessageBox.Show("Edited!");
                LoadData();
            }
            catch
            {
                MessageBox.Show("Edit Failed");
            }

        }
    }
}
