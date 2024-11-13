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
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace Final_Project_DBMS.View.Screen_QuanLy
{
    public partial class UC_QuanLy : UserControl
    {
        DA_QuanLy dA_QuanLy = new DA_QuanLy();
        int ma;
        private ContextMenuStrip contextMenuStrip;
        List<String> anhTemp = new List<String>();
        List<String> anhRoot = new List<String>();
        string loai;
        string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
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
            LoadPhongDichVu();
        }
        private void UC_QuanLy_Load(object sender, EventArgs e)
        {
            LoadData();
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
            string hoTen = txb_TenNV.Text.Trim();
            DateTime ngaySinh = dtp_NgaySinhNV.Value;
            string gioiTinh = cb_GioiTinh.Text.Trim();
            string diaChi = txb_DiaChiNV.Text.Trim();
            string sdt = txb_sdtNV.Text.Trim();
            decimal luong = decimal.Parse(txb_LuongNV.Text);
            string congViec = txb_CongViec.Text.Trim();
            int maNQL = Convert.ToInt32(txb_MaQL.Text.Trim());
            if (lb_maNV.Text == "")
            {
                try
                {
                    // Nếu tất cả các kiểm tra đều hợp lệ, tiến hành gọi Stored Procedure
                    object[] parameters = { hoTen, ngaySinh, gioiTinh, diaChi, sdt, luong, congViec, maNQL };
                    bool res = dA_QuanLy.ThemNhanVien( parameters);
                    if (res)
                    {
                        MessageBox.Show("Thông tin nhân viên đã được thêm thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không có thay đổi nào được thực hiện.");
                    }    
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
                try
                {
                    // Lấy dữ liệu từ các TextBox
                    int maNhanVien = Convert.ToInt32(lb_maNV.Text);

                    // Nếu tất cả các kiểm tra đều hợp lệ, tiến hành gọi Stored Procedure
                    object[] parameters = { maNhanVien, hoTen, ngaySinh, gioiTinh, diaChi, sdt, luong, congViec, maNQL };
                    bool res = dA_QuanLy.SuaNhanVien(parameters);
                    if (res)
                    {
                        MessageBox.Show("Thông tin nhân viên đã được sửa thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không có thay đổi nào được thực hiện.");
                    }
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
                        object[] parameters = { maNhanVien };
                        bool res = dA_QuanLy.XoaNhanVien( parameters);
                        if (res)
                        {
                            MessageBox.Show("Thông tin nhân viên đã được xóa thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không có thay đổi nào được thực hiện.");
                        }
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
                    object[] parameters = { maKhachHang, hoTen, sdt, diemTichLuy };
                    bool res = dA_QuanLy.SuaKhachHang(parameters);
                    if (res)
                    {
                        MessageBox.Show("Thông tin khách hàng đã được sửa thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không có thay đổi nào được thực hiện.");
                    }
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
                        object[] parameters = { maKhachHang };
                        dA_QuanLy.XoaKhachHang(parameters);
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
        }

        private void dgv_ThuCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgv_ThuCung.Rows[e.RowIndex].IsNewRow)
            {
                anhTemp.Clear();
                // Lấy dòng hiện tại
                DataGridViewRow row = dgv_ThuCung.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox
                lb_maTC.Text = row.Cells["Ma_Thu_Cung"].Value.ToString();
                txb_TenTC.Text = row.Cells["Ten"].Value.ToString();
                txb_Loai.Text = row.Cells["Loai"].Value.ToString();
                txb_GiongTC.Text = row.Cells["Giong"].Value.ToString();
                dtp_NgaySinhTC.Value = Convert.ToDateTime(row.Cells["Ngay_Sinh"].Value);
                txb_MauSacTC.Text = row.Cells["Mau_Sac"].Value.ToString();
                txb_CanNangTC.Text = row.Cells["Can_Nang"].Value.ToString();
                cb_sucKhoeTC.Text = row.Cells["Tinh_Trang_Suc_Khoe"].Value.ToString();
                cb_trangThaiTC.Text = row.Cells["Trang_Thai"].Value.ToString();
                txb_SoMuiTiemTC.Text = row.Cells["So_Lan_Tiem"].Value.ToString();
                cb_GioiTinhTC.Text = row.Cells["Gioi_Tinh"].Value.ToString();
                txb_GiaGocTC.Text = row.Cells["Gia_Ban_Goc"].Value.ToString();
                txb_GiaKMTC.Text = row.Cells["Gia_Khuyen_Mai"].Value.ToString();
                rtb_motaTC.Text = row.Cells["Mo_Ta"].Value.ToString();
                flp_HinhAnhTC.Controls.Clear();
                btn_ThemAnhTC.Tag = lb_maTC.Text;
                ma = Convert.ToInt32(lb_maTC.Text);
                LoadImages();
            }
        }
        private void LoadImages()
        {
            string query = "SELECT * FROM HinhAnh WHERE Ma_SPDV = @Ma_SPDV";
            // Khai báo các mảng cho tên tham số và giá trị tham số
            string[] parameterNames = new string[] { "@Ma_SPDV" }; // Tên tham số
            object[] parameterValues = new object[] { ma }; // Giá trị tham số

            // Thực thi truy vấn và nhận DataTable
            DataTable table = dA_QuanLy.ExecuteQuery(query, parameterValues, parameterNames);

            // Gọi hàm để thêm hình ảnh vào FlowLayoutPanel
            AddImagesToFlowLayout(table);
        }

        private void AddImagesToFlowLayout(DataTable table)
        {
            foreach (DataRow rowHA in table.Rows)
            {
                // Lấy đường dẫn hình ảnh từ cột "Duong_Dan" của bảng
                string link = rowHA["Duong_Dan"].ToString();

                // Tạo PictureBox mới cho mỗi hình ảnh với bản sao ảnh
                PictureBox pictureBox = CreatePictureBox(link);

                // Thêm PictureBox vào FlowLayoutPanel tương ứng
                AddPictureBoxToPanel(pictureBox);
            }
        }

        private PictureBox CreatePictureBox(string path)
        {
            PictureBox pictureBox = new PictureBox
            {
                Width = 100,
                Height = 100,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            path = imageLinkConverter.Convert(path).ToString();
            path = path.Replace("file:///", "");
            pictureBox.Tag = path; // Lưu trữ ID hình ảnh (nếu cần)
            // Tạo FileStream để mở ảnh và tạo bản sao ảnh
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                pictureBox.Image = new Bitmap(fs); // Tạo bản sao ảnh
            }

            return pictureBox;
        }
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PictureBox pictureBox = sender as PictureBox;

                if (pictureBox != null)
                {
                    // Lưu đường dẫn ảnh vào Tag của menu item
                    contextMenuStrip.Tag = pictureBox.Tag;
                    // Hiển thị menu ngữ cảnh
                    contextMenuStrip.Show(pictureBox, e.Location);
                }
            }
        }

        private void MenuItemXoa_Click(object sender, EventArgs e)
        {
            string filePath = contextMenuStrip.Tag as string;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hình ảnh này?", "Xóa Ảnh", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File không tồn tại: " + filePath);
                    return;
                }
                string checkAnhroot = filePath.Replace("/", "\\");
                for (int i = 0; i < anhRoot.Count; i++)
                {
                    if(checkAnhroot == anhRoot[i])
                    {
                        GiaiPhongTaiNguyen(filePath);
                        return;
                    }
                }
                try
                {
                    GiaiPhongTaiNguyen(filePath);
                    // Xóa thông tin hình ảnh khỏi cơ sở dữ liệu
                    string duongdan = filePath.Replace("/", "\\");
                    duongdan = duongdan.Replace(projectDirectory + $"\\", "").Trim();
                    object[] paramValues = { ma, duongdan };
                    bool res = dA_QuanLy.XoaHinhAnh(paramValues);
                    if(res)
                    {
                        MessageBox.Show("Ảnh đã được xóa thành công");
                    }
                    // Xóa file ảnh
                    File.Delete(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa hình ảnh: {ex.Message}");
                }
            }
        }

        private void GiaiPhongTaiNguyen(string filePath)
        {
            if (loai == "thucung")
            {
                // Giải phóng tài nguyên ảnh trước khi xóa
                foreach (Control control in flp_HinhAnhTC.Controls)
                {
                    if (control is PictureBox pb && pb.Tag.ToString() == filePath)
                    {
                        pb.Image?.Dispose();
                        pb.Image = null;
                        flp_HinhAnhTC.Controls.Remove(pb);
                        break;
                    }
                }
            }
            else if (loai == "vatpham")
            {
                // Giải phóng tài nguyên ảnh trước khi xóa
                foreach (Control control in flp_HinhAnhVP.Controls)
                {
                    if (control is PictureBox pb && pb.Tag.ToString() == filePath)
                    {
                        pb.Image?.Dispose();
                        pb.Image = null;
                        flp_HinhAnhVP.Controls.Remove(pb);
                        break;
                    }
                }
            }
            else if (loai == "dichvu")
            {
                // Giải phóng tài nguyên ảnh trước khi xóa
                foreach (Control control in flp_HinhAnhDV.Controls)
                {
                    if (control is PictureBox pb && pb.Tag.ToString() == filePath)
                    {
                        pb.Image?.Dispose();
                        pb.Image = null;
                        flp_HinhAnhDV.Controls.Remove(pb);
                        break;
                    }
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void AddPictureBoxToPanel(PictureBox pictureBox)
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
                LoadImages();
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
                LoadImages();
            }
        }

        private void btn_ThemAnhTC_Click(object sender, EventArgs e)
        {
            btnThemAnh_Click(sender, e);
        }
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn Hình Ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    anhRoot.Add(selectedImagePath);
                    // Tạo PictureBox mới cho mỗi hình ảnh
                    PictureBox pictureBox = CreatePictureBox(selectedImagePath);
                    // Thêm PictureBox vào FlowLayoutPanel tương ứng
                    AddPictureBoxToPanel(pictureBox);
                    // Đường dẫn lưu hình ảnh vào thư mục
                    string directoryPath = projectDirectory +  $"\\assets\\images\\";
                    string fileName = Path.GetFileNameWithoutExtension(selectedImagePath);
                    string extension = Path.GetExtension(selectedImagePath);
                    string imagePath = Path.Combine(directoryPath, $"{fileName}{extension}");

                    // Tạo thư mục nếu chưa tồn tại
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    // Kiểm tra và thêm số vào tên nếu ảnh đã tồn tại 
                    int counter = 1;
                    while (File.Exists(imagePath) || anhTemp.Any(item => item == imagePath))
                    {
                        imagePath = Path.Combine(directoryPath, $"{fileName}_{counter}{extension}");

                        counter++;
                    }
                    anhTemp.Add(imagePath);
                }
            }
        }

        private void btn_ThemThuCung_Click(object sender, EventArgs e)
        {
            lb_maTC.Text = "";
            txb_TenTC.Text = "";
            txb_Loai.Text = "";
            txb_GiongTC.Text = "";
            dtp_NgaySinhTC.Value = DateTime.Now;
            cb_GioiTinhTC.Text = "";
            txb_MauSacTC.Text = "";
            txb_CanNangTC.Text = "";
            txb_SoMuiTiemTC.Text = "";
            cb_sucKhoeTC.Text = "";
            cb_trangThaiTC.Text = "";
            rtb_motaTC.Text = "";
            flp_HinhAnhTC.Controls.Clear();
            txb_GiaGocTC.Text = "";
            txb_GiaKMTC.Text = "";
            anhTemp.Clear();
            anhRoot.Clear();
        }

        private void btn_okVP_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox và các điều khiển khác
            string ten = txb_TenVP.Text.Trim();
            string moTa = rtb_moTaVP.Text.Trim(); // Mô tả vật phẩm
            decimal giaBanGoc = decimal.Parse(txb_GiaGocVP.Text); // Giá bán gốc
            decimal giaKhuyenMai = decimal.Parse(txb_GiaKMVP.Text); // Giá khuyến mãi
            string thuongHieu = txb_ThuongHieuVP.Text.Trim(); // Thương hiệu
            DateTime hanSuDung = dtp_HSDVP.Value; // Hạn sử dụng
            int soLuongTonKho = Convert.ToInt32(txb_SoLuongVP.Text); // Số lượng tồn kho
            if (lb_maVP.Text == "")
            {
                try
                {
                    // Tạo mảng chứa tên các tham số và các giá trị của chúng
                    int ma;
                    object[] paramValues = { ten, moTa, giaBanGoc, giaKhuyenMai, thuongHieu, hanSuDung, soLuongTonKho };
                    ma = dA_QuanLy.ThemVatPham(paramValues);
                    if (ma != -1)
                    {
                        MessageBox.Show("Thông tin vật phẩm đã được thêm thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không có thay đổi nào được thực hiện.");
                    }
                    string originalDirectory = Path.GetDirectoryName(anhTemp[0]);

                    // Tạo đường dẫn mới bằng cách thêm chuỗi vào thư mục
                    string newDirectory = Path.Combine(originalDirectory, ma.ToString());
                    if (!Directory.Exists(newDirectory))
                    {
                        Directory.CreateDirectory(newDirectory);
                    }
                }
                catch (FormatException ex)
                {
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
                try
                {
                    int maVatPham = Convert.ToInt32(lb_maVP.Text); // Mã vật phẩm
                    object[] paramValues = { maVatPham, ten, moTa, giaBanGoc, giaKhuyenMai, thuongHieu, hanSuDung, soLuongTonKho };
                    if (dA_QuanLy.SuaVatPham(paramValues))
                    {
                        MessageBox.Show("Thông tin vật phẩm đã được sửa thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không có thay đổi nào được thực hiện.");
                    }
                }
                catch (FormatException ex)
                {
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
            if (anhTemp.Count > 0)
            {
                if (ma != -1)
                {
                    string duongdan = "";
                    for (int i = 0; i < anhTemp.Count; i++)
                    {
                        anhTemp[i] = anhTemp[i].Replace("images", "images\\" + ma);
                        // Kiểm tra và thêm số vào tên nếu ảnh đã tồn tại 
                        int counter = 1;
                        string originalPath = anhTemp[i];
                        while (File.Exists(anhTemp[i]))
                        {
                            // Tạo đường dẫn mới với số đếm
                            string fileName = Path.GetFileNameWithoutExtension(originalPath);
                            string extension = Path.GetExtension(originalPath);
                            anhTemp[i] = Path.Combine(Path.GetDirectoryName(originalPath), $"{fileName}_{counter}{extension}");
                            counter++;
                        }
                        // Kiểm tra và thêm số vào tên nếu ảnh đã tồn tại 
                        duongdan = anhTemp[i].Replace(projectDirectory + "\\", "");
                        object[] paramValuesHA = { ma, duongdan };
                        dA_QuanLy.ThemHinhAnh(paramValuesHA);
                        File.Copy(anhRoot[i], anhTemp[i], true);
                    }
                }
            }
            anhTemp.Clear();
            anhRoot.Clear();
        }
        private void LoadPhongDichVu()
        {
            DataTable dt = dA_QuanLy.DanhSachPhongDichVu();
            dgv_PhongDichVu.DataSource = dt;
            cb_tenDV.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                cb_tenDV.Items.Add(row["Ma_Dich_Vu"].ToString() + " - " + row["Ten_Dich_Vu"].ToString());
            }
        }
        private void btn_ThemVP_Click(object sender, EventArgs e)
        {
            lb_maVP.Text = "";
            txb_TenVP.Text = "";
            txb_ThuongHieuVP.Text = "";
            dtp_HSDVP.Value = DateTime.Now;
            txb_SoLuongVP.Text = "";
            rtb_moTaVP.Text = "";
            flp_HinhAnhVP.Controls.Clear();
            txb_GiaGocVP.Text = "";
            txb_GiaKMVP.Text = "";
        }

        private void btn_okDV_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox và các điều khiển khác
            string tenDV = txb_TenDV.Text.Trim();
            int tgth = Convert.ToInt32(txb_TGTH.Text.Trim());
            string moTaDV = rtb_motaDV.Text.Trim();

            // Thông tin sản phẩm/dịch vụ
            decimal giaBanGoc = decimal.Parse(txb_GiaGocDV.Text.Trim());
            decimal giaKhuyenMai = decimal.Parse(txb_GiaKMDV.Text.Trim());

            int sophong = Convert.ToInt32(txb_SoPhong.Text.Trim());
            // Tạo mảng chứa tên các tham số và các giá trị của chúng

            int ma = 0;
            if (lb_maDV.Text == "")
            {
                try
                {

                    object[] paramValues = { tenDV, moTaDV, giaBanGoc, giaKhuyenMai,tgth,sophong };
                    ma = dA_QuanLy.ThemDichVu( paramValues);
                    if (ma != -1)
                    {
                        MessageBox.Show("Thông tin dịch vụ đã được thêm thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không có thay đổi nào được thực hiện.");
                    }
                    string originalDirectory = Path.GetDirectoryName(anhTemp[0]);

                    // Tạo đường dẫn mới bằng cách thêm chuỗi vào thư mục
                    string newDirectory = Path.Combine(originalDirectory, ma.ToString());
                    if (!Directory.Exists(newDirectory))
                    {
                        Directory.CreateDirectory(newDirectory);
                    }
                }
                catch (FormatException ex)
                {
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
                try
                {

                    // Lấy dữ liệu từ các TextBox và các điều khiển khác
                    int maDichVu = Convert.ToInt32(lb_maDV.Text);
                    string duongdan = "";
                    // Tạo mảng chứa tên các tham số và các giá trị của chúng


                    object[] paramValues = { maDichVu, tenDV, moTaDV, giaBanGoc, giaKhuyenMai, tgth, sophong };
                    if (dA_QuanLy.SuaDichVu(paramValues))
                    {
                        MessageBox.Show("Thông tin dịch vụ đã được sửa thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không có thay đổi nào được thực hiện.");
                    }
                }
                catch (FormatException ex)
                {
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
            if (anhTemp.Count > 0)
            {
                if (ma != -1)
                {
                    string duongdan = "";
                    for (int i = 0; i < anhTemp.Count; i++)
                    {
                        anhTemp[i] = anhTemp[i].Replace("images", "images\\" + ma);

                        // Kiểm tra và thêm số vào tên nếu ảnh đã tồn tại 
                        int counter = 1;
                        string originalPath = anhTemp[i];
                        while (File.Exists(anhTemp[i]))
                        {
                            // Tạo đường dẫn mới với số đếm
                            string fileName = Path.GetFileNameWithoutExtension(originalPath);
                            string extension = Path.GetExtension(originalPath);
                            anhTemp[i] = Path.Combine(Path.GetDirectoryName(originalPath), $"{fileName}_{counter}{extension}");
                            counter++;
                        }
                        duongdan = anhTemp[i].Replace(projectDirectory + "\\", "");
                        object[] paramValuesHA = { ma, duongdan };
                        dA_QuanLy.ThemHinhAnh(paramValuesHA);
                        File.Copy(anhRoot[i], anhTemp[i], true);
                    }
                }
            }
            anhTemp.Clear();
            anhRoot.Clear();
        }

        private void btn_ThemAnhDV_Click(object sender, EventArgs e)
        {
            btnThemAnh_Click(sender, e);
        }

        private void btn_ThemDV_Click(object sender, EventArgs e)
        {
            lb_maDV.Text ="";
            txb_TenDV.Text = "";
            txb_GiaGocDV.Text ="";
            txb_GiaKMDV.Text = "";
            txb_TGTH.Text = "";
            rtb_motaDV.Text = "";
            txb_SoPhong.Text = "";
            flp_HinhAnhDV.Controls.Clear();
        }

        private void btn_okTC_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox và các điều khiển khác
            string tenTC = txb_TenTC.Text.Trim();
            string loai = txb_Loai.Text.Trim();
            string giong = txb_GiongTC.Text.Trim();
            DateTime ngaySinhTC = dtp_NgaySinhTC.Value;
            string gioiTinhTC = cb_GioiTinhTC.Text;
            string mauSac = txb_MauSacTC.Text.Trim();
            decimal canNang = decimal.Parse(txb_CanNangTC.Text.Trim());
            string sucKhoe = cb_sucKhoeTC.Text.Trim();
            string trangThai = cb_trangThaiTC.Text.Trim();
            int soLanTiem = Convert.ToInt32(txb_SoMuiTiemTC.Text.Trim());

            // Thông tin sản phẩm/dịch vụ
            decimal giaBanGoc = decimal.Parse(txb_GiaGocTC.Text.Trim());
            decimal giaKhuyenMai = decimal.Parse(txb_GiaKMTC.Text.Trim());
            string motaTC = rtb_motaTC.Text.Trim();


            // Tạo mảng chứa tên các tham số và các giá trị của chúng
            int ma = 0;
            if (lb_maTC.Text == "")
            {
                try
                {
                    object[] paramValues = {loai, giong, ngaySinhTC, gioiTinhTC, mauSac, canNang, sucKhoe, trangThai,
                                 soLanTiem, tenTC, motaTC, giaBanGoc, giaKhuyenMai };

                    ma = dA_QuanLy.ThemThuCung(paramValues);
                    if (ma != -1)
                    {
                        MessageBox.Show("Thông tin thú cưng đã được thêm thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không có thay đổi nào được thực hiện.");
                    }
                    string originalDirectory = Path.GetDirectoryName(anhTemp[0]);

                    // Tạo đường dẫn mới bằng cách thêm chuỗi vào thư mục
                    string newDirectory = Path.Combine(originalDirectory, ma.ToString());
                    if (!Directory.Exists(newDirectory))
                    {
                        Directory.CreateDirectory(newDirectory);
                    }
                }
                catch (FormatException ex)
                {
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
                try
                {
                    int maTC = Convert.ToInt32(lb_maTC.Text);
                    object[] paramValues = {maTC, loai, giong, ngaySinhTC, gioiTinhTC, mauSac, canNang, sucKhoe, trangThai,
                                 soLanTiem, tenTC, motaTC, giaBanGoc, giaKhuyenMai};
                    if (dA_QuanLy.SuaThuCung(paramValues))
                    {
                        MessageBox.Show("Thông tin thú cưng đã được sửa thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không có thay đổi nào được thực hiện.");
                    }
                }
                catch (FormatException ex)
                {
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
            if (anhTemp.Count > 0)
            {
                if (ma != -1)
                {
                    string duongdan = "";
                    for (int i = 0; i < anhTemp.Count; i++)
                    {
                        anhTemp[i] = anhTemp[i].Replace("images", "images\\" + ma);
                        //
                        // Kiểm tra và thêm số vào tên nếu ảnh đã tồn tại 
                        int counter = 1;
                        string originalPath = anhTemp[i];
                        while (File.Exists(anhTemp[i]))
                        {
                            // Tạo đường dẫn mới với số đếm
                            string fileName = Path.GetFileNameWithoutExtension(originalPath);
                            string extension = Path.GetExtension(originalPath);
                            anhTemp[i] = Path.Combine(Path.GetDirectoryName(originalPath), $"{fileName}_{counter}{extension}");
                            counter++;
                        }
                        duongdan = anhTemp[i].Replace(projectDirectory + "\\", "");
                        object[] paramValuesHA = { ma, duongdan };
                        dA_QuanLy.ThemHinhAnh(paramValuesHA);
                        File.Copy(anhRoot[i], anhTemp[i], true);
                    }
                }
            }
            anhTemp.Clear();
            anhRoot.Clear();
        }

        private void btn_ThemAnhVP_Click(object sender, EventArgs e)
        {
            btnThemAnh_Click(sender, e );
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra tab nào đang được chọn
            if (tabControl.SelectedTab == tp_TC)
            {
                loai = "thucung";
            }
            else if (tabControl.SelectedTab == tp_VP)
            {
                loai = "vatpham";
            }
            else if (tabControl.SelectedTab == tp_DV)
            {
                loai = "dichvu";
            }
        }

        private void btn_TimKiemNV_Click(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = dA_QuanLy.TimKiemNhanVienTheoTen(txb_TenNVTK.Text.Trim());
        }

        private void btn_TimKiemTC_Click(object sender, EventArgs e)
        {
            dgv_ThuCung.DataSource = dA_QuanLy.TimKiemThuCungTheoTen(txb_TenTCTK.Text.Trim());
        }

        private void btn_TimKiemVP_Click(object sender, EventArgs e)
        {
            dgv_VatPham.DataSource = dA_QuanLy.TimKiemVatPhamTheoTen(txb_TenVPTK.Text.Trim());
        }

        private void btn_TimKiemDV_Click(object sender, EventArgs e)
        {
            dgv_DichVu.DataSource = dA_QuanLy.TimKiemDichVuTheoTen(txb_TenDVTK.Text.Trim());
        }

        private void btn_TimKiemKH_Click(object sender, EventArgs e)
        {
            dgv_KhachHang.DataSource = dA_QuanLy.TimKiemKhachHangTheoTen(txb_TenKHTK.Text.Trim());
        }

        private void btn_timkiemPDV_Click(object sender, EventArgs e)
        {
            dgv_PhongDichVu.DataSource = dA_QuanLy.TimKiemPhongDichVuTheoTen(txb_tenPDVTK.Text.Trim());
        }

        private void dgv_PhongDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgv_PhongDichVu.Rows[e.RowIndex].IsNewRow)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgv_PhongDichVu.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox
                txb_maPDV.Text = row.Cells["Ma_Phong"].Value.ToString();
                cb_tenDV.Text = row.Cells["Ma_Dich_Vu"].Value.ToString() + " - " + row.Cells["Ten_Dich_Vu"].Value.ToString();
                txb_tgbdPDV.Text = row.Cells["Thoi_Gian_Bat_Dau"].Value.ToString();
                txb_tgktPDV.Text = row.Cells["Thoi_Gian_Ket_Thuc"].Value.ToString();
                cb_trangthaiPDV.Text = row.Cells["Trang_Thai"].Value.ToString();
            }
        }

        private void btn_ThemPDV_Click(object sender, EventArgs e)
        {
            string ma_PDV = txb_maPDV.Text.Trim();
            string ma_DV = cb_tenDV.Text.Trim().Substring(0, cb_tenDV.Text.Trim().IndexOf(" "));
            string trangthai = cb_trangthaiPDV.Text.Trim();
            // Tạo mảng chứa tên các tham số và các giá trị của chúng
            object[] paramValues = {ma_PDV, ma_DV, trangthai };
            bool res = dA_QuanLy.ThemPhongDichVu(paramValues);
            if (res)
            {
                MessageBox.Show("Thông tin phòng dịch vụ đã được thêm thành công.");
            }
            LoadPhongDichVu();
        }

        private void btn_suaPDV_Click(object sender, EventArgs e)
        {
            string ma_PDV = txb_maPDV.Text.Trim();
            string ma_DV = cb_tenDV.Text.Trim().Substring(0, cb_tenDV.Text.Trim().IndexOf(" "));
            string trangthai = cb_trangthaiPDV.Text.Trim();
            // Tạo mảng chứa tên các tham số và các giá trị của chúng
            object[] paramValues = { ma_PDV, ma_DV, trangthai };
            bool res = dA_QuanLy.SuaPhongDichVu(paramValues);
            if (res)
            {
                MessageBox.Show("Thông tin phòng dịch vụ đã được sửa thành công.");
            }
            LoadPhongDichVu();
        }

        private void btn_XoaPDV_Click(object sender, EventArgs e)
        {
            if (txb_maPDV.Text == "")
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
                        string ma_PDV = txb_maPDV.Text.Trim();
                        // Tạo mảng chứa tên các tham số và các giá trị của chúng
                        object[] paramValues = { ma_PDV };
                        bool res = dA_QuanLy.XoaPhongDichVu(paramValues);
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
                        LoadPhongDichVu();
                    }
                }
            }
        }
    }
}
