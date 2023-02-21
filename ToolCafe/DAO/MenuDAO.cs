using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolCafe.DTO;

namespace ToolCafe.DAO
{
    public class MenuDAO
    {

        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { instance = value; }
        }
        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> lstMenu = new List<Menu>();
            string query = @"select f.name,bi.count,f.price, f.price*bi.count as totalPrice from dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.idTable = " + id;
            DataTable dt = DataProvider.Insance.ExecuteQuery(query);
            foreach(DataRow item in dt.Rows)
            {
                Menu menu = new Menu(item);
                lstMenu.Add(menu);
            }
            return lstMenu;
        }
    }
}
