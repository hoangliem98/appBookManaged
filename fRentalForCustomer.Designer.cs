namespace QuanLySach
{
    partial class fRentalForCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRentalForCustomer));
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giathue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.btnRent = new System.Windows.Forms.Button();
            this.nmRentAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTermDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRentalDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBookSearch = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbNV = new System.Windows.Forms.Label();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRentAmount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach,
            this.tensach,
            this.tacgia,
            this.nhaxuatban,
            this.theloai,
            this.soluong,
            this.giathue});
            this.dgvBook.Location = new System.Drawing.Point(0, 32);
            this.dgvBook.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(520, 463);
            this.dgvBook.TabIndex = 0;
            // 
            // masach
            // 
            this.masach.DataPropertyName = "ID";
            this.masach.FillWeight = 111.0902F;
            this.masach.HeaderText = "ID";
            this.masach.Name = "masach";
            this.masach.Width = 41;
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "Name";
            this.tensach.FillWeight = 355.33F;
            this.tensach.HeaderText = "Tên sách";
            this.tensach.Name = "tensach";
            this.tensach.Width = 77;
            // 
            // tacgia
            // 
            this.tacgia.DataPropertyName = "Author";
            this.tacgia.FillWeight = 173.4235F;
            this.tacgia.HeaderText = "Tác giả";
            this.tacgia.Name = "tacgia";
            this.tacgia.Width = 67;
            // 
            // nhaxuatban
            // 
            this.nhaxuatban.DataPropertyName = "Publisher";
            this.nhaxuatban.FillWeight = 15.03909F;
            this.nhaxuatban.HeaderText = "Nhà xuất bản";
            this.nhaxuatban.Name = "nhaxuatban";
            this.nhaxuatban.Width = 96;
            // 
            // theloai
            // 
            this.theloai.DataPropertyName = "Category";
            this.theloai.FillWeight = 15.03909F;
            this.theloai.HeaderText = "Thể loại";
            this.theloai.Name = "theloai";
            this.theloai.Width = 69;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "Amount";
            this.soluong.FillWeight = 15.03909F;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.Width = 71;
            // 
            // giathue
            // 
            this.giathue.DataPropertyName = "RentPrice";
            dataGridViewCellStyle2.Format = "#,###";
            dataGridViewCellStyle2.NullValue = "0";
            this.giathue.DefaultCellStyle = dataGridViewCellStyle2;
            this.giathue.FillWeight = 15.03909F;
            this.giathue.HeaderText = "Giá thuê";
            this.giathue.Name = "giathue";
            this.giathue.Width = 73;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtBookId);
            this.panel1.Controls.Add(this.nmPrice);
            this.panel1.Controls.Add(this.btnRent);
            this.panel1.Controls.Add(this.nmRentAmount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpTermDate);
            this.panel1.Controls.Add(this.dtpRentalDate);
            this.panel1.Location = new System.Drawing.Point(520, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 385);
            this.panel1.TabIndex = 3;
            // 
            // txtBookId
            // 
            this.txtBookId.BackColor = System.Drawing.SystemColors.Window;
            this.txtBookId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookId.Location = new System.Drawing.Point(113, 39);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(141, 26);
            this.txtBookId.TabIndex = 3;
            // 
            // nmPrice
            // 
            this.nmPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPrice.Location = new System.Drawing.Point(107, 204);
            this.nmPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(147, 26);
            this.nmPrice.TabIndex = 7;
            // 
            // btnRent
            // 
            this.btnRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Location = new System.Drawing.Point(89, 259);
            this.btnRent.Margin = new System.Windows.Forms.Padding(2);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(119, 30);
            this.btnRent.TabIndex = 8;
            this.btnRent.Text = "Thuê";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // nmRentAmount
            // 
            this.nmRentAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmRentAmount.Location = new System.Drawing.Point(135, 163);
            this.nmRentAmount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmRentAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmRentAmount.Name = "nmRentAmount";
            this.nmRentAmount.Size = new System.Drawing.Size(119, 26);
            this.nmRentAmount.TabIndex = 6;
            this.nmRentAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmRentAmount.ValueChanged += new System.EventHandler(this.nmRentAmount_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng thuê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hạn trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày thuê";
            // 
            // dtpTermDate
            // 
            this.dtpTermDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTermDate.CustomFormat = "dd/MM/yyyy";
            this.dtpTermDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTermDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTermDate.Location = new System.Drawing.Point(113, 121);
            this.dtpTermDate.Name = "dtpTermDate";
            this.dtpTermDate.Size = new System.Drawing.Size(141, 25);
            this.dtpTermDate.TabIndex = 5;
            // 
            // dtpRentalDate
            // 
            this.dtpRentalDate.CustomFormat = "dd/MM/yyyy";
            this.dtpRentalDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRentalDate.Location = new System.Drawing.Point(113, 80);
            this.dtpRentalDate.Name = "dtpRentalDate";
            this.dtpRentalDate.Size = new System.Drawing.Size(141, 26);
            this.dtpRentalDate.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtBookSearch);
            this.panel2.Controls.Add(this.btnSearchBook);
            this.panel2.Location = new System.Drawing.Point(520, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 76);
            this.panel2.TabIndex = 4;
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBookSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBookSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBookSearch.Location = new System.Drawing.Point(20, 23);
            this.txtBookSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.Size = new System.Drawing.Size(173, 26);
            this.txtBookSearch.TabIndex = 1;
            this.txtBookSearch.Text = "Nhập tên sách...";
            this.txtBookSearch.Enter += new System.EventHandler(this.txtBookSearch_Enter);
            this.txtBookSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookSearch_KeyDown);
            this.txtBookSearch.Leave += new System.EventHandler(this.txtBookSearch_Leave);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.Location = new System.Drawing.Point(197, 15);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(79, 41);
            this.btnSearchBook.TabIndex = 2;
            this.btnSearchBook.Text = "Tìm kiếm";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.lbNV);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 35);
            this.panel3.TabIndex = 5;
            // 
            // lbNV
            // 
            this.lbNV.AutoSize = true;
            this.lbNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNV.Location = new System.Drawing.Point(3, 9);
            this.lbNV.Name = "lbNV";
            this.lbNV.Size = new System.Drawing.Size(87, 21);
            this.lbNV.TabIndex = 6;
            this.lbNV.Text = "Thuê sách";
            // 
            // panelDropDown
            // 
            this.panelDropDown.Controls.Add(this.btnExit);
            this.panelDropDown.Controls.Add(this.btnLogout);
            this.panelDropDown.Controls.Add(this.btnInfo);
            this.panelDropDown.Controls.Add(this.btnSwitch);
            this.panelDropDown.Location = new System.Drawing.Point(779, 0);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(100, 139);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(35, 35);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(35, 35);
            this.panelDropDown.TabIndex = 17;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 103);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Silver;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 69);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(35, 34);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Silver;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(0, 35);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(35, 34);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSwitch.FlatAppearance.BorderSize = 0;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitch.Image")));
            this.btnSwitch.Location = new System.Drawing.Point(0, 0);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(35, 35);
            this.btnSwitch.TabIndex = 1;
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // fRentalForCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 495);
            this.Controls.Add(this.panelDropDown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fRentalForCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuê sách";
            this.Load += new System.EventHandler(this.fRentalForCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRentAmount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giathue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpTermDate;
        private System.Windows.Forms.DateTimePicker dtpRentalDate;
        private System.Windows.Forms.TextBox txtBookSearch;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.NumericUpDown nmRentAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbNV;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSwitch;
    }
}