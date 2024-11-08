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
            this.Close();
            form_DangKy.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
