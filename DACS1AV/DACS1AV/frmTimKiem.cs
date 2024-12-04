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
    public partial class frmTimKiem : Form
    {
        DataTable HOADON;
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            DACS1AV.Function.Connect();
            ResetValues();
            dgvTKHD.DataSource = null;
            Function.FillCombo("SELECT SOHD FROM HOADON ", cboSHD, "SOHD", "SOHD");
            cboSHD.SelectedIndex = -1;
        }
        private void ResetValues()
        {
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                    ctl.Text = "";
            cboSHD.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboSHD.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtMNV.Text == "") && (txtMKH.Text == "") &&
               (txtTT.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM HOADON WHERE 1=1";
            if (cboSHD.Text != "")
                sql = sql + " AND SOHD Like N'%" + cboSHD.Text + "%'";
            if (txtThang.Text != "")
                sql = sql + " AND MONTH(NGHD) =" + txtThang.Text;
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(NGHD) =" + txtNam.Text;
            if (txtMNV.Text != "")
                sql = sql + " AND MANV Like N'%" + txtMNV.Text + "%'";
            if (txtMKH.Text != "")
                sql = sql + " AND MAKH Like N'%" + txtMKH.Text + "%'";
            if (txtTT.Text != "")
                sql = sql + " AND TRIGIA <=" + txtTT.Text;
            HOADON = Function.GetDataToTable(sql);
            if (HOADON.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + HOADON.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvTKHD.DataSource = HOADON;
            loaddata();
        }
        private void loaddata()
        {
            dgvTKHD.Columns[0].HeaderText = "Số Hóa Đơn";
            dgvTKHD.Columns[1].HeaderText = "Ngày Bán";
            dgvTKHD.Columns[2].HeaderText = "Mã Nhân Viên";
            dgvTKHD.Columns[3].HeaderText = "Mã Khách Hàng";
            dgvTKHD.Columns[4].HeaderText = "Tổng tiền";
            dgvTKHD.Columns[0].Width = 200;
            dgvTKHD.Columns[1].Width = 100;
            dgvTKHD.Columns[2].Width = 100;
            dgvTKHD.Columns[3].Width = 100;
            dgvTKHD.Columns[4].Width = 150;
            dgvTKHD.AllowUserToAddRows = false;
            dgvTKHD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvTKHD.DataSource = null;
        }

        private void txtTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgvTKHD_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = dgvTKHD.CurrentRow.Cells["SOHD"].Value.ToString();
                frmHoaDon frm = new frmHoaDon();
                frm.txtSHD.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
