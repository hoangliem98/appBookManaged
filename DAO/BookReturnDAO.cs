using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    public class BookReturnDAO
    {
        private static BookReturnDAO instance;

        public static BookReturnDAO Instance
        {
            get { if (instance == null) instance = new BookReturnDAO(); return instance; }
            private set { instance = value; }
        }

        private BookReturnDAO() { }

        public bool InsertBookReturn(int idrentalbook, int idemployeeaccount, DateTime? returndate, float outdateprice, float totalprice)
        {
            string sql = string.Format("INSERT INTO dbo.BookReturn(IdBookRental, IdEmployeeAccount, ReturnDate, OutDatePrice, TotalPrice) VALUES({0}, {1}, N'{2}', {3}, {4})", idrentalbook, idemployeeaccount, returndate, outdateprice, totalprice);
            int result = DataProvider.Instance.ExecuteNonQuery(sql);
            return result > 0;
        }

        public List<BookReturn> GetListBook() 
        {
            List<BookReturn> list = new List<BookReturn>();
            string sql = "SELECT rent.*, re.*, a.UserName AS 'Customer', a2.UserName AS 'Employee', b.Name FROM dbo.BookReturn AS re INNER JOIN dbo.BookRental AS rent ON re.IdBookRental = rent.Id INNER JOIN dbo.Account AS a ON a.Id = rent.IdAccount INNER JOIN dbo.Account AS a2 ON a2.Id = re.IdEmployeeAccount INNER JOIN dbo.Book AS b ON b.Id = rent.IdBook";

            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in data.Rows)
            {
                BookReturn book = new BookReturn(item);
                list.Add(book);
            }
            return list;
        }

        public List<BookReturn> SearchByUserName(string username)
        {
            List<BookReturn> list = new List<BookReturn>();
            string sql = "SELECT rent.*, re.*, a.UserName AS 'Customer', a2.UserName AS 'Employee', b.Name FROM dbo.BookReturn AS re INNER JOIN dbo.BookRental AS rent ON re.IdBookRental = rent.Id INNER JOIN dbo.Account AS a ON a.Id = rent.IdAccount INNER JOIN dbo.Account AS a2 ON a2.Id = re.IdEmployeeAccount INNER JOIN dbo.Book AS b ON b.Id = rent.IdBook WHERE UserName like N'%" + username + "%'";

            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in data.Rows)
            {
                BookReturn book = new BookReturn(item);
                list.Add(book);
            }
            return list;
        }
    }
}
