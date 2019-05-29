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
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();
        }
        string err;
        private int deleteRoomID = -1;

        BLRoom dbRoom = new BLRoom();

        private void FrmRoom_Load(object sender, EventArgs e)
        {
            RolePermission(public_class.role);
            LoadData();
        }

        private void RolePermission(string role)
        {
            if ((public_class.role == "Guest"|| public_class.role =="Receptionist") && public_class.islogin == true)
            {
                Tab_Room.TabPages.Remove(TabPageNewRoom);
            }
            if (public_class.role == "Manager" && public_class.islogin == true)
            {
                this.btn_RoomDelete.Visible = true;
            }
        }
        private void LoadData()
        {
            if(dbRoom.LoadRoom()!=null)
            {
                dgv_RoomList.DataSource = dbRoom.LoadRoom();
                dgv_RoomList.AutoResizeColumns();
                foreach (DataGridViewRow row in dgv_RoomList.Rows)
                {
                    if (Convert.ToString(row.Cells["Status"].Value) == "Occupied")
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkRed;
                        row.DefaultCellStyle.ForeColor = Color.WhiteSmoke;

                    }
                    if (Convert.ToString(row.Cells["Status"].Value) == "Reserve")
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkSlateGray;
                        row.DefaultCellStyle.ForeColor = Color.WhiteSmoke;

                    }
                    if (Convert.ToString(row.Cells["Status"].Value) == "Available")
                    {
                        row.DefaultCellStyle.BackColor = Color.AliceBlue;
                    }
                }
            }
        }
       
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_RoomCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //AddRoom
        private void BtnRoomSave_Click(object sender, EventArgs e)
        {
            if(CheckNullRoom()==true)
                MessageBox.Show("Please enter all fields");
            else
            {
                string RoomNumber = this.txtRoomNumber.Text;
                string RoomType = this.txtRoomType.Text;
                int RoomRate = Convert.ToInt32(this.txtRoomRate.Text);
                int NoOfOccupancy = Convert.ToInt32(this.txtNoOfOccupancy.Text);
                string Status = "Available";
                if(dbRoom.FindRoomNumber(RoomNumber)==true)
                {
                    MessageBox.Show("RoomNumber already exists." + Environment.NewLine + "Please enter another RoomNumber!");
                }
                else
                {
                    try
                    {
                        LoadData();
                        int ID = dbRoom.AutoGenerateID();
                        dbRoom.AddRoom(ID, RoomNumber, RoomType, RoomRate, NoOfOccupancy, Status, ref err);
                        MessageBox.Show("New room added!");
                        LoadData();
                    }
                    catch
                    {
                        MessageBox.Show("Add room failed");
                    }
                }
            }
        }
        private bool CheckNullRoom()
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(this.txtNoOfOccupancy);
            textBoxes.Add(this.txtRoomNumber);
            textBoxes.Add(this.txtRoomRate);
            textBoxes.Add(this.txtRoomType);
            foreach (TextBox i in textBoxes)
            {
                if (i.Text == "")
                {
                    return true;
                }
            }
            return false;
        }
        private void Btn_RoomDelete_Click(object sender, EventArgs e)
        {
            if(deleteRoomID == -1)
                MessageBox.Show("Please select room to delete");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Delete this room?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dbRoom.DeleteRoom(ref err, deleteRoomID);
                    LoadData();
                    deleteRoomID = -1;
                }
            }
        }

        private void Dgv_RoomList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_RoomList.CurrentCell.RowIndex;
            if (public_class.role == "Manager")
            {
                deleteRoomID = Convert.ToInt32(dgv_RoomList.Rows[r].Cells[0].Value) ;           
            }

            Room roomSelected = new Room();
            roomSelected.ID = Convert.ToInt32(dgv_RoomList.Rows[r].Cells[0].Value);
            roomSelected.RoomNumber = dgv_RoomList.Rows[r].Cells[1].Value.ToString();
            roomSelected.RoomType = dgv_RoomList.Rows[r].Cells[2].Value.ToString();
            roomSelected.RoomRate = Convert.ToInt32(dgv_RoomList.Rows[r].Cells[3].Value);
            roomSelected.NoOfOccupancy = Convert.ToInt32(dgv_RoomList.Rows[r].Cells[4].Value);
            roomSelected.Status = dgv_RoomList.Rows[r].Cells[5].Value.ToString();
            public_class.roomSelected = new Room();
            public_class.roomSelected = roomSelected;
            public_class.isRoomSelected = true;
            MessageBox.Show("Room " + public_class.roomSelected.RoomNumber + " selected");

        }
    }
}
