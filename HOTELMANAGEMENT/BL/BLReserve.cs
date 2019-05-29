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
        DataTable dtUser = null;
        public BLReserve()
        {
            db = new DBMain();
        }
        public DataSet GetDiscountActive()
        {
            return db.ExecuteQueryDataSet("select * from tblDiscount where Status = 'Active'", CommandType.Text);
        }
        public int GetDiscountRate(string DiscountType)
        {
            return db.ExecuteQueryInt("select tblDiscount.DiscountRate from tblDiscount where DiscountType =N'" + DiscountType+"'", CommandType.Text);
        }
    }
}
