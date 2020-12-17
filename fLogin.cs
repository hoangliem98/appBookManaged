using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySach.DAO;
using QuanLySach.DTO;

namespace QuanLySach
{
    public partial class fLogin : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            fAccountManager register = new fAccountManager(LoginAccount);
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (Login(username, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(username);
                if (loginAccount.Type == 1)
                {
                    fHome home = new fHome(loginAccount);
                    this.Hide();
                    home.Show();
                }
                else
                {
                    fRentalForCustomer rent = new fRentalForCustomer(loginAccount);
                    this.Hide();
                    rent.Show();
                }
            }
            else 
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }
    }
}
