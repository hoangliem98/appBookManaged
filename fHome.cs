using QuanLySach.DTO;
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
    public partial class fHome : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public fHome(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }

        void ChangeAccount(int type)
        {
            btnInfo.Text =  LoginAccount.UserName;
        }

        private void fHome_Load(object sender, EventArgs e)
        {
            panelDropDown.Size = panelDropDown.MinimumSize;
            panelDropDown.Left = 662;
            panelDropDown.Top = -3;
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (panelDropDown.Size == panelDropDown.MinimumSize)
            {
                panelDropDown.Size = panelDropDown.MaximumSize;
                panelDropDown.Left = 597;
                panelDropDown.Top = -3;
            }
            else
            {
                panelDropDown.Size = panelDropDown.MinimumSize;
                panelDropDown.Left = 662;
                panelDropDown.Top = -3;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            fLogin login = new fLogin();
            this.Close();
            login.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            fAccountManager account = new fAccountManager(LoginAccount);
            account.Update += account_Update;
            account.Show();
            this.fHome_Load(sender, e);
        }

        void account_Update(object sender, AccountEvent e)
        {
            this.Close();
            fLogin login = new fLogin();
            login.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            fBookList book = new fBookList();
            this.Hide();
            book.ShowDialog();
            this.Show();
            this.fHome_Load(sender, e);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            fCustomerList customer = new fCustomerList();
            this.Hide();
            customer.ShowDialog();
            this.Show();
            this.fHome_Load(sender, e);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            fEmployeeList book = new fEmployeeList();
            this.Hide();
            book.ShowDialog();
            this.Show();
            this.fHome_Load(sender, e);
        }

        private void btnBookRental_Click(object sender, EventArgs e)
        {
            fBookRental f = new fBookRental(loginAccount);
            this.Hide();
            f.ShowDialog();
            this.Show();
            this.fHome_Load(sender, e);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            fAccount acc = new fAccount();
            this.Hide();
            acc.ShowDialog();
            this.Show();
            this.fHome_Load(sender, e);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            fBookReturn rebook = new fBookReturn();
            this.Hide();
            rebook.ShowDialog();
            this.Show();
            this.fHome_Load(sender, e);
        }
    }
}
