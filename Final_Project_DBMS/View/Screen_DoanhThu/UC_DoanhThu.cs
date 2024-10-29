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

namespace Final_Project_DBMS.View.Screen_DoanhThu
{
    public partial class UC_DoanhThu : UserControl
    {
        DA_DoanhThu dA_DoanhThu = new DA_DoanhThu();
        decimal tongTien = 0;
        public UC_DoanhThu()
        {
            InitializeComponent();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            
            DataTable dataTable = dA_DoanhThu.LoadDanhSach(dtpStartDate.Value, dtpEndDate.Value, ref tongTien);
            dataGridView1.DataSource = dataTable;
            lblTotalAmount.Text = $"Tổng Tiền: {tongTien:F0} VNĐ";
        }
    }
}
