using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Project_DBMS.DataAccess
{
    public class Database
    {

        private SqlConnection connAdmin = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private SqlConnection conn = new SqlConnection("Server=MEOWWW\\DAT; Database=PetShop; User Id=" + DA_TaiKhoan.username + "; Password=" + DA_TaiKhoan.password + ";");
        /*private SqlConnection conn = new SqlConnection("Server=HNT\\MSSQLSERVER04; Database=PetShop; User Id=" + DA_TaiKhoan.username + "; Password=" + DA_TaiKhoan.password + ";");*/
        public SqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }
        public SqlConnection getConnectionAdmin
        {
            get
            {
                return connAdmin;
            }
        }
        public void openConnectionAdmin()
        {
            if (connAdmin.State == ConnectionState.Closed)
            {
                connAdmin.Open();
            }
        }
        public void closeConnectionAdmin()
        {
            if (connAdmin.State == ConnectionState.Open)
            {
                connAdmin.Close();
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
            openConnection();
            SqlCommand command = new SqlCommand(query, conn);
            if (parameter != null)
            {
                command.Parameters.AddRange(parameter);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(data);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Warning");
            }
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
        /// <param name="isText">Xác định xemm kiểu câu lệnh là text hay stored procedure, mặc định là storedProcedure</param>
        /// <returns></returns>
        public object getResultFromProc(string query, object[] parametervalue = null, string[] paramName = null, bool isExecReader = false, bool isText = false)
        {
            conn = getConnection;
            openConnection();
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            if (isText)
                sqlCommand.CommandType = CommandType.Text;
            else
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
            try
            {
                object result = sqlCommand.ExecuteScalar();
                closeConnection();
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());

            }
            return null;
           
        }
        public object ExecuteReturnAdmin(string query, SqlParameter[] parameters)
        {
            object result = null;
            SqlCommand cmd = new SqlCommand(query, getConnectionAdmin);
            try
            {
                openConnectionAdmin();
                cmd.Parameters.AddRange(parameters);
                result = cmd.ExecuteScalar();    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { closeConnectionAdmin(); }
            return result;
        }
        public bool ExecuteNonReturnAdmin(string proc, SqlParameter[] parameters)
        {
            bool result = false;

            try
            {
                openConnectionAdmin();
                SqlCommand cmd = new SqlCommand(proc, getConnectionAdmin);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);
                int rowsAffected = cmd.ExecuteNonQuery();
                result = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { closeConnectionAdmin(); }
            return result;
        }
        public int ExecuteQueryLayMa(string procedureName, object[] parameters, string[] parameterNames)
        {
            int maspdv = -1; // Giá trị mặc định trả về nếu có lỗi
            conn = getConnection;
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
                openConnection();
                int rowsAffected = cmd.ExecuteNonQuery();

                // Kiểm tra kết quả sau khi thực hiện
                if (rowsAffected > 0)
                {
                    // Lấy giá trị từ tham số đầu ra @Ma_SPDV
                    maspdv = (int)maSpdvParam.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return maspdv;
        }
        public bool ExecProcedure(string procedureName, object[] parameters, string[] parameterNames)
        {
            conn = getConnection;
            SqlCommand cmd = new SqlCommand(procedureName, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm các tham số vào SqlCommand
            for (int i = 0; i < parameterNames.Length; i++)
            {
                cmd.Parameters.AddWithValue(parameterNames[i], parameters[i]);
            }

            try
            {
                openConnection();
                int rowsAffected = cmd.ExecuteNonQuery();
                // Hiển thị thông báo sau khi thực hiện
                if (rowsAffected != 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return false;
        }
    }
}