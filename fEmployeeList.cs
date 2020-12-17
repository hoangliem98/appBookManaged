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
    public partial class fEmployeeList : Form
    {
        public fEmployeeList()
        {
            InitializeComponent();
            LoadDateTimepicker(); 
        }
        void LoadDateTimepicker()
        {
            DateTime today = DateTime.Now;
            dtpEmployeeBirthDate.Value = new DateTime(today.Year - 18, 1, 1);
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeSearch_Enter(object sender, EventArgs e)
        {

        }
    }
}
