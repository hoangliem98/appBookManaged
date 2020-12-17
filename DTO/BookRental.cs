using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DTO
{
    public class BookRental
    {
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        //private int idBook;

        //public int IdBook
        //{
        //    get { return idBook; }
        //    set { idBook = value; }
        //}
        //private int idAccount;

        //public int IdAccount
        //{
        //    get { return idAccount; }
        //    set { idAccount = value; }
        //}

        private int rentAmount;

        public int RentAmount
        {
            get { return rentAmount; }
            set { rentAmount = value; }
        }
        private DateTime? rentDate;

        public DateTime? RentDate
        {
            get { return rentDate; }
            set { rentDate = value; }
        }
        private DateTime? termDate;

        public DateTime? TermDate
        {
            get { return termDate; }
            set { termDate = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public BookRental(int id, int rentamount, DateTime? rentdate, DateTime? termdate, float price, string status, string bookname, string username)
        {
            this.ID = id;
            //this.IdBook = idbook;
            //this.IdAccount = idaccount;
            this.BookName = bookname;
            this.UserName = username;
            this.RentAmount = rentamount;
            this.RentDate = rentdate;
            this.TermDate = termdate;
            this.Price = price;
            this.Status = status;
        }
        public BookRental(DataRow row)
        {
            this.ID = (int)row["Id"];
            //this.IdBook = (int)row["IdBook"];
            //this.IdAccount = (int)row["IdAccount"];
            this.BookName = row["Name"].ToString();
            this.UserName = row["UserName"].ToString();
            this.RentAmount = (int)row["RentAmount"];
            this.RentDate = (DateTime?)row["RentDate"];
            this.TermDate = (DateTime?)row["TermDate"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
            this.Status = row["Status"].ToString();
        }
    }
}
