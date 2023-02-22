using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolCafe.DTO;

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
            string query = @"USP_LOGIN @userName , @password";
            DataTable result = DataProvider.Insance.ExecuteQuery(query,new object[] {userName, passWord});
            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string userName)
        {
            string query = @"select * from Account where userName ='" + userName+"'";
            DataTable dt = DataProvider.Insance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                return new Account(dr);
            }
            return null;
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Insance.ExecuteNonQuery("USP_UpdateAccount @userName , @displayName , @password , @newPassword ", new object[] { userName, displayName, pass, newPass });
            return result > 0;
        }
    }
}
