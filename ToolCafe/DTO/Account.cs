using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolCafe.DTO
{
    public class Account
    {
        private string userName;
        private string password;
        private int type;
        private string displayName;
        public Account(string userName, string displayName,int type, string password= null)
        {
            this.UserName = userName;
            this.Password = password;
            this.DisplayName = displayName;
            this.Type = type;

        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.Password = row["password"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Type = (int)row["type"];
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
    }
}
