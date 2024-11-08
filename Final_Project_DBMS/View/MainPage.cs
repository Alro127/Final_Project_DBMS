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
using Final_Project_DBMS.View.Screen_QuanLy;
using Final_Project_DBMS.View.Screen_BanHang;

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
            UC_BanHang ucBH = new UC_BanHang();
            flpScreen.Controls.Clear();
            flpScreen.Controls.Add(ucBH);
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            UC_QuanLy ucQL = new UC_QuanLy();
            flpScreen.Controls.Clear();
            flpScreen.Controls.Add(ucQL);
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

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
