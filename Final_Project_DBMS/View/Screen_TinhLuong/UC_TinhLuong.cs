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

namespace Final_Project_DBMS.View.Screen_TinhLuong
{
    public partial class UC_TinhLuong : UserControl
    {
        DA_TinhLuong dA_TinhLuong = new DA_TinhLuong();
        public UC_TinhLuong()
        {
            InitializeComponent();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            DataTable dataTable = dA_TinhLuong.LoadDanhSach(dtpStartDate.Value, dtpEndDate.Value);
            dataGridView1.DataSource = dataTable;
        }
    }
}
