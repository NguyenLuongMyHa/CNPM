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
    class BLLogin
    {
        DBMain db = null;

        public BLLogin()
        {
            db = new DBMain();
        }
        public DataSet GetUserLogin(string username, string password, string role)
        {
            return db.ExecuteQueryDataSet("Select * from tblLogin where username = N'" + username + "'and password = N'" + password +"' and role = N'" + role +"'", CommandType.Text);
        }

        public bool FindUserName(string username)
        {
            DataSet ds = db.ExecuteQueryDataSet("Select * from tblLogin where username = N'" + username + "'", CommandType.Text);
            DataTable data = new DataTable();
            data = ds.Tables[0];
            if (data.Rows.Count != 0)
                return true;
            else
                return false;
        }

        public bool AddUser(string username, string password, string role, ref string err)
        {
            string sqlString = "INSERT INTO tblLogin(username, password, role) Values(N'" +
            username + "',N'" +
            password + "',N'" +
            role + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool DeleteUser(ref string err, string username)
        {
            string sqlString = "Delete From tblLogin Where username='" + username + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool EditUser(string username, string password, string role, ref string err)
        {
            string sqlString =
            "Update tblLogin Set " +
            "username=N'" + username + "'," +
            "password=N'" + password + "'," +
            "role=N'" + role +
            "' Where username=N'" + username + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
