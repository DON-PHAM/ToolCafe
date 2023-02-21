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
            if(dt.Rows.Count > 0)
            {
                Bill bill = new Bill(dt.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

    }
}
