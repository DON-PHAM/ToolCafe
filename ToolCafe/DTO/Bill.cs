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

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        {
            this.iD= id;
            this.DateCheckIn= dateCheckIn;
            this.DateCheckOut= dateCheckOut;
            this.Status = status;
        }

        public Bill(DataRow dr)
        {
            this.ID = (int)dr["ID"];
            this.DateCheckIn = (DateTime?)dr["dateCheckin"];
            var dateCheckOutTemp = dr["dateCheckout"];
            if(dateCheckOutTemp.ToString() != "")
            {
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            }    
            
            this.Status = (int)dr["status"];
        }

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

        public int ID { get => iD; set => iD = value; }
    }
}
