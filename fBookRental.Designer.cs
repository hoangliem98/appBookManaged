namespace QuanLySach
{
    partial class fBookRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBookRental));
            this.dgvBookRental = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rent_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rent_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.nmOutDatePrice = new System.Windows.Forms.NumericUpDown();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.dtpTermDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchUserName = new System.Windows.Forms.Button();
            this.txtUserNameSearch = new System.Windows.Forms.TextBox();
            this.lbPayed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookRental)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutDatePrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookRental
            // 
            this.dgvBookRental.AllowUserToAddRows = false;
            this.dgvBookRental.AllowUserToDeleteRows = false;
            this.dgvBookRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookRental.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.bookId,
            this.accountId,
            this.rent_amount,
            this.rent_date,
            this.term_date,
            this.price,
            this.status});
            this.dgvBookRental.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBookRental.Location = new System.Drawing.Point(0, 179);
            this.dgvBookRental.Name = "dgvBookRental";
            this.dgvBookRental.RowTemplate.Height = 21;
            this.dgvBookRental.Size = new System.Drawing.Size(782, 345);
            this.dgvBookRental.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Width = 60;
            // 
            // bookId
            // 
            this.bookId.DataPropertyName = "BookName";
            this.bookId.HeaderText = "Tên sách";
            this.bookId.Name = "bookId";
            // 
            // accountId
            // 
            this.accountId.DataPropertyName = "UserName";
            this.accountId.HeaderText = "Tài khoản thuê";
            this.accountId.Name = "accountId";
            this.accountId.Width = 130;
            // 
            // rent_amount
            // 
            this.rent_amount.DataPropertyName = "RentAmount";
            this.rent_amount.HeaderText = "Số lượng thuê";
            this.rent_amount.Name = "rent_amount";
            // 
            // rent_date
            // 
            this.rent_date.DataPropertyName = "RentDate";
            this.rent_date.HeaderText = "Ngày thuê";
            this.rent_date.Name = "rent_date";
            // 
            // term_date
            // 
            this.term_date.DataPropertyName = "TermDate";
            this.term_date.HeaderText = "Ngày hẹn trả";
            this.term_date.Name = "term_date";
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Giá tiền";
            this.price.Name = "price";
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Trạng thái";
            this.status.Name = "status";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.nmTotalPrice);
            this.panel2.Controls.Add(this.nmOutDatePrice);
            this.panel2.Controls.Add(this.btnReturnBook);
            this.panel2.Controls.Add(this.dtpTermDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpReturnDate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtRentalID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 179);
            this.panel2.TabIndex = 32;
            // 
            // nmTotalPrice
            // 
            this.nmTotalPrice.Location = new System.Drawing.Point(427, 55);
            this.nmTotalPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmTotalPrice.Name = "nmTotalPrice";
            this.nmTotalPrice.Size = new System.Drawing.Size(120, 26);
            this.nmTotalPrice.TabIndex = 12;
            // 
            // nmOutDatePrice
            // 
            this.nmOutDatePrice.Location = new System.Drawing.Point(427, 19);
            this.nmOutDatePrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmOutDatePrice.Name = "nmOutDatePrice";
            this.nmOutDatePrice.Size = new System.Drawing.Size(120, 26);
            this.nmOutDatePrice.TabIndex = 12;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBook.Location = new System.Drawing.Point(224, 135);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(140, 31);
            this.btnReturnBook.TabIndex = 10;
            this.btnReturnBook.Text = "Trả sách";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // dtpTermDate
            // 
            this.dtpTermDate.CustomFormat = "  dd/MM/yyyy";
            this.dtpTermDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTermDate.Location = new System.Drawing.Point(122, 55);
            this.dtpTermDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTermDate.Name = "dtpTermDate";
            this.dtpTermDate.Size = new System.Drawing.Size(171, 26);
            this.dtpTermDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ngày hẹn trả";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CustomFormat = "  dd/MM/yyyy";
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnDate.Location = new System.Drawing.Point(122, 91);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(171, 26);
            this.dtpReturnDate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày trả";
            // 
            // txtRentalID
            // 
            this.txtRentalID.BackColor = System.Drawing.SystemColors.Window;
            this.txtRentalID.Location = new System.Drawing.Point(122, 18);
            this.txtRentalID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.ReadOnly = true;
            this.txtRentalID.Size = new System.Drawing.Size(171, 26);
            this.txtRentalID.TabIndex = 11;
            this.txtRentalID.TextChanged += new System.EventHandler(this.txtRentalID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phạt trễ hạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã thuê";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSearchUserName);
            this.panel1.Controls.Add(this.txtUserNameSearch);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(576, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 179);
            this.panel1.TabIndex = 33;
            // 
            // btnSearchUserName
            // 
            this.btnSearchUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchUserName.Location = new System.Drawing.Point(55, 94);
            this.btnSearchUserName.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchUserName.Name = "btnSearchUserName";
            this.btnSearchUserName.Size = new System.Drawing.Size(79, 31);
            this.btnSearchUserName.TabIndex = 10;
            this.btnSearchUserName.Text = "Tìm kiếm";
            this.btnSearchUserName.UseVisualStyleBackColor = true;
            this.btnSearchUserName.Click += new System.EventHandler(this.btnSearchUserName_Click);
            // 
            // txtUserNameSearch
            // 
            this.txtUserNameSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUserNameSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUserNameSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUserNameSearch.Location = new System.Drawing.Point(12, 56);
            this.txtUserNameSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserNameSearch.Name = "txtUserNameSearch";
            this.txtUserNameSearch.Size = new System.Drawing.Size(180, 26);
            this.txtUserNameSearch.TabIndex = 9;
            this.txtUserNameSearch.Text = "Nhập tên tài khoản...";
            this.txtUserNameSearch.Enter += new System.EventHandler(this.txtUserNameSearch_Enter);
            this.txtUserNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserNameSearch_KeyDown);
            this.txtUserNameSearch.Leave += new System.EventHandler(this.txtUserNameSearch_Leave);
            // 
            // lbPayed
            // 
            this.lbPayed.AutoSize = true;
            this.lbPayed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPayed.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayed.Location = new System.Drawing.Point(224, 73);
            this.lbPayed.Name = "lbPayed";
            this.lbPayed.Size = new System.Drawing.Size(174, 35);
            this.lbPayed.TabIndex = 34;
            this.lbPayed.Text = "Đã thanh toán";
            this.lbPayed.Visible = false;
            // 
            // fBookRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 524);
            this.Controls.Add(this.lbPayed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvBookRental);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fBookRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thuê trả";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookRental)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutDatePrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookRental;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchUserName;
        private System.Windows.Forms.TextBox txtUserNameSearch;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn rent_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn rent_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn term_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.NumericUpDown nmTotalPrice;
        private System.Windows.Forms.NumericUpDown nmOutDatePrice;
        private System.Windows.Forms.DateTimePicker dtpTermDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPayed;
    }
}