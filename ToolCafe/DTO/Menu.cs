using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolCafe.DTO
{
    public class Menu
    {
        private int count;
        private float price;
        private float totalPrice;
        private string foodName;
        public Menu(string foodName,int count,float price, float totalPrice = 0)
        {
            this.FoodName = foodName;
            this.Price = price;
            this.Count = count;
            this.TotalPrice = totalPrice;
        }
        public Menu(DataRow drw)
        {
            this.FoodName = drw["Name"].ToString();
            this.Count = (int)drw["count"];
            this.Price = (float)Convert.ToDouble(drw["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(drw["totalPrice"].ToString());
        }

        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string FoodName { get => foodName; set => foodName = value; }
    }
}
