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
        string idkhachhang = "0";
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
            tao_hoa_don_Load();
            hoa_don_Load();
            khach_hang_Load();
        }

        private void hoa_don_Load()
        {
            gv_hoadon.DataSource = dA_BanHang.taiHoaDon();
        }

        private void tao_hoa_don_Load()
        {
            lv_hoa_don.Columns.Add("ID", 50); // Tên cột và độ rộng
            lv_hoa_don.Columns.Add("Tên sản phẩm", 150);
            lv_hoa_don.Columns.Add("Số lượng", 70);
            lv_hoa_don.Columns.Add("Đơn giá", 100);
            lv_hoa_don.Columns.Add("Thành tiền", 100);
        }
        private void khach_hang_Load(DataTable dt = null)
        {
            if (dt == null)
            {
                gv_thanh_vien.DataSource = dA_BanHang.layThongTinKhachHang();
            }
            else
            {
                gv_thanh_vien.DataSource = dt;
            }
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
            lv_hoa_don.View = System.Windows.Forms.View.Details;
            // Thêm các cột vào ListView
            thu_cung_load();
            vat_pham_load();
            dich_vu_Load();

        }
        private void dich_vu_Load(DataTable dichvu = null)
        {
            dA_BanHang.capNhatSoPhongTrong();
            if (dichvu == null)
            {
                dt_dichvu = dA_BanHang.layView("view_DanhSachDichVu");
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
                DataTable temp = dA_BanHang.layHinhAnhSPDV(id);
                string link = null;

                if (temp.Rows.Count > 0)
                {
                    DataRow dataRow = temp.Rows[0];
                    link = dataRow["Duong_Dan"].ToString();
                    link = imageLinkConverter.Convert(link).ToString();
                }

                int sophongtrong = Convert.ToInt16(row["So_Luong_Phong_Trong"]);
                UC_DichVuCard cardvatpham = new UC_DichVuCard(id, name, giagoc, giauudai, link, sophongtrong);
                cardvatpham.addHoaDon += AddHoaDonDV;
                cardvatpham.chitietvatpham += ChiTietVatPham;
                flp_dichvu.Controls.Add(cardvatpham);
            }
        }

        private void AddHoaDonDV(object sender, EventArgs e)
        {
            if (!dA_BanHang.coTheThaoTacHoaDon(IDHoaDonHienTai))
            {
                return;
            }
            UC_DichVuCard _DichVuCard = (UC_DichVuCard)sender;
            Form_DanhSachPhongDV form_DanhSachPhongDV = new Form_DanhSachPhongDV(_DichVuCard.Id);
            form_DanhSachPhongDV.ShowDialog();
            string inititalState = "";
            string eventualState = "";
            int maphong = 0;
            form_DanhSachPhongDV.layGiaTriTrangThai(ref inititalState, ref eventualState, ref maphong);
            if (dA_BanHang.laDatPhong(inititalState, eventualState))
            {
                UC_SanPhamCard uC_SanPhamCard = new UC_SanPhamCard(_DichVuCard.Id, _DichVuCard.Ten + " -- Mã phòng: " + maphong.ToString(), _DichVuCard.GiaGoc, _DichVuCard.GiaUudai, _DichVuCard.Link);
                AddHoaDon(uC_SanPhamCard, e);
            }
            else
            {
                MessageBox.Show("Đặt phòng không hợp lệ, giao dịch bị hủy bỏ!", "Warning");;
            }
            dich_vu_Load();
        }

        private void vat_pham_load(DataTable vatpham = null)
        {
            if (vatpham == null)
            {
                dt_vatpham = dA_BanHang.layView("view_DanhSachVatPham");
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
                DataTable temp = dA_BanHang.layHinhAnhSPDV(id);
                string link = null;

                if (temp.Rows.Count > 0)
                {
                    DataRow dataRow = temp.Rows[0];
                    link = dataRow["Duong_Dan"].ToString();
                    link = imageLinkConverter.Convert(link).ToString();
                }
                UC_SanPhamCard cardvatpham = new UC_SanPhamCard(id, name, giagoc, giauudai, link);
                cardvatpham.addHoaDon += AddHoaDon;
                cardvatpham.chitietvatpham += ChiTietVatPham;
                flp_vatpham.Controls.Add(cardvatpham);
            }
        }

        private void thu_cung_load(DataTable thucung = null)
        {
            if (thucung == null)
            {
                dt_thucung = dA_BanHang.layView("view_DanhSachThuCung");
            }
            else
            {
                dt_thucung = thucung;
            }
            flp_thu_cung.Controls.Clear();
            foreach (DataRow row in dt_thucung.Rows)
            {
                int id = Convert.ToInt32(row["Ma_Thu_Cung"]);
                string name = row["Ten"].ToString();
                decimal giagoc = Convert.ToDecimal(row["Gia_Ban_Goc"]);
                decimal giauudai = Convert.ToDecimal(row["Gia_Khuyen_Mai"]);
                DataTable temp = dA_BanHang.layHinhAnhSPDV(id);
                string link = null;
                
                if (temp.Rows.Count >0)
                {
                    DataRow dataRow = temp.Rows[0];
                    link = dataRow["Duong_Dan"].ToString();
                    link = imageLinkConverter.Convert(link).ToString();
                }

                UC_SanPhamCard cardvatpham = new UC_SanPhamCard(id, name, giagoc, giauudai, link);
                cardvatpham.addHoaDon += AddHoaDon;
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
                Form_ChiTietDichVu chiTietDichVu = new Form_ChiTietDichVu(cardvatpham.Id);
                chiTietDichVu.ShowDialog();
                dich_vu_Load();
            }
        }
        private void AddHoaDon(object sender, EventArgs e)
        {
            UC_SanPhamCard item = (UC_SanPhamCard)sender;
            if (IDHoaDonHienTai == -1)
            {
                // Tạo hóa đơn mới
                IDHoaDonHienTai = dA_BanHang.taoHoaDonMoi();
            }

            // Nếu là hóa đơn được lấy từ mục chỉnh sửa
            if (!dA_BanHang.coTheThaoTacHoaDon(IDHoaDonHienTai))
            {
                return;
            }
            // Tránh trường hợp khi nhập id khách hàng vào trước khi thêm hóa đơn thì không lấy được mã giảm giá
            btn_xac_nhan_id_khachhang_Click(sender, e);


            // Thêm vào chi tiết hóa đơn
            decimal thanhtien = dA_BanHang.themChiTietHoaDon(IDHoaDonHienTai.ToString(), item);

            // Kiểm tra nếu thành tiền là 0, không làm nữa vì không thêm dược
            if (thanhtien == 0)
                return;

            // cập nhật tổng tiền
            tongtien = LayTongTienHoaDonHienTai();
            setTongTien(tongtien);


            // Bước hiển thị
            bool isExist = false;
            ListViewItem currentItem = null;
            string[] row = new string[] { item.Id.ToString(), item.Ten, (thanhtien / item.GiaUudai).ToString("#,0"), item.GiaUudai.ToString("#,0"), thanhtien.ToString("#,0") };
            foreach (ListViewItem record in lv_hoa_don.Items)
            {
                if (record.SubItems[0].Text == item.Id.ToString())
                { isExist = true; currentItem = record; break; }
            }
            if (isExist)
            {
                lv_hoa_don.Items.Remove(currentItem);
                currentItem = new ListViewItem(row);
                lv_hoa_don.Items.Add(currentItem);
            }
            else
            {
                currentItem = new ListViewItem(row);
                lv_hoa_don.Items.Add(currentItem);
            }
            thu_cung_load();
            vat_pham_load();
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
        /// <summary>
        /// Lấy hết tất cả thông tin để tìm kiếm
        /// </summary>
        private void getAllInfoSearching()
        {
            // Kiểm tra xem là tab thú cưng hay vật phẩm để có tên view
            switch (tc_ban_hang.SelectedIndex)
            {
                case 0:
                    switch (tb_types.SelectedIndex)
                    {
                        case 0:
                            tenView = "view_DanhSachThuCung";
                            break;
                        case 1:
                            tenView = "view_DanhSachVatPham";
                            break;
                        case 2:
                            tenView = "view_DanhSachDichVu";
                            break;
                        default:
                            tenView = null;
                            break;

                    }
                    break;
                case 2:
                    tenView = "view_DanhSachKhachHang";
                    break;
                default:
                    break;
            }
          

            // Kiểm tra cb giá
            sortOrderGiaTien = getValueCBGiaTien();

            // Kiểm tra cb tên
            sortOrderTen = getValueCBTen();

            // Kiểm tra từ khóa
            if (tc_ban_hang.SelectedIndex == 0)
            {
                tuKhoa = txt_tim_kiem.Text;
            }
            else
            {
                tuKhoa = txt_tim_kiem_thanh_vien.Text;
            }

            // Kiểm tra giá bắt đầu
            startingValue = txt_gia_bat_dau.Text;

            // Kiểm tra giá kết thúc
            endingValue = txt_gia_ket_thuc.Text;
        }
        private void TimKiem()
        {
            getAllInfoSearching();
            if (tc_ban_hang.SelectedIndex == 0)
            {
                if (tb_types.SelectedIndex == 0)
                {
                    dt_thucung = dA_BanHang.TimKiem(tenView, "Ten", tuKhoa, startingValue, endingValue,
                    sortOrderGiaTien, sortOrderTen, "Gia_Khuyen_Mai");
                    thu_cung_load(dt_thucung);
                }
                else if (tb_types.SelectedIndex == 1)
                {
                    dt_vatpham = dA_BanHang.TimKiem(tenView, "Ten_San_Pham", tuKhoa, startingValue, endingValue,
                    sortOrderGiaTien, sortOrderTen);
                    vat_pham_load(dt_vatpham);
                }
                else
                {
                    dt_dichvu = dA_BanHang.TimKiem(tenView, "Ten_Dich_Vu", tuKhoa, startingValue, endingValue,
                    sortOrderGiaTien, sortOrderTen);
                    dich_vu_Load(dt_dichvu);
                }
            }
            else
            {
                DataTable dt = new DataTable();
                dt = dA_BanHang.TimKiem(tenView, "Ten", tuKhoa, Gia_Khuyen_Mai:null);
                khach_hang_Load(dt);
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

        private void txt_gia_bat_dau_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_gia_bat_dau.Clear();
        }

        private void txt_gia_ket_thuc_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txt_gia_ket_thuc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_gia_ket_thuc.Clear();
        }
        private void btn_xac_nhan_id_khachhang_Click(object sender, EventArgs e)
        {
            // Buoc cap nhat CSDL
            idkhachhang = "0";
            if (txt_id_khachhang.Text != "0")
            {
                idkhachhang = txt_id_khachhang.Text;
            }

            dA_BanHang.capNhatThongTinKhachHangLenHoaDon(idkhachhang, IDHoaDonHienTai.ToString());
            /* dA_BanHang.tinhTongTien(idkhachhang, IDHoaDonHienTai);*/
            capNhatThongTinKhachHangLenGiaoDien(idkhachhang);
            setTongTien(LayTongTienHoaDonHienTai());
        }
        private void capNhatThongTinKhachHangLenGiaoDien(string idkhachhang)
        {
            if (idkhachhang != null)
            {
                DataTable dt_vw_khach_hang = dA_BanHang.layThongTinKhachHang(idkhachhang);
                foreach (DataRow row in dt_vw_khach_hang.Rows)
                {
                    lbl_ten_khachhang.Text = row["Ten"].ToString();
                    lbl_giam_gia.Text = row["Diem_Tich_Luy"].ToString();
                }
            }
        }
        private void setTongTien(decimal value)
        {
            tongtien = value;
            lbl_tong_tien.Text = tongtien.ToString("#,0") + "VND";
        }
        private decimal LayTongTienHoaDonHienTai()
        {
            
            DataTable result = dA_BanHang.layTongTienHoaDonHienTai(IDHoaDonHienTai.ToString());
            decimal tongtien = 0;
            if (result.Rows.Count > 0) // Kiểm tra nếu có kết quả
            {
                var value = result.Rows[0]["Tong_Tien"];

                // Kiểm tra nếu giá trị là DBNull trước khi chuyển đổi
                if (value != DBNull.Value)
                {
                    tongtien = Convert.ToDecimal(value); // Lấy tổng tiền từ hàng đầu tiên
                }
            }
            return tongtien;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (!dA_BanHang.coTheThaoTacHoaDon(IDHoaDonHienTai))
            {
                MessageBox.Show("Không thể xóa vật phẩm trong hóa đơn đã thanh toán tại đây!", "Warning!");
                return;
            }
            if (lv_hoa_don.SelectedItems == null)
                return;
            foreach (ListViewItem item in lv_hoa_don.SelectedItems)
            {
                string idVatPham = item.SubItems[0].Text;
                string nameVatPham = item.SubItems[1].Text;
                dA_BanHang.xoaSPDVKhoiHoaDonDangLap(IDHoaDonHienTai.ToString(), idVatPham, nameVatPham);
                lv_hoa_don.Items.Remove((ListViewItem)item);

            }
            setTongTien(LayTongTienHoaDonHienTai());
            san_pham_va_dich_vu_Load();
        }

        private void btn_huy_bo_Click(object sender, EventArgs e)
        {
            if (!dA_BanHang.coTheThaoTacHoaDon(IDHoaDonHienTai))
            {
                MessageBox.Show("Không thể xóa toàn bộ hóa đơn đã thanh toán tại đây!", "Warning!");
                return;
            }
            foreach (ListViewItem item in lv_hoa_don.Items)
            {
                string idVatPham = item.SubItems[0].Text;
                string nameVatPham = item.SubItems[1].Text;
                dA_BanHang.xoaSPDVKhoiHoaDonDangLap(IDHoaDonHienTai.ToString(), idVatPham, nameVatPham);
            }
            dA_BanHang.xoaHoaDonDangLap(IDHoaDonHienTai.ToString());
            lv_hoa_don.Items.Clear();
            IDHoaDonHienTai = -1;
            XoaGiaoDichHienTai();
            setTongTien(0);
            san_pham_va_dich_vu_Load();
        }
        private void XoaGiaoDichHienTai()
        {
            lv_hoa_don.Items.Clear();
            IDHoaDonHienTai = -1;
            txt_id_khachhang.Text = "0";
            lbl_giam_gia.Text = "0";
            lbl_ten_khachhang.Text = "";
            setTongTien(0);
        }

        private void btn_xac_nhan_Click(object sender, EventArgs e)
        {
            if (!dA_BanHang.coTheThaoTacHoaDon(IDHoaDonHienTai))
            {
                MessageBox.Show("Không thể thực hiện thao tác nào với hóa đơn đã thanh toán này");
                return;
            }
            if (dA_BanHang.coTheThemHoaDon(IDHoaDonHienTai.ToString()))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thanh toán ngay?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Người dùng nhấn nút Yes
                    MessageBox.Show("Bạn đã chọn Yes, hóa đơn có trạng thái đã thanh toán", "Notice");
                    dA_BanHang.datTrangThaiThanhToan(IDHoaDonHienTai.ToString());
                }
                else if (result == DialogResult.No)
                {
                    // Người dùng nhấn nút No
                    MessageBox.Show("Bạn đã chọn No, hóa đơn sẽ đưa vào danh sách chờ", "Notice");
                }
                XoaGiaoDichHienTai();
            }
            else
            {
                MessageBox.Show("Hóa đơn không hợp lệ!", "Warning");
                XoaGiaoDichHienTai();
            }
        }

        private void btn_chinh_sua_hoadon_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow hoadonhientai = gv_hoadon.CurrentRow;
            if (hoadonhientai != null)
            {
                IDHoaDonHienTai = Convert.ToInt32(hoadonhientai.Cells[0].Value);
                DataTable chitiethoadon = dA_BanHang.xemChiTietHoaDon(IDHoaDonHienTai);
                if (chitiethoadon != null)
                    CapNhatGiaoDienHoaDonCanChinhSua(chitiethoadon);
            }
        }
        /// <summary>
        /// Input datatable của hóa đơn cần chỉnh sửa để update lên giao diện
        /// </summary>
        /// <param name="dt"></param>
        private void CapNhatGiaoDienHoaDonCanChinhSua(DataTable dt)
        {
            lv_hoa_don.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string idVatpham = row["Ma_SPDV"].ToString();
                string ten = row["Ten"].ToString();
                string soluong = row["So_Luong"].ToString();
                string dongia = Convert.ToDecimal(row["Gia_Khuyen_Mai"]).ToString("#,0");
                string thanhtien = Convert.ToDecimal(row["Thanh_Tien"]).ToString("#,0");
                string[] lvItem = { idVatpham, ten, soluong, dongia, thanhtien };
                lv_hoa_don.Items.Add(new ListViewItem(lvItem));
            }
            // Chặn họng trước, tý sửa sau
            if (dt.Rows.Count > 0)
            {
                txt_id_khachhang.Text = dt.Rows[0]["Ma_Khach_Hang"].ToString();
    
            }
            if (txt_id_khachhang.Text.Length == 0)
                txt_id_khachhang.Text = "0";
            /*btn_xac_nhan_id_khachhang_Click(null, null);*/
            capNhatThongTinKhachHangLenGiaoDien(txt_id_khachhang.Text);
            setTongTien(LayTongTienHoaDonHienTai());
            tc_ban_hang.SelectedIndex = 0;
        }
        private void tc_ban_hang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc_ban_hang.SelectedIndex==0)
            {
                san_pham_va_dich_vu_Load();
            }
            else if (tc_ban_hang.SelectedIndex==1)
            {
                hoa_don_Load();
            }
            else
            {
                khach_hang_Load();
            }
        }
        private void modifyMember(string header)
        {
            string title = header + " thông tin thành viên";
            Form_ThemKhachHang member_Detail = new Form_ThemKhachHang(title);
            member_Detail.ShowDialog();
            string name = "";
            string sdt = "";
            string dtl = "";
            member_Detail.getValue(ref name, ref sdt, ref dtl);
            dA_BanHang.ThemThanhVien(name, sdt, dtl);
            khach_hang_Load();
        }

        private void btn_them_thanh_vien_Click(object sender, EventArgs e)
        {
            modifyMember("Thêm");
        }

        private void txt_tim_kiem_thanh_vien_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_tim_kiem_thanh_vien.Clear();
        }

        private void btn_tim_kiem_thanh_vien_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void flp_thu_cung_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
