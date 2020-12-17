using CrystalDecisions.CrystalReports.Engine;
using QuanLySach.DAO;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            CrystalReport rpt = new CrystalReport();
            SqlConnection conn = new SqlConnection("Data Source=.\\SORIMACHI2012;Initial Catalog=LibraryManager;Integrated Security=True");
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT rent.*, re.*, a.UserName AS 'Customer', a2.UserName AS 'Employee', b.Name FROM dbo.BookReturn AS re INNER JOIN dbo.BookRental AS rent ON re.IdBookRental = rent.Id INNER JOIN dbo.Account AS a ON a.Id = rent.IdAccount INNER JOIN dbo.Account AS a2 ON a2.Id = re.IdEmployeeAccount INNER JOIN dbo.Book AS b ON b.Id = rent.IdBook", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
