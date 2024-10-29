using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_DBMS.DataAccess;

namespace Final_Project_DBMS.View.Screen_PhanCa
{
    public partial class Form_ThemCaLam : Form
    {
        DA_PhanCa dA_PhanCa = new DA_PhanCa();
        public Form_ThemCaLam()
        {
            InitializeComponent();
        }

        private void Form_ThemCaLam_Load(object sender, EventArgs e)
        {
            DataTable dataTable = dA_PhanCa.dataNhanVien();
            foreach (DataRow row in dataTable.Rows)
            {
                cbMaNV.Items.Add(row["Ma_Nhan_Vien"].ToString());
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string buoi = cbBuoiLam.SelectedItem.ToString(); 
            DateTime ngayLamViec = dpNgayLamViec.Value;   
            int maNhanVien = int.Parse(cbMaNV.SelectedItem.ToString());
            dA_PhanCa.ThemCaLam(buoi,ngayLamViec,maNhanVien);
            this.Close();
        }
    }
}
