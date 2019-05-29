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
        public string GetDiscountRate(string DiscountType)
        {
            return db.ExecuteQueryString("select * from tblDiscount where DiscountType = '"+DiscountType+"'", CommandType.Text);
        }
    }
}
