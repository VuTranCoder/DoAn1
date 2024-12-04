namespace DACS1AV
{
    partial class frmSanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaLoaiSP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.grBSanPham = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtNuocSX = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMancc = new System.Windows.Forms.TextBox();
            this.txtMaloai = new System.Windows.Forms.TextBox();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmahang = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.grBSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(749, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Từ Khóa";
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuKhoa.Location = new System.Drawing.Point(758, 10);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(44, 23);
            this.lblTuKhoa.TabIndex = 22;
            this.lblTuKhoa.Text = "Tìm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBoQua);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.lblTuKhoa);
            this.panel2.Controls.Add(this.cbbTimKiem);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 680);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1286, 130);
            this.panel2.TabIndex = 14;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Image = global::DACS1AV.Properties.Resources.skip;
            this.btnBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoQua.Location = new System.Drawing.Point(616, 31);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(127, 61);
            this.btnBoQua.TabIndex = 28;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.Image = global::DACS1AV.Properties.Resources.luu2;
            this.btnLuu.Location = new System.Drawing.Point(245, 30);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 61);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Image = global::DACS1AV.Properties.Resources.search1;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1039, 31);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(130, 44);
            this.btnTimKiem.TabIndex = 26;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.Image = global::DACS1AV.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(3, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 61);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(839, 69);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(194, 22);
            this.txtTimKiem.TabIndex = 25;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.Image = global::DACS1AV.Properties.Resources.sua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(129, 30);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 61);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.Image = global::DACS1AV.Properties.Resources.trash;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(371, 30);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 61);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Mã Hàng",
            "Mã Loại",
            "Mã Nhà Cung Cấp"});
            this.cbbTimKiem.Location = new System.Drawing.Point(839, 12);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(194, 24);
            this.cbbTimKiem.TabIndex = 23;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button6.Image = global::DACS1AV.Properties.Resources.exit3;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(489, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 62);
            this.button6.TabIndex = 20;
            this.button6.Text = "Đóng";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaLoaiSP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTenLoai);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 494);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 158);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Mục Loại";
            // 
            // txtMaLoaiSP
            // 
            this.txtMaLoaiSP.Location = new System.Drawing.Point(152, 60);
            this.txtMaLoaiSP.Name = "txtMaLoaiSP";
            this.txtMaLoaiSP.Size = new System.Drawing.Size(272, 27);
            this.txtMaLoaiSP.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Mã Loại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tên Loại";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(152, 116);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(272, 27);
            this.txtTenLoai.TabIndex = 16;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(578, 397);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(214, 71);
            this.txtGhiChu.TabIndex = 21;
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(578, 317);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(214, 74);
            this.txtAnh.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(495, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ghi Chú";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(495, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ảnh";
            // 
            // dgvLoaiSP
            // 
            this.dgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSP.Location = new System.Drawing.Point(499, 506);
            this.dgvLoaiSP.Name = "dgvLoaiSP";
            this.dgvLoaiSP.RowHeadersWidth = 51;
            this.dgvLoaiSP.RowTemplate.Height = 24;
            this.dgvLoaiSP.Size = new System.Drawing.Size(670, 146);
            this.dgvLoaiSP.TabIndex = 17;
            this.dgvLoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSP_CellClick);
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Location = new System.Drawing.Point(489, 11);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.RowHeadersWidth = 51;
            this.dgvSanpham.RowTemplate.Height = 24;
            this.dgvSanpham.Size = new System.Drawing.Size(674, 294);
            this.dgvSanpham.TabIndex = 15;
            this.dgvSanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanpham_CellClick);
            // 
            // grBSanPham
            // 
            this.grBSanPham.Controls.Add(this.button1);
            this.grBSanPham.Controls.Add(this.txtSL);
            this.grBSanPham.Controls.Add(this.label12);
            this.grBSanPham.Controls.Add(this.txtGiaTien);
            this.grBSanPham.Controls.Add(this.txtNuocSX);
            this.grBSanPham.Controls.Add(this.txtDVT);
            this.grBSanPham.Controls.Add(this.txtTenSP);
            this.grBSanPham.Controls.Add(this.txtMancc);
            this.grBSanPham.Controls.Add(this.dgvSanpham);
            this.grBSanPham.Controls.Add(this.txtMaloai);
            this.grBSanPham.Controls.Add(this.txtMahang);
            this.grBSanPham.Controls.Add(this.label7);
            this.grBSanPham.Controls.Add(this.label6);
            this.grBSanPham.Controls.Add(this.label5);
            this.grBSanPham.Controls.Add(this.label4);
            this.grBSanPham.Controls.Add(this.label3);
            this.grBSanPham.Controls.Add(this.label2);
            this.grBSanPham.Controls.Add(this.lblmahang);
            this.grBSanPham.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.grBSanPham.ForeColor = System.Drawing.Color.Black;
            this.grBSanPham.Location = new System.Drawing.Point(12, 6);
            this.grBSanPham.Name = "grBSanPham";
            this.grBSanPham.Size = new System.Drawing.Size(1169, 482);
            this.grBSanPham.TabIndex = 13;
            this.grBSanPham.TabStop = false;
            this.grBSanPham.Text = "Sản Phẩm";
            // 
            // button1
            // 
            this.button1.Image = global::DACS1AV.Properties.Resources.open;
            this.button1.Location = new System.Drawing.Point(786, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "Mở";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(180, 387);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(269, 27);
            this.txtSL.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 19);
            this.label12.TabIndex = 15;
            this.label12.Text = "Số Lượng";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(180, 330);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(271, 27);
            this.txtGiaTien.TabIndex = 14;
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.Location = new System.Drawing.Point(180, 285);
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.Size = new System.Drawing.Size(271, 27);
            this.txtNuocSX.TabIndex = 13;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(180, 233);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(271, 27);
            this.txtDVT.TabIndex = 12;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(181, 185);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(271, 27);
            this.txtTenSP.TabIndex = 11;
            // 
            // txtMancc
            // 
            this.txtMancc.Location = new System.Drawing.Point(180, 143);
            this.txtMancc.Name = "txtMancc";
            this.txtMancc.Size = new System.Drawing.Size(271, 27);
            this.txtMancc.TabIndex = 10;
            // 
            // txtMaloai
            // 
            this.txtMaloai.Location = new System.Drawing.Point(181, 101);
            this.txtMaloai.Name = "txtMaloai";
            this.txtMaloai.Size = new System.Drawing.Size(271, 27);
            this.txtMaloai.TabIndex = 9;
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(180, 57);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(272, 27);
            this.txtMahang.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nước Sản Xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn Vị Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Sản Phẩm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Loại";
            // 
            // lblmahang
            // 
            this.lblmahang.AutoSize = true;
            this.lblmahang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmahang.ForeColor = System.Drawing.Color.Black;
            this.lblmahang.Location = new System.Drawing.Point(6, 57);
            this.lblmahang.Name = "lblmahang";
            this.lblmahang.Size = new System.Drawing.Size(76, 19);
            this.lblmahang.TabIndex = 1;
            this.lblmahang.Text = "Mã Hàng";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(798, 368);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 44);
            this.btnOpen.TabIndex = 23;
            this.btnOpen.Text = "Mở";
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(898, 317);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(271, 151);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 22;
            this.picAnh.TabStop = false;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1286, 810);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvLoaiSP);
            this.Controls.Add(this.grBSanPham);
            this.Controls.Add(this.btnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.grBSanPham.ResumeLayout(false);
            this.grBSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaLoaiSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvLoaiSP;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.GroupBox grBSanPham;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtNuocSX;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMancc;
        private System.Windows.Forms.TextBox txtMaloai;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmahang;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button button1;
    }
}