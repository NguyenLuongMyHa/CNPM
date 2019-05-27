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
        BLUser dbUser = new BLUser();
        BLLogin dbLogin = new BLLogin();
        private string deleteUser = "";
        private void FrmRegister_Load(object sender, EventArgs e)
        {
            RolePermission(public_class.role);
            LoadData();
        }
      
        private void LoadData()
        {
            if(dbUser.LoadDataUser()==true)
            {
                dgv_GuestList.DataSource = public_class.guestUserData;
                dgv_GuestList.AutoResizeColumns();
                dgv_ReceptionistList.DataSource = public_class.receptionistUserData;
                dgv_ReceptionistList.AutoResizeColumns();
                if(public_class.role == "Guest")
                {
                    this.txt_EditGuestFName.Text = public_class.user.UserFName;
                    this.txt_EditGuestMName.Text = public_class.user.UserMName;
                    this.txt_EditGuestLName.Text = public_class.user.UserLName;
                    this.txt_EditGuestEmail.Text = public_class.user.UserEmail;
                    this.txt_EditGuestAddress.Text = public_class.user.UserAddress;
                    this.txt_EditGuestNumber.Text = public_class.user.UserContactNumber;
                    this.cbx_EditGuestGender.SelectedItem = public_class.user.UserGender;
                }

                if (public_class.role == "Receptionist")
                {
                    this.txt_RecepEditFName.Text = public_class.user.UserFName;
                    this.txt_RecepEditMName.Text = public_class.user.UserMName;
                    this.txt_RecepEditLName.Text = public_class.user.UserLName;
                    this.txt_RecepEditEmail.Text = public_class.user.UserEmail;
                    this.txt_RecepEditAddress.Text = public_class.user.UserAddress;
                    this.txt_RecepEditNumber.Text = public_class.user.UserContactNumber;
                    this.cbx_RecepEditGender.SelectedItem = public_class.user.UserGender;
                }
            }
            else
            {
                MessageBox.Show("Load data error");
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
                lbl_EditRecepPass.Visible = false;
                this.txt_RecepEditPassword.Visible = false;
            }
        }
        //---------------------------------------------
        private void BtnGuestSave_Click(object sender, EventArgs e)//add Guest
        {
            if(CheckNullGuest()==true)
                MessageBox.Show("Please enter all fields");
            else
            {
                bool isSafe = false;
                string UserFName = this.txtGuestFName.Text;
                string UserMName = this.txtGuestMName.Text;
                string UserLName = this.txtGuestLName.Text;
                string UserAddress = this.txtGuestAddress.Text;
                string UserContactNumber = this.txtGuestNumber.Text;
                string UserEmail = this.txtGuestEmail.Text;
                string Status = "Active";
                string Remarks = "Available";
                string UserName = this.txtGuestUserName.Text;
                string Password = this.txtGuestPassword.Text;
                string UserGender = "Male";
                if (this.cboGuestGender.SelectedItem == null)
                {
                    MessageBox.Show("Please select gender");
                    isSafe = false;
                }
                else
                {
                    UserGender = this.cboGuestGender.SelectedItem.ToString();
                    isSafe = true;
                }
                if (dbLogin.FindUserName(UserName) == true)
                {
                    MessageBox.Show("Username already exists." + Environment.NewLine + "Please enter another Username!");
                    isSafe = false;
                }
                if(isSafe == true)
                {
                    try
                    {
                        LoadData();
                        int ID = dbUser.AutoGenerateID(public_class.allUserData);
                        dbLogin.AddUser(UserName, Password, "Guest", ref err);
                        dbUser.AddUser(ID, UserFName, UserMName, UserLName, UserAddress, UserContactNumber, UserGender, UserEmail, Status, Remarks, UserName, ref err);
                        MessageBox.Show("Registered!");
                        LoadData();
                    }
                    catch
                    {
                        MessageBox.Show("Register Failed");
                    }
                }
            }
            
        }
        private void BtnReceptSave_Click(object sender, EventArgs e)// Manager add new Receptionist
        {
            if (CheckNullRecept() == true)
                MessageBox.Show("Please enter all fields");
            else
            {
                bool isSafe = false;
                string UserFName = this.txtRecepFName.Text;
                string UserMName = this.txtRecepMName.Text;
                string UserLName = this.txtRecepLname.Text;
                string UserAddress = this.txtRecepAddress.Text;
                string UserContactNumber = this.txtRecepNumber.Text;
                string UserEmail = this.txtRecepEmail.Text;
                string Status = "Active";
                string Remarks = "Available";
                string UserName = this.txtRecepUserName.Text;
                string Password = this.txtReceptPassword.Text;
                string UserGender = "Male";

                if (this.cbxReceptGender.SelectedItem == null)
                {
                    MessageBox.Show("Please select gender");
                    isSafe = false;
                }
                else
                {
                    UserGender = this.cbxReceptGender.SelectedItem.ToString();
                    isSafe = true;
                }
                if (dbLogin.FindUserName(UserName) == true)
                {
                    MessageBox.Show("Receptionist Username already exists." + Environment.NewLine + "Please enter another Username!");
                    isSafe = false;
                }
                if(isSafe==true)
                {
                    try
                    {
                        LoadData();
                        int ID = dbUser.AutoGenerateID(public_class.allUserData);

                        dbLogin.AddUser(UserName, Password, "Receptionist", ref err);
                        dbUser.AddUser(ID, UserFName, UserMName, UserLName, UserAddress, UserContactNumber, UserGender, UserEmail, Status, Remarks, UserName, ref err);
                        MessageBox.Show("Registered!");
                        LoadData();
                    }
                    catch
                    {
                        MessageBox.Show("Register Failed");
                    }
                }
            }
        }
        //receptionnist/manager select guest to edit
        private void btn_SelectGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectGuest guest = new frmSelectGuest();
            guest.ShowDialog();
            this.Show();
            if(public_class.userSelected != null && public_class.isUserSelected==true)
            {
                this.txt_EditGuestFName.Text = public_class.userSelected.UserFName;
                this.txt_EditGuestMName.Text = public_class.userSelected.UserMName;
                this.txt_EditGuestLName.Text = public_class.userSelected.UserLName;
                this.txt_EditGuestEmail.Text = public_class.userSelected.UserEmail;
                this.txt_EditGuestAddress.Text = public_class.userSelected.UserAddress;
                this.txt_EditGuestNumber.Text = public_class.userSelected.UserContactNumber;
                this.cbx_EditGuestGender.SelectedItem = public_class.userSelected.UserGender;
                public_class.isUserSelected = false;
            }
        }
        //manager select receptionist to edit
        private void Btn_SelectReceptionist_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectReceptionist receptlist = new frmSelectReceptionist();
            receptlist.ShowDialog();
            this.Show();
            if (public_class.userSelected != null && public_class.isUserSelected == true)
            {
                this.txt_RecepEditFName.Text = public_class.userSelected.UserFName;
                this.txt_RecepEditMName.Text = public_class.userSelected.UserMName;
                this.txt_RecepEditLName.Text = public_class.userSelected.UserLName;
                this.txt_RecepEditEmail.Text = public_class.userSelected.UserEmail;
                this.txt_RecepEditAddress.Text = public_class.userSelected.UserAddress;
                this.txt_RecepEditNumber.Text = public_class.userSelected.UserContactNumber;
                this.cbx_RecepEditGender.SelectedItem = public_class.userSelected.UserGender;
                public_class.isUserSelected = false;
            }
        }
        private void Btn_EditGuestSave_Click(object sender, EventArgs e)//Edit Guest
        {
            

            string UserGender = "Male";
            if (this.cbx_EditGuestGender.SelectedItem == null)
                MessageBox.Show("Please select gender");
            else
                UserGender = this.cbx_EditGuestGender.SelectedItem.ToString();
            if (CheckNullGuestEdit() == true)
                MessageBox.Show("Please enter all fields");
            else
            {
                
                string UserFName = this.txt_EditGuestFName.Text;
                string UserMName = this.txt_EditGuestMName.Text;
                string UserLName = this.txt_EditGuestLName.Text;
                string UserAddress = this.txt_EditGuestAddress.Text;
                string UserContactNumber = this.txt_EditGuestNumber.Text;
                string UserEmail = this.txt_EditGuestEmail.Text;
                string Status = "Active";
                string Remarks = "Available";
                string Password = this.txt_EditGuestPassword.Text;


                string Username = public_class.user.UserName;
                int ID = public_class.user.ID;
                if (public_class.role == "Receptionist" || public_class.role == "Manager")
                {
                    Username = public_class.userSelected.UserName;
                    ID = public_class.userSelected.ID;
                }

                try
                {
                    if (public_class.role == "Guest")//Guest duoc sua password cua minh
                    {
                        dbLogin.EditUser(Username, Password, "Guest", ref err);
                        if (this.txt_EditGuestPassword.Text == "")
                        {
                            MessageBox.Show("please fill out password");
                        }
                        else
                        {
                            dbUser.EditUser(ID, UserFName, UserMName, UserLName, UserAddress, UserContactNumber, UserGender, UserEmail, Status, Remarks, Username, ref err);
                            MessageBox.Show("Edited!");
                        }
                    }
                    else//Manager và Receptionist khong sua password cua guest
                    {
                        dbUser.EditUser(ID, UserFName, UserMName, UserLName, UserAddress, UserContactNumber, UserGender, UserEmail, Status, Remarks, Username, ref err);
                        MessageBox.Show("Edited!");
                    }

                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Edit Failed");
                }
            }
        }
        private void Btn_EditReceptionistSave_Click(object sender, EventArgs e)//Edit Guest
        {
            string UserGender = "Male";
            if (this.cbx_RecepEditGender.SelectedItem == null)
                MessageBox.Show("Please select gender");
            else
                UserGender = this.cbx_RecepEditGender.SelectedItem.ToString();
            if (CheckNullReceptEdit() == true)
                MessageBox.Show("Please enter all fields");
            else
            {
                string UserFName = this.txt_RecepEditFName.Text;
                string UserMName = this.txt_RecepEditMName.Text;
                string UserLName = this.txt_RecepEditLName.Text;
                string UserAddress = this.txt_RecepEditAddress.Text;
                string UserContactNumber = this.txt_RecepEditNumber.Text;
                string UserEmail = this.txt_RecepEditEmail.Text;
                string Status = "Active";
                string Remarks = "Available";
                string Password = this.txt_RecepEditPassword.Text;
                string Username = public_class.user.UserName;
                int ID = public_class.user.ID;

                if (public_class.role == "Manager")
                {
                    Username = public_class.userSelected.UserName;
                    ID = public_class.userSelected.ID;
                }

                try
                {
                    if (public_class.role == "Receptionist")//Receptionist duoc sua password cua minh
                    {
                        dbLogin.EditUser(Username, Password, "Receptionist", ref err);
                        if (this.txt_RecepEditPassword.Text == "")
                        {
                            MessageBox.Show("please fill out password");
                        }
                        else
                        {
                            dbUser.EditUser(ID, UserFName, UserMName, UserLName, UserAddress, UserContactNumber, UserGender, UserEmail, Status, Remarks, Username, ref err);
                            MessageBox.Show("Edited!");
                        }
                    }
                    else//Manager khong sua password cua receptionist 
                    {
                        dbUser.EditUser(ID, UserFName, UserMName, UserLName, UserAddress, UserContactNumber, UserGender, UserEmail, Status, Remarks, Username, ref err);
                        MessageBox.Show("Edited!");
                    }

                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Edit Failed");
                }
            }
        }
        private bool CheckNullReceptEdit()
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(this.txt_RecepEditFName);
            textBoxes.Add(this.txt_RecepEditMName);
            textBoxes.Add(this.txt_RecepEditLName);
            textBoxes.Add(this.txt_RecepEditAddress);
            textBoxes.Add(this.txt_RecepEditEmail);
            textBoxes.Add(this.txt_RecepEditNumber);
            foreach(TextBox i in textBoxes)
            {
                if (i.Text == "")
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckNullRecept()
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(this.txtRecepFName);
            textBoxes.Add(this.txtRecepMName);
            textBoxes.Add(this.txtRecepLname);
            textBoxes.Add(this.txtRecepAddress);
            textBoxes.Add(this.txtRecepNumber);
            textBoxes.Add(this.txtRecepEmail);
            textBoxes.Add(this.txtRecepUserName);
            textBoxes.Add(this.txtReceptPassword);
            foreach (TextBox i in textBoxes)
            {
                if (i.Text == "")
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckNullGuest()
        {

            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(this.txtGuestFName);
            textBoxes.Add(this.txtGuestMName);
            textBoxes.Add(this.txtGuestLName);
            textBoxes.Add(this.txtGuestAddress);
            textBoxes.Add(this.txtGuestNumber);
            textBoxes.Add(this.txtGuestEmail);
            textBoxes.Add(this.txtGuestUserName);
            textBoxes.Add(this.txtGuestPassword);


                foreach (TextBox i in textBoxes)
            {
                if (i.Text == "")
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckNullGuestEdit()
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(this.txt_EditGuestAddress);
            textBoxes.Add(this.txt_EditGuestEmail);
            textBoxes.Add(this.txt_EditGuestFName);
            textBoxes.Add(this.txt_EditGuestLName);
            textBoxes.Add(this.txt_EditGuestMName);
            textBoxes.Add(this.txt_EditGuestNumber);

            foreach (TextBox i in textBoxes)
            {
                if (i.Text == "")
                {
                    return true;
                }
            }
            return false;
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
        private void BtnGuestCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_GuestListCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuestDelete_Click(object sender, EventArgs e)
        {
            if(deleteUser=="")
            {
                MessageBox.Show("Please select guest to delete");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Delete this guest?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dbLogin.DeleteUser(ref err, deleteUser);
                    dbUser.DeleteUser(ref err, deleteUser);
                    LoadData();
                    deleteUser = "";
                }
            }
        }

        private void BtnReceptDelete_Click(object sender, EventArgs e)
        {
            if (deleteUser == "")
            {
                MessageBox.Show("Please select receptionist to delete");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Delete this receptionist?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dbLogin.DeleteUser(ref err, deleteUser);
                    dbUser.DeleteUser(ref err, deleteUser);
                    LoadData();
                    deleteUser = "";
                }
            }
        }

        private void Dgv_GuestList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_GuestList.CurrentCell.RowIndex;
            deleteUser = dgv_GuestList.Rows[r].Cells[9].Value.ToString();
        }

        private void Dgv_ReceptionistList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_ReceptionistList.CurrentCell.RowIndex;
            deleteUser = dgv_ReceptionistList.Rows[r].Cells[9].Value.ToString();
        }
    }
}
