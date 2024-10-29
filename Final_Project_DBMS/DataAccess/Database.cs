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
    }
}
