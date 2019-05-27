using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTELMANAGEMENT.BL
{
    public class User
    {
        public int ID;
        public string UserFName;
        public string UserMName;
        public string UserLName;
        public string UserAddress;
        public string UserContactNumber;
        public string UserGender;
        public string UserEmail;
        public string Status;
        public string Remarks;
        public string UserName;

        public void SetUser(int iD, string UserFName, string UserMName, string UserLName, string UserAddress, string UserContactNumber, string UserGender, string UserEmail, string status, string remarks, string username)
        {
            this.ID = iD;
            this.UserFName = UserFName;
            this.UserMName = UserMName;
            this.UserLName = UserLName;
            this.UserAddress = UserAddress;
            this.UserContactNumber = UserContactNumber;
            this.UserGender = UserGender;
            this.UserEmail = UserEmail;
            this.Status = status;
            this.Remarks = remarks;
            this.UserName = username;
        }

    }
}
