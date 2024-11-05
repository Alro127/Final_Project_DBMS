using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_DBMS.control.converter;

namespace Final_Project_DBMS.DataAccess
{
    public class DA_BanHang
    {
        Database db = new Database();
        public string getSearchBTNIcon()
        {
            string img_link = @"assets\images\chucnangbanhang\icon\Search_Icon.png";
            img_link = imageLinkConverter.Convert(img_link).ToString();
            Uri uri = new Uri(img_link);
            string filePath = uri.LocalPath;
            return filePath;
        }
        public DataTable getView(string viewName)
        {
            return db.ExecuteQuery("SELECT * FROM " + viewName);
        }
        public DataTable getHinhAnhSPDV(int idSPDV)
        {
            string sqlcmd = "proc_HinhAnhSPDV";
            string[] paramName = { "@idSPDV" };
            object[] paramValue = { idSPDV };
            return (DataTable)db.getResultFromProc(sqlcmd,paramName:paramName, parametervalue:paramValue, isExecReader:true);
        }
        /// <summary>
        /// Hàm tìm kiếm sẽ tìm kiếm một lần dựa trên tất cả các điều kiện.
        /// Mặc định tất cả tham số sẽ là null.
        /// Nếu tất cả tham số là null, không thực hiện tìm kiếm, trả về null.
        /// Output là một datatable thỏa tất cả điều kiện tìm kiếm.
        /// </summary>
        /// <param name="tenView">Tên view muốn thực hiện tìm kiếm</param>
        /// <param name="tenCot">Cột để tìm kiếm dựa trên từ khóa của txt_tim_kiem</param>
        /// <param name="tukhoa">Từ khóa</param>
        /// <param name="startingValue">giá khởi điểm</param>
        /// <param name="endingValue">giá kết thúc</param>
        /// <param name="orderColumnGiaTien">Dùng cho cb giá tiền để kiểm tra cách order</param>
        /// <param name="orderColumnTen">Dùng cho cb tên để kiểm tra cách order</param>
        /// <returns></returns>
        public DataTable TimKiem(string tenView = null, string tenCot = null, string tukhoa = null, string startingValue = null,
            string endingValue = null, string orderColumnGiaTien = null, string orderColumnTen = null, string Gia_Khuyen_Mai = "Gia_Khuyen_Mai")
        {
            /*string tukhoa = "";
            if (txt_tim_kiem.Text.Length == 0 || txt_tim_kiem.Text.Equals("Tìm kiếm"))
            {
                tukhoa = "";
            }
            else
            {
                tukhoa = txt_tim_kiem.Text;
            }*/
            if (tenView == null && tenCot == null && tukhoa == null && startingValue == null 
                && endingValue == null && orderColumnGiaTien == null && orderColumnTen == null)
            {
                return null;
            }
            string cmd = "proc_TimKiemSanPhamVaDichVu";
            object[] paramValues = { tenView, tenCot, tukhoa, startingValue, endingValue,
                Gia_Khuyen_Mai, orderColumnGiaTien, tenCot, orderColumnTen };
            string[] paramNames = { "@tenview", "@tencot", "@tukhoa", "@ValueA", "@ValueB",
                "@SortColumnGiaTien", "@SortOrderGiaTien", "@SortColumnTen", "@SortOrderTen" };
            DataTable dt = (DataTable)db.getResultFromProc(cmd, paramValues, paramNames, true);
            return dt;
        }
    }
}
