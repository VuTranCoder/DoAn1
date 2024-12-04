namespace DACS1AV
{
    partial class frmKhachHang
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cboGT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtLoaiKH = new System.Windows.Forms.TextBox();
            this.dtpNgayDK = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblDoanhSo = new System.Windows.Forms.Label();
            this.lblNgayDangKy = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cboGT
            // 
            this.cboGT.FormattingEnabled = true;
            this.cboGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGT.Location = new System.Drawing.Point(220, 127);
            this.cboGT.Name = "cboGT";
            this.cboGT.Size = new System.Drawing.Size(298, 27);
            this.cboGT.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Giới Tính";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::DACS1AV.Properties.Resources.search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(741, 302);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(148, 45);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(477, 308);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(191, 27);
            this.txtTimKiem.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Từ Khóa";
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuKhoa.Location = new System.Drawing.Point(93, 312);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(44, 23);
            this.lblTuKhoa.TabIndex = 21;
            this.lblTuKhoa.Text = "Tìm";
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Mã Khách Hàng\t",
            "Tên Khách Hàng"});
            this.cbbTimKiem.Location = new System.Drawing.Point(168, 308);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(156, 27);
            this.cbbTimKiem.TabIndex = 20;
            // 
            // txtLoaiKH
            // 
            this.txtLoaiKH.Location = new System.Drawing.Point(845, 182);
            this.txtLoaiKH.Name = "txtLoaiKH";
            this.txtLoaiKH.Size = new System.Drawing.Size(273, 27);
            this.txtLoaiKH.TabIndex = 15;
            // 
            // dtpNgayDK
            // 
            this.dtpNgayDK.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDK.Location = new System.Drawing.Point(845, 127);
            this.dtpNgayDK.Name = "dtpNgayDK";
            this.dtpNgayDK.Size = new System.Drawing.Size(273, 27);
            this.dtpNgayDK.TabIndex = 14;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(845, 76);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(273, 27);
            this.dtpNgaysinh.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(845, 27);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(273, 27);
            this.txtSDT.TabIndex = 12;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(220, 179);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(298, 27);
            this.txtDiachi.TabIndex = 11;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(220, 76);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(298, 27);
            this.txtTenKH.TabIndex = 10;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(220, 32);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(298, 27);
            this.txtMaKH.TabIndex = 9;
            // 
            // lblDoanhSo
            // 
            this.lblDoanhSo.AutoSize = true;
            this.lblDoanhSo.Location = new System.Drawing.Point(696, 179);
            this.lblDoanhSo.Name = "lblDoanhSo";
            this.lblDoanhSo.Size = new System.Drawing.Size(72, 19);
            this.lblDoanhSo.TabIndex = 8;
            this.lblDoanhSo.Text = "Loại KH";
            // 
            // lblNgayDangKy
            // 
            this.lblNgayDangKy.AutoSize = true;
            this.lblNgayDangKy.Location = new System.Drawing.Point(696, 130);
            this.lblNgayDangKy.Name = "lblNgayDangKy";
            this.lblNgayDangKy.Size = new System.Drawing.Size(83, 19);
            this.lblNgayDangKy.TabIndex = 7;
            this.lblNgayDangKy.Text = "Ngày Mua";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(696, 82);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(83, 19);
            this.lblNgaysinh.TabIndex = 6;
            this.lblNgaysinh.Text = "Ngày Sinh";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(696, 35);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(112, 19);
            this.lblSDT.TabIndex = 5;
            this.lblSDT.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(41, 79);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(129, 19);
            this.lblTenKH.TabIndex = 3;
            this.lblTenKH.Text = "Tên Khách Hàng";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.BackColor = System.Drawing.Color.PaleGreen;
            this.lblMaKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(41, 35);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(126, 19);
            this.lblMaKH.TabIndex = 2;
            this.lblMaKH.Text = "Mã Khách Hàng";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(21, 358);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(1097, 399);
            this.dgvKhachHang.TabIndex = 4;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Controls.Add(this.cboGT);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTuKhoa);
            this.panel1.Controls.Add(this.cbbTimKiem);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtLoaiKH);
            this.panel1.Controls.Add(this.dtpNgayDK);
            this.panel1.Controls.Add(this.dtpNgaysinh);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.lblDoanhSo);
            this.panel1.Controls.Add(this.lblNgayDangKy);
            this.panel1.Controls.Add(this.lblNgaysinh);
            this.panel1.Controls.Add(this.lblSDT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTenKH);
            this.panel1.Controls.Add(this.lblMaKH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 348);
            this.panel1.TabIndex = 3;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Image = global::DACS1AV.Properties.Resources.skip;
            this.btnBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoQua.Location = new System.Drawing.Point(829, 238);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(126, 49);
            this.btnBoQua.TabIndex = 31;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.Image = global::DACS1AV.Properties.Resources.luu1;
            this.btnLuu.Location = new System.Drawing.Point(459, 236);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 49);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button6.Image = global::DACS1AV.Properties.Resources.exit3;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(1007, 236);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 49);
            this.button6.TabIndex = 19;
            this.button6.Text = "Đóng";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.Image = global::DACS1AV.Properties.Resources.trash;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(648, 236);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 49);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.Image = global::DACS1AV.Properties.Resources.sua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(262, 236);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 49);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.Image = global::DACS1AV.Properties.Resources.add1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(66, 236);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 49);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1131, 763);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.ComboBox cboGT;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtLoaiKH;
        private System.Windows.Forms.DateTimePicker dtpNgayDK;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblDoanhSo;
        private System.Windows.Forms.Label lblNgayDangKy;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Panel panel1;
    }
}