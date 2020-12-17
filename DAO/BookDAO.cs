using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    public class BookDAO
    {
        private static BookDAO instance;

        public static BookDAO Instance
        {
            get { if(instance == null) instance = new BookDAO(); return instance; }
            private set { instance = value; }
        }

        private BookDAO() { }

        public List<Book> GetListBook()
        {
            List<Book> list = new List<Book>();
            string query = "SELECT * FROM dbo.Book";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }

        public List<Book> GetCategoryById(string id)
        {
            List<Book> list = new List<Book>();
            string query = "SELECT IdCategory FROM dbo.Book WHERE Id = " + id + "";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }

        public bool InsertBook(string name, string author, string publisher, int category, int amount, float rentprice)
        {
            string query = string.Format("INSERT INTO dbo.Book(Name, Author, Publisher, IdCategory, Amount, RentPrice) VALUES(N'{0}', N'{1}', N'{2}', {3}, {4}, {5})", name, author, publisher, category, amount, rentprice);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateBook(int id, string name, string author, string publisher, int category, int amount, float rentprice)
        {
            string query = string.Format("UPDATE dbo.Book SET Name = N'{0}', Author = N'{1}', Publisher = N'{2}', IdCategory = {3}, Amount = {4}, RentPrice = {5} WHERE Id = {6}", name, author, publisher, category, amount, rentprice, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteBook(int id)
        {
            string query = "USP_DeleteBook @book_id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }

        public Book GetBookById(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Book WHERE Id = " + id + "");
            foreach (DataRow item in data.Rows)
            {
                return new Book(item);
            }
            return null;
        }

        public List<Book> SearchByName(string name)
        {
            List<Book> list = new List<Book>();
            string sql = string.Format("SELECT * FROM dbo.Book WHERE dbo.fuConvertToUnsign1(Name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }
    }
}
