using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolCafe.DTO
{
    public class BillInfo
    {
        private int iD;
        private int billId;
        private int foodId;
        private int count;
        public BillInfo(int id,int billId, int foodId,int count)
        {
            this.ID= id;
            this.BillId= billId;
            this.FoodId= foodId;
            this.Count= count;
        }

        public BillInfo(DataRow dr)
        {
            this.ID = (int)dr["Id"];
            this.BillId = (int)dr["idbill"];
            this.FoodId = (int)dr["idfood"];
            this.Count = (int)dr["Count"];
        }
        public int ID {
            get { return iD; }
            set { iD = value; }
        }

        public int BillId { get => billId; set => billId = value; }
        public int FoodId { get => foodId; set => foodId = value; }
        public int Count { get => count; set => count = value; }
    }
}
