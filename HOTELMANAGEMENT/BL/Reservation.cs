using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTELMANAGEMENT.BL
{
    class Reservation
    {
        private int ID;
        private int GuestID;
        private int RoomID;
        private DateTime CheckInDate;
        private DateTime CheckOutDate;
        private int NoOfChild;
        private int NoOfAdults;
        private int DiscountID;
        private string Remark;

        public Reservation()
        {

        }
        public Reservation(int iD, int guestID, int roomID, DateTime checkInDate, DateTime checkOutDate, int noOfChild, int noOfAdults, int discountID, string remark)
        {
            ID1 = iD;
            GuestID1 = guestID;
            RoomID1 = roomID;
            CheckInDate1 = checkInDate;
            CheckOutDate1 = checkOutDate;
            NoOfChild1 = noOfChild;
            NoOfAdults1 = noOfAdults;
            DiscountID1 = discountID;
            Remark1 = remark;
        }

        public int ID1 { get => ID; set => ID = value; }
        public int GuestID1 { get => GuestID; set => GuestID = value; }
        public int RoomID1 { get => RoomID; set => RoomID = value; }
        public DateTime CheckInDate1 { get => CheckInDate; set => CheckInDate = value; }
        public DateTime CheckOutDate1 { get => CheckOutDate; set => CheckOutDate = value; }
        public int NoOfChild1 { get => NoOfChild; set => NoOfChild = value; }
        public int NoOfAdults1 { get => NoOfAdults; set => NoOfAdults = value; }
        public int DiscountID1 { get => DiscountID; set => DiscountID = value; }
        public string Remark1 { get => Remark; set => Remark = value; }
    }
}
