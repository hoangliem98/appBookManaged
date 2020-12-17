using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    public class BookRentalDAO
    {
        private static BookRentalDAO instance;

        public static BookRentalDAO Instance
        {
            get { if (instance == null) instance = new BookRentalDAO(); return instance; }
            private set { instance = value; }
        }

        private BookRentalDAO() { }

        public bool InsertBookRental(int idbook, int idaccount, int rentamount, DateTime? rentdate, DateTime? termdate, float price, string status)
        {
            string sql = string.Format("INSERT INTO dbo.BookRental(IdBook, IdAccount, RentAmount, RentDate, TermDate, Price, Status) VALUES({0}, {1}, {2}, N'{3}', N'{4}', {5}, N'{6}')", idbook, idaccount, rentamount, rentdate, termdate, price, status);
            int result = DataProvider.Instance.ExecuteNonQuery(sql);
            return result > 0;
        }

        public List<BookRental> GetBookRental()
        {
            List<BookRental> list = new List<BookRental>();
            string sql = "SELECT br.*, a.UserName, b.Name FROM dbo.BookRental AS br INNER JOIN dbo.Account AS a ON a.Id = br.IdAccount INNER JOIN dbo.Book AS b ON b.Id = br.IdBook";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow row in data.Rows)
            {
                BookRental book = new BookRental(row);
                list.Add(book);
            }
            return list;
        }

        public List<BookRental> SearchByUserName(string username)
        {
            List<BookRental> list = new List<BookRental>();
            string sql = "SELECT br.*, a.UserName, b.Name FROM dbo.BookRental AS br INNER JOIN dbo.Account AS a ON a.Id = br.IdAccount INNER JOIN dbo.Book AS b ON b.Id = br.IdBook WHERE a.UserName like '%" + username + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow row in data.Rows)
            {
                BookRental book = new BookRental(row);
                list.Add(book);
            }
            return list;
        }

        public BookRental GetRentalById(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT br.*, a.UserName, b.Name FROM dbo.BookRental AS br INNER JOIN dbo.Account AS a ON a.Id = br.IdAccount INNER JOIN dbo.Book AS b ON b.Id = br.IdBook WHERE br.Id = " + id + "");
            foreach (DataRow row in data.Rows)
            {
                return new BookRental(row);
            }
            return null;
        }

        public bool UpdateStatus(int id)
        {
            string sql = "UPDATE dbo.BookRental SET Status = N'Đã trả sách' WHERE Id = " + id + "";
            int result = DataProvider.Instance.ExecuteNonQuery(sql);
            return result > 0;
        }
    }
}
