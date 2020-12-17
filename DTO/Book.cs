using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DTO
{
    public class Book
    {
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        private int category;

        public int Category
        {
            get { return category; }
            set { category = value; }
        }
        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private float rentprice;

        public float Rentprice
        {
            get { return rentprice; }
            set { rentprice = value; }
        }

        public Book(int id, string name, string author, string publisher, int category, int amount, float rentprice)
        {
            this.ID = id;
            this.Name = name;
            this.Author = author;
            this.Publisher = publisher;
            this.Category = category;
            this.Amount = amount;
            this.Rentprice = rentprice;
        }

        public Book(DataRow row)
        {
            this.ID = (int)row["Id"];
            this.Name = row["Name"].ToString();
            this.Author = row["Author"].ToString();
            this.Publisher = row["Publisher"].ToString();
            this.category = (int)row["IdCategory"];
            this.Amount = (int)row["Amount"];
            this.Rentprice = (float)Convert.ToDouble(row["RentPrice"].ToString());
        }
    }
}
