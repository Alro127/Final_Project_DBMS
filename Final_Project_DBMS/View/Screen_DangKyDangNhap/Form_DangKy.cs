using Final_Project_DBMS.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_DBMS.View.Screen_DangKyDangNhap
{
    public partial class Form_DangKy : Form
    {
        public Form_DangKy()
        {
            InitializeComponent();
        }

        private void lblDenDangNhap_Click(object sender, EventArgs e)
        {
            Form_DangNhap form_DangNhap = new Form_DangNhap();
            this.Close();
            form_DangNhap.ShowDialog();

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            DA_TaiKhoan.username = txtTenDangNhap.Text;
            DA_TaiKhoan.password = txtMatKhau.Text;
            DA_TaiKhoan.manv = txtMaNV.Text;
            if ( DA_TaiKhoan.SignUp() == false)
            {
                MessageBox.Show("Đăng ký không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form_DangNhap form_DangNhap = new Form_DangNhap();
            this.Close();
            form_DangNhap.ShowDialog();
        }
    }
}
