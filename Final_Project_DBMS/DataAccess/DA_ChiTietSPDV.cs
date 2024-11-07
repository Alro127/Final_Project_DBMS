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
        public DataTable layChiTietThuCung(int idSPDV)
        {
            string cmd = "SELECT * FROM dbo.func_XemChiTietThuCung(" + idSPDV.ToString() + ")";
            return db.ExecuteQuery(cmd);
        }
        public DataTable layHinhanh(int idSPDV)
        {
            string cmd = "Select * from HinhAnh where Ma_SPDV = " + idSPDV.ToString();
            return db.ExecuteQuery(cmd);
        }
        public DataTable layChiTietVatPham(int idSPDV)
        {
            string cmd = "SELECT * FROM dbo.func_XemChiTietVatPham(" + idSPDV.ToString() + ")";
            return db.ExecuteQuery(cmd);
        }
        public DataTable layChiTietDichVu(int idSPDV)
        {
            string cmd = "Select * from func_XemChiTietDichVu(" + idSPDV.ToString() + ")";
            return db.ExecuteQuery(cmd);
        }
        public DataTable layThongTinPhong(int idSPDV)
        {
            string cmd = "Select * from func_XemThongTinPhong(" + idSPDV.ToString() + ")";
            return db.ExecuteQuery(cmd);
        }
        public void capNhatTrangThaiPhongDichVu(string sqlcmd, string[] paramNames, object[] paramValues)
        {
            db.getResultFromProc(sqlcmd, paramValues, paramNames);
        }
        public bool coKhaNangDatPhong(int idSPDV)
        {
            string cmd = "SELECT dbo.func_KiemTraSoLuongPhongTrong(@idSPDV)";
            string[] paramName = { "@idSPDV" };
            object[] paramValue = { idSPDV };
            return (bool)db.getResultFromProc(cmd, parametervalue:paramValue, paramName:paramName, isText: true);
        }
        public DataTable taiPhongDichVu(int iDDV)
        {
            string sqlcmd = "SELECT * FROM dbo.func_XemPhongDichVuSanSang(@idDV)";
            string[] paramNames = { "@idDV" };
            object[] paramValues = { iDDV };
            return (DataTable)db.getResultFromProc(sqlcmd, paramValues, paramNames, isText: true, isExecReader:true);
        }
    }
}
