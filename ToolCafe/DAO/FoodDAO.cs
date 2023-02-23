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

            string query = @"select * from where idCategory = "+ id;

            DataTable dt = DataProvider.Insance.ExecuteQuery(query);
            foreach(DataRow item in dt.Rows)
            {
                Food food = new Food(item);
                lstFood.Add(food);
            }
            return lstFood;
        }
        public List<Food> GetListFood()
        {
            List<Food> lstFood = new List<Food>();

            string query = @"select * from dbo.Food";

            DataTable dt = DataProvider.Insance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Food food = new Food(item);
                lstFood.Add(food);
            }
            return lstFood;
        }

        public bool InserFood(string name, int id, float price)
        {
            string query = string.Format("Insert into dbo.Food (name, idCategory, price) values (N'{0}' , {1} , {2})", name, id, price);
            int result = DataProvider.Insance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateFood(string name, int id, int idCategory, float price)
        {
            string query = string.Format("Update dbo.Food set Name = N'{0}', idCategory = {1}, price= {2} where id = {3}", name, idCategory, price, id);
            int result = DataProvider.Insance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
