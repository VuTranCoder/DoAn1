using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACS1AV
{
    public partial class frmKhachHang : Form
    {
        DataTable KHACHHANG;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DACS1AV.Function.Connect();
            txtMaKH.Enabled = false;
            btnLuu.Enabled = false;
            loaddata();
            dgvKhachHang.Columns[0].HeaderText = "Mã Khách Hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns[2].HeaderText = "Giới Tính";
            dgvKhachHang.Columns[3].HeaderText = "Địa Chỉ";
            dgvKhachHang.Columns[4].HeaderText = "Số Điện Thoại";
            dgvKhachHang.Columns[5].HeaderText = "Ngày Sinh";
            dgvKhachHang.Columns[6].HeaderText = "Ngày Mua";
            dgvKhachHang.Columns[7].HeaderText = "Loại Khách Hàng";


            dgvKhachHang.Columns[0].Width = 130;
            dgvKhachHang.Columns[1].Width = 170;
            dgvKhachHang.Columns[2].Width = 100;
            dgvKhachHang.Columns[3].Width = 150;
            dgvKhachHang.Columns[4].Width = 100;
            dgvKhachHang.Columns[5].Width = 100;
            dgvKhachHang.Columns[6].Width = 100;
            dgvKhachHang.Columns[7].Width = 100;
        }
        void loaddata()
        {
            string sql;
            sql = "SELECT *  FROM KHACHHANG";
            KHACHHANG = DACS1AV.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvKhachHang.DataSource = KHACHHANG; //Nguồn dữ liệu            

            dgvKhachHang.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnBoQua.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMaKH.Enabled = true; //cho phép nhập mới
            txtMaKH.Focus();
            loaddata();
        }
        private void ResetValue()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            cboGT.Text = "";
            txtDiachi.Text = "";
            txtSDT.Text = "";
            dtpNgaysinh.Text = "";
            dtpNgayDK.Text = "";
            txtLoaiKH.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (KHACHHANG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKH.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenKH.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboGT.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSDT.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dtpNgaysinh.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dtpNgayDK.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtLoaiKH.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE KHACHHANG SET " +
       "HOTEN=N'" + txtTenKH.Text.Trim().ToString() + "'," +
       "GIOITINHKH=N'" + cboGT.Text.Trim().ToString() + "'," +
       "DCHI=N'" + txtDiachi.Text.Trim().ToString() + "'," +
       "SODT=N'" + txtSDT.Text.Trim().ToString() + "'," +
       "NGSINH=N'" + dtpNgaysinh.Text.Trim().ToString() + "'," +
       "NGDK=N'" + dtpNgayDK.Text.Trim().ToString() + "', " +
       "LOAIKH=N'" + txtLoaiKH.Text.Trim().ToString() + "' " + // Đảm bảo dữ liệu nhập là số để tránh lỗi
       "WHERE MAKH=N'" + txtMaKH.Text + "'";
            DACS1AV.Function.RunSQL(sql);
            loaddata();
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (KHACHHANG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKH.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE KHACHHANG WHERE MAKH=N'" + txtMaKH.Text + "'";
                DACS1AV.Function.RunSqlDel(sql);
                loaddata();
                ResetValue();
            }
            else
            {
                MessageBox.Show("Mã Khách Hàng Không Tồn Tại!", "Lỗi");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKH.Text.Trim().Length == 0 || txtTenKH.Text.Trim().Length == 0 ||
            cboGT.Text.Trim().Length == 0 || txtDiachi.Text.Trim().Length == 0 ||
            txtSDT.Text.Trim().Length == 0 || dtpNgaysinh.Text.Trim().Length == 0 || dtpNgayDK.Text.Trim().Length == 0 ||
            txtLoaiKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "Select MAKH From KHACHHANG where MAKH=N'" + txtMaKH.Text.Trim() + "'";
            if (DACS1AV.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã khách hàng này đã tồn tại,Vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKH.Focus();
                return;
            }

            sql = "INSERT INTO KHACHHANG VALUES (N'" + txtMaKH.Text + "', N'" + txtTenKH.Text + "',N'" + cboGT.Text + "',N'" + txtDiachi.Text + "',N'" + txtSDT.Text + "',N'" + dtpNgaysinh.Text + "',N'" + dtpNgayDK.Text + "',N'" + txtLoaiKH.Text + "')";
            DACS1AV.Function.RunSQL(sql); //Thực hiện câu lệnh sql
            loaddata(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaKH.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=DA_QLBMT;Integrated Security=True";
            string searchText = txtTimKiem.Text.Trim();
            string query = "SELECT * FROM KHACHHANG WHERE MAKH LIKE @SearchText OR HOTEN LIKE @SearchText ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dgvKhachHang.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKhachHang.CurrentRow.Index;
            txtMaKH.Text = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
            cboGT.Text = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
            txtDiachi.Text = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[i].Cells[4].Value.ToString();
            dtpNgaysinh.Text = dgvKhachHang.Rows[i].Cells[5].Value.ToString();
            dtpNgayDK.Text = dgvKhachHang.Rows[i].Cells[6].Value.ToString();
            txtLoaiKH.Text = dgvKhachHang.Rows[i].Cells[7].Value.ToString();
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
            txtMaKH.Enabled = false;
        }
    }
}
