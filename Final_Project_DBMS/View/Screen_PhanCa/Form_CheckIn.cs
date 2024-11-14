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

namespace Final_Project_DBMS.View.Screen_PhanCa
{
    public partial class Form_CheckIn : Form
    {
        DataRow row;
        public Form_CheckIn(DataRow row)
        {
            InitializeComponent();
            this.row = row;
        }

        private void Form_CheckIn_Load(object sender, EventArgs e)
        {
            lbl_MaNV.Text = row["Ma_Nhan_Vien"].ToString();
            lbl_BuoiLam.Text = row["Buoi"].ToString();
            lbl_NgayLamViec.Text = row["Ngay_Lam_Viec"].ToString();
            if (row["Check_In"].ToString() != "")
            {
                lbl_CheckIn.Text = row["Check_In"].ToString();
                btn_CheckIn.Enabled = false;
                btn_CheckIn.Text = "Đã check in";
            }     
        }

        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            DA_PhanCa dA_PhanCa = new DA_PhanCa();
            dA_PhanCa.CheckIn(row);
        }
    }
}
