namespace DACS1AV
{
    partial class frmGiaoDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoDien));
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.panel1_Leff = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnPBH = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnHoadon = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.btnMatHang = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_body.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.panel1_Leff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.PaleGreen;
            this.panel_body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_body.BackgroundImage")));
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_body.Controls.Add(this.panel2);
            this.panel_body.Controls.Add(this.panel1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(215, 76);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1165, 761);
            this.panel_body.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(508, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 147);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(185, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "HỆ THỐNG ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(-10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(613, 57);
            this.label2.TabIndex = 6;
            this.label2.Text = "QUẢN LÝ BÁN MÁY TÍNH";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Location = new System.Drawing.Point(996, 699);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 61);
            this.panel1.TabIndex = 8;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::DACS1AV.Properties.Resources.lôut;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(3, 3);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(166, 57);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.PaleGreen;
            this.panel_Top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Top.BackgroundImage")));
            this.panel_Top.Controls.Add(this.lblHome);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(215, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1165, 76);
            this.panel_Top.TabIndex = 4;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Red;
            this.lblHome.Location = new System.Drawing.Point(415, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(344, 51);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Màn Hình Chính";
            // 
            // panel1_Leff
            // 
            this.panel1_Leff.BackColor = System.Drawing.Color.Green;
            this.panel1_Leff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1_Leff.BackgroundImage")));
            this.panel1_Leff.Controls.Add(this.btnDong);
            this.panel1_Leff.Controls.Add(this.btnPBH);
            this.panel1_Leff.Controls.Add(this.btnTK);
            this.panel1_Leff.Controls.Add(this.btnHoadon);
            this.panel1_Leff.Controls.Add(this.btnNCC);
            this.panel1_Leff.Controls.Add(this.btnMatHang);
            this.panel1_Leff.Controls.Add(this.btnKhachHang);
            this.panel1_Leff.Controls.Add(this.btnNhanVien);
            this.panel1_Leff.Controls.Add(this.pictureBox1);
            this.panel1_Leff.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1_Leff.Location = new System.Drawing.Point(0, 0);
            this.panel1_Leff.Name = "panel1_Leff";
            this.panel1_Leff.Size = new System.Drawing.Size(215, 837);
            this.panel1_Leff.TabIndex = 3;
            // 
            // btnDong
            // 
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = global::DACS1AV.Properties.Resources.exit1;
            this.btnDong.Location = new System.Drawing.Point(0, 755);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(215, 80);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnPBH
            // 
            this.btnPBH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPBH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPBH.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPBH.Image = global::DACS1AV.Properties.Resources.PBH;
            this.btnPBH.Location = new System.Drawing.Point(0, 662);
            this.btnPBH.Name = "btnPBH";
            this.btnPBH.Size = new System.Drawing.Size(215, 93);
            this.btnPBH.TabIndex = 8;
            this.btnPBH.Text = "Phiếu Bảo Hành";
            this.btnPBH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPBH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPBH.UseVisualStyleBackColor = false;
            this.btnPBH.Click += new System.EventHandler(this.btnPBH_Click);
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTK.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTK.Image = global::DACS1AV.Properties.Resources.searchbill;
            this.btnTK.Location = new System.Drawing.Point(0, 570);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(215, 92);
            this.btnTK.TabIndex = 7;
            this.btnTK.Text = "Tìm Kiếm Hóa Đơn";
            this.btnTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoadon.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadon.Image = global::DACS1AV.Properties.Resources.bill;
            this.btnHoadon.Location = new System.Drawing.Point(0, 478);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Size = new System.Drawing.Size(215, 92);
            this.btnHoadon.TabIndex = 5;
            this.btnHoadon.Text = "Hóa Đơn";
            this.btnHoadon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoadon.UseVisualStyleBackColor = false;
            this.btnHoadon.Click += new System.EventHandler(this.btnHoadon_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNCC.Font = new System.Drawing.Font("Times New Roman", 7.5F, System.Drawing.FontStyle.Bold);
            this.btnNCC.Image = global::DACS1AV.Properties.Resources.nhacungcap;
            this.btnNCC.Location = new System.Drawing.Point(0, 386);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(215, 92);
            this.btnNCC.TabIndex = 4;
            this.btnNCC.Text = "Nhà Cung Cấp";
            this.btnNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNCC.UseVisualStyleBackColor = false;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnMatHang
            // 
            this.btnMatHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMatHang.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnMatHang.Image = global::DACS1AV.Properties.Resources.sanpham;
            this.btnMatHang.Location = new System.Drawing.Point(0, 294);
            this.btnMatHang.Name = "btnMatHang";
            this.btnMatHang.Size = new System.Drawing.Size(215, 92);
            this.btnMatHang.TabIndex = 3;
            this.btnMatHang.Text = "Sản Phẩm";
            this.btnMatHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMatHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMatHang.UseVisualStyleBackColor = false;
            this.btnMatHang.Click += new System.EventHandler(this.btnMatHang_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
            this.btnKhachHang.Image = global::DACS1AV.Properties.Resources.khachhang;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 202);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(215, 92);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "Quản Lý Khách Hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 6.8F, System.Drawing.FontStyle.Bold);
            this.btnNhanVien.Image = global::DACS1AV.Properties.Resources.nhanvien;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 110);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(215, 92);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Quản Lý Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DACS1AV.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmGiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 837);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel1_Leff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGiaoDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Máy Tính";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiaoDien_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGiaoDien_FormClosed);
            this.panel_body.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel1_Leff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnPBH;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnHoadon;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnMatHang;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1_Leff;
    }
}