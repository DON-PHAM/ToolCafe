using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolCafe.DTO;

namespace ToolCafe.DAO
{
    public class BillDAO
    {

        private BillDAO() { }
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { BillDAO.instance = value; }
        }
        /// <summary>
        /// Thành công : bill ID
        /// Thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUnCheckBillIDByTableID(int id)
        {

            DataTable dt = DataProvider.Insance.ExecuteQuery("selec * from dbo.Bill idTable =" + id + " And status = 0");
            if (dt.Rows.Count > 0)
            {
                Bill bill = new Bill(dt.Rows[0]);
                return bill.ID;
            }

            return -1;
        }

        public void CheckOut(int id,int discount)
        {
            string query = "UPDATe dbo.Bill set status = 1, discount = "+discount+" where id =" +id;
            DataProvider.Insance.ExecuteNonQuery(query);
        }

        public void InsertBill(int id)
        {
            DataProvider.Insance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }
        public int GetMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Insance.ExecuteScalar("select max(id) from dbo.Bill");
            }
            catch
            {
                return 1;
            }

        }

        public List<Bill> GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            List<Bill> lstBill = new List<Bill>();
            string query = @"select * from dbo.Bill where DateCheckIn =" + checkIn + " and DateCheckOut =" + checkOut;

            DataTable dt = DataProvider.Insance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                Bill bill = new Bill(dr);

                lstBill.Add(bill);
            }
            return lstBill;
        }

    }
}
