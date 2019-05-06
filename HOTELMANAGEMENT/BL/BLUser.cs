using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOTELMANAGEMENT.DAL;
using System.Data;
using System.Data.SqlClient;

namespace HOTELMANAGEMENT.BL
{
    class BLUser
    {
        DBMain db = null;

        public BLUser()
        {
            db = new DBMain();
        }
        public DataSet GetUser()
        {
            return db.ExecuteQueryDataSet("Select * from tblUser", CommandType.Text);
        }
        public DataSet GetGuestUser()
        {
            return db.ExecuteQueryDataSet("select a.UserFName, a.UserMName, a.UserLName, a.UserAddress, a.UserContactNumber, a.UserGender, a.UserEmail, a.Status, a.Remarks, a.UserName from tblUser a, tblLogin where tblLogin.username = a.UserName and tblLogin.role = 'Guest'", CommandType.Text);
        }
        public DataSet GetGuestUserHasID()
        {
            return db.ExecuteQueryDataSet("select a.ID, a.UserFName, a.UserMName, a.UserLName, a.UserAddress, a.UserContactNumber, a.UserGender, a.UserEmail, a.Status, a.Remarks, a.UserName from tblUser a, tblLogin where tblLogin.username = a.UserName and tblLogin.role = 'Guest'", CommandType.Text);
        }
        public DataSet GetReceptionistUser()
        {
            return db.ExecuteQueryDataSet("select a.UserFName, a.UserMName, a.UserLName, a.UserAddress, a.UserContactNumber, a.UserGender, a.UserEmail, a.Status, a.Remarks, a.UserName from tblUser a, tblLogin where tblLogin.username = a.UserName and tblLogin.role = 'Receptionist'", CommandType.Text);
        }
        public DataSet GetUserByUsername(string username)
        {
            return db.ExecuteQueryDataSet("Select * from tblUser where UserName=N'"+username+"'", CommandType.Text);
        }
        public bool AddUser(int ID, string UserFName, string UserMName, string UserLName, string UserAddress, string UserContactNumber, string UserGender, string UserEmail, string Status, string Remarks, string Username, ref string err)
        {
            string sqlString = "INSERT INTO tblUser(ID, UserFName,UserMName,UserLName,UserAddress,UserContactNumber,UserGender,UserEmail,Status,Remarks, UserName) Values(" +
            ID + ",N'" +
            UserFName + "',N'" +
            UserMName + "',N'" +
            UserLName + "',N'" +
            UserAddress + "',N'" +
            UserContactNumber + "',N'" +
            UserGender + "',N'" +
            UserEmail + "',N'" +
            Status + "',N'" +
            Remarks + "',N'" +
            Username + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool DeleteUser(ref string err, string ID, string username)
        {
            string sqlString = "Delete From tblUser Where ID=" + ID + " delete from tblUser where username=N'"+username+"'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool EditUser(int ID, string UserFName, string UserMName, string UserLName, string UserAddress, string UserContactNumber, string UserGender, string UserEmail, string Status, string Remarks, string Username, ref string err)
        {
            string sqlString =
            "Update tblUser Set " +
            "ID=" + ID + "," +
            "UserFName=N'" + UserFName + "'," +
            "UserMName=N'" + UserMName + "'," +
            "UserLName=N'" + UserLName + "'," +
            "UserAddress=N'" + UserAddress + "'," +
            "UserContactNumber=N'" + UserContactNumber + "'," +
            "UserGender=N'" + UserGender + "'," +
            "UserEmail=N'" + UserEmail + "'," +
            "Status=N'" + Status + "'," +
            "Remarks=N'" + Remarks + "'," +
            "UserName=N'" + Username +
            "' Where ID=" + ID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public int AutoGenerateID(DataTable data)
        {
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
