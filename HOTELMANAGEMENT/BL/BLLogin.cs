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
        DataTable dtLogin = null;
        DataTable dtUser = null;
        BLUser dbUser = new BLUser();


        bool isLogin = false;


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

        public bool CheckLogin(string username, string password, string role)
        {
            try
            {
                dtLogin = new DataTable();
                dtLogin.Clear();
                DataSet dslogin = this.GetUserLogin(username, password, role);
                dtLogin = dslogin.Tables[0];
            }
            catch
            {
                isLogin = false;
                return isLogin;
            }
            if (dtLogin.Rows.Count != 0)
            {
                dtUser = new DataTable();
                dtUser.Clear();
                DataSet ds = dbUser.GetUserByUsername(username);
                dtUser = ds.Tables[0];
                User UserLogin = new User();

                foreach (DataRow dr in dtUser.Rows)
                {
                    UserLogin.SetUser
                    (
                        int.Parse(dr[0].ToString()),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        dr[3].ToString(),
                        dr[4].ToString(),
                        dr[5].ToString(),
                        dr[6].ToString(),
                        dr[7].ToString(),
                        dr[8].ToString(),
                        dr[9].ToString(),
                        dr[10].ToString()
                    );
                    public_class.user = UserLogin;
                    isLogin = true;
                }
            }
            else
                isLogin = false;

            return isLogin;
        }
    }
}
