namespace DACS1AV
{
    partial class frmTimKiem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.cboSHD = new System.Windows.Forms.ComboBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtMKH = new System.Windows.Forms.TextBox();
            this.txtMNV = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTKHD = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.btnTimLai);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 574);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 91);
            this.panel2.TabIndex = 10;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = global::DACS1AV.Properties.Resources.exit1;
            this.btnDong.Location = new System.Drawing.Point(778, 12);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(132, 55);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cboSHD
            // 
            this.cboSHD.FormattingEnabled = true;
            this.cboSHD.Location = new System.Drawing.Point(181, 24);
            this.cboSHD.Name = "cboSHD";
            this.cboSHD.Size = new System.Drawing.Size(300, 27);
            this.cboSHD.TabIndex = 12;
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(704, 93);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(279, 27);
            this.txtTT.TabIndex = 11;
            this.txtTT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTT_KeyPress);
            // 
            // txtMKH
            // 
            this.txtMKH.Location = new System.Drawing.Point(704, 23);
            this.txtMKH.Name = "txtMKH";
            this.txtMKH.Size = new System.Drawing.Size(279, 27);
            this.txtMKH.TabIndex = 10;
            // 
            // txtMNV
            // 
            this.txtMNV.Location = new System.Drawing.Point(181, 160);
            this.txtMNV.Name = "txtMNV";
            this.txtMNV.Size = new System.Drawing.Size(297, 27);
            this.txtMNV.TabIndex = 9;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(364, 93);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(114, 27);
            this.txtNam.TabIndex = 8;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(181, 93);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(93, 27);
            this.txtThang.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng Tiền";
            // 
            // dgvTKHD
            // 
            this.dgvTKHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKHD.Location = new System.Drawing.Point(99, 218);
            this.dgvTKHD.Name = "dgvTKHD";
            this.dgvTKHD.RowHeadersWidth = 51;
            this.dgvTKHD.RowTemplate.Height = 24;
            this.dgvTKHD.Size = new System.Drawing.Size(861, 324);
            this.dgvTKHD.TabIndex = 8;
            this.dgvTKHD.DoubleClick += new System.EventHandler(this.dgvTKHD_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(80, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nhấn đúp vào hóa đơn để thể hiện thông tin chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Hóa Đơn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboSHD);
            this.panel1.Controls.Add(this.txtTT);
            this.panel1.Controls.Add(this.txtMKH);
            this.panel1.Controls.Add(this.txtMNV);
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.txtThang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 212);
            this.panel1.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::DACS1AV.Properties.Resources.search;
            this.btnTimKiem.Location = new System.Drawing.Point(181, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(132, 55);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTimLai
            // 
            this.btnTimLai.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimLai.Image = global::DACS1AV.Properties.Resources.timlai1;
            this.btnTimLai.Location = new System.Drawing.Point(481, 12);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(132, 55);
            this.btnTimLai.TabIndex = 3;
            this.btnTimLai.Text = "Tìm Lại";
            this.btnTimLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimLai.UseVisualStyleBackColor = true;
            this.btnTimLai.Click += new System.EventHandler(this.btnTimLai_Click);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1055, 665);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvTKHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox cboSHD;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtMKH;
        private System.Windows.Forms.TextBox txtMNV;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTKHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}