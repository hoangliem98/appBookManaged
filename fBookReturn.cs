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
    public partial class fBookReturn : Form
    {
        BindingSource list = new BindingSource();   
        public fBookReturn()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            dgvReturn.DataSource = list;
            LoadRental();
            ReturnBinding();
        }

        void ReturnBinding()
        {
            txtReturnID.DataBindings.Add(new Binding("Text", dgvReturn.DataSource, "ID", true, DataSourceUpdateMode.Never));
            dtpRentDate.DataBindings.Add(new Binding("Value", dgvReturn.DataSource, "RentDate", true, DataSourceUpdateMode.Never));
            dtpReturnDate.DataBindings.Add(new Binding("Value", dgvReturn.DataSource, "ReturnDate", true, DataSourceUpdateMode.Never));
            nmTotalPrice.DataBindings.Add(new Binding("Value", dgvReturn.DataSource, "TotalPrice", true, DataSourceUpdateMode.Never));
            nmOutDatePrice.DataBindings.Add(new Binding("Value", dgvReturn.DataSource, "OutDatePrice", true, DataSourceUpdateMode.Never));
            txtEmployeeAccount.DataBindings.Add(new Binding("Text", dgvReturn.DataSource, "Employee", true, DataSourceUpdateMode.Never));
        }

        void LoadRental()
        {
            list.DataSource = BookReturnDAO.Instance.GetListBook();
            dgvReturn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvReturn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void btnSearchUserName_Click(object sender, EventArgs e)
        {
            list.DataSource = BookReturnDAO.Instance.SearchByUserName(txtUserNameSearch.Text);
            dgvReturn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvReturn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
    }
}
