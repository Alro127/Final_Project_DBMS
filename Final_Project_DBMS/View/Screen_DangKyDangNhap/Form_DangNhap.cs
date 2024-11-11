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
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void lblDenDangKy_Click(object sender, EventArgs e)
        {
            Form_DangKy form_DangKy = new Form_DangKy();
            form_DangKy.ShowDialog();
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Lấy thông tin đăng nhập từ các ô nhập liệu
            DA_TaiKhoan.username = txtTenDangNhap.Text;
            DA_TaiKhoan.password = txtMatKhau.Text;

            // Gọi phương thức getQuyen để lấy quyền của tài khoản
            DA_TaiKhoan.permission = DA_TaiKhoan.getQuyen();

            // Kiểm tra nếu quyền không phải là "No Access"
            if (DA_TaiKhoan.permission != "No Access")
            {
                MainPage mainPage = new MainPage();
                mainPage.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
