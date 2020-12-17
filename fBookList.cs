using QuanLySach.DAO;
using QuanLySach.DTO;
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

namespace QuanLySach
{
    public partial class fBookList : Form
    {
        BindingSource bookList = new BindingSource();
        public fBookList()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            LoadCatagory();
            dgvBook.DataSource = bookList;
            LoadBookList();
            BookBiding();
            LoadAutoCompleteSearchName();
        }

        void LoadCatagory()
        {
            cbbCategory.DataSource = CategoryDAO.Instance.GetListCategory();
            cbbCategory.DisplayMember = "Name";
        }

        void LoadBookList()
        {
            bookList.DataSource = BookDAO.Instance.GetListBook();
            dgvBook.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBook.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void BookBiding()
        {
            txtBookID.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtBookName.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtBookAuthor.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "Author", true, DataSourceUpdateMode.Never));
            //cbbCategory.DataBindings.Add(new Binding("SelectedValue", dgvBook.DataSource, "Category", true, DataSourceUpdateMode.Never));
            txtPublisher.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "Publisher", true, DataSourceUpdateMode.Never));
            nmRentPrice.DataBindings.Add(new Binding("Value", dgvBook.DataSource, "Rentprice", true, DataSourceUpdateMode.Never));
            nmBookAmount.DataBindings.Add(new Binding("Value", dgvBook.DataSource, "Amount", true, DataSourceUpdateMode.Never));
        }

        //Binding Combobox
        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            if (dgvBook.SelectedCells.Count > 0)
            {
                int id = (int)dgvBook.SelectedCells[0].OwningRow.Cells["theloai"].Value;

                Category category = CategoryDAO.Instance.GetCategoryById(id);
                cbbCategory.SelectedItem = category;

                int index = -1;
                int i = 0;
                foreach (Category item in cbbCategory.Items)
                {
                    if (item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbbCategory.SelectedIndex = index;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string name = txtBookName.Text;
            string author = txtBookAuthor.Text;
            string publisher = txtPublisher.Text;
            int category = (cbbCategory.SelectedItem as Category).ID;
            int amount = int.Parse(nmBookAmount.Text);
            float rentprice = float.Parse(nmRentPrice.Text);
            if (BookDAO.Instance.InsertBook(name, author, publisher, category, amount, rentprice))
            {
                MessageBox.Show("Thêm sách thành công!!!", "Thành công", MessageBoxButtons.OK);
                LoadBookList();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBookID.Text);
            string name = txtBookName.Text;
            string author = txtBookAuthor.Text;
            string publisher = txtPublisher.Text;
            int category = (cbbCategory.SelectedItem as Category).ID;
            int amount = int.Parse(nmBookAmount.Text);
            float rentprice = float.Parse(nmRentPrice.Text);
            if (BookDAO.Instance.UpdateBook(id, name, author, publisher, category, amount, rentprice))
            {
                MessageBox.Show("Sửa sách thành công!!!", "Thành công", MessageBoxButtons.OK);
                LoadBookList();
            }
            else
                MessageBox.Show("Sửa thất bại");
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Việc này có thể sẽ ảnh hưởng đến các dữ liệu liên quan bạn có chắc muốn xóa?", "Warning", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int id = int.Parse(txtBookID.Text);
                if (BookDAO.Instance.DeleteBook(id))
                {
                    MessageBox.Show("Xóa thành công!!!");
                    LoadBookList();
                }
                else
                    MessageBox.Show("Xóa thất bại");
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

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            bookList.DataSource = BookDAO.Instance.SearchByName(txtBookSearch.Text);
            dgvBook.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBook.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
        }

    }
}
