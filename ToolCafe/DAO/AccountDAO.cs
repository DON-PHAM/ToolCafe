using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolCafe.DAO
{
   public  class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance { 
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { instance = value; }
        }

        private AccountDAO()
        {
        }

        public bool Login(string userName, string passWord)
        {
            string query = @"SELECT * from Account where UserName = N'"+userName+"' AND Password = N'"+passWord+"'";
            DataTable result = DataProvider.Insance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
