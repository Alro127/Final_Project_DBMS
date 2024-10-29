using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_DBMS.DataAccess
{
    
    public class DA_PhanCa
    {
        Database db = new Database();
        SqlConnection conn;
        public DataTable LoadCaLam(DateTime startDate)
        {
            conn = db.getConnection;
            SqlCommand cmd = new SqlCommand("Proc_XemPhanCaTheoTuan", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@StartDate", startDate));

            DataTable dataTable = new DataTable();
            try
            {
                db.openConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
            return dataTable;
        }
        public void XoaCaLam(DataRow row)
        {
            conn = db.getConnection;
            SqlCommand cmd = new SqlCommand("Proc_XoaCaLamChoNhanVien", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Buoi", row["Buoi"]);
            cmd.Parameters.AddWithValue("@Ngay_Lam_Viec", row["Ngay_Lam_Viec"]);
            cmd.Parameters.AddWithValue("@Ma_Nhan_Vien", row["Ma_Nhan_Vien"]);

            try
            {
                db.openConnection();
                int rowsAffected = cmd.ExecuteNonQuery();

                // Hiển thị thông báo sau khi thực hiện
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Ca làm đã được xóa thành công.");
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
        public void ThemCaLam(string buoi, DateTime ngayLamViec, int maNhanVien)
        {
            conn = db.getConnection;
            SqlCommand cmd = new SqlCommand("Proc_ThemCaLamChoNhanVien", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Buoi", buoi);
            cmd.Parameters.AddWithValue("@Ngay_Lam_Viec", ngayLamViec);
            cmd.Parameters.AddWithValue("@Ma_Nhan_Vien", maNhanVien);

            try
            {
                db.openConnection();
                int rowsAffected = cmd.ExecuteNonQuery();

                // Hiển thị thông báo sau khi thực hiện
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Ca làm đã được thêm thành công.");
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
        public DataTable dataNhanVien()
        {
            DataTable dataTable = db.getDataTable("SELECT Ma_Nhan_Vien FROM NhanVien");
            return dataTable;
        }
    }
}
