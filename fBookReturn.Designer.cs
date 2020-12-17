namespace QuanLySach
{
    partial class fBookReturn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBookReturn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.nmOutDatePrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeAccount = new System.Windows.Forms.TextBox();
            this.txtReturnID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchUserName = new System.Windows.Forms.Button();
            this.txtUserNameSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutDatePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nmTotalPrice);
            this.panel1.Controls.Add(this.nmOutDatePrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpRentDate);
            this.panel1.Controls.Add(this.dtpReturnDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEmployeeAccount);
            this.panel1.Controls.Add(this.txtReturnID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 453);
            this.panel1.TabIndex = 0;
            // 
            // nmTotalPrice
            // 
            this.nmTotalPrice.Location = new System.Drawing.Point(419, 58);
            this.nmTotalPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmTotalPrice.Name = "nmTotalPrice";
            this.nmTotalPrice.Size = new System.Drawing.Size(120, 26);
            this.nmTotalPrice.TabIndex = 22;
            // 
            // nmOutDatePrice
            // 
            this.nmOutDatePrice.Location = new System.Drawing.Point(419, 22);
            this.nmOutDatePrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmOutDatePrice.Name = "nmOutDatePrice";
            this.nmOutDatePrice.Size = new System.Drawing.Size(120, 26);
            this.nmOutDatePrice.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "TK Nhân viên";
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.CustomFormat = "  dd/MM/yyyy";
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRentDate.Location = new System.Drawing.Point(400, 94);
            this.dtpRentDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(139, 26);
            this.dtpRentDate.TabIndex = 14;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CustomFormat = "  dd/MM/yyyy";
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnDate.Location = new System.Drawing.Point(114, 94);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(171, 26);
            this.dtpReturnDate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày thuê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày trả";
            // 
            // txtEmployeeAccount
            // 
            this.txtEmployeeAccount.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmployeeAccount.Location = new System.Drawing.Point(132, 57);
            this.txtEmployeeAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeAccount.Name = "txtEmployeeAccount";
            this.txtEmployeeAccount.ReadOnly = true;
            this.txtEmployeeAccount.Size = new System.Drawing.Size(153, 26);
            this.txtEmployeeAccount.TabIndex = 21;
            // 
            // txtReturnID
            // 
            this.txtReturnID.BackColor = System.Drawing.SystemColors.Window;
            this.txtReturnID.Location = new System.Drawing.Point(114, 21);
            this.txtReturnID.Margin = new System.Windows.Forms.Padding(2);
            this.txtReturnID.Name = "txtReturnID";
            this.txtReturnID.ReadOnly = true;
            this.txtReturnID.Size = new System.Drawing.Size(171, 26);
            this.txtReturnID.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phạt trễ hạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã trả";
            // 
            // dgvReturn
            // 
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BookName,
            this.Customer,
            this.Employee,
            this.RentDate,
            this.ReturnDate,
            this.OutDate,
            this.TotalPrice});
            this.dgvReturn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReturn.Location = new System.Drawing.Point(0, 146);
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.RowTemplate.Height = 21;
            this.dgvReturn.Size = new System.Drawing.Size(779, 307);
            this.dgvReturn.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Width = 70;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Tên sách";
            this.BookName.Name = "BookName";
            this.BookName.Width = 150;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "TK Khách thuê";
            this.Customer.Name = "Customer";
            this.Customer.Width = 120;
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "Employee";
            this.Employee.HeaderText = "TK Nhân viên";
            this.Employee.Name = "Employee";
            // 
            // RentDate
            // 
            this.RentDate.DataPropertyName = "RentDate";
            this.RentDate.HeaderText = "Ngày thuê";
            this.RentDate.Name = "RentDate";
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "Ngày trả";
            this.ReturnDate.Name = "ReturnDate";
            // 
            // OutDate
            // 
            this.OutDate.DataPropertyName = "OutDatePrice";
            this.OutDate.HeaderText = "Phạt trễ hạn";
            this.OutDate.Name = "OutDate";
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Tổng tiền";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnSearchUserName);
            this.panel2.Controls.Add(this.txtUserNameSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(568, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 146);
            this.panel2.TabIndex = 2;
            // 
            // btnSearchUserName
            // 
            this.btnSearchUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchUserName.Location = new System.Drawing.Point(59, 83);
            this.btnSearchUserName.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchUserName.Name = "btnSearchUserName";
            this.btnSearchUserName.Size = new System.Drawing.Size(79, 31);
            this.btnSearchUserName.TabIndex = 12;
            this.btnSearchUserName.Text = "Tìm kiếm";
            this.btnSearchUserName.UseVisualStyleBackColor = true;
            this.btnSearchUserName.Click += new System.EventHandler(this.btnSearchUserName_Click);
            // 
            // txtUserNameSearch
            // 
            this.txtUserNameSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUserNameSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUserNameSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUserNameSearch.Location = new System.Drawing.Point(16, 45);
            this.txtUserNameSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserNameSearch.Name = "txtUserNameSearch";
            this.txtUserNameSearch.Size = new System.Drawing.Size(180, 26);
            this.txtUserNameSearch.TabIndex = 11;
            this.txtUserNameSearch.Text = "Nhập tên TK nhân viên...";
            this.txtUserNameSearch.Enter += new System.EventHandler(this.txtUserNameSearch_Enter);
            this.txtUserNameSearch.Leave += new System.EventHandler(this.txtUserNameSearch_Leave);
            // 
            // fBookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvReturn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fBookReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin trả sách";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutDatePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchUserName;
        private System.Windows.Forms.TextBox txtUserNameSearch;
        private System.Windows.Forms.NumericUpDown nmTotalPrice;
        private System.Windows.Forms.NumericUpDown nmOutDatePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReturnID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeAccount;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}