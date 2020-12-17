using QuanLySach.DTO;
using QuanLySach.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class fAccountManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fAccountManager(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            if (loginAccount != null)
            {
                txtUserName.Text = loginAccount.UserName;
                txtUserName.ReadOnly = true;
                if (loginAccount.Type == 1)
                {
                    cbbType.SelectedItem = "Admin";
                }
                else if (loginAccount.Type == 0)
                {
                    cbbType.SelectedItem = "Thường";
                    panelRole.Hide();
                }
            }
            else
            {
                panelRole.Hide();
                btnUpdateAccount.Text = "Đăng ký tài khoản";
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPasswordConfirm.Focus();
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void txtPasswordConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnUpdateAccount.PerformClick();
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        void CreateAccount()
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string confirm_password = txtPasswordConfirm.Text;
            int type = 0;

            if (password == "" && username == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
            }
            else if (username.Contains(" "))
            {
                MessageBox.Show("Vui lòng sử dụng tên đăng nhập không có khoảng trắng");
            }
            else if (!password.Equals(confirm_password))
            {
                MessageBox.Show("Mật khẩu không trùng nhau. Vui lòng kiểm tra lại");
            }
            else if (AccountDAO.Instance.GetAccountByUserName(username) != null)
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }
            else if(AccountDAO.Instance.CreateAccount(username, password, type))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                this.Close();
            }
        }

        void UpdateAccount()
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string confirm_password = txtPasswordConfirm.Text;
            int type = 0;
            if (cbbType.SelectedItem.Equals("Admin"))
            {
                type = 1;
            }
            else if (cbbType.SelectedItem.Equals("Thường"))
            {
                type = 0;
            }

            if (!password.Equals(confirm_password))
            {
                MessageBox.Show("Mật khẩu không trùng nhau. Vui lòng kiểm tra lại");
            }
            else if (AccountDAO.Instance.UpdateAccount(username, password, type))
            {
                MessageBox.Show("Cập nhật thành công!");
                this.Close();
                if (update != null)
                    update(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(username)));
            }
        }
        private event EventHandler<AccountEvent> update;
        public event EventHandler<AccountEvent> Update
        {
            add { update += value; }
            remove { update -= value; }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            if (loginAccount != null)
            {
                UpdateAccount();
            }
            else
            {
                CreateAccount();
            }
        }
    }
    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
