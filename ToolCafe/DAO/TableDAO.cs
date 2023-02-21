using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolCafe.DTO;

namespace ToolCafe.DAO
{
    public  class TableDAO
    {
        private TableDAO() { }
        private static TableDAO instance;

        public static TableDAO Instance { 
            get { if(instance == null)  instance= new TableDAO(); return instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 100;
        public static int TableHeight = 100;

        public List<Table> LoadTableList() 
        {
            List<Table> list = new List<Table>();
            DataTable dt = DataProvider.Insance.ExecuteQuery("USP_GetTableList");
            foreach (DataRow dr in dt.Rows)
            {
                Table tb = new Table(dr);
                list.Add(tb);
            }

            return list;
        }
    }
}
