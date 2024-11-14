using Final_Project_DBMS.control.converter;
using Final_Project_DBMS.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_DBMS.View.Screen_BanHang
{
    public partial class Form_ChiTietDichVu : Form
    {
        int currentID = 0;
        int currentRoomID = 0;
        DA_ChiTietSPDV dA_ChiTiet = new DA_ChiTietSPDV();
        public Form_ChiTietDichVu(int idSPDV)
        {
            InitializeComponent();
            currentID = idSPDV;
            load_giao_dien();
        }
        private void load_giao_dien()
        {
            load_giao_dien_dich_vu();
            load_thongtin_phong();
        }

        private void load_thongtin_phong()
        {
            DataTable dt = dA_ChiTiet.layThongTinPhong(currentID);
            dg_dsPhong.DataSource = dt;
        }

        private void load_giao_dien_dich_vu()
        {
            DataTable dt = dA_ChiTiet.layChiTietDichVu(currentID);
            DataTable hinhanh = dA_ChiTiet.layHinhanh(currentID);
            foreach (DataRow row in dt.Rows)
            {
                rtxt_detail.Clear();
                lbl_ten_spdv.Text = row["Ten"].ToString();
                lbl_gia_ban_goc.Text = Convert.ToDecimal(row["Gia_Ban_Goc"]).ToString("#,0") + "VND";
                lbl_gia_khuyen_mai.Text = Convert.ToDecimal(row["Gia_Khuyen_Mai"]).ToString("#,0") + "VND";
                rtxt_detail.Text += "Số lượng phòng trống: " + row["So_Luong_Phong_Trong"].ToString() + "\n";
                rtxt_detail.Text += "Mô tả: " + row["Mo_Ta"].ToString() + "\n";

            }
            ObservableCollection<string> listImg = new ObservableCollection<string>();
            foreach (DataRow item in hinhanh.Rows)
            {
                string link = item["Duong_Dan"].ToString();
                link = imageLinkConverter.Convert(link).ToString();
                listImg.Add(link);

            }
            if (listImg.Count > 0)
            {
                pb_main.ImageLocation = listImg[0];
                pb_main.SizeMode = PictureBoxSizeMode.StretchImage;
                foreach (string item in listImg)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.ImageLocation = item;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Click += PictureBox_Click;
                    flp_hinhanh.Controls.Add(pictureBox);
                }
            }        
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            pb_main.ImageLocation = picture.ImageLocation;
        }
        private void tc_chitietdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc_chitietdv.SelectedIndex == 0)
            {
                load_giao_dien_dich_vu();
            }
            else
                load_thongtin_phong();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (dg_dsPhong.SelectedRows.Count == 0)
                return;
            string trangthai = "";
            if (cb_trangthai.SelectedIndex == 0)
            {
                trangthai = "Sẵn sàng";
            }
            else
            {
                trangthai = "Chưa sẵn sàng";
            }
            string idphong = currentRoomID.ToString();
            string sqlcmd = "proc_CapNhatTrangThaiPhongDichVu";
            string[] paramNames = { "@idphongdv", "@trangthai" };
            object[] paramValues = { idphong, trangthai };
            dA_ChiTiet.capNhatTrangThaiPhongDichVu(sqlcmd, paramNames, paramValues);
            load_giao_dien();

        }

        private void dg_dsPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dg_dsPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_dsPhong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dg_dsPhong.Rows.Count - 1)
            {
                // Lấy hàng được click từ DataGridView
                DataGridViewRow row = dg_dsPhong.Rows[e.RowIndex];
                // Gán giá trị cho các nhãn từ các ô trong dòng
                if (row.Cells["Trang_Thai"].Value.ToString() == "Sẵn sàng")
                    cb_trangthai.SelectedIndex = 0;
                else
                    cb_trangthai.SelectedIndex = 1;
                currentRoomID = Convert.ToInt32(row.Cells["Ma_Phong"].Value);

            }
        }
    }
}
