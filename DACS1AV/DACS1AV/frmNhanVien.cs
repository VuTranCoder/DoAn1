using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACS1AV
{
    public partial class frmNhanVien : Form
    {
        DataTable NHANVIEN;
        void loaddata()
        {
            string sql;
            sql = "SELECT *  FROM NHANVIEN";
            NHANVIEN = DACS1AV.Function.GetDataToTable(sql);
            dgvNhanVien.DataSource = NHANVIEN;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DACS1AV.Function.Connect();
            txtMaNV.Enabled = false;
            txtMaNV.Enabled = false;
            btnLuu.Enabled = false;
            loaddata();
            dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns[2].HeaderText = "Giới Tính";
            dgvNhanVien.Columns[3].HeaderText = "Số Điện Thoại";
            dgvNhanVien.Columns[4].HeaderText = "Ngày vào Làm";
            dgvNhanVien.Columns[5].HeaderText = "Loại Nhân Viên";


            dgvNhanVien.Columns[0].Width = 150;
            dgvNhanVien.Columns[1].Width = 170;
            dgvNhanVien.Columns[2].Width = 110;
            dgvNhanVien.Columns[3].Width = 110;
            dgvNhanVien.Columns[4].Width = 170;
            dgvNhanVien.Columns[5].Width = 150;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnBoQua.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMaNV.Enabled = true; //cho phép nhập mới
            txtMaNV.Focus();
            loaddata();
        }
        private void ResetValue()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cboGT.Text = "";
            txtSDT.Text = "";
            dtpNVL.Text = "";
            txtLoaiNV.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (NHANVIEN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE NHANVIEN WHERE MANV=N'" + txtMaNV.Text + "'";
                DACS1AV.Function.RunSqlDel(sql);
                loaddata();
                ResetValue();
            }
            else
            {
                MessageBox.Show("Mã Nhân Viên Không Tồn Tại!", "Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (NHANVIEN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNV.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboGT.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSDT.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dtpNVL.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtLoaiNV.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE NHANVIEN SET " +
       "HOTEN=N'" + txtTenNV.Text.Trim().ToString() + "'," +
       "GIOITINHNV=N'" + cboGT.Text.Trim().ToString() + "'," +
       "SODT=N'" + txtSDT.Text.Trim().ToString() + "'," +
       "NGVL=N'" + dtpNVL.Text.Trim().ToString() + "'," + "LOAINV=N'" + txtLoaiNV.Text.Trim().ToString() + "' " + // Đảm bảo dữ liệu nhập là số để tránh lỗi
       "WHERE MANV=N'" + txtMaNV.Text + "'";
            DACS1AV.Function.RunSQL(sql);
            loaddata();
            ResetValue();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (NHANVIEN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            cboGT.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            dtpNVL.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            txtLoaiNV.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaNV.Text.Trim().Length == 0 || txtTenNV.Text.Trim().Length == 0 ||
            cboGT.Text.Trim().Length == 0 || txtSDT.Text.Trim().Length == 0 ||
            dtpNVL.Text.Trim().Length == 0 || txtLoaiNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "Select MANV From NHANVIEN where MANV=N'" + txtMaNV.Text.Trim() + "'";
            if (DACS1AV.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại,Vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            sql = "INSERT INTO NHANVIEN VALUES (N'" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + cboGT.Text + "',N'" + txtSDT.Text + "',N'" + dtpNVL.Text + "',N'" + txtLoaiNV.Text + "')";
            DACS1AV.Function.RunSQL(sql); //Thực hiện câu lệnh sql
            loaddata(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            TextBox textBox = (TextBox)sender;
            string soDienThoai = textBox.Text + e.KeyChar; // Lấy chuỗi số điện thoại hiện tại

            // Kiểm tra điều kiện số điện thoại hợp lệ
            if (soDienThoai.Length > 10 || !soDienThoai.All(char.IsDigit) || soDienThoai.Contains("-"))
            {
                e.Handled = true; // Không cho nhập thêm ký tự nữa nếu số điện thoại không hợp lệ
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
        }
    }
}
