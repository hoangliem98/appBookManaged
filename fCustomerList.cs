using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class fCustomerList : Form
    {
        public fCustomerList()
        {
            InitializeComponent();
            LoadDateTimepicker();
        }
        void LoadDateTimepicker()
        {
            DateTime today = DateTime.Now;
            dtpCustomerBirthDate.Value = new DateTime(today.Year - 5, 1, 1);
        }
    }
}
