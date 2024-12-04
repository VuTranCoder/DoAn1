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
    public partial class frmDangNhap : Form
    {

        List<TaiKhoan> listTaiKhoan = DSTaiKhoan.Instance.ListTaiKhoan; //truy xuat vao list tai khoan thong qua instance
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtDangNhap.Text, txtMatKhau.Text))
            {
                frmGiaoDien f = new frmGiaoDien();
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;

            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Lỗi!");
                txtDangNhap.Focus();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void F_DangXuat(object sender, EventArgs e)
        {
            (sender as frmGiaoDien).isThoat = false;
            (sender as frmGiaoDien).Close();
            this.Show();
        }
        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            for (int i = 0; i < listTaiKhoan.Count; i++)
            {
                if (tentaikhoan == listTaiKhoan[i].TenTaiKhoan && matkhau == listTaiKhoan[i].Matkhau)
                    return true;
            }
            return false;
        }
        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (KiemTraDangNhap(txtDangNhap.Text, txtMatKhau.Text))
                {
                    frmGiaoDien f = new frmGiaoDien();
                    f.Show();
                    this.Hide();
                    f.DangXuat += F_DangXuat;

                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Lỗi!");
                    txtDangNhap.Focus();
                }
            }
        }
    }
}
