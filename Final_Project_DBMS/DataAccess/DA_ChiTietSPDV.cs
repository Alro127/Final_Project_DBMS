using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_DBMS.DataAccess
{
    public class DA_ChiTietSPDV
    {
        Database db = new Database();
        public DataTable getChiTietThuCung(int idSPDV)
        {
            string cmd = "SELECT * FROM dbo.func_XemChiTietThuCung(" + idSPDV.ToString() + ")";
            return db.ExecuteQuery(cmd);
        }
        public DataTable getHinhAnh(int idSPDV)
        {
            string cmd = "Select * from HinhAnh where Ma_SPDV = " + idSPDV.ToString();
            return db.ExecuteQuery(cmd);
        }
        public DataTable getChiTietVatPham(int idSPDV)
        {
            string cmd = "SELECT * FROM dbo.func_XemChiTietVatPham(" + idSPDV.ToString() + ")";
            return db.ExecuteQuery(cmd);
        }
        public DataTable getChiTietDichVu(int idSPDV)
        {
            string cmd = "Select * from func_XemChiTietDichVu(" + idSPDV.ToString() + ")";
            return db.ExecuteQuery(cmd);
        }
    }
}
