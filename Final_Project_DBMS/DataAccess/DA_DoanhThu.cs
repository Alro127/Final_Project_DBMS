using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_DBMS.DataAccess
{
    public class DA_DoanhThu
    {
        Database db = new Database();
        SqlConnection conn;

        public DataTable LoadDanhSach(DateTime startDate, DateTime endDate, ref decimal tongTien)
        {
            conn = db.getConnection;
            SqlCommand cmd = new SqlCommand("Proc_DoanhThu", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@NgayBatDau", startDate));
            cmd.Parameters.Add(new SqlParameter("@NgayKetThuc", endDate));

            SqlParameter doanhThuParam = new SqlParameter("@DoanhThu", SqlDbType.Decimal);
            doanhThuParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(doanhThuParam);

            DataTable dataTable = new DataTable();
            try
            {
                db.openConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);

                tongTien = (decimal)doanhThuParam.Value;
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
