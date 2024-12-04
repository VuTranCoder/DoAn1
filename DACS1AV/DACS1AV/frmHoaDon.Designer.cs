namespace DACS1AV
{
    partial class frmHoaDon
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboSHD = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBangChu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMNV = new System.Windows.Forms.ComboBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDchi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSHD = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpNL = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(497, 698);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(153, 34);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboSHD
            // 
            this.cboSHD.FormattingEnabled = true;
            this.cboSHD.Location = new System.Drawing.Point(148, 705);
            this.cboSHD.Name = "cboSHD";
            this.cboSHD.Size = new System.Drawing.Size(320, 24);
            this.cboSHD.TabIndex = 9;
            this.cboSHD.DropDown += new System.EventHandler(this.cboSHD_DropDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 705);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "Số Hóa Đơn";
            // 
            // lblBangChu
            // 
            this.lblBangChu.AutoSize = true;
            this.lblBangChu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBangChu.ForeColor = System.Drawing.Color.Blue;
            this.lblBangChu.Location = new System.Drawing.Point(39, 356);
            this.lblBangChu.Name = "lblBangChu";
            this.lblBangChu.Size = new System.Drawing.Size(79, 17);
            this.lblBangChu.TabIndex = 36;
            this.lblBangChu.Text = "Bằng Chữ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBangChu);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtTT);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtGG);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTenHang);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnInHD);
            this.groupBox2.Controls.Add(this.txtDG);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.cboMaHang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgvCTHD);
            this.groupBox2.Controls.Add(this.txtSL);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1182, 450);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(39, 329);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 15);
            this.label16.TabIndex = 35;
            this.label16.Text = "Nháy đúp để xóa một dòng";
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(912, 99);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(214, 27);
            this.txtTT.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(815, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 19);
            this.label15.TabIndex = 33;
            this.label15.Text = "Thành Tiền";
            // 
            // txtGG
            // 
            this.txtGG.Location = new System.Drawing.Point(561, 104);
            this.txtGG.Name = "txtGG";
            this.txtGG.Size = new System.Drawing.Size(225, 27);
            this.txtGG.TabIndex = 32;
            this.txtGG.TextChanged += new System.EventHandler(this.txtGG_TextChanged);
            this.txtGG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGG_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Giảm Giá %";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(561, 61);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(226, 27);
            this.txtTenHang.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(438, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 19);
            this.label14.TabIndex = 29;
            this.label14.Text = "Tên Hàng";
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(912, 56);
            this.txtDG.Name = "txtDG";
            this.txtDG.ReadOnly = true;
            this.txtDG.Size = new System.Drawing.Size(214, 27);
            this.txtDG.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(815, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Đơn Giá";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(788, 329);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(208, 27);
            this.txtGia.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button6.Image = global::DACS1AV.Properties.Resources.exit2;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(1045, 388);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 50);
            this.button6.TabIndex = 20;
            this.button6.Text = "Đóng";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cboMaHang
            // 
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(170, 56);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(227, 27);
            this.cboMaHang.TabIndex = 7;
            this.cboMaHang.SelectedIndexChanged += new System.EventHandler(this.cboMaHang_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(707, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Trị giá";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(170, 146);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.Size = new System.Drawing.Size(826, 166);
            this.dgvCTHD.TabIndex = 6;
            this.dgvCTHD.DoubleClick += new System.EventHandler(this.dgvCTHD_DoubleClick);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(169, 101);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(228, 27);
            this.txtSL.TabIndex = 5;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(23, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(25, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã hàng";
            // 
            // cboMNV
            // 
            this.cboMNV.FormattingEnabled = true;
            this.cboMNV.Location = new System.Drawing.Point(172, 110);
            this.cboMNV.Name = "cboMNV";
            this.cboMNV.Size = new System.Drawing.Size(287, 27);
            this.cboMNV.TabIndex = 11;
            this.cboMNV.SelectedIndexChanged += new System.EventHandler(this.cboMNV_SelectedIndexChanged);
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(732, 17);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(287, 27);
            this.cboMaKH.TabIndex = 10;
            this.cboMaKH.SelectedIndexChanged += new System.EventHandler(this.cboMaKH_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(592, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Lập HĐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Hóa Đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDchi);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSHD);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpNL);
            this.groupBox1.Controls.Add(this.cboMNV);
            this.groupBox1.Controls.Add(this.cboMaKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1186, 193);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(731, 150);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(288, 27);
            this.txtSDT.TabIndex = 21;
            // 
            // txtDchi
            // 
            this.txtDchi.Location = new System.Drawing.Point(733, 104);
            this.txtDchi.Name = "txtDchi";
            this.txtDchi.ReadOnly = true;
            this.txtDchi.Size = new System.Drawing.Size(286, 27);
            this.txtDchi.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(592, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 17);
            this.label17.TabIndex = 19;
            this.label17.Text = "Số Điện Thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(592, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Địa Chỉ ";
            // 
            // txtSHD
            // 
            this.txtSHD.Location = new System.Drawing.Point(172, 17);
            this.txtSHD.Name = "txtSHD";
            this.txtSHD.Size = new System.Drawing.Size(287, 27);
            this.txtSHD.TabIndex = 17;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(172, 156);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(287, 27);
            this.txtTenNV.TabIndex = 16;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(732, 58);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(287, 27);
            this.txtTenKH.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(26, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Tên Nhân Viên";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(592, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Tên Khách Hàng";
            // 
            // dtpNL
            // 
            this.dtpNL.CustomFormat = "";
            this.dtpNL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNL.Location = new System.Drawing.Point(172, 58);
            this.dtpNL.Name = "dtpNL";
            this.dtpNL.Size = new System.Drawing.Size(287, 27);
            this.dtpNL.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.Image = global::DACS1AV.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(8, 388);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(197, 50);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm Hóa Đơn";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.Image = global::DACS1AV.Properties.Resources.luu;
            this.btnLuu.Location = new System.Drawing.Point(275, 388);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(183, 50);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu Hóa Đơn";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnInHD
            // 
            this.btnInHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnInHD.Image = global::DACS1AV.Properties.Resources.print;
            this.btnInHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHD.Location = new System.Drawing.Point(800, 388);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(183, 50);
            this.btnInHD.TabIndex = 28;
            this.btnInHD.Text = "In Hóa Đơn";
            this.btnInHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuy.Image = global::DACS1AV.Properties.Resources.timlai;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(542, 388);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(183, 50);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy Hóa Đơn";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1209, 767);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboSHD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboSHD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBangChu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMNV;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDchi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSHD;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpNL;
    }
}