using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_DBMS.DataAccess
{
    public class DA_TinhLuong
    {
        Database db = new Database();
        SqlConnection conn;
        
        public DataTable LoadDanhSach(DateTime startDate, DateTime endDate)
        {
            conn = db.getConnection;
            SqlCommand cmd = new SqlCommand("Proc_TinhLuongNhanVien", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@StartDate", startDate));
            cmd.Parameters.Add(new SqlParameter("@EndDate", endDate));

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
    }
}
