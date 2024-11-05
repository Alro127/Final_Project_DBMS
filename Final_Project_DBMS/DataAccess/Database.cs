using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_DBMS.DataAccess
{
    public class Database
    {
        private SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public SqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable getDataTable(string str)
        {
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand(str, getConnection);
            try
            {
                openConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { closeConnection(); }
            return dataTable;
        }
        /// <summary>
        /// Chạy query, trả về datatable
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            conn = getConnection;
            SqlCommand command = new SqlCommand(query, conn);
            if (parameter != null)
            {
                command.Parameters.AddRange(parameter);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            closeConnection();
            return data;
        }
        /// <summary>
        /// Xử lý các câu lệnh stored procedure, trả về 1 giá trị (execuscalar) hoặc 1 datatable (executeReader)
        /// </summary>
        /// <param name="query">Câu query</param>
        /// <param name="parametervalue">Mảng các giá trị tham số</param>
        /// <param name="paramName">Mảng tên các giá trị tham số</param>
        /// <param name="isExecReader">xác định xem output là datatable hay 1 giá trị object</param>
        /// <returns></returns>
        public object getResultFromProc(string query, object[] parametervalue = null, string[] paramName = null, bool isExecReader = false)
        {
            conn = getConnection;
            openConnection();
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Nếu có tham số, gán cho SqlCommand
            if (parametervalue != null && paramName != null)
            {
                // Giả sử rằng tham số được truyền vào sẽ là các giá trị kiểu object.
                for (int i = 0; i < parametervalue.Length; i++)
                {
                    // Gán tham số vào SqlCommand
                    sqlCommand.Parameters.AddWithValue(paramName[i], parametervalue[i]);
                    
                }
            }
            if (isExecReader)
            {
                try
                {
                    DataTable dt = new DataTable();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {

                        dt.Load(reader); // Tải dữ liệu từ SqlDataReader vào DataTable
                    }
                    return dt; // Trả về DataTable chứa kết quả
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return null;
                }

            }
            object result = sqlCommand.ExecuteScalar();
            closeConnection();
            return result;
        }

    }
}
