using Final_Project_DBMS.View.Screen_BanHang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_DBMS.DataAccess
{
    public class DA_QuanLy
    {
        Database db = new Database();
        DA_BanHang dA_BanHang = new DA_BanHang();
        SqlConnection conn;
        public DataTable DanhSachNhanVien()
        {
            DataTable dataTable = db.getDataTable("SELECT * FROM view_DanhSachNhanVien");
            return dataTable;
        }
        public DataTable DanhSachPhongDichVu()
        {
            DataTable dataTable = db.getDataTable("SELECT * FROM view_DanhSachPhongDichVu");
            return dataTable;
        }
        public DataTable TimKiemNhanVienTheoTen(string ten)
        {
            return dA_BanHang.TimKiem(tenView: "view_DanhSachNhanVien", tenCot: "Ho_Ten", tukhoa: ten);
        }
        public DataTable TimKiemPhongDichVuTheoTen(string ten)
        {
            return dA_BanHang.TimKiem(tenView: "view_DanhSachPhongDichVu", tenCot: "Ten_Dich_Vu", tukhoa: ten);
        }
        public DataTable TimKiemThuCungTheoTen(string ten)
        {
            return dA_BanHang.TimKiem(tenView: "view_DanhSachThuCung", tenCot: "Ten", tukhoa: ten);
        }
        public DataTable TimKiemVatPhamTheoTen(string ten)
        {
            return dA_BanHang.TimKiem(tenView: "view_DanhSachVatPham", tenCot: "Ten_San_Pham", tukhoa: ten);
        }
        public DataTable TimKiemDichVuTheoTen(string ten)
        {
            return dA_BanHang.TimKiem(tenView: "view_DanhSachDichVu", tenCot: "Ten_Dich_Vu", tukhoa: ten);
        }
        public DataTable TimKiemKhachHangTheoTen(string ten)
        {
            return dA_BanHang.TimKiem(tenView: "view_DanhSachKhachHang", tenCot: "Ten", tukhoa: ten);
        }
        public bool ThemNhanVien(object[] parameters)
        {
            string[] parameterNames = { "@Ho_Ten", "@Ngay_Sinh", "@Gioi_Tinh", "@Dia_Chi", "@SDT", "@Luong", "@Cong_Viec", "@Ma_NQL" };
            return db.ExecProcedure("proc_ThemNhanVien", parameters, parameterNames);
        }
        public bool SuaNhanVien(object[] parameters)
        {
            string[] parameterNames = { "@Ma_Nhan_Vien", "@Ho_Ten", "@Ngay_Sinh", "@Gioi_Tinh", "@Dia_Chi", "@SDT", "@Luong", "@Cong_Viec", "@Ma_NQL" };
            return db.ExecProcedure("proc_SuaNhanVien", parameters, parameterNames);
        }
        public bool XoaNhanVien(object[] parameters)
        {
            string[] parameterNames = { "@Ma_Nhan_Vien" };
            return db.ExecProcedure("proc_XoaNhanVien", parameters, parameterNames);
        }
        public bool XoaSanPhamDichVu(object[] parameters)
        {
            string[] parameterNames = { "@Ma_SPDV" };
            return db.ExecProcedure("proc_XoaSanPhamDichVu", parameters, parameterNames);
        }
        public bool SuaKhachHang(object[] parameters)
        {
            string[] parameterNames = { "@Ma_Khach_Hang", "@Ten", "@SDT", "Diem_Tich_Luy" };
            return db.ExecProcedure("proc_SuaKhachHang", parameters, parameterNames);
        }
        public bool XoaKhachHang(object[] parameters)
        {
            string[] parameterNames = { "@Ma_Khach_Hang" };
            return db.ExecProcedure("proc_XoaKhachHang", parameters, parameterNames);
        }
        public bool ThemHinhAnh(object[] parameters)
        {
            string[] parameterNames = { "@Ma_SPDV", "@Duong_Dan" };
            return db.ExecProcedure("proc_ThemHinhAnh", parameters, parameterNames);
        }
        public bool XoaHinhAnh(object[] parameters)
        {
            string[] parameterNames = { "@Ma_SPDV", "@Duong_Dan" };
            return db.ExecProcedure("proc_XoaHinhAnh", parameters, parameterNames);
        }
        public int ThemVatPham(object[] parameters)
        {
            string[] paramNames = { "@Ten", "@Mo_Ta", "@Gia_Ban_Goc", "@Gia_Khuyen_Mai", "@Thuong_Hieu", "@Han_Su_Dung", "@So_Luong_Ton_Kho" };
            return db.ExecuteQueryLayMa("proc_ThemVatPham", parameters, paramNames);
        }
        public bool SuaVatPham(object[] parameters)
        {
            string[] paramNames = { "@Ma_Vat_Pham", "@Ten", "@Mo_Ta", "@Gia_Ban_Goc", "@Gia_Khuyen_Mai", "@Thuong_Hieu", "@Han_Su_Dung", "@So_Luong_Ton_Kho"};
            return db.ExecProcedure("proc_SuaVatPham", parameters, paramNames);
        }
        public int ThemThuCung(object[] parameters)
        {
            string[] paramNames = {"@Loai", "@Giong", "@Ngay_Sinh", "@Gioi_Tinh", "@Mau_Sac", "@Can_Nang",
                                "@Tinh_Trang_Suc_Khoe", "@Trang_Thai", "@So_Lan_Tiem", "@Ten_SPDV", "@Mo_Ta_SPDV",
                                "@Gia_Ban_Goc", "@Gia_Khuyen_Mai" };
            return db.ExecuteQueryLayMa("proc_ThemThuCung", parameters, paramNames);
        }
        public bool SuaThuCung(object[] parameters)
        {
            string[] paramNames = {"@Ma_Thu_Cung","@Loai", "@Giong", "@Ngay_Sinh", "@Gioi_Tinh", "@Mau_Sac", "@Can_Nang",
                                "@Tinh_Trang_Suc_Khoe", "@Trang_Thai", "@So_Lan_Tiem", "@Ten_SPDV", "@Mo_Ta_SPDV",
                                "@Gia_Ban_Goc", "@Gia_Khuyen_Mai"};
            return db.ExecProcedure("proc_SuaThuCung", parameters, paramNames);
        }
        public int ThemDichVu(object[] parameters)
        {
            string[] paramNames = { "@Ten", "@Mo_Ta", "@Gia_Ban_Goc", "@Gia_Khuyen_Mai", "@Thoi_Gian_Thuc_Hien" }; ;
            return db.ExecuteQueryLayMa("proc_ThemDichVu", parameters, paramNames);
        }
        public bool SuaDichVu(object[] parameters)
        {
            string[] paramNames = { "@Ma_Dich_Vu", "@Ten", "@Mo_Ta", "@Gia_Ban_Goc", "@Gia_Khuyen_Mai", "@Thoi_Gian_Thuc_Hien"};
            return db.ExecProcedure("proc_SuaDichVu", parameters, paramNames);
        }
        public bool ThemPhongDichVu(object[] parameters)
        {
            string[] paramNames = { "@Ma_Phong", "@Ma_Dich_Vu"};
            return db.ExecProcedure("proc_ThemPhongDichVu", parameters, paramNames);
        }
        public bool SuaPhongDichVu(object[] parameters)
        {
            string[] paramNames = { "@Ma_Phong", "@Ma_Dich_Vu"};
            return db.ExecProcedure("proc_SuaPhongDichVu", parameters, paramNames);
        }
        public bool XoaPhongDichVu(object[] parameters)
        {
            string[] paramNames = { "@Ma_Phong"};
            return db.ExecProcedure("proc_XoaPhongDichVu", parameters, paramNames);
        }
        public DataTable DanhSachKhachHang()
        {
            DataTable dataTable = db.getDataTable("SELECT * FROM view_DanhSachKhachHang");
            return dataTable;
        }
        public DataTable DanhSachThuCung()
        {
            DataTable dataTable = db.getDataTable("SELECT * FROM view_DanhSachThuCung");
            return dataTable;
        }
        public DataTable DanhSachVatPham()
        {
            DataTable dataTable = db.getDataTable("SELECT * FROM view_DanhSachVatPham");
            return dataTable;
        }
        public DataTable DanhSachDichVu()
        {
            DataTable dataTable = db.getDataTable("SELECT * FROM view_DanhSachDichVu");
            return dataTable;
        }
        public DataTable ExecuteQuery(string query, object[] parameters, string[] parameterNames)
        {
            conn = db.getConnection;
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand(query, conn);
            // Thêm tham số vào câu lệnh (Giả sử parameterNames và parameters đã được khai báo)
            for (int i = 0; i < parameterNames.Length; i++)
            {
                cmd.Parameters.AddWithValue(parameterNames[i], parameters[i]);
            }

            try
            {
                db.openConnection();  // Mở kết nối
                SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);  // Thông báo lỗi nếu có lỗi xảy ra
            }
            finally { db.closeConnection(); }
            return dataTable;
        }
    }
}
