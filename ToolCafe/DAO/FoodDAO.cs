using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolCafe.DTO;

namespace ToolCafe.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { instance = value; }
        }
        private FoodDAO() { }
        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> lstFood = new List<Food>();

            string query = @"";

            DataTable dt = DataProvider.Insance.ExecuteQuery(query);
            foreach(DataRow item in dt.Rows)
            {
                Food food = new Food(item);
                lstFood.Add(food);
            }
            return lstFood;
        }

    }
}
