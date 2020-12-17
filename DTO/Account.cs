using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DTO
{
    public class Account
    {
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string passWord;

        public string PassWord
        {
            set { passWord = value; }
        }

        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public Account(int id, string username, int type, string password = null)
        {
            this.ID = id;
            this.UserName = username;
            this.PassWord = password;
            this.Type = type;
        }

        public Account(DataRow row)
        {
            this.ID = (int)row["Id"];
            this.UserName = row["UserName"].ToString();
            this.PassWord = row["Password"].ToString();
            this.Type = (int)row["type"];
        }
    }
}
