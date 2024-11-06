using Final_Project_DBMS.control.converter;
using Final_Project_DBMS.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_DBMS.View.Screen_QuanLy
{
    public partial class UC_QuanLy : UserControl
    {
        DA_QuanLy dA_QuanLy = new DA_QuanLy();
        int ma;
        private ContextMenuStrip contextMenuStrip;
        public UC_QuanLy()
        {
            InitializeComponent();
            // Khởi tạo ContextMenuStrip
            contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem menuItemXoa = new ToolStripMenuItem("Xóa Ảnh");
            menuItemXoa.Click += MenuItemXoa_Click;
            contextMenuStrip.Items.Add(menuItemXoa);
        }
        public void LoadData()
        {
            dgv_NhanVien.DataSource = dA_QuanLy.DanhSachNhanVien();
            dgv_KhachHang.DataSource = dA_QuanLy.DanhSachKhachHang();
            dgv_ThuCung.DataSource = dA_QuanLy.DanhSachThuCung();
            dgv_VatPham.DataSource = dA_QuanLy.DanhSachVatPham();
            dgv_DichVu.DataSource = dA_QuanLy.DanhSachDichVu();
        }

        private void UC_QuanLy_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void MenuItemXoa_Click(object sender, EventArgs e)
        {
            string imageLocation = contextMenuStrip.Tag as string;
            string filePath = imageLocation.Replace("file:///", "");
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Không tìm thấy hình ảnh để xóa.");
                return;
            }


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hình ảnh này?", "Xóa Ảnh", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File không tồn tại: " + filePath);
                    return;
                }
                try
                {
                    File.Delete(filePath);
                    string a = "";
                    filePath = filePath.Replace("D:/HQTCSDL/PetShop/Final_Project_DBMS/Final_Project_DBMS/", "");
                    // Gọi procedure để xóa thông tin hình ảnh khỏi cơ sở dữ liệu
                    filePath = filePath.Replace("/",@"\").Trim();
                    string[] paramNames = { "@Ma_SPDV", "@Duong_Dan" };
                    object[] paramValues = { ma, filePath };
                    dA_QuanLy.ExecProcedure("proc_XoaHinhAnh",paramValues,paramNames);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa hình ảnh: {ex.Message}");
                    return;
                }

            }
        }
        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgv_NhanVien.Rows[e.RowIndex].IsNewRow)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgv_NhanVien.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox
                lb_maNV.Text = row.Cells["Ma_Nhan_Vien"].Value.ToString();
                txb_TenNV.Text = row.Cells["Ho_Ten"].Value.ToString();
                txb_sdtNV.Text = row.Cells["SDT"].Value.ToString();
                txb_DiaChiNV.Text = row.Cells["Dia_Chi"].Value.ToString();
                dtp_NgaySinhNV.Value = Convert.ToDateTime(row.Cells["Ngay_Sinh"].Value);
                cb_GioiTinh.Text = row.Cells["Gioi_Tinh"].Value.ToString();
                txb_CongViec.Text = row.Cells["Cong_Viec"].Value.ToString();
                txb_LuongNV.Text = row.Cells["Luong"].Value.ToString();
                txb_MaQL.Text = row.Cells["Ma_NQL"].Value.ToString();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(lb_maNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên bạn muốn sửa");
            }
            else
            {
                try
                {
                    // Lấy dữ liệu từ các TextBox
                    int maNhanVien = Convert.ToInt32(lb_maNV.Text);
                    string hoTen = txb_TenNV.Text.Trim();
                    DateTime ngaySinh = dtp_NgaySinhNV.Value;
                    string gioiTinh = cb_GioiTinh.Text.Trim();
                    string diaChi = txb_DiaChiNV.Text.Trim();
                    string sdt = txb_sdtNV.Text.Trim();
                    decimal luong = decimal.Parse(txb_LuongNV.Text);
                    string congViec = txb_CongViec.Text.Trim();
                    int maNQL = Convert.ToInt32(txb_MaQL.Text.Trim());

                    // Nếu tất cả các kiểm tra đều hợp lệ, tiến hành gọi Stored Procedure
                    string[] parameterNames = { "@Ma_Nhan_Vien", "@Ho_Ten", "@Ngay_Sinh", "@Gioi_Tinh", "@Dia_Chi", "@SDT", "@Luong", "@Cong_Viec", "@Ma_NQL" };
                    object[] parameters = { maNhanVien, hoTen, ngaySinh, gioiTinh, diaChi, sdt, luong, congViec, maNQL };
                    dA_QuanLy.ExecProcedure("proc_SuaNhanVien", parameters, parameterNames);
                }
                catch (FormatException ex)
                {
                    // Bắt lỗi định dạng dữ liệu (ví dụ: số điện thoại không hợp lệ)
                    MessageBox.Show("Lỗi định dạng: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Bắt lỗi chung khác
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    LoadData();
                }
            }
        }

        private void btn_ThemNhanVien_Click(object sender, EventArgs e)
        {
            if(lb_maNV.Text != "")
            {
                MessageBox.Show("Vui lòng làm sạch để bắt đầu nhập thông tin thêm!");
            }
            else
            {
                try
                {
                    // Lấy dữ liệu từ các TextBox
                    string hoTen = txb_TenNV.Text.Trim();
                    DateTime ngaySinh = dtp_NgaySinhNV.Value;
                    string gioiTinh = cb_GioiTinh.Text.Trim();
                    string diaChi = txb_DiaChiNV.Text.Trim();   
                    string sdt = txb_sdtNV.Text.Trim();
                    decimal luong = decimal.Parse(txb_LuongNV.Text);
                    string congViec = txb_CongViec.Text.Trim();
                    int maNQL = Convert.ToInt32(txb_MaQL.Text.Trim());

                    // Nếu tất cả các kiểm tra đều hợp lệ, tiến hành gọi Stored Procedure
                    string[] parameterNames = {"@Ho_Ten", "@Ngay_Sinh", "@Gioi_Tinh", "@Dia_Chi", "@SDT", "@Luong", "@Cong_Viec", "@Ma_NQL" };
                    object[] parameters = { hoTen, ngaySinh, gioiTinh, diaChi, sdt, luong, congViec, maNQL };
                    dA_QuanLy.ExecProcedure("proc_ThemNhanVien",parameters, parameterNames);
                }
                catch (FormatException ex)
                {
                    // Bắt lỗi định dạng dữ liệu (ví dụ: số điện thoại không hợp lệ)
                    MessageBox.Show("Lỗi định dạng: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Bắt lỗi chung khác
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    LoadData();
                }
            }    
        }

        private void btn_LamSach_Click(object sender, EventArgs e)
        {
            lb_maNV.Text = "";
            txb_TenNV.Text = "";
            txb_sdtNV.Text = "";
            txb_DiaChiNV.Text = "";
            dtp_NgaySinhNV.Value = DateTime.Now;
            cb_GioiTinh.Text = "";
            txb_CongViec.Text = "";
            txb_LuongNV.Text = "";
            txb_MaQL.Text = "";
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (lb_maNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn vào nhân viên bạn muốn xóa");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(
               "Bạn có chắc chắn muốn xóa nhân viên này không?", // Thông điệp
               "Xác nhận xóa", // Tiêu đề
               MessageBoxButtons.YesNo, // Các nút
               MessageBoxIcon.Question // Biểu tượng
                );

                // Kiểm tra kết quả
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int maNhanVien = Convert.ToInt32(lb_maNV.Text);
                        string[] parameterNames = { "@Ma_Nhan_Vien" };
                        object[] parameters = { maNhanVien };
                        dA_QuanLy.ExecProcedure("proc_XoaNhanVien", parameters, parameterNames);
                    }
                    catch (FormatException ex)
                    {
                        // Bắt lỗi định dạng dữ liệu (ví dụ: số điện thoại không hợp lệ)
                        MessageBox.Show("Lỗi định dạng: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        // Bắt lỗi chung khác
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                    finally
                    {
                        LoadData();
                    }
                }
                else
                {
                    // Nếu người dùng nhấn "No", không làm gì cả
                    // Có thể hiển thị thông báo hoặc thực hiện hành động khác nếu cần
                    MessageBox.Show("Hành động xóa đã bị hủy.");
                }
            }    
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            if(lbl_maKH.Text=="")
            {
                MessageBox.Show("Vui lòng chọn khách hàng bạn muốn sửa");
            }    
            else
            {
                try
                {
                    // Lấy dữ liệu từ các TextBox
                    int maKhachHang = Convert.ToInt32(lbl_maKH.Text);
                    string hoTen = txb_TenKH.Text.Trim();
                    string sdt = txb_sdtKH.Text.Trim();
                    int diemTichLuy = Convert.ToInt32(txb_DiemTichLuy.Text);

                    // Nếu tất cả các kiểm tra đều hợp lệ, tiến hành gọi Stored Procedure
                    string[] parameterNames = { "@Ma_Khach_Hang", "@Ten", "@SDT", "Diem_Tich_Luy" };
                    object[] parameters = { maKhachHang, hoTen, sdt, diemTichLuy };
                    dA_QuanLy.ExecProcedure("proc_SuaKhachHang", parameters, parameterNames);
                }
                catch (FormatException ex)
                {
                    // Bắt lỗi định dạng dữ liệu (ví dụ: số điện thoại không hợp lệ)
                    MessageBox.Show("Lỗi định dạng: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Bắt lỗi chung khác
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    LoadData();
                }
            }
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgv_KhachHang.Rows[e.RowIndex].IsNewRow)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgv_KhachHang.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox
                lbl_maKH.Text = row.Cells["Ma_Khach_Hang"].Value.ToString();
                txb_TenKH.Text = row.Cells["Ten"].Value.ToString();
                txb_sdtKH.Text = row.Cells["SDT"].Value.ToString();
                txb_DiemTichLuy.Text = row.Cells["Diem_Tich_Luy"].Value.ToString();
            }
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            if (lbl_maKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn vào khách hàng bạn muốn xóa.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(
               "Bạn có chắc chắn muốn xóa khách hàng này không?", // Thông điệp
               "Xác nhận xóa", // Tiêu đề
               MessageBoxButtons.YesNo, // Các nút
               MessageBoxIcon.Question // Biểu tượng
                );

                // Kiểm tra kết quả
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int maKhachHang= Convert.ToInt32(lbl_maKH.Text);
                        string[] parameterNames = { "@Ma_Khach_Hang" };
                        object[] parameters = { maKhachHang };
                        dA_QuanLy.ExecProcedure("proc_XoaKhachHang", parameters, parameterNames);
                    }
                    catch (FormatException ex)
                    {
                        // Bắt lỗi định dạng dữ liệu (ví dụ: số điện thoại không hợp lệ)
                        MessageBox.Show("Lỗi định dạng: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        // Bắt lỗi chung khác
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                    finally
                    {
                        LoadData();
                    }
                }
                else
                {
                    // Nếu người dùng nhấn "No", không làm gì cả
                    // Có thể hiển thị thông báo hoặc thực hiện hành động khác nếu cần
                    MessageBox.Show("Hành động xóa đã bị hủy.");
                }
            }
        }

        private void dgv_ThuCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgv_ThuCung.Rows[e.RowIndex].IsNewRow)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgv_ThuCung.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox
                lb_maTC.Text = row.Cells["Mã Thú Cưng"].Value.ToString();
                txb_TenTC.Text = row.Cells["Tên Thú Cưng"].Value.ToString();
                txb_Loai.Text = row.Cells["Loài"].Value.ToString();
                txb_GiongTC.Text = row.Cells["Giống"].Value.ToString();
                dtp_NgaySinhTC.Value = Convert.ToDateTime(row.Cells["Ngày Sinh"].Value);
                txb_MauSacTC.Text = row.Cells["Màu Sắc"].Value.ToString();
                txb_CanNangTC.Text = row.Cells["Cân Nặng (kg)"].Value.ToString();
                cb_sucKhoeTC.Text = row.Cells["Tình Trạng Sức Khỏe"].Value.ToString();
                cb_trangThaiTC.Text = row.Cells["Trạng Thái"].Value.ToString();
                txb_SoMuiTiemTC.Text = row.Cells["Số Lần Tiêm"].Value.ToString();
                cb_GioiTinhTC.Text = row.Cells["Giới Tính"].Value.ToString();
                txb_GiaGocTC.Text = row.Cells["Giá Bán Gốc"].Value.ToString();
                txb_GiaKMTC.Text = row.Cells["Giá Khuyến Mại"].Value.ToString();
                rtb_moTaTC.Text = row.Cells["Mô tả"].Value.ToString();
                flp_HinhAnhTC.Controls.Clear();
                btn_ThemAnhTC.Tag = lb_maTC.Text;
                ma = Convert.ToInt32(lb_maTC.Text);
                LoadImages("thucung");
            }
        }
        private void LoadImages(string loai)
        {
            string query = "SELECT * FROM HinhAnh WHERE Ma_SPDV = @Ma_SPDV";
            // Khai báo các mảng cho tên tham số và giá trị tham số
            string[] parameterNames = new string[] { "@Ma_SPDV" }; // Tên tham số
            object[] parameterValues = new object[] { ma }; // Giá trị tham số

            // Thực thi truy vấn và nhận DataTable
            DataTable table = dA_QuanLy.ExecuteQuery(query, parameterValues, parameterNames);

            // Gọi hàm để thêm hình ảnh vào FlowLayoutPanel
            AddImagesToFlowLayout(table, loai);
        }

        private void AddImagesToFlowLayout(DataTable table, string loai)
        {
            foreach (DataRow rowHA in table.Rows)
            {
                // Lấy đường dẫn hình ảnh từ cột "Duong_Dan" của bảng
                string link = rowHA["Duong_Dan"].ToString();

                // Chuyển đổi đường dẫn
                link = imageLinkConverter.Convert(link).ToString();

                // Tạo PictureBox mới cho mỗi hình ảnh
                PictureBox pictureBox = CreatePictureBox(link);
                pictureBox.Tag = rowHA["Ma_SPDV"]; // Lưu trữ ID hình ảnh (nếu cần)

                // Thêm PictureBox vào FlowLayoutPanel tương ứng
                AddPictureBoxToPanel(pictureBox, loai);
            }
        }

        private PictureBox CreatePictureBox(string link)
        {
            return new PictureBox
            {
                Width = 100,
                Height = 100,
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = link
            };
        }

        private void AddPictureBoxToPanel(PictureBox pictureBox, string loai)
        {
            if (loai == "thucung")
            {
                flp_HinhAnhTC.Controls.Add(pictureBox);
            }
            else if (loai == "vatpham")
            {
                flp_HinhAnhVP.Controls.Add(pictureBox);
            }
            else if (loai == "dichvu")
            {
                flp_HinhAnhDV.Controls.Add(pictureBox);
            }

            pictureBox.MouseDown += PictureBox_MouseDown;
        }
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PictureBox pictureBox = sender as PictureBox;

                if (pictureBox != null)
                {
                    //Lưu đường dẫn ảnh vào Tag của menu item
                    contextMenuStrip.Tag = pictureBox.ImageLocation;
                    // Hiển thị menu ngữ cảnh
                    contextMenuStrip.Show(pictureBox, e.Location);
                }
            }
        }

        private void dgv_VatPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgv_VatPham.Rows[e.RowIndex].IsNewRow)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgv_VatPham.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox
                lb_maVP.Text = row.Cells["Ma_Vat_Pham"].Value.ToString();
                txb_TenVP.Text = row.Cells["Ten_San_Pham"].Value.ToString();
                txb_ThuongHieuVP.Text = row.Cells["Thuong_Hieu"].Value.ToString();
                dtp_HSDVP.Value = Convert.ToDateTime(row.Cells["Han_Su_Dung"].Value);
                txb_SoLuongVP.Text = row.Cells["So_Luong_Ton_Kho"].Value.ToString();
                txb_GiaGocVP.Text = row.Cells["Gia_Ban_Goc"].Value.ToString();
                txb_GiaKMVP.Text = row.Cells["Gia_Khuyen_Mai"].Value.ToString();
                rtb_moTaVP.Text = row.Cells["Mo_Ta"].Value.ToString();
                flp_HinhAnhVP.Controls.Clear();
                btn_ThemAnhVP.Tag = lb_maVP.Text;
                ma = Convert.ToInt32(lb_maVP.Text);
                LoadImages("vatpham");
            }
        }

        private void dgv_DichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgv_DichVu.Rows[e.RowIndex].IsNewRow)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgv_DichVu.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox
                lb_maDV.Text = row.Cells["Ma_Dich_Vu"].Value.ToString();
                txb_TenDV.Text = row.Cells["Ten_Dich_Vu"].Value.ToString();
                txb_GiaGocDV.Text = row.Cells["Gia_Ban_Goc"].Value.ToString();
                txb_GiaKMDV.Text = row.Cells["Gia_Khuyen_Mai"].Value.ToString();
                txb_TGTH.Text = row.Cells["Thoi_Gian_Thuc_Hien"].Value.ToString();
                rtb_motaDV.Text = row.Cells["Mo_Ta"].Value.ToString();
                txb_SoPhong.Text = row.Cells["So_Luong_Phong_Trong"].Value.ToString();
                flp_HinhAnhDV.Controls.Clear();
                btn_ThemAnhDV.Tag = lb_maDV.Text;
                ma = Convert.ToInt32(lb_maDV.Text);
                LoadImages("dichvu");
            }
        }

        private void btn_ThemAnhTC_Click(object sender, EventArgs e)
        {

        }
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Lấy Mã Thú Cưng từ Tag của nút
            if (clickedButton?.Tag == null)
            {
                MessageBox.Show("Mã sản phẩm và dịch vụ không hợp lệ.");
                return;
            }

            int maSPDV = Convert.ToInt32(clickedButton.Tag);

            // Tiến hành xử lý thêm ảnh
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn Hình Ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    // Đường dẫn lưu hình ảnh
                    string imagePath = $"D:\\HQTCSDL\\PetShop\\DBMS_FinalProject\\DBMS_\\assets\\images\\{maSPDV}\\" + Path.GetFileName(selectedImagePath);

                    // Tạo thư mục nếu chưa tồn tại
                    string directoryPath = $"D:\\HQTCSDL\\PetShop\\DBMS_FinalProject\\assets\\images\\{maSPDV}";
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }
                    // Sao chép hình ảnh vào thư mục
                    try
                    {
                        File.Copy(selectedImagePath, imagePath, true);
                        // Gọi procedure để lưu thông tin hình ảnh vào cơ sở dữ liệu
                        string[] paramNames = { "@Ma_SPDV", "@Duong_Dan" };
                        object[] paramValues = { maSPDV, imagePath };

                        //object result = db.getResultFromProc("sp_ThemHinhAnh", paramValues, paramNames, false);

                    //    if (result != null)
                    //    {
                    //        MessageBox.Show(result.ToString()); // Hiển thị thông báo từ stored procedure // Tải lại hình ảnh để cập nhật giao diện
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("Đã xảy ra lỗi khi thêm hình ảnh.");
                    //    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi sao chép hình ảnh: {ex.Message}");
                        return; // Kết thúc hàm nếu sao chép không thành công
                    }
                }
            }
        }
    }
}
