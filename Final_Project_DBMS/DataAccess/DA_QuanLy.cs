using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_DBMS.DataAccess
{
    public class DA_QuanLy
    {
        Database db = new Database();
        SqlConnection conn;
        public DataTable DanhSachNhanVien()
        {
            DataTable dataTable = db.getDataTable("SELECT * FROM view_DanhSachNhanVien");
            return dataTable;
        }
        public DataTable TimKiemNhanVienTheoTen(string ten)
        {
            string query = "SELECT * FROM view_DanhSachNhanVien WHERE Ho_Ten COLLATE SQL_Latin1_General_CP1_CI_AI LIKE '%" + ten + "%'";
            MessageBox.Show(query);
            return db.getDataTable(query);
        }
        public DataTable TimKiemThuCungTheoTen(string ten)
        {
            string query = "SELECT * FROM view_DanhSachThuCung WHERE Ten COLLATE SQL_Latin1_General_CP1_CI_AI LIKE '%" + ten + "%'";
            return db.getDataTable(query);
        }
        public DataTable TimKiemVatPhamTheoTen(string ten)
        {
            string query = "SELECT * FROM view_DanhSachVatPham WHERE Ten_San_Pham COLLATE SQL_Latin1_General_CP1_CI_AI LIKE '%" + ten + "%'";
            return db.getDataTable(query);
        }
        public DataTable TimKiemDichVuTheoTen(string ten)
        {
            string query = "SELECT * FROM view_DanhSachDichVu WHERE Ten_Dich_Vu COLLATE SQL_Latin1_General_CP1_CI_AI LIKE '%" + ten + "%'";
            return db.getDataTable(query);
        }
        public DataTable TimKiemKhachHangTheoTen(string ten)
        {
            string query = "SELECT * FROM view_DanhSachKhachHang WHERE Ten COLLATE SQL_Latin1_General_CP1_CI_AI LIKE '%" + ten + "%'";
            return db.getDataTable(query);
        }
        public void ExecProcedure(string procedureName , object[] parameters, string[] parameterNames)
        {
            conn = db.getConnection;
            SqlCommand cmd = new SqlCommand(procedureName, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm các tham số vào SqlCommand
            for (int i = 0; i < parameterNames.Length; i++)
            {
                cmd.Parameters.AddWithValue(parameterNames[i], parameters[i]);
            }

            try
            {
                db.openConnection();
                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show(rowsAffected + "");
                // Hiển thị thông báo sau khi thực hiện
                if (rowsAffected != 0)
                {
                    if (procedureName == "proc_ThemNhanVien")
                    {
                        MessageBox.Show("Thông tin nhân viên đã được thêm thành công.");
                    }
                    else if (procedureName == "proc_SuaNhanVien")
                    {
                        MessageBox.Show("Thông tin nhân viên đã được sửa thành công.");
                    }
                    else if (procedureName == "proc_XoaNhanVien")
                    {
                        MessageBox.Show("Thông tin nhân viên đã được xóa thành công.");
                    }
                    else if (procedureName == "proc_SuaKhachHang")
                    {
                        MessageBox.Show("Thông tin khách hàng đã được sửa thành công");
                    }
                    else if (procedureName == "proc_XoaKhachHang")
                    {
                        MessageBox.Show("Thông tin khách hàng đã được xóa thành công");
                    }
                    else if (procedureName == "proc_XoaHinhAnh")
                    {
                        MessageBox.Show("Hình ảnh đã được xóa thành công");
                    }
                    else if (procedureName == "proc_ThemHinhAnh")
                    {
                        MessageBox.Show("Hình ảnh đã được xóa thành công");
                    }
                    else if (procedureName == "proc_SuaVatPham")
                    {
                        MessageBox.Show("Hình ảnh đã được xóa thành công");
                    }
                    else if (procedureName == "proc_SuaDichVu")
                    {
                        MessageBox.Show("Hình ảnh đã được xóa thành công");
                    }
                    else if (procedureName == "proc_SuaThuCung")
                    {
                        MessageBox.Show("Hình ảnh đã được xóa thành công");
                    }

                }
                else
                {
                    MessageBox.Show("Không có thay đổi nào được thực hiện.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }
        public int ExecuteQueryLayMa(string procedureName, object[] parameters, string[] parameterNames)
        {
            int maspdv = -1; // Giá trị mặc định trả về nếu có lỗi
            conn = db.getConnection;
            SqlCommand cmd = new SqlCommand(procedureName, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm các tham số đầu vào vào SqlCommand
            for (int i = 0; i < parameterNames.Length; i++)
            {
                cmd.Parameters.AddWithValue(parameterNames[i], parameters[i]);
            }

            // Thêm tham số đầu ra @Ma_SPDV
            SqlParameter maSpdvParam = new SqlParameter("@Ma_SPDV", SqlDbType.Int);
            maSpdvParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(maSpdvParam);

            try
            {
                db.openConnection();
                int rowsAffected = cmd.ExecuteNonQuery();

                // Kiểm tra kết quả sau khi thực hiện
                if (rowsAffected > 0)
                {
                    if (procedureName == "proc_ThemVatPham")
                    {
                        MessageBox.Show("Thông tin vật phẩm đã được thêm thành công.");
                    }
                    else if (procedureName == "proc_ThemDichVu")
                    {
                        MessageBox.Show("Thông tin dịch vụ đã được sửa thành công.");
                    }
                    else if (procedureName == "proc_ThemThuCung")
                    {
                        MessageBox.Show("Thông tin thú cưng đã được xóa thành công.");
                    }
                    // Lấy giá trị từ tham số đầu ra @Ma_SPDV
                    maspdv = (int)maSpdvParam.Value;
                }
                else
                {
                    MessageBox.Show("Không có thay đổi nào được thực hiện.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }

            return maspdv;
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
