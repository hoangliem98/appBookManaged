using QuanLySach.DAO;
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
    public partial class fAccount : Form
    {
        BindingSource list = new BindingSource();
        public fAccount()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            dgvAccount.DataSource = list;
            loadAccount();
            Binding();
            LoadAutoCompleteSearchName();
        }

        void loadAccount()
        {
            list.DataSource = AccountDAO.Instance.GetAccount();
            dgvAccount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAccount.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void Binding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            Account acc = AccountDAO.Instance.GetAccountByUserName(txtUserName.Text);
            if (acc != null)
            {
                if (acc.Type == 1)
                    cbbType.SelectedItem = "Admin";
                else
                    cbbType.SelectedItem = "Thường";
            }
        }

        void LoadAutoCompleteSearchName()
        {
            List<Account> list = AccountDAO.Instance.GetAccount();
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            foreach (var item in list)
            {
                stringCol.Add(Convert.ToString(item.UserName));
            }
            txtUserNameSearch.AutoCompleteCustomSource = stringCol;
        }

        private void txtUserNameSearch_Enter(object sender, EventArgs e)
        {
            if (txtUserNameSearch.Text == "Nhập tên tài khoản...")
            {
                txtUserNameSearch.Text = "";
                txtUserNameSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtUserNameSearch_Leave(object sender, EventArgs e)
        {
            if (txtUserNameSearch.Text == "")
            {
                txtUserNameSearch.Text = "Nhập tên tài khoản...";
                txtUserNameSearch.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void btnSearchUserName_Click(object sender, EventArgs e)
        {
            list.DataSource = AccountDAO.Instance.SearchAccountByUserName(txtUserNameSearch.Text);
            dgvAccount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAccount.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            int type = 0;
            if (cbbType.SelectedItem.Equals("Admin"))
            {
                type = 1;
            }
            else if (cbbType.SelectedItem.Equals("Thường"))
            {
                type = 0;
            }
            if (AccountDAO.Instance.UpdateAccount(username, password, type))
            {
                MessageBox.Show("Cập nhật thành công!");
                txtPassword.Text = "";
                loadAccount();
            }
        }
    }
}
