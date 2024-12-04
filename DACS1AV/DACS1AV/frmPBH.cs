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
    public partial class frmPBH : Form
    {
        DataTable PHIEUBAOHANH;
        public frmPBH()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            string sql;
            sql = "Select * from PHIEUBAOHANH";
            PHIEUBAOHANH = Function.GetDataToTable(sql);
            dgvPBH.DataSource = PHIEUBAOHANH;
            dgvPBH.Columns[0].HeaderText = "Mã Phiếu Bảo Hành";
            dgvPBH.Columns[1].HeaderText = "Mã Hàng";
            dgvPBH.Columns[2].HeaderText = "Thời Gian Bảo Hành";
            dgvPBH.Columns[3].HeaderText = "Số Hóa Đơn";
            dgvPBH.Columns[0].Width = 150;
            dgvPBH.Columns[1].Width = 150;
            dgvPBH.Columns[2].Width = 150;
            dgvPBH.Columns[3].Width = 220;
            dgvPBH.AllowUserToAddRows = false;
            dgvPBH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void frmPBH_Load(object sender, EventArgs e)
        {
            DACS1AV.Function.Connect();
            txtPBH.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            Function.FillCombo("SELECT MAHANG,TENSP FROM MATHANG", cboMH, "MAHANG", "MAHANG");
            cboMH.SelectedIndex = -1;
            Function.FillCombo("SELECT SOHD FROM HOADON", cboSHD, "SOHD", "SOHD");
            cboSHD.SelectedIndex = -1;
            if (txtPBH.Text != "")
            {
                btnXoa.Enabled = true;
                btnLuu.Enabled = true;
            }
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnBoQua.Enabled = true;
            ResetValues();
            txtPBH.Text = Function.CreateKey("BH");
            loaddata();
        }
        private void ResetValues()
        {
            txtPBH.Text = "";
            txtTG.Text = "";
            cboSHD.Text = "";
            cboMH.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtPBH.Text.Trim().Length == 0 || cboMH.Text.Trim().Length == 0 ||
           cboSHD.Text.Trim().Length == 0 || txtTG.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "Select MAPBH From PHIEUBAOHANH where MAPBH=N'" + txtPBH.Text.Trim() + "'";
            if (DACS1AV.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã phiếu bảo hành  này đã tồn tại,Vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPBH.Focus();
                return;
            }

            sql = "INSERT INTO PHIEUBAOHANH VALUES (N'" + txtPBH.Text + "', N'" + cboMH.Text + "',N'" + txtTG.Text + "',N'" + cboSHD.Text + "')";
            DACS1AV.Function.RunSQL(sql); //Thực hiện câu lệnh sql
            loaddata(); //Nạp lại DataGridView
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtPBH.Enabled = false;
        }

        private void cboSHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboSHD.Text == "")
            {
                cboMH.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT MAHANG FROM CTHD  WHERE SOHD =N'" + cboSHD.SelectedValue + "'";
            cboMH.Text = Function.GetFieldValues(str);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (PHIEUBAOHANH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboMH.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboSHD.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTG.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPBH.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn phải nhập mã phiếu bảo hành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE PHIEUBAOHANH SET " +
       "THOIGIANBH=N'" + txtTG.Text.Trim().ToString() + "' " +
       "WHERE MAPBH=N'" + txtPBH.Text + "'";
           DACS1AV.Function.RunSQL(sql);
            loaddata();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (PHIEUBAOHANH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPBH.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE PHIEUBAOHANH WHERE MAPBH=N'" + txtPBH.Text + "'";
                DACS1AV.Function.RunSqlDel(sql);
                loaddata();
                ResetValues();
            }
            else
            {
                MessageBox.Show("Mã Khách Hàng Không Tồn Tại!", "Lỗi");
            }
        }

        private void dgvPBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvPBH.CurrentRow.Index;
            txtPBH.Text = dgvPBH.Rows[i].Cells[0].Value.ToString();
            cboMH.Text = dgvPBH.Rows[i].Cells[1].Value.ToString();
            txtTG.Text = dgvPBH.Rows[i].Cells[2].Value.ToString();
            cboSHD.Text = dgvPBH.Rows[i].Cells[1].Value.ToString();
            btnXoa.Enabled = true;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtPBH.Enabled = false;
        }
    }
}
