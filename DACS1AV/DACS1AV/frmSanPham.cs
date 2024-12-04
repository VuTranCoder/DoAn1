using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACS1AV
{
    public partial class frmSanPham : Form
    {
        DataTable MATHANG;
        DataTable LOAIHANG;
        void loaddataMatHang()
        {
            string sql;
            sql = "SELECT *  FROM MATHANG";
            MATHANG = DACS1AV.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvSanpham.DataSource = MATHANG; //Nguồn dữ liệu            
        }
        void loaddataLoaiHang()
        {
            string sql;
            sql = "SELECT *  FROM LOAIHANG";
            LOAIHANG = DACS1AV.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvLoaiSP.DataSource = LOAIHANG; //Nguồn dữ liệu            
        }
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            DACS1AV.Function.Connect();
            txtMahang.Enabled = false;
            txtMaloai.Enabled = false;
            btnLuu.Enabled = false;
            loaddataMatHang();
            dgvSanpham.Columns[0].HeaderText = "Mã Hàng";
            dgvSanpham.Columns[1].HeaderText = "Mã Loại";
            dgvSanpham.Columns[2].HeaderText = "Mã Nhà Cung Cấp";
            dgvSanpham.Columns[3].HeaderText = "Tên Sản Phẩm";
            dgvSanpham.Columns[4].HeaderText = "Đơn Vị Tính";
            dgvSanpham.Columns[5].HeaderText = "Nước Sản Xuất";
            dgvSanpham.Columns[6].HeaderText = "Giá";
            dgvSanpham.Columns[7].HeaderText = "Ảnh";
            dgvSanpham.Columns[8].HeaderText = "Ghi Chú";
            dgvSanpham.Columns[9].HeaderText = "Số Lượng";
            dgvSanpham.Columns[0].Width = 100;
            dgvSanpham.Columns[1].Width = 100;
            dgvSanpham.Columns[2].Width = 100;
            dgvSanpham.Columns[3].Width = 200;
            dgvSanpham.Columns[4].Width = 150;
            dgvSanpham.Columns[5].Width = 150;
            dgvSanpham.Columns[6].Width = 100;
            dgvSanpham.Columns[7].Width = 100;
            dgvSanpham.Columns[8].Width = 100;
            dgvSanpham.Columns[9].Width = 100;
            dgvSanpham.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvSanpham.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
            loaddataLoaiHang();
            dgvLoaiSP.Columns[0].HeaderText = "Mã Loại";
            dgvLoaiSP.Columns[1].HeaderText = "Tên Loại";
            dgvLoaiSP.Columns[0].Width = 300;
            dgvLoaiSP.Columns[1].Width = 300;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnBoQua.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMahang.Enabled = true; //cho phép nhập mới
            txtMaloai.Enabled = true;
            txtMaloai.Focus();
            txtMahang.Focus();
            loaddataMatHang();
            loaddataLoaiHang();
        }
        private void ResetValue()
        {
            txtMahang.Text = "";
            txtMaloai.Text = "";
            txtMancc.Text = "";
            txtTenSP.Text = "";
            txtDVT.Text = "";
            txtNuocSX.Text = "";
            txtGiaTien.Text = "";
            txtMaLoaiSP.Text = "";
            txtTenLoai.Text = "";
            txtAnh.Text = "";
            picAnh.Image = null;
            txtGhiChu.Text = "";
            txtSL.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (ConditionCheck())
            {
                if (MATHANG.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMahang.Text == "") //nếu chưa chọn bản ghi nào
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMaloai.Text == "") //nếu chưa chọn bản ghi nào
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMancc.Text == "") //nếu chưa chọn bản ghi nào
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTenSP.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
                {
                    MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtDVT.Text == "") //nếu chưa chọn bản ghi nào
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtNuocSX.Text == "") //nếu chưa chọn bản ghi nào
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtGiaTien.Text == "") //nếu chưa chọn bản ghi nào
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtAnh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAnh.Focus();
                    return;
                }
                if (txtSL.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập vào số lượng cho mặt hàng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAnh.Focus();
                    return;
                }

                sql = "UPDATE MATHANG SET " +
        "TENSP=N'" + txtTenSP.Text.Trim().ToString() + "'," +
        "DVT=N'" + txtDVT.Text.Trim().ToString() + "'," +
        "NUOCSX=N'" + txtNuocSX.Text.Trim().ToString() + "'," +
        "GIA=N'" + txtGiaTien.Text.Trim().ToString() + "'," +
        "ANH=N'" + txtAnh.Text.Trim().ToString() + "'," +
        "GHICHU=N'" + txtGhiChu.Text.Trim().ToString() + "'," +
        "SOLUONG=N'" + txtSL.Text.Trim().ToString() + "' " + // Đảm bảo dữ liệu nhập là số để tránh lỗi
        "WHERE MAHANG=N'" + txtMahang.Text + "'";
                DACS1AV.Function.RunSQL(sql);
                loaddataMatHang();
                ResetValue();
            }
            else
            {
                if (LOAIHANG.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMaLoaiSP.Text == "") //nếu chưa chọn bản ghi nào
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTenLoai.Text == "") //nếu chưa chọn bản ghi nào
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql = "UPDATE LOAIHANG SET TENLOAI=N'" +
             txtTenLoai.Text.ToString() +
              "' WHERE MALOAI=N'" + txtMaLoaiSP.Text + "'";
                DACS1AV.Function.RunSQL(sql);
                loaddataMatHang();
                ResetValue();
                btnBoQua.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (ConditionCheck())
            {
                if (MATHANG.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMahang.Text == "") //nếu chưa chọn bản ghi nào
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql = "DELETE MATHANG WHERE MAHANG=N'" + txtMahang.Text + "'";
                    DACS1AV.Function.RunSqlDel(sql);
                    loaddataMatHang();
                    ResetValue();
                }
                else
                {
                    MessageBox.Show("Mã Sản Phẩm Không Tồn Tại!", "Lỗi");
                }
            }
            else
            {
                if (LOAIHANG.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMaLoaiSP.Text == "") //nếu chưa chọn bản ghi nào
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql = "DELETE LOAIHANG WHERE MALOAI=N'" + txtMaLoaiSP.Text + "'";
                    DACS1AV.Function.RunSqlDel(sql);
                    loaddataLoaiHang();
                    ResetValue();
                }
                else
                {
                    MessageBox.Show("Mã Loại Hàng Không Tồn Tại!", "Lỗi");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI\\MSI;Initial Catalog=DA_QLBMT;Integrated Security=True";
            string searchText = txtTimKiem.Text.Trim();
            string query = "SELECT * FROM MATHANG WHERE MAHANG LIKE @SearchText OR MALOAI LIKE @SearchText OR MANCC LIKE @SearchText";

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
                            dgvSanpham.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (ConditionCheck())
            {
                if (txtMahang.Text.Trim().Length == 0 || txtMaloai.Text.Trim().Length == 0 ||
            txtMancc.Text.Trim().Length == 0 || txtTenSP.Text.Trim().Length == 0 ||
            txtDVT.Text.Trim().Length == 0 || txtNuocSX.Text.Trim().Length == 0 ||
            txtGiaTien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql = "Select MAHANG From MATHANG where MAHANG=N'" + txtMahang.Text.Trim() + "'";
                if (DACS1AV.Function.CheckKey(sql))
                {
                    MessageBox.Show("Mã hàng này đã tồn tại,Vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMahang.Focus();
                    return;
                }

                sql = "INSERT INTO MATHANG VALUES (N'" + txtMahang.Text + "', N'" + txtMaloai.Text + "',N'" + txtMancc.Text + "',N'" + txtTenSP.Text + "',N'" + txtDVT.Text + "',N'" + txtNuocSX.Text + "',N'" + txtGiaTien.Text + "',N'" + txtAnh.Text + "',N'" + txtGhiChu.Text + "',N'" + txtSL.Text + "')";
                DACS1AV.Function.RunSQL(sql); //Thực hiện câu lệnh sql
                loaddataMatHang(); //Nạp lại DataGridView
                ResetValue();
            }
            else
            {
                sql = "Select MALOAI from LOAIHANG where MALOAI=N'" + txtMaLoaiSP.Text.Trim() + "'";
                if (DACS1AV.Function.CheckKey(sql))
                {
                    MessageBox.Show("Mã loại này đã tồn tại,Vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaLoaiSP.Focus();
                    return;
                }
                sql = "INSERT INTO LOAIHANG VALUES(N'" + txtMaLoaiSP.Text + "',N'" + txtTenLoai.Text + "')";
                DACS1AV.Function.RunSQL(sql);
                loaddataLoaiHang();
                ResetValue();
            }
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMahang.Enabled = false;
            btnLuu.Enabled = false;
        }
        private bool ConditionCheck()
        {
            if (!string.IsNullOrEmpty(txtMahang.Text))
            {
                return true; // Trả về true nếu điều kiện được thoả mãn để thêm dữ liệu vào bảng MATHANG
            }
            else
            {
                return false; // Trả về false nếu không thoả mãn điều kiện để thêm vào bảng MATHANG
            }
        }

        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMahang.Focus();
                return;
            }
            if (MATHANG.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int i;
            i = dgvSanpham.CurrentRow.Index;
            txtMahang.Text = dgvSanpham.Rows[i].Cells[0].Value.ToString();
            txtMaloai.Text = dgvSanpham.Rows[i].Cells[1].Value.ToString();
            txtMancc.Text = dgvSanpham.Rows[i].Cells[2].Value.ToString();
            txtTenSP.Text = dgvSanpham.Rows[i].Cells[3].Value.ToString();
            txtDVT.Text = dgvSanpham.Rows[i].Cells[4].Value.ToString();
            txtNuocSX.Text = dgvSanpham.Rows[i].Cells[5].Value.ToString();
            txtGiaTien.Text = dgvSanpham.Rows[i].Cells[6].Value.ToString();
            txtAnh.Text = dgvSanpham.Rows[i].Cells[7].Value.ToString();
            txtGhiChu.Text = dgvSanpham.Rows[i].Cells[8].Value.ToString();
            txtSL.Text = dgvSanpham.Rows[i].Cells[9].Value.ToString();
            sql = "SELECT ANH FROM MATHANG WHERE MAHANG=N'" + txtMahang.Text + "'";
            txtAnh.Text = DACS1AV.Function.GetFieldValues(sql);
            if (!string.IsNullOrEmpty(txtAnh.Text) && File.Exists(txtAnh.Text))
            {
                picAnh.Image = Image.FromFile(txtAnh.Text);
            }
            string sqlnote;
            sqlnote = "SELECT GHICHU FROM MATHANG WHERE MAHANG = N'" + txtMahang.Text + "'";
            txtGhiChu.Text = DACS1AV.Function.GetFieldValues(sqlnote);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void dgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaloai.Focus();
                return;
            }
            if (LOAIHANG.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int j;
            j = dgvLoaiSP.CurrentRow.Index;
            txtMaLoaiSP.Text = dgvLoaiSP.Rows[j].Cells[0].Value.ToString();
            txtTenLoai.Text = dgvLoaiSP.Rows[j].Cells[1].Value.ToString();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMahang.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }
    }
}
