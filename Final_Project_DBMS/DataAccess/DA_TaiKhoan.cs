using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_DBMS.DataAccess
{
    public class DA_TaiKhoan
    {
        public static string username;
        public static string password;
        public static string permission;
        public static string manv;
        public static string getMaNV()
        {
            Database db = new Database();
            string result = null;
            if (username != null && password != null)
            {
                string query = "SELECT Ma_Nhan_Vien From TaiKhoan Where Ten_Dang_Nhap = @username";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@username", SqlDbType.NVarChar) { Value = username },
                };
                result = db.ExecuteReturnAdmin(query, parameters).ToString();
            }
            return result;
        }
        public static string getQuyen()
        {
            Database db = new Database();
            string result = null;
            if (username != null && password != null)
            {
                string query = "SELECT dbo.func_CheckLogin(@username, @password)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@username", SqlDbType.NVarChar) { Value = username },
                    new SqlParameter("@password", SqlDbType.NVarChar) { Value = password }
                };
                result = (string) db.ExecuteReturnAdmin(query, parameters);
            }
            return result;
        }
        public static bool SignUp()
        {
            bool result = false;
            Database db = new Database();
            if (username != null && password != null && manv != null) 
            {
                string proc = "proc_ThemTaiKhoanVoiLoginVaRole";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@username", SqlDbType.NVarChar) { Value = username },
                    new SqlParameter("@maNhanVien", SqlDbType.Int) { Value = manv },
                    new SqlParameter("@password", SqlDbType.NVarChar) { Value = password }
                };
                result = db.ExecuteNonReturnAdmin(proc, parameters);
            }
            return result;
        }
    }
}
