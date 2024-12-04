using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACS1AV;
using COMExcel = Microsoft.Office.Interop.Excel;
namespace DACS1AV
{
    public partial class frmHoaDon : Form
    {
        DataTable CTHD;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            DACS1AV.Function.Connect();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnInHD.Enabled = false;
            txtSHD.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtTenHang.ReadOnly = true;
            txtDG.ReadOnly = true;
            txtTT.ReadOnly = true;
            txtGia.ReadOnly = true;
            txtGG.Text = "0";
            txtGia.Text = "0";
            Function.FillCombo("SELECT MAKH, HOTEN FROM KHACHHANG", cboMaKH, "MAKH", "MAKH");
            cboMaKH.SelectedIndex = -1;
            Function.FillCombo("SELECT MANV, HOTEN FROM NHANVIEN", cboMNV, "MANV", "MANV");
            cboMNV.SelectedIndex = -1;
            cboMaHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboMaHang.AutoCompleteSource = AutoCompleteSource.ListItems;
            Function.FillCombo("SELECT MAHANG, TENSP FROM MATHANG ", cboMaHang, "MAHANG", "MAHANG");
            cboMaHang.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtSHD.Text != "")
            {
                LoadInfoHoaDon();
                btnHuy.Enabled = true;
                btnInHD.Enabled = true;
            }
            loaddataCTHD();
        }
        void loaddataCTHD()
        {
            string sql;
            sql = "SELECT a.MAHANG, b.TENSP, a.SL, b.GIA, a.GIAMGIA,a.THANHTIEN FROM CTHD AS a, MATHANG AS b WHERE a.SOHD = N'" + txtSHD.Text + "' AND a.MAHANG=b.MAHANG";
            CTHD = Function.GetDataToTable(sql);
            dgvCTHD.DataSource = CTHD;
            dgvCTHD.Columns[0].HeaderText = "Mã hàng";
            dgvCTHD.Columns[1].HeaderText = "Tên hàng";
            dgvCTHD.Columns[2].HeaderText = "Số lượng";
            dgvCTHD.Columns[3].HeaderText = "Đơn giá";
            dgvCTHD.Columns[4].HeaderText = "Giảm giá %";
            dgvCTHD.Columns[5].HeaderText = "Thành tiền";
            dgvCTHD.Columns[0].Width = 80;
            dgvCTHD.Columns[1].Width = 130;
            dgvCTHD.Columns[2].Width = 80;
            dgvCTHD.Columns[3].Width = 90;
            dgvCTHD.Columns[4].Width = 90;
            dgvCTHD.Columns[5].Width = 90;
            dgvCTHD.AllowUserToAddRows = false;
            dgvCTHD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NGHD FROM HOADON WHERE SOHD = N'" + txtSHD.Text + "'";
            dtpNL.Text = Function.ConvertDateTime(Function.GetFieldValues(str));
            str = "SELECT MANV FROM HOADON WHERE SOHD = N'" + txtSHD.Text + "'";
            cboMNV.SelectedValue = Function.GetFieldValues(str);
            str = "SELECT MAKH FROM HOADON WHERE SOHD = N'" + txtSHD.Text + "'";
            cboMaKH.SelectedValue = Function.GetFieldValues(str);
            str = "SELECT TRIGIA FROM HOADON WHERE SOHD = N'" + txtSHD.Text + "'";
            txtGia.Text = Function.GetFieldValues(str);
            lblBangChu.Text = "Bằng chữ: " + Function.ChuyenSoSangChuoi(double.Parse(txtGia.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnInHD.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtSHD.Text = Function.CreateKey("HDB");
            loaddataCTHD();
        }
        private void ResetValues()
        {
            txtSHD.Text = "";
            dtpNL.Text = DateTime.Now.ToShortDateString();
            cboMNV.Text = "";
            cboMaKH.Text = "";
            txtGia.Text = "0";
            lblBangChu.Text = "Bằng chữ: ";
            cboMaHang.Text = "";
            txtSL.Text = "";
            txtGG.Text = "0";
            txtTT.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT SOHD FROM HOADON WHERE SOHD=N'" + txtSHD.Text + "'";
            if (!Function.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (dtpNL.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpNL.Focus();
                    return;
                }
                if (cboMNV.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMNV.Focus();
                    return;
                }
                if (cboMaKH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaKH.Focus();
                    return;
                }
                sql = "INSERT INTO HOADON(SOHD, NGHD, MAKH, MANV, TRIGIA) VALUES (N'" + txtSHD.Text.Trim() + "','" +
                        Function.ConvertDateTime(dtpNL.Text.Trim()) + "',N'" + cboMaKH.SelectedValue + "',N'" +
                        cboMNV.SelectedValue + "'," + txtGia.Text + ")";
                Function.RunSQL(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cboMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHang.Focus();
                return;
            }
            if ((txtSL.Text.Trim().Length == 0) || (txtSL.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSL.Text = "";
                txtSL.Focus();
                return;
            }
            if (txtGG.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGG.Focus();
                return;
            }
            sql = "SELECT MAHANG FROM CTHD WHERE MAHANG=N'" + cboMaHang.SelectedValue + "' AND SOHD = N'" + txtSHD.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cboMaHang.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Function.GetFieldValues("SELECT SOLUONG FROM MATHANG WHERE MAHANG = N'" + cboMaHang.SelectedValue + "'"));
            if (Convert.ToDouble(txtSL.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSL.Text = "";
                txtSL.Focus();
                return;
            }
            sql = "INSERT INTO CTHD(SOHD,MAHANG,SL,DONGIA, GIAMGIA,THANHTIEN) VALUES(N'" + txtSHD.Text.Trim() + "',N'" + cboMaHang.SelectedValue + "'," + txtSL.Text + "," + txtDG.Text + "," + txtGG.Text + "," + txtTT.Text + ")";
            Function.RunSQL(sql);
            loaddataCTHD();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txtSL.Text);
            sql = "UPDATE MATHANG SET SOLUONG =" + SLcon + " WHERE MAHANG= N'" + cboMaHang.SelectedValue + "'";
            Function.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Function.GetFieldValues("SELECT TRIGIA FROM HOADON WHERE SOHD = N'" + txtSHD.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtTT.Text);
            sql = "UPDATE HOADON SET TRIGIA =" + Tongmoi + " WHERE SOHD = N'" + txtSHD.Text + "'";
            Function.RunSQL(sql);
            txtGia.Text = Tongmoi.ToString();
            lblBangChu.Text = "Bằng chữ: " + Function.ChuyenSoSangChuoi(double.Parse(Tongmoi.ToString()));
            ResetValuesHang();
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnInHD.Enabled = true;
        }
        private void ResetValuesHang()
        {
            cboMaHang.Text = "";
            txtSL.Text = "";
            txtGG.Text = "0";
            txtTT.Text = "0";
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaHang.Text == "")
            {
                txtTenHang.Text = "";
                txtDG.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT TENSP FROM MATHANG WHERE MAHANG =N'" + cboMaHang.SelectedValue + "'";
            txtTenHang.Text = Function.GetFieldValues(str);
            str = "SELECT GIA FROM MATHANG WHERE MAHANG =N'" + cboMaHang.SelectedValue + "'";
            txtDG.Text = Function.GetFieldValues(str);
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaKH.Text == "")
            {
                txtTenKH.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select HOTEN from KHACHHANG where MAKH = N'" + cboMaKH.SelectedValue + "'";
            txtTenKH.Text = Function.GetFieldValues(str);
            str = "Select DCHI from KHACHHANG where MAKH = N'" + cboMaKH.SelectedValue + "'";
            txtDchi.Text = Function.GetFieldValues(str);
            str = "Select SODT from KHACHHANG where MAKH = N'" + cboMaKH.SelectedValue + "'";
            txtSDT.Text = Function.GetFieldValues(str);
        }

        private void cboMNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMNV.Text == "")
                txtTenNV.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select HOTEN from NHANVIEN where MANV =N'" + cboMNV.SelectedValue + "'";
            txtTenNV.Text = Function.GetFieldValues(str);
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSL.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSL.Text);
            if (txtGG.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGG.Text);
            if (txtDG.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDG.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtTT.Text = tt.ToString();
        }

        private void txtGG_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSL.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSL.Text);
            if (txtGG.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGG.Text);
            if (txtDG.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDG.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtTT.Text = tt.ToString();
        }

        private void cboSHD_DropDown(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT SOHD FROM HOADON", cboSHD, "SOHD", "SOHD");
            cboSHD.SelectedIndex = -1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboSHD.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSHD.Focus();
                return;
            }
            txtSHD.Text = cboSHD.Text;
            LoadInfoHoaDon();
            loaddataCTHD();
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnInHD.Enabled = true;
            cboSHD.SelectedIndex = -1;
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa Hàng Máy Tính Anh Vũ";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Ninh Kiều-Cần Thơ";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0941258884";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.SOHD, a.NGHD, a.TRIGIA, b.HOTEN, b.DCHI, b.SODT, c.HOTEN FROM HOADON AS a,KHACHHANG AS b, NHANVIEN AS c WHERE a.SOHD = N'" + txtSHD.Text + "' AND a.MAKH = b.MAKH AND a.MANV = c.MANV";
            tblThongtinHD = Function.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TENSP, a.SL, b.GIA, a.GIAMGIA, a.THANHTIEN " +
                  "FROM CTHD AS a ,MATHANG AS b WHERE a.SOHD = N'" +
                  txtSHD.Text + "' AND a.MAHANG = b.MAHANG";
            tblThongtinHang = Function.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Function.ChuyenSoSangChuoi(double.Parse(tblThongtinHD.Rows[0][2].ToString()));
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa Đơn Bán Hàng";
            exApp.Visible = true;
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MAHANG,SL FROM CTHD WHERE SOHD = N'" + txtSHD.Text + "'";
                DataTable tblHang = Function.GetDataToTable(sql);
                for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Function.GetFieldValues("SELECT SOLUONG FROM MATHANG WHERE MAHANG = N'" + tblHang.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblHang.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE MATHANG SET SOLUONG =" + slcon + " WHERE MAHANG= N'" + tblHang.Rows[hang][0].ToString() + "'";
                    Function.RunSQL(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE CTHD WHERE SOHD=N'" + txtSHD.Text + "'";
                Function.RunSqlDel(sql);

                //Xóa hóa đơn
                sql = "DELETE HOADON WHERE SOHD=N'" + txtSHD.Text + "'";
                Function.RunSqlDel(sql);
                ResetValues();
                loaddataCTHD();
                btnHuy.Enabled = false;
                btnInHD.Enabled = false;
            }
        }

        private void dgvCTHD_DoubleClick(object sender, EventArgs e)
        {

            string MaHangxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (CTHD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = dgvCTHD.CurrentRow.Cells["MAHANG"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgvCTHD.CurrentRow.Cells["SL"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvCTHD.CurrentRow.Cells["THANHTIEN"].Value.ToString());
                sql = "DELETE CTHD WHERE SOHD=N'" + txtSHD.Text + "' AND MAHANG = N'" + MaHangxoa + "'";
                Function.RunSQL(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(Function.GetFieldValues("SELECT SOLUONG FROM MATHANG WHERE MAHANG = N'" + MaHangxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE MATHANG SET SOLUONG =" + slcon + " WHERE MAHANG= N'" + MaHangxoa + "'";
                Function.RunSQL(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(Function.GetFieldValues("SELECT TRIGIA FROM HOADON WHERE SOHD = N'" + txtSHD.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE HOADON SET TRIGIA =" + tongmoi + " WHERE SOHD = N'" + txtSHD.Text + "'";
                Function.RunSQL(sql);
                txtGia.Text = tongmoi.ToString();
                lblBangChu.Text = "Bằng chữ: " + Function.ChuyenSoSangChuoi(double.Parse(tongmoi.ToString()));
                loaddataCTHD();
            }
        }

        private void txtGG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
