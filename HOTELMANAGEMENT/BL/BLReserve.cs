using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOTELMANAGEMENT.DAL;
using System.Data;

namespace HOTELMANAGEMENT.BL
{
    class BLReserve
    {
        DBMain db = null;
        DataTable dtReserve = null;
        public BLReserve()
        {
            db = new DBMain();
        }
        public bool MakeReservation(int ID, int GuestID,int RoomID, DateTime CheckInDate, DateTime CheckOutDate, int NoOfChild, int NoOfAdult, int DiscountID, string Remarks, ref string err)
        {
            string sqlString = "INSERT INTO tblReservation(ID, GuestID, RoomID, CheckInDate, CheckOutDate, NoOfChild, NoOfAdult, DiscountID, Remarks) Values(" +
            ID + "," +
            GuestID + "," +
            RoomID + ",'" +
            CheckInDate + "','" +
            CheckOutDate + "'," +
            NoOfChild + "," +
            NoOfAdult + "," +
            DiscountID + ",'" +
            Remarks + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet GetDiscountActive()
        {
            return db.ExecuteQueryDataSet("select * from tblDiscount where Status = 'Active'", CommandType.Text);
        }
        public int GetDiscountRate(string DiscountType)
        {
            return db.ExecuteQueryInt("select tblDiscount.DiscountRate from tblDiscount where DiscountType =N'" + DiscountType+"'", CommandType.Text);
        }
        public int GetDiscountID(string DiscountType)
        {
            return db.ExecuteQueryInt("select tblDiscount.ID from tblDiscount where DiscountType =N'" + DiscountType + "'", CommandType.Text);
        }
        public int GetNoOfOccurancy(string RoomNumber)
        {
            return db.ExecuteQueryInt("select tblRoom.NoOfOccupancy from tblRoom where tblRoom.RoomNumber = '" + RoomNumber + "'", CommandType.Text);
        }
        public int GetPrice(string RoomNumber)
        {
            return db.ExecuteQueryInt("select a.Price from tblPrice a, tblRoom b where b.ID = a.RoomID and b.RoomNumber = '" + RoomNumber + "'", CommandType.Text);
        }

        public List<Reservation> Load()
        {
            List<Reservation> ReservationList = new List<Reservation>();

            try
            {
                dtReserve = new DataTable();
                dtReserve.Clear();
                DataSet ds = this.GetReservation();
                dtReserve = ds.Tables[0];
                foreach(DataRow row in dtReserve.Rows)
                {
                    Reservation thisReservation = new Reservation();
                    thisReservation.ID1 = Convert.ToInt16(row["ID"]);
                    thisReservation.GuestID1 = Convert.ToInt16(row["GuestID"]);
                    thisReservation.RoomID1 = Convert.ToInt16(row["RoomID"]);
                    thisReservation.CheckInDate1 = Convert.ToDateTime(row["CheckInDate"]);
                    thisReservation.CheckOutDate1 = Convert.ToDateTime(row["CheckOutDate"]);
                    ReservationList.Add(thisReservation);
                }
                return ReservationList;
            }
            catch
            {
                return null;
            }
        }

        public DataTable LoadReservation()
        {
            try
            {
                dtReserve = new DataTable();
                dtReserve.Clear();
                DataSet ds = this.GetReservation();
                dtReserve = ds.Tables[0];
                return dtReserve;
            }
            catch
            {
                return null;
            }
        }
        public DataSet GetReservation()
        {
            return db.ExecuteQueryDataSet("Select * from tblReservation", CommandType.Text);
        }
        public int AutoGenerateID()
        {
            DataTable data = LoadReservation();
            List<int> ListID = new List<int>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                ListID.Add(int.Parse(data.Rows[i]["ID"].ToString()));
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
