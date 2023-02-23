using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolCafe.DTO
{
    public class Bill
    {
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;
        private int iD;

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status,int discount = 0)
        {
            this.iD= id;
            this.DateCheckIn= dateCheckIn;
            this.DateCheckOut= dateCheckOut;
            this.Status = status;
            this.Discount= discount;
        }

        public Bill(DataRow dr)
        {
            this.ID = (int)dr["ID"];
            this.DateCheckIn = (DateTime?)dr["DateCheckIn"];
            var dateCheckOutTemp = dr["DateCheckOut"];
            if(dateCheckOutTemp.ToString() != "")
            {
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            }    
            
            this.Status = (int)dr["status"];
            this.Discount = (int)dr["discount"];
        }

        private int discount;

        public DateTime? DateCheckIn { 
            get { return dateCheckIn; } 
            set { dateCheckIn = value; }
        }

        public DateTime? DateCheckOut {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        public int Status {
            get { return status; }
            set { status = value; }
        }

        public int ID {
            get { return iD; }
            set { iD = value; }
        }

        public int Discount { get => discount; set => discount = value; }
    }
}
