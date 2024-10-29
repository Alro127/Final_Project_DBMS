using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_DBMS.View.Screen_PhanCa;
using Final_Project_DBMS.View.Screen_TinhLuong;
using Final_Project_DBMS.View.Screen_DoanhThu;

namespace Final_Project_DBMS.View
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {

        }

        private void btnPhanCa_Click(object sender, EventArgs e)
        {
            UC_PhanCa ucPC = new UC_PhanCa();
            flpScreen.Controls.Clear();
            flpScreen.Controls.Add(ucPC);
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            UC_TinhLuong ucTL = new UC_TinhLuong();
            flpScreen.Controls.Clear();
            flpScreen.Controls.Add(ucTL);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            UC_DoanhThu ucDT = new UC_DoanhThu();
            flpScreen.Controls.Clear();
            flpScreen.Controls.Add(ucDT);
        }
    }
}
