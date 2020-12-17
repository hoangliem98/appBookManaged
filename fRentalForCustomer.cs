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
    public partial class fRentalForCustomer : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        BindingSource bookList = new BindingSource();
        public fRentalForCustomer(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            load();
            dtpTermDate.TextChanged += dtpTermDate_TextChanged;
        }

        void ChangeAccount(int type)
        {
            btnInfo.Text = LoginAccount.UserName;
        }

        void load()
        {
            dgvBook.DataSource = bookList;
            LoadBookList();
            BookBiding();
            LoadDateTimepicker();
            LoadAutoCompleteSearchName();
        }

        void LoadDateTimepicker()
        {
            DateTime today = DateTime.Now;
            dtpRentalDate.MinDate = today;
            dtpRentalDate.MaxDate = today;
            dtpTermDate.Value = new DateTime(today.Year, today.Month, today.Day + 1);
            dtpTermDate.MinDate = dtpTermDate.Value;
        }

        void LoadBookList()
        {
            bookList.DataSource = BookDAO.Instance.GetListBook();
            dgvBook.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBook.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void BookBiding()
        {
            txtBookId.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "ID", true, DataSourceUpdateMode.Never));
            //txtBookId.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "Name", true, DataSourceUpdateMode.Never));
            nmPrice.DataBindings.Add(new Binding("Value", dgvBook.DataSource, "Rentprice", true, DataSourceUpdateMode.Never));
            decimal tmp = nmPrice.Value;
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            bookList.DataSource = BookDAO.Instance.SearchByName(txtBookSearch.Text);
            dgvBook.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBook.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Book book = BookDAO.Instance.GetBookById(int.Parse(txtBookId.Text));
            int BookId = int.Parse(txtBookId.Text);
            int AccountId = LoginAccount.ID;
            int RentAmount = int.Parse(nmRentAmount.Text);
            DateTime RentalDate = DateTime.Parse(dtpRentalDate.Value.ToString("yyyy-MM-dd"));
            DateTime TermDate = DateTime.Parse(dtpTermDate.Value.ToString("yyyy-MM-dd"));
            TimeSpan t = TermDate - RentalDate;
            int result = t.Days;
            nmPrice.Value = nmPrice.Value * result;
            float Price = float.Parse(nmPrice.Value.ToString());
            string Status = "Chưa thanh toán";
            if (RentAmount > book.Amount)
            {
                MessageBox.Show("Sách trong kho không đủ số lượng bạn yêu cầu");
            }
            else if (BookRentalDAO.Instance.InsertBookRental(BookId, AccountId, RentAmount, RentalDate, TermDate, Price, Status))
            {
                MessageBox.Show("Tổng tiền thuê của bạn là: " + Price + ". Mời bạn đến quầy để nhận sách và đặt cọc!!!");
                LoadBookList();
                nmRentAmount.Value = 1;
                nmPrice.Text = book.Rentprice.ToString();
                return;
            }
            else
            {
                MessageBox.Show("Thuê thất bại");
                return;
            }
        }

        void LoadAutoCompleteSearchName()
        {
            List<Book> list = BookDAO.Instance.GetListBook();
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            foreach (var item in list)
            {
                stringCol.Add(Convert.ToString(item.Name));
            }
            txtBookSearch.AutoCompleteCustomSource = stringCol;
        }

        private void txtBookSearch_Enter(object sender, EventArgs e)
        {
            if (txtBookSearch.Text == "Nhập tên sách...")
            {
                txtBookSearch.Text = "";
                txtBookSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtBookSearch_Leave(object sender, EventArgs e)
        {
            if (txtBookSearch.Text == "")
            {
                txtBookSearch.Text = "Nhập tên sách...";
                txtBookSearch.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void txtBookSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchBook.PerformClick();
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void nmRentAmount_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            if (Convert.ToInt32(num.Text) > num.Value)
            {
                decimal tmp = nmPrice.Value / (int.Parse(nmRentAmount.Value.ToString()) + 1);
                nmPrice.Value = tmp * nmRentAmount.Value;
            }
            else
            {
                decimal tmp = nmPrice.Value / (int.Parse(nmRentAmount.Value.ToString()) - 1);
                nmPrice.Value = tmp * nmRentAmount.Value;
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (panelDropDown.Size == panelDropDown.MinimumSize)
            {
                panelDropDown.Size = panelDropDown.MaximumSize;
                panelDropDown.Left = 714;
                panelDropDown.Top = 0;
            }
            else
            {
                panelDropDown.Size = panelDropDown.MinimumSize;
                panelDropDown.Left = 779;
                panelDropDown.Top = 0;
            }
        }

        private void fRentalForCustomer_Load(object sender, EventArgs e)
        {
            panelDropDown.Size = panelDropDown.MinimumSize;
            panelDropDown.Left = 779;
            panelDropDown.Top = 0;
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

        void dtpTermDate_TextChanged(object sender, EventArgs e)
        {
            DateTime termDate = DateTime.Parse(dtpTermDate.Value.ToString("yyyy-MM-dd"));
            DateTime rentalDate = DateTime.Parse(dtpRentalDate.Value.ToString("yyyy-MM-dd"));
            TimeSpan t = termDate - rentalDate;
            int result = t.Days;
            if (result > 10)
            {
                MessageBox.Show("Xin lỗi bạn không thể thuê quá 10 ngày...");
                dtpTermDate.Value = dtpTermDate.MinDate;
            }
        }
    }
}
