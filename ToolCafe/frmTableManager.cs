using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolCafe.DAO;
using ToolCafe.DTO;

namespace ToolCafe
{
    public partial class frmTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount { 
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public frmTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
            
        }

        #region METHOD

        void ChangeAccount(int type)
        {
            tadmin.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + " )"; 

        }
        void LoadTable()
        {
            lsvBill.Items.Clear();
            List<Table> tablelist = TableDAO.Instance.LoadTableList();
            foreach (Table table in tablelist)
            {
                Button btn = new Button() { Width= TableDAO.TableWidth,Height= TableDAO.TableHeight };
                btn.Text = table.Name + Environment.NewLine + table.Status;
                btn.Click += btn_Click;
                btn.Tag = table;
                switch(table.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua; 
                        break;
                    default: 
                        btn.BackColor = Color.LightBlue;
                        break;

                }
                flpTable.Controls.Add(btn);

            }
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";

        }

        void ShowBill(int id)
        {

            lsvBill.Items.Clear();
            List<Menu> lstBillInfo = MenuDAO.Instance.GetListMenuByTable(id);

            float totalPrice = 0;


            foreach(Menu item in lstBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
           
        }

        #endregion

        #region EVENT
        private void btn_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableId);
        }
        private void mnProfile_Click(object sender, EventArgs e)
        {
            frmAccountProfile f = new frmAccountProfile(loginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
            
        }

        private void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void tadmin_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lsvBill.Tag as Table;
                if(table != null)
                {
                    int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
                    int foodID = (cbFood.SelectedItem as Food).ID;
                    int count = (int)nmFooCount.Value;
                    if (idBill == 1)
                    {
                        BillDAO.Instance.InsertBill(table.ID);
                        BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), foodID, count);
                    }
                    else
                    {
                        BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), foodID, count);
                    }
                    ShowBill(table.ID);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không có bàn nào");
            }
        }
        #endregion

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
            int discount = (int)nmDisCount.Value;
            double totlaPrice = Convert.ToDouble(txtTotalPrice.Text);
            double finalTotalPrice = totlaPrice - (totlaPrice / 100) * discount;
            if(idBill != -1)
            {
                if(MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\n sau giảm giá {1}% là {2}  ", table.Name,discount,finalTotalPrice),"Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill,discount);
                    ShowBill(table.ID);
                    LoadTable();

                }
            }

        }
    }
}
