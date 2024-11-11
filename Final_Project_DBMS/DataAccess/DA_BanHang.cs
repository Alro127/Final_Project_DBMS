using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_DBMS.control.converter;
using Final_Project_DBMS.View.Screen_BanHang;
using System.Data.SqlTypes;
using System.Xml.Linq;

namespace Final_Project_DBMS.DataAccess
{
    public class DA_BanHang
    {
        Database db = new Database();
        public string layIconBtnTimKiem()
        {
            string img_link = @"assets\images\chucnangbanhang\icon\Search_Icon.png";
            img_link = imageLinkConverter.Convert(img_link).ToString();
            Uri uri = new Uri(img_link);
            string filePath = uri.LocalPath;
            return filePath;
        }
        public DataTable layView(string viewName)
        {
            return db.ExecuteQuery("SELECT * FROM " + viewName);
        }
        public DataTable layHinhAnhSPDV(int idSPDV)
        {
            string sqlcmd = "proc_HinhAnhSPDV";
            string[] paramName = { "@idSPDV" };
            object[] paramValue = { idSPDV };
            return (DataTable)db.getResultFromProc(sqlcmd, paramName: paramName, parametervalue: paramValue, isExecReader: true);
        }
        /// <summary>
        /// Hàm tìm kiếm sẽ tìm kiếm một lần dựa trên tất cả các điều kiện.
        /// Mặc định tất cả tham số sẽ là null.
        /// Nếu tất cả tham số là null, không thực hiện tìm kiếm, trả về null.
        /// Output là một datatable thỏa tất cả điều kiện tìm kiếm.
        /// </summary>
        /// <param name="tenView">Tên view muốn thực hiện tìm kiếm</param>
        /// <param name="tenCot">Cột để tìm kiếm dựa trên từ khóa của txt_tim_kiem</param>
        /// <param name="tukhoa">Từ khóa</param>
        /// <param name="startingValue">giá khởi điểm</param>
        /// <param name="endingValue">giá kết thúc</param>
        /// <param name="orderColumnGiaTien">Dùng cho cb giá tiền để kiểm tra cách order</param>
        /// <param name="orderColumnTen">Dùng cho cb tên để kiểm tra cách order</param>
        /// <returns></returns>
        public DataTable TimKiem(string tenView = null, string tenCot = null, string tukhoa = null, string startingValue = null,
            string endingValue = null, string orderColumnGiaTien = null, string orderColumnTen = null, string Gia_Khuyen_Mai = "Gia_Khuyen_Mai")
        {
            if (tenView == null && tenCot == null && tukhoa == null && startingValue == null
                && endingValue == null && orderColumnGiaTien == null && orderColumnTen == null)
            {
                return null;
            }
            string cmd = "proc_TimKiemSanPhamVaDichVu";
            object[] paramValues = { tenView, tenCot, tukhoa, startingValue, endingValue,
                Gia_Khuyen_Mai, orderColumnGiaTien, tenCot, orderColumnTen };
            string[] paramNames = { "@tenview", "@tencot", "@tukhoa", "@ValueA", "@ValueB",
                "@SortColumnGiaTien", "@SortOrderGiaTien", "@SortColumnTen", "@SortOrderTen" };
            DataTable dt = (DataTable)db.getResultFromProc(cmd, paramValues, paramNames, true);
            return dt;
        }
        public void capNhatThongTinKhachHangLenHoaDon(string idkhachhang, string IDHoaDonHienTai)
        {
            string sqlcmd = "Update HoaDon Set Ma_Khach_Hang = " + idkhachhang + " where Ma_Hoa_Don = " + IDHoaDonHienTai;
            db.ExecuteQuery(sqlcmd);

            sqlcmd = "EXEC proc_CapNhatTongTien @Ma_Khach_Hang = " + idkhachhang + ", @Ma_Hoa_Don = " + IDHoaDonHienTai;
            db.ExecuteQuery(sqlcmd);
        }
        public DataTable layThongTinKhachHang(string idkhachhang)
        {
            return db.ExecuteQuery("select * from KhachHang where Ma_Khach_Hang = " + idkhachhang);
        }
        public DataTable layTongTienHoaDonHienTai(string IDHoaDonHienTai)
        {
            string sqlcmd = "select Tong_Tien from HoaDon where Ma_Hoa_Don = " + IDHoaDonHienTai;
            return db.ExecuteQuery(sqlcmd);
        }
        public int taoHoaDonMoi()
        {
            string cmd = "proc_TaoHoaDonMoi";
            return Convert.ToInt16(db.getResultFromProc(cmd));
        }
        //public decimal themChiTietHoaDon(string IDHoaDonHienTai, UC_SanPhamCard item)
        //{
        //    object[] parameterValues = { IDHoaDonHienTai, item.Id, item.Ten, item.GiaUudai };
        //    string[] parameterNames = { "@id_hoadon", "@id_vatpham", "@ten", "@dongia" };
        //    string SQLcmd = "proc_ThemChiTietHoaDon";
        //    return Convert.ToDecimal(db.getResultFromProc(SQLcmd, parameterValues, parameterNames));

        //}
        public void xoaSPDVKhoiHoaDonDangLap(string IDHoaDonHienTai, string idVatPham)
        {
            string sqlcmd = "delete from ChiTietHoaDon where Ma_Hoa_Don = " + IDHoaDonHienTai + " and Ma_SPDV = " + idVatPham;
            db.ExecuteQuery(sqlcmd);
        }
        public void xoaHoaDonDangLap(string sqlcmd, object[] paramValues, string[] paramNames)
        {
            db.getResultFromProc(sqlcmd, paramValues, paramNames);
        }
        public void datTrangThaiThanhToan(string IDHoaDonHienTai)
        {
            string sqlcmd = "update HoaDon set Trang_thai = N'Đã thanh toán' where Ma_Hoa_Don = " + IDHoaDonHienTai;
            db.ExecuteQuery(sqlcmd);
        }
        public DataTable taiHoaDon()
        {
            return db.ExecuteQuery("select * from HoaDon");
        }
        public DataTable xemChiTietHoaDon(int IDHoaDonHienTai)
        {
            string query = "SELECT * FROM func_XemChiTietHoaDon(" + IDHoaDonHienTai.ToString() + ")";
            return (DataTable)db.ExecuteQuery(query);
        }
        public DataTable layThongTinKhachHang()
        {
            return db.ExecuteQuery("select * from KhachHang");
        }
        public void ThemThanhVien(string name, string sdt, string dtl)
        {
            if (name == null || name == "")
            {
                return;
            }
            string sqlcmd = "proc_ThemThanhVien";
            string[] paramNames = { "@ten", "@sdt", "@dtl" };
            object[] paramValues = { name, sdt, dtl };
            db.getResultFromProc(sqlcmd, paramValues, paramNames);
        }
        public bool coTheThemHoaDon(string @idHD)
        {
            string sqlcmd = "select dbo.func_KiemTraThemHoaDon(@idHD)";
            string[] paramName = { "@idHD" };
            object[] paramValue = { @idHD };
            return (bool)(db.getResultFromProc(sqlcmd, parametervalue: paramValue, paramName: paramName, isText: true));
        }

        public bool laDatPhong(string @dtrangthai, string @itrangthai)
        {
            string sqlcmd = "select dbo.func_KiemTraDatPhong(@dtrangthai, @itrangthai)";
            string[] paramNames = { "@dtrangthai", "@itrangthai" };
            object[] paramValues = { @dtrangthai, @itrangthai };
            return (bool)(db.getResultFromProc(sqlcmd, paramValues, paramNames, isText: true));
        }
    }
}
