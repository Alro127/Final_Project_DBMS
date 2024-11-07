using Final_Project_DBMS.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_DBMS.View.Screen_BanHang
{
    public partial class UC_DichVuCard : UserControl
    {
        DA_ChiTietSPDV dA = new DA_ChiTietSPDV();
        public EventHandler addHoaDon;
        public EventHandler chitietvatpham;
        private int id;
        private decimal giaUudai;
        private string ten;
        private decimal giaGoc;
        private string link;
        public int Id { get => id; set => id = value; }
        public decimal GiaUudai { get => giaUudai; set => giaUudai = value; }
        public string Ten { get => ten; set => ten = value; }
        public decimal GiaGoc { get => giaGoc; set => giaGoc = value; }
        public string Link { get => link; set => link = value; }

        public UC_DichVuCard(int id, string name, decimal giagoc, decimal giauudai, string link, int sophongtrong)
        {
            InitializeComponent();
            this.Id = id;
            this.GiaUudai = giauudai;
            this.Ten = name;
            this.Link = link;
            this.giaGoc = giagoc;
            lbl_gia_goc.Text = giagoc.ToString("#,0") + "VND";
            lbl_gia_uu_dai.Text = giauudai.ToString("#,0") + "VND";
            lbl_ten.Text = name;
            lbl_so_phong.Text = sophongtrong.ToString();
            lbl_gia_goc.TextAlign = ContentAlignment.MiddleCenter;
            lbl_gia_uu_dai.TextAlign = ContentAlignment.MiddleCenter;
            lbl_ten.AutoSize = false;
            lbl_ten.TextAlign = ContentAlignment.MiddleCenter;
            picture_spdv.ImageLocation = link;
            picture_spdv.SizeMode = PictureBoxSizeMode.StretchImage;
            
            // Kiểm tra xem số lượng phòng trống có thỏa mãn để đặt không.
            canBeBought();
        }

        private void canBeBought()
        {
            if (dA.coKhaNangDatPhong(Id))
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_chi_tiet_Click(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (chitietvatpham != null)
            {
                chitietvatpham(this, e);
            }
        }
        private void lbl_ten_Click(object sender, EventArgs e)
        {

        }

        private void UC_DichVuCard_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (addHoaDon != null)
            {
                addHoaDon(this, e);
            }
        }
    }
}
