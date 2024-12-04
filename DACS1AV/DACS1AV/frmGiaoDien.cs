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
    public partial class frmGiaoDien : Form
    {
        public bool isThoat = true;
        public frmGiaoDien()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
            lblHome.Text = btnNhanVien.Text;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
            lblHome.Text = btnKhachHang.Text;
        }

        private void btnMatHang_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.ShowDialog();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhaCC());
            lblHome.Text = btnNCC.Text;
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
            lblHome.Text = btnHoadon.Text;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTimKiem());
            lblHome.Text = btnTK.Text;
        }

        private void btnPBH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPBH());
            lblHome.Text = btnPBH.Text;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }
        public event EventHandler DangXuat;//uy thac'
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void frmGiaoDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình", "Cảnh Báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void frmGiaoDien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lblHome.Text = "Màn Hình Chính";
        }
    }
   }