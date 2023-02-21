using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolCafe.DTO;

namespace ToolCafe.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance 
        { 
            get { if (instance == null) instance = new BillInfoDAO(); return instance; }
            private set { instance = value; }
        }
        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> lstBillInfo = new List<BillInfo>();

            DataTable dt = DataProvider.Insance.ExecuteQuery("select * from dbo.BillInfo where idBill = "+ id);

            foreach (DataRow dr in dt.Rows)
            {
                BillInfo info = new BillInfo(dr);
                lstBillInfo.Add(info);
            }
            return lstBillInfo;
        }
    }
}
