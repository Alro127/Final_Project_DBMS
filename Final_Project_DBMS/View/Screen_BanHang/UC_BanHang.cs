using Final_Project_DBMS.control.converter;
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
    public partial class UC_BanHang : UserControl
    { 
        DataTable dt_thucung = new DataTable();
        DataTable dt_vatpham = new DataTable();
        DataTable dt_dichvu = new DataTable();
        int IDHoaDonHienTai = -1;
        decimal tongtien = 0;
        string sortOrderGiaTien = null;
        string sortOrderTen = null;
        string tuKhoa = null;
        string startingValue = null;
        string endingValue = null;
        string tenView = null;
        DA_BanHang dA_BanHang = new DA_BanHang();
        public UC_BanHang()
        {
            InitializeComponent();

        }
        private void UC_BanHang_Load(object sender, EventArgs e)
        {
            san_pham_va_dich_vu_Load();
        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void san_pham_va_dich_vu_Load()
        {
            if (startingValue != null && endingValue != null)
            {
                txt_gia_bat_dau.Text = startingValue.ToString();
                txt_gia_ket_thuc.Text = endingValue.ToString();
            }

            cb_gia.SelectedIndex = 0;
            cb_alphabet.SelectedIndex = 0;
            imageList.Images.Add(Image.FromFile(dA_BanHang.getSearchBTNIcon()));
            btn_tim_kiem.ImageList = imageList;
            btn_tim_kiem.Image = imageList.Images[0];
            lv_hoa_don.View = System.Windows.Forms.View.Details;
            // Thêm các cột vào ListView
            thu_cung_load();
            vat_pham_load();
            dich_vu_Load();

        }
        private void dich_vu_Load(DataTable dichvu = null)
        {
            if (dichvu == null)
            {
                dt_dichvu = dA_BanHang.getView("view_DanhSachPhongDichVu");
            }
            else
            {
                dt_dichvu = dichvu;
            }
            flp_dichvu.Controls.Clear();
            foreach (DataRow row in dt_dichvu.Rows)
            {
                int id = Convert.ToInt32(row["Ma_Dich_Vu"]);
                string name = row["Ten_Dich_Vu"].ToString();
                decimal giagoc = Convert.ToDecimal(row["Gia_Ban_Goc"]);
                decimal giauudai = Convert.ToDecimal(row["Gia_Khuyen_Mai"]);
                DataTable temp = dA_BanHang.getHinhAnhSPDV(id);
                DataRow dataRow = temp.Rows[0];
                string link = dataRow["Duong_Dan"].ToString();
                link = imageLinkConverter.Convert(link).ToString();
                int sophongtrong = Convert.ToInt16(row["So_Luong_Phong_Trong"]);
                UC_DichVuCard cardvatpham = new UC_DichVuCard(id, name, giagoc, giauudai, link, sophongtrong);
                /*cardvatpham.addHoaDon += AddHoaDon;*/
                cardvatpham.chitietvatpham += ChiTietVatPham;
                flp_dichvu.Controls.Add(cardvatpham);
            }
        }
        private void vat_pham_load(DataTable vatpham = null)
        {
            if (vatpham == null)
            {
                dt_vatpham = dA_BanHang.getView("view_DanhSachVatPham");
            }
            else
            {
                dt_vatpham = vatpham;
            }
            flp_vatpham.Controls.Clear();
            foreach (DataRow row in dt_vatpham.Rows)
            {
                int id = Convert.ToInt32(row["Ma_Vat_Pham"]);
                string name = row["Ten_San_Pham"].ToString();
                decimal giagoc = Convert.ToDecimal(row["Gia_Ban_Goc"]);
                decimal giauudai = Convert.ToDecimal(row["Gia_Khuyen_Mai"]);
                DataTable temp = dA_BanHang.getHinhAnhSPDV(id);
                DataRow dataRow = temp.Rows[0];
                string link = dataRow["Duong_Dan"].ToString();
                link = imageLinkConverter.Convert(link).ToString();
                UC_SanPhamCard cardvatpham = new UC_SanPhamCard(id, name, giagoc, giauudai, link);
                /*cardvatpham.addHoaDon += AddHoaDon;*/
                cardvatpham.chitietvatpham += ChiTietVatPham;
                flp_vatpham.Controls.Add(cardvatpham);
            }
        }

        private void thu_cung_load(DataTable thucung = null)
        {
            if (thucung == null)
            {
                dt_thucung = dA_BanHang.getView("view_DanhSachThuCung");
            }
            else
            {
                dt_thucung = thucung;
            }
            flp_thu_cung.Controls.Clear();
            foreach (DataRow row in dt_thucung.Rows)
            {
                int id = Convert.ToInt32(row["Mã Thú Cưng"]);
                string name = row["Tên Thú Cưng"].ToString();
                decimal giagoc = Convert.ToDecimal(row["Giá Bán Gốc"]);
                decimal giauudai = Convert.ToDecimal(row["Giá Khuyến Mại"]);
                DataTable temp = dA_BanHang.getHinhAnhSPDV(id);
                DataRow dataRow = temp.Rows[0];
                string link = dataRow["Duong_Dan"].ToString();
                link = imageLinkConverter.Convert(link).ToString();

                UC_SanPhamCard cardvatpham = new UC_SanPhamCard(id, name, giagoc, giauudai, link);
                /*cardvatpham.addHoaDon += AddHoaDon;*/
                cardvatpham.chitietvatpham += ChiTietVatPham;
                flp_thu_cung.Controls.Add(cardvatpham);
            }
        }
        private void ChiTietVatPham(object sender, EventArgs e)
        {
            
            if (tb_types.SelectedIndex == 0)
            {
                UC_SanPhamCard cardvatpham = (UC_SanPhamCard)sender;
                Form_ChiTietSPDV chitietvatphamthucung = new Form_ChiTietSPDV(cardvatpham.Id, "tc");
                chitietvatphamthucung.ShowDialog();
            }
            else if (tb_types.SelectedIndex == 1)
            {
                UC_SanPhamCard cardvatpham = (UC_SanPhamCard)sender;
                Form_ChiTietSPDV chitietvatphamthucung = new Form_ChiTietSPDV(cardvatpham.Id, "vp");
                chitietvatphamthucung.ShowDialog();
            }
            else
            {
                UC_DichVuCard cardvatpham = (UC_DichVuCard)sender;
                Form_ChiTietSPDV chitietvatphamthucung = new Form_ChiTietSPDV(cardvatpham.Id, "dv");
                chitietvatphamthucung.ShowDialog();
            }
        }
        private string getValueCBGiaTien()
        {
            switch (cb_gia.SelectedIndex)
            {
                case 0:
                    return null;
                case 1:
                    return "ASC";
                case 2:
                    return "DESC";
                default:
                    return null;
            }
        }
        private string getValueCBTen()
        {
            switch (cb_alphabet.SelectedIndex)
            {
                case 0:
                    return null;
                case 1:
                    return "ASC";
                case 2:
                    return "DESC";
                default:
                    return null;
            }
        }
        private void txt_tim_kiem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_tim_kiem.Clear();
        }
        private void getAllInfoSearching()
        {
            // Kiểm tra xem là tab thú cưng hay vật phẩm để có tên view
            switch (tb_types.SelectedIndex)
            {
                case 0:
                    tenView = "view_DanhSachThuCung";
                    break;
                case 1:
                    tenView = "view_DanhSachVatPham";
                    break;
                default:
                    tenView = null;
                    break;
            }

            // Kiểm tra cb giá
            sortOrderGiaTien = getValueCBGiaTien();

            // Kiểm tra cb tên
            sortOrderTen = getValueCBTen();

            // Kiểm tra từ khóa
            tuKhoa = txt_tim_kiem.Text;

            // Kiểm tra giá bắt đầu
            startingValue = txt_gia_bat_dau.Text;

            // Kiểm tra giá kết thúc
            endingValue = txt_gia_ket_thuc.Text;
        }
        private void TimKiem()
        {
            getAllInfoSearching();
            if (tb_types.SelectedIndex == 0)
            {
                dt_thucung = dA_BanHang.TimKiem(tenView, "Tên Thú Cưng", tuKhoa, startingValue, endingValue,
                sortOrderGiaTien, sortOrderTen, "Giá Khuyến Mại");
                thu_cung_load(dt_thucung);
            }
            else if (tb_types.SelectedIndex == 1)
            {
                dt_vatpham = dA_BanHang.TimKiem(tenView, "Ten_San_Pham", tuKhoa, startingValue, endingValue,
                sortOrderGiaTien, sortOrderTen);
                vat_pham_load(dt_vatpham);
            }         
        }
        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void cb_alphabet_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void cb_gia_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void btn_chon_khoang_gia_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void tb_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}
