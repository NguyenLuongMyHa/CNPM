using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTELMANAGEMENT.BL
{
    class Room
    {
        public int ID;
        public string RoomNumber;
        public string RoomType;
        public int RoomRate;
        public int NoOfOccupancy;
        public string Status;


        public void SetRoom(int iD, string RoomNumber, string RoomType, int RoomRate, int NoOfOccupancy, string Status)
        {
            this.ID = iD;
            this.RoomNumber= RoomNumber;
            this.RoomType= RoomType;
            this.RoomRate= RoomRate;
            this.NoOfOccupancy= NoOfOccupancy;
            this.Status= Status;
        }

    }
}
