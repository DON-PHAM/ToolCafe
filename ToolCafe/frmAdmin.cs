using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolCafe.DAO;
using ToolCafe.DTO;

namespace ToolCafe
{
    public partial class frmAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        public frmAdmin()
        {
            InitializeComponent();
            dtgvFood.DataSource = foodList;

            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkStart.Value, dtpkEndTime.Value);
            LoadListFood();
            LoadCategoryIntoCombobox(cbCategory);
            AddFoodBinding();
        }

        #region Method

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkStart.Value = new DateTime(today.Year, today.Month, 1);
            dtpkEndTime.Value = dtpkStart.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();

        }

        void AddFoodBinding()
        {
            txtNameFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name",true,DataSourceUpdateMode.Never));
            txtIdFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmPriceFood.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        #endregion

        #region Events
        private void btnViewFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        #endregion

        private void txtIdFood_TextChanged(object sender, EventArgs e)
        {
            int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryId"].Value;

            Category cat = CategoryDAO.Instance.GetCategoryById(id);

            int index = -1;
            int i = 0;
            foreach (Category item in cbCategory.Items)
            {
                if(item.ID == cat.ID)
                {
                    index = i;
                }
                i++;
            }
            cbCategory.SelectedIndex = index;
            

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txtNameFood.Text;
            int idCategory = (cbCategory.SelectedItem as Category).ID;
            float price = (float)nmPriceFood.Value;
            if(FoodDAO.Instance.InserFood(name,idCategory,price))
            {
                MessageBox.Show("Thêm thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm đồ ăn");
            }
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            string name = txtNameFood.Text;
            int idCategory = (cbCategory.SelectedItem as Category).ID;
            float price = (float)nmPriceFood.Value;
            int id = Convert.ToInt32(txtIdFood.Text);
            if (FoodDAO.Instance.UpdateFood(name,id, idCategory, price))
            {
                MessageBox.Show("Sửa thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa đồ ăn");
            }
        }
    }
}
