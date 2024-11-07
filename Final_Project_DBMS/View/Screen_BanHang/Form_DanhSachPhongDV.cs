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

namespace Final_Project_DBMS.View.Screen_BanHang
{
    public partial class Form_DanhSachPhongDV : Form
    {
        string inititalState = "";
        string eventualState = "";
        DA_ChiTietSPDV dA = new DA_ChiTietSPDV();
        int idDV = 0;
        int currentRoomID = 0;
        public Form_DanhSachPhongDV(int iDDV)
        {
            InitializeComponent();
            IdDV = iDDV;
            load_phong_dich_vu();
        }

        private void load_phong_dich_vu()
        {
            gv_phongdv.DataSource = dA.taiPhongDichVu(idDV);
        }

        public int IdDV { get => idDV; set => idDV = value; }

 

        private void gv_phongdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cb_trangthai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (gv_phongdv.SelectedRows.Count == 0)
                return;
            string trangthai = "";
            if (cb_trangthai.SelectedIndex == 0)
            {
                trangthai = "Sẵn sàng";
                eventualState = trangthai;
            }
            else
            {
                trangthai = "Chưa sẵn sàng";
                eventualState = trangthai;
            }
            string idphong = currentRoomID.ToString();
            string sqlcmd = "proc_CapNhatTrangThaiPhongDichVu";
            string[] paramNames = { "@idphongdv", "@trangthai" };
            object[] paramValues = { idphong, trangthai };
            dA.capNhatTrangThaiPhongDichVu(sqlcmd, paramNames, paramValues);
            this.Close();
        }

        private void gv_phongdv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được click từ DataGridView
                DataGridViewRow row = gv_phongdv.Rows[e.RowIndex];
                // Gán giá trị cho các nhãn từ các ô trong dòng
                if (row.Cells["Trang_Thai"].Value.ToString() == "Sẵn sàng")
                {
                    cb_trangthai.SelectedIndex = 0;
                    inititalState = "Sẵn sàng";
                }
                else
                {
                    cb_trangthai.SelectedIndex = 1;
                    inititalState = "Chưa sẵn sàng";
                }
                currentRoomID = Convert.ToInt32(row.Cells["Ma_Phong"].Value);
               
            }
        }
        public void layGiaTriTrangThai(ref string inititalState, ref string eventualState)
        {
            inititalState = this.inititalState;
            eventualState = this.eventualState;
        }
    }
}
