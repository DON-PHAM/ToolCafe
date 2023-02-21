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
        public frmTableManager()
        {
            InitializeComponent();
        }

        #region METHOD
        void LoadTable()
        {
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

        void ShowBill(int id)
        {
            List<BillInfo> lstBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetUnCheckBillIDByTableID(id));
            foreach(BillInfo item in lstBillInfo)
            {

            }
        }

        #endregion

        #region EVENT
        private void btn_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as Table).ID;
            ShowBill(tableId);
        }
        private void mnProfile_Click(object sender, EventArgs e)
        {
            frmAccountProfile f = new frmAccountProfile();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tadmin_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
