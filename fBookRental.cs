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
    public partial class fBookRental : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        BindingSource list = new BindingSource();   
        public fBookRental(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            load();
            LoadAutoCompleteSearchName();
        }

        void load()
        {
            dgvBookRental.DataSource = list;
            LoadRental();
            RentalBinding();
            loadDTPReturnDate();
        }

        void loadDTPReturnDate()
        {
            DateTime now = DateTime.Now;
            dtpReturnDate.MinDate = dtpReturnDate.MaxDate = now;
            dtpTermDate.Enabled = false;
        }

        void RentalBinding()
        {
            txtRentalID.DataBindings.Add(new Binding("Text", dgvBookRental.DataSource, "ID", true, DataSourceUpdateMode.Never));
            dtpTermDate.DataBindings.Add(new Binding("Value", dgvBookRental.DataSource, "TermDate", true, DataSourceUpdateMode.Never));
            nmTotalPrice.DataBindings.Add(new Binding("Value", dgvBookRental.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void LoadRental()
        {
            list.DataSource = BookRentalDAO.Instance.GetBookRental();
            dgvBookRental.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBookRental.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            list.DataSource = BookRentalDAO.Instance.SearchByUserName(txtUserNameSearch.Text);
            dgvBookRental.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBookRental.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void txtUserNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchUserName.PerformClick();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            int idRentalBook = int.Parse(txtRentalID.Text);
            int idEmployeeAccount = loginAccount.ID;
            DateTime returnDate = DateTime.Parse(dtpReturnDate.Value.ToString("yyyy-MM-dd"));
            float oudatePrice = float.Parse(nmOutDatePrice.Text);
            float totalPrice = float.Parse(nmTotalPrice.Text);
            if (BookReturnDAO.Instance.InsertBookReturn(idRentalBook, idEmployeeAccount, returnDate, oudatePrice, totalPrice) && BookRentalDAO.Instance.UpdateStatus(idRentalBook))
            {
                MessageBox.Show("Hoàn thành trả sách");
                LoadRental();
                panel2.Visible = false;
                lbPayed.Visible = true;
            }
            else
            {
                MessageBox.Show("Lỗi. Không thể thực thi việc trả sách");
            }
        }

        private void txtRentalID_TextChanged(object sender, EventArgs e)
        {
            if (txtRentalID.Text == "")
            {
                return;
            }
            int id = int.Parse(txtRentalID.Text);
            BookRental rent = BookRentalDAO.Instance.GetRentalById(id);
            if (rent.Status == "Đã trả sách")
            {
                panel2.Visible = false;
                lbPayed.Visible = true;
            }
            else
            {
                panel2.Visible = true;
                lbPayed.Visible = false;
            }
            DateTime ReturnDate = DateTime.Parse(dtpReturnDate.Value.ToString("yyyy-MM-dd"));
            DateTime TermDate = DateTime.Parse(dtpTermDate.Value.ToString("yyyy-MM-dd"));
            TimeSpan t = ReturnDate - TermDate;
            double result = t.TotalDays;
            if(result > 0)
            {
                double percent = result / 100;
                nmOutDatePrice.Value = decimal.Parse(rent.Price.ToString()) * decimal.Parse(percent.ToString());
            }
            else
            {
                nmOutDatePrice.Value = 0;
            }
            nmTotalPrice.Value = nmTotalPrice.Value + nmOutDatePrice.Value; 
        }
    }
}
