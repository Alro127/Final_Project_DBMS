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
    public partial class Form_ChiTietSPDV : Form
    {
        DA_ChiTietSPDV dA_ChiTiet = new DA_ChiTietSPDV();
        DataTable HinhAnh = new DataTable();
        public Form_ChiTietSPDV(int idSPDV, string isPet)
        {
            InitializeComponent();
            if (isPet == "tc")
            {
                load_giao_dien_thu_cung(idSPDV);
            }
            else if (isPet == "vp")
            {
                load_giao_dien_vat_pham(idSPDV);
            }
            else
            {
                load_giao_dien_dich_vu(idSPDV);
            }
        }

        private void load_giao_dien_dich_vu(int idSPDV)
        {
            DataTable dt = dA_ChiTiet.getChiTietDichVu(idSPDV);
            DataTable hinhanh = dA_ChiTiet.getHinhAnh(idSPDV);
            foreach (DataRow row in dt.Rows)
            {
                rtxt_detail.Clear();
                lbl_ten_spdv.Text = row["Ten"].ToString();
                lbl_gia_ban_goc.Text = Convert.ToDecimal(row["Gia_Ban_Goc"]).ToString("#,0") + "VND";
                lbl_gia_khuyen_mai.Text = Convert.ToDecimal(row["Gia_Khuyen_Mai"]).ToString("#,0") + "VND";
                rtxt_detail.Text += "Mô tả: " + row["Mo_Ta"].ToString() + "\n"; 
                /* lbl_ten_spdv.Text = row["Ten"].ToString();
                 lbl_mo_ta.Text = row["Mo_Ta"].ToString();
                 lbl_gia_ban_goc.Text = Convert.ToDecimal(row["Gia_Ban_Goc"]).ToString("#,0") + "VND";
                 lbl_gia_khuyen_mai.Text = Convert.ToDecimal(row["Gia_Khuyen_Mai"]).ToString("#,0") + "VND";
                 lbl_thuonghieu.Text = row["Thuong_Hieu"].ToString();
                 lbl_hsd.Text = Convert.ToDateTime(row["Han_Su_Dung"]).ToString("dd/MM/yyyy");
                 lbl_tonkho.Text = row["So_Luong_Ton_Kho"].ToString();*/
            }
            ObservableCollection<string> listImg = new ObservableCollection<string>();
            foreach (DataRow item in hinhanh.Rows)
            {
                string link = item["Duong_Dan"].ToString();
                link = imageLinkConverter.Convert(link).ToString();
                listImg.Add(link);

            }
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

        private void load_giao_dien_vat_pham(int idSPDV)
        {
            /* panel_thu_cung.Visible = false;
             panel_vatpham.Visible = true;*/
            DataTable dt = dA_ChiTiet.getChiTietVatPham(idSPDV);
            DataTable hinhanh = dA_ChiTiet.getHinhAnh(idSPDV);
            foreach (DataRow row in dt.Rows)
            {
                rtxt_detail.Clear();
                lbl_ten_spdv.Text = row["Ten"].ToString();
                lbl_gia_ban_goc.Text = Convert.ToDecimal(row["Gia_Ban_Goc"]).ToString("#,0") + "VND";
                lbl_gia_khuyen_mai.Text = Convert.ToDecimal(row["Gia_Khuyen_Mai"]).ToString("#,0") + "VND";
                rtxt_detail.Text += "Mô tả: " + row["Mo_Ta"].ToString() + "\n";
                rtxt_detail.Text += "Thương hiệu: " + row["Thuong_Hieu"].ToString() + "\n";
                if (row["Han_Su_Dung"] != DBNull.Value)
                {
                    rtxt_detail.Text += "Hạn sử dụng: " + Convert.ToDateTime(row["Han_Su_Dung"]).ToString("dd/MM/yyyy") + "\n";
                }
                else
                {
                    rtxt_detail.Text += "Hạn sử dụng: Không có thông tin\n";
                }
                rtxt_detail.Text += "Tồn kho: " + row["So_Luong_Ton_Kho"].ToString() + "\n"; 
                /* lbl_ten_spdv.Text = row["Ten"].ToString();
                 lbl_mo_ta.Text = row["Mo_Ta"].ToString();
                 lbl_gia_ban_goc.Text = Convert.ToDecimal(row["Gia_Ban_Goc"]).ToString("#,0") + "VND";
                 lbl_gia_khuyen_mai.Text = Convert.ToDecimal(row["Gia_Khuyen_Mai"]).ToString("#,0") + "VND";
                 lbl_thuonghieu.Text = row["Thuong_Hieu"].ToString();
                 lbl_hsd.Text = Convert.ToDateTime(row["Han_Su_Dung"]).ToString("dd/MM/yyyy");
                 lbl_tonkho.Text = row["So_Luong_Ton_Kho"].ToString();*/
            }
            ObservableCollection<string> listImg = new ObservableCollection<string>();
            foreach (DataRow item in hinhanh.Rows)
            {
                string link = item["Duong_Dan"].ToString();
                link = imageLinkConverter.Convert(link).ToString();
                listImg.Add(link);

            }
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
        private void load_giao_dien_thu_cung(int idSPDV)
        {
            DataTable dt = dA_ChiTiet.getChiTietThuCung(idSPDV);
            DataTable hinhanh = dA_ChiTiet.getHinhAnh(idSPDV);
            /*panel_thu_cung.Visible = true;
            panel_vatpham.Visible = false;*/
            foreach (DataRow row in dt.Rows)
            {
                lbl_ten_spdv.Text = row["Ten"].ToString();
               /* lbl_mo_ta.Text = row["Mo_Ta"].ToString();*/
                lbl_gia_ban_goc.Text = Convert.ToDecimal(row["Gia_Ban_Goc"]).ToString("#,0") + "VND";
                lbl_gia_khuyen_mai.Text = Convert.ToDecimal(row["Gia_Khuyen_Mai"]).ToString("#,0") + "VND";
               /* lbl_loai.Text = row["Loai"].ToString();
                lbl_giong.Text = row["Giong"].ToString();
                lbl_gioi_tinh.Text = row["Gioi_Tinh"].ToString();
                lbl_mau_sac.Text = row["Mau_Sac"].ToString();
                lbl_can_nang.Text = row["Can_Nang"].ToString() + " kg";
                lbl_so_lan_tiem.Text = row["So_Lan_Tiem"].ToString();
                lbl_ttsk.Text = row["Tinh_Trang_Suc_Khoe"].ToString().ToLower();
                lbl_trang_thai.Text = row["Trang_Thai"].ToString();*/
                string ngaysinh = Convert.ToDateTime(row["Ngay_Sinh"]).ToString("dd/MM/yyyy");
               /* lbl_ngay_sinh.Text = ngaysinh;*/
                rtxt_detail.Clear();
                rtxt_detail.Text += "Loài: " + row["Loai"].ToString() + "\n";
                rtxt_detail.Text += "Giống: " + row["giong"].ToString() + "\n";
                rtxt_detail.Text += "Giới tính: " + row["Gioi_Tinh"].ToString() + "\n";
                rtxt_detail.Text += ngaysinh + "\n";
                rtxt_detail.Text += "Màu sắc: " + row["Mau_Sac"].ToString() + "\n";
                rtxt_detail.Text += "Cân nặng: " + row["Can_Nang"].ToString() + "\n";
                rtxt_detail.Text += "Số lần tiêm: " + row["So_Lan_Tiem"].ToString() + "\n";
                rtxt_detail.Text += "Tình trạng sức khỏe: " + row["Tinh_Trang_Suc_Khoe"].ToString() + "\n";
                rtxt_detail.Text += "Trạng thái: " + row["Trang_Thai"].ToString() + "\n";
                rtxt_detail.Text += "Mô tả: " + row["Mo_Ta"].ToString() + "\n";
            }
            ObservableCollection<string> listImg = new ObservableCollection<string>();
            foreach (DataRow item in hinhanh.Rows)
            {
                string link = item["Duong_Dan"].ToString();
                link = imageLinkConverter.Convert(link).ToString();
                listImg.Add(link);

            }
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
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            pb_main.ImageLocation = picture.ImageLocation;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_gia_ban_goc_Click(object sender, EventArgs e)
        {

        }

        private void lbl_gia_khuyen_mai_Click(object sender, EventArgs e)
        {

        }
    }
}
