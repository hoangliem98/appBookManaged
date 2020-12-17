using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DTO
{
    public class BookReturn
    {
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private int iDBookRental;

        public int IDBookRental
        {
            set { iDBookRental = value; }
        }
        private int iDEmployeeAccount;

        public int IDEmployeeAccount
        {
            set { iDEmployeeAccount = value; }
        }
        private DateTime? returnDate;

        public DateTime? ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        private DateTime? rentDate;

        public DateTime? RentDate
        {
            get { return rentDate; }
            set { rentDate = value; }
        }
        private string customer;

        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        private string employee;

        public string Employee
        {
            get { return employee; }
            set { employee = value; }
        }
        private float outDatePrice;

        public float OutDatePrice
        {
            get { return outDatePrice; }
            set { outDatePrice = value; }
        }
        private float toTalPrice;

        public float ToTalPrice
        {
            get { return toTalPrice; }
            set { toTalPrice = value; }
        }

        public BookReturn(int id, string bookname, string customer, string employee, DateTime? returndate, DateTime? rentdate, float outdateprice, float totalprice)
        {
            this.ID = id;
            this.Employee = employee;
            this.Customer = customer;
            this.BookName = bookname;
            this.RentDate = rentDate;
            this.ReturnDate = returndate;
            this.OutDatePrice = outdateprice;
            this.ToTalPrice = totalprice;
        }

        public BookReturn(DataRow row)
        {
            this.ID = (int)row["Id"];
            this.Employee = row["Employee"].ToString();
            this.Customer = row["Customer"].ToString();
            this.BookName = row["Name"].ToString();
            this.RentDate = (DateTime?)row["RentDate"];
            this.ReturnDate = (DateTime?)row["ReturnDate"];
            this.OutDatePrice = (float)Convert.ToDouble(row["OutDatePrice"].ToString());
            this.ToTalPrice = (float)Convert.ToDouble(row["TotalPrice"].ToString());
        }

    }
}
