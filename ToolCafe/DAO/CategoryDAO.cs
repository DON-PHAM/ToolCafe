﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolCafe.DTO;

namespace ToolCafe.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance 
        { 
            get { if (instance == null) instance = new CategoryDAO();return CategoryDAO.instance; }
            private set { instance = value; }
        }
        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> lstCat = new List<Category>();
            string query = "select * from FoodCategory";
            DataTable dt = DataProvider.Insance.ExecuteQuery(query);
            foreach(DataRow item in dt.Rows)
            {
                Category cat = new Category(item);
                lstCat.Add(cat);
            }
            return lstCat;
        }

        public Category GetCategoryById(int id)
        {
            Category cat = null; ;
            string query = @"Select * from dbo.FoodCategory where Id= " + id;

            DataTable dt = DataProvider.Insance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                cat = new Category(dr);

                return cat;
            }
            return cat;
        }
    }
}
