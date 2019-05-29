using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOTELMANAGEMENT.DAL;
using System.Data;
namespace HOTELMANAGEMENT.BL
{


    class BLRoom
    {
        DBMain db = null;
        DataTable dtRoom = null;
        public BLRoom()
        {
            db = new DBMain();
        }
        public DataTable LoadRoom()
        {
            try
            {
                dtRoom = new DataTable();
                dtRoom.Clear();
                DataSet ds = this.GetRoom();
                dtRoom = ds.Tables[0];
                return dtRoom;
            }
            catch
            {
                return null;
            }
        }
        public DataSet GetRoom()
        {
            return db.ExecuteQueryDataSet("Select * from tblRoom", CommandType.Text);
        }
        public bool DeleteRoom(ref string err, int roomID)
        {
            string sqlString = " delete from tblRoom where ID=" + roomID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool AddRoom(int ID, string RoomNumber, string RoomType, int RoomRate, int NoOfOccupancy, string Status, ref string err)
        {
            string sqlString = "INSERT INTO tblRoom(ID, RoomNumber, RoomType, RoomRate, NoOfOccupancy, Status) Values(" +
            ID + ",N'" +
            RoomNumber + "',N'" +
            RoomType + "'," +
            RoomRate + "," +
            NoOfOccupancy + ",N'" +
            Status + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool FindRoomNumber(string RoomNumber)
        {
            DataSet ds = db.ExecuteQueryDataSet("Select * from tblRoom where RoomNumber = N'" + RoomNumber + "'", CommandType.Text);
            DataTable data = new DataTable();
            data = ds.Tables[0];
            if (data.Rows.Count != 0)
                return true;
            else
                return false;
        }
        public int AutoGenerateID()
        {
            DataTable data = LoadRoom();
            List<int> ListID = new List<int>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                ListID.Add(int.Parse(data.Rows[i][0].ToString()));
            }
            ListID.Sort();
            int j = 1;
            int ID = -1;
            foreach (int x in ListID)
            {
                if (j != x)
                {
                    ID = j;
                    break;
                }
                else
                    j++;
            }
            if (ID == -1)
                ID = ListID.Count + 1;
            return ID;
        }
    }
}
