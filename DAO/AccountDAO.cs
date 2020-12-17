using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            //string sql = "SELECT * FROM dbo.Account WHERE username = '" + username + "' AND password = '" + password + "'";
            //DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            string sql = "USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(sql, new object[] { username, password });
            return result.Rows.Count > 0;
        }

        public bool CreateAccount(string username, string password, int type)
        {
            string sql = string.Format("INSERT INTO dbo.Account(UserName, Password, type) VALUES(N'{0}', N'{1}', {2})", username, password, type);
            int result = DataProvider.Instance.ExecuteNonQuery(sql);
            return result > 0;
        }

        public bool UpdateAccount(string username, string password, int type)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateAccount @userName , @password , @type", new object[] { username, password, type });
            return result > 0;
        }

        public Account GetAccountByUserName(string UserName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE UserName = '" + UserName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public List<Account> GetAccount()
        {
            List<Account> list = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account");
            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                list.Add(acc);
            }
            return list;
        }

        public List<Account> SearchAccountByUserName(string UserName)
        {
            List<Account> list = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE UserName like '%" + UserName + "%'");
            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                list.Add(acc);
            }
            return list;
        }
    }
}
