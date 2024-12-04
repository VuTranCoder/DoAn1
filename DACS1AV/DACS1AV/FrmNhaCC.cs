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
    public partial class FrmNhaCC : Form
    {
        DataTable NHACC;
        public FrmNhaCC()
        {
            InitializeComponent();
        }

        private void FrmNhaCC_Load(object sender, EventArgs e)
        {
            DACS1AV.Function.Connect();
            txtMaNCC.Enabled = false;
            btnLuu.Enabled = false;
            loaddata();
            dgvNhaCC.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            dgvNhaCC.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            dgvNhaCC.Columns[2].HeaderText = "Tên Giao Dịch";
            dgvNhaCC.Columns[3].HeaderText = "Địa Chỉ";
            dgvNhaCC.Columns[4].HeaderText = "Số Điện Thoại";
            dgvNhaCC.Columns[5].HeaderText = "Email";
            dgvNhaCC.Columns[0].Width = 150;
            dgvNhaCC.Columns[1].Width = 150;
            dgvNhaCC.Columns[2].Width = 150;
            dgvNhaCC.Columns[3].Width = 150;
            dgvNhaCC.Columns[4].Width = 120;
            dgvNhaCC.Columns[5].Width = 150;
        }
        void loaddata()
        {
            string sql;
            sql = "SELECT *  FROM NHACC";
            NHACC = DACS1AV.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvNhaCC.DataSource = NHACC; //Nguồn dữ liệu            

            dgvNhaCC.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvNhaCC.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNhaCC.CurrentRow.Index;
            txtMaNCC.Text = dgvNhaCC.Rows[i].Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNhaCC.Rows[i].Cells[1].Value.ToString();
            txtTenGiaoDich.Text = dgvNhaCC.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhaCC.Rows[i].Cells[3].Value.ToString();
            txtDienThoai.Text = dgvNhaCC.Rows[i].Cells[4].Value.ToString();
            txtEmail.Text = dgvNhaCC.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnBoQua.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMaNCC.Enabled = true; //cho phép nhập mới
            txtMaNCC.Focus();
            loaddata();
        }
        private void ResetValue()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtTenGiaoDich.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (NHACC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNCC.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNCC.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenGiaoDich.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDienThoai.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtEmail.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE NHACC SET " +
      "TENNCC=N'" + txtTenNCC.Text.Trim().ToString() + "'," +
      "TENGIAODICH=N'" + txtTenGiaoDich.Text.Trim().ToString() + "'," +
      "DIACHI=N'" + txtDiaChi.Text.Trim().ToString() + "'," +
      "DIENTHOAI=N'" + txtDienThoai.Text.Trim().ToString() + "'," +
      "EMAIL=N'" + txtEmail.Text.Trim().ToString() + "' " + // Đảm bảo dữ liệu nhập là số để tránh lỗi
      "WHERE MANCC=N'" + txtMaNCC.Text + "'";
            DACS1AV.Function.RunSQL(sql);
            loaddata();
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (NHACC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNCC.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE NHACC WHERE MANCC=N'" + txtMaNCC.Text + "'";
                DACS1AV.Function.RunSqlDel(sql);
                loaddata();
                ResetValue();
            }
            else
            {
                MessageBox.Show("Mã Nhà Cung Cấp Không Tồn Tại!", "Lỗi");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=DA_QLBMT;Integrated Security=True";
            string searchText = txtTimKiem.Text.Trim();
            string query = "SELECT * FROM NHACC WHERE MANCC LIKE @SearchText OR TENNCC LIKE @SearchText ";
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
                            dgvNhaCC.DataSource = dataTable;
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
            string sql;
            if (txtMaNCC.Text.Trim().Length == 0 || txtTenNCC.Text.Trim().Length == 0 ||
            txtTenGiaoDich.Text.Trim().Length == 0 || txtDiaChi.Text.Trim().Length == 0 ||
            txtDienThoai.Text.Trim().Length == 0 || txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "Select MANCC From NHACC where MANCC=N'" + txtMaNCC.Text.Trim() + "'";
            if (DACS1AV.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã nhà cung cấp này đã tồn tại,Vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNCC.Focus();
                return;
            }

            sql = "INSERT INTO NHACC VALUES (N'" + txtMaNCC.Text + "', N'" + txtTenNCC.Text + "',N'" + txtTenGiaoDich.Text + "',N'" + txtDiaChi.Text + "',N'" + txtDienThoai.Text + "',N'" + txtEmail.Text + "')";
            DACS1AV.Function.RunSQL(sql); //Thực hiện câu lệnh sql
            loaddata(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNCC.Enabled = false;
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
            txtMaNCC.Enabled = false;
        }


    }
}
