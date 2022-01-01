using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoopFood
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
          
        }

 

        private void formNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
          
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            formTrangChu.Show();
            formSanPham.Hide();
            formKhachHang.Hide();
            formHoaDon.Hide();
            formNhanVien.Hide();
            formThongKe.Hide();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            formTrangChu.Hide();
            formSanPham.Show();
            formKhachHang.Hide();
            formHoaDon.Hide();
            formNhanVien.Hide();
            formThongKe.Hide();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            formTrangChu.Hide();
            formSanPham.Hide();
            formKhachHang.Show();
            formHoaDon.Hide();
            formNhanVien.Hide();
            formThongKe.Hide();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            formTrangChu.Hide();
            formSanPham.Hide();
            formKhachHang.Hide();
            formHoaDon.Show();
            formNhanVien.Hide();
            formThongKe.Hide();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            formTrangChu.Hide();
            formSanPham.Hide();
            formKhachHang.Hide();
            formHoaDon.Hide();
            formNhanVien.Show();
            formThongKe.Hide();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            formTrangChu.Hide();
            formSanPham.Hide();
            formKhachHang.Hide();
            formHoaDon.Hide();
            formNhanVien.Hide();
            formThongKe.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void formThongKe_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formNhanVien_Load_1(object sender, EventArgs e)
        {

        }

        private void formHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void formKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void formSanPham_Load(object sender, EventArgs e)
        {

        }

        private void formTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
