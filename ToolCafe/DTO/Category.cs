using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolCafe.DTO
{
    public class Category
    {
        private string name;
        private int iD;
        public Category(int id,string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public Category(DataRow dr)
        {
            this.ID = (int)dr["id"];
            this.Name = dr["name"].ToString();
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
