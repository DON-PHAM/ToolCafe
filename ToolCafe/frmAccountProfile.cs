using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using ToolCafe.DTO;
using ToolCafe.DAO;

namespace ToolCafe
{
    public partial class frmAccountProfile : Form
    {
        private Account loginAccount;
        public frmAccountProfile(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        void ChangeAccount(Account acc)
        {
            txtUserName.Text = acc.UserName;
            txtDisplayName.Text = acc.DisplayName;
        }
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        void AccountUpdate()
        {
            string displayName = txtDisplayName.Text;
            string passwordold = txtPasswordOld.Text;
            string passwordnew = txtPasswordNew.Text;
            string repasswordnew = txtRepasswordNew.Text;
            string userName = txtUserName.Text;

            if(passwordnew != repasswordnew)
            {
                MessageBox.Show("Vui lòng nhập đúng mật khẩu nhập lại ");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, passwordold, passwordnew))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu hoặc không được để trống");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AccountUpdate();
        }
    }
    public class AccountEvent:EventArgs
    {
        private Account acc;

        public Account Acc { get { return acc; } set { acc = value; } }
        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
