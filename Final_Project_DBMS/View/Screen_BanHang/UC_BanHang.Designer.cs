namespace Final_Project_DBMS.View.Screen_BanHang
{
    partial class UC_BanHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_ban_hang = new System.Windows.Forms.TabControl();
            this.tp_spdv = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_huy_bo = new System.Windows.Forms.Button();
            this.btn_xac_nhan_id_khachhang = new System.Windows.Forms.Button();
            this.btn_xac_nhan = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.lbl_tong_tien = new System.Windows.Forms.Label();
            this.lbl_id_khachhang = new System.Windows.Forms.Label();
            this.lbl_title_tongtien = new System.Windows.Forms.Label();
            this.txt_id_khachhang = new System.Windows.Forms.TextBox();
            this.lbl_title_hoten = new System.Windows.Forms.Label();
            this.lbl_ten_khachhang = new System.Windows.Forms.Label();
            this.lbl_giam_gia = new System.Windows.Forms.Label();
            this.lbl_title_giam_gia = new System.Windows.Forms.Label();
            this.lv_hoa_don = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_types = new System.Windows.Forms.TabControl();
            this.tp_thu_cung = new System.Windows.Forms.TabPage();
            this.flp_thu_cung = new System.Windows.Forms.FlowLayoutPanel();
            this.tp_vat_pham = new System.Windows.Forms.TabPage();
            this.flp_vatpham = new System.Windows.Forms.FlowLayoutPanel();
            this.tp_dich_vu = new System.Windows.Forms.TabPage();
            this.flp_dichvu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_gia_ket_thuc = new System.Windows.Forms.TextBox();
            this.txt_gia_bat_dau = new System.Windows.Forms.TextBox();
            this.btn_chon_khoang_gia = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_title_alphabet = new System.Windows.Forms.Label();
            this.lbl_title_sap_xep_gia = new System.Windows.Forms.Label();
            this.cb_alphabet = new System.Windows.Forms.ComboBox();
            this.cb_gia = new System.Windows.Forms.ComboBox();
            this.btn_tim_kiem = new System.Windows.Forms.Button();
            this.txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.tp_hoa_don = new System.Windows.Forms.TabPage();
            this.gv_hoadon = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_chinh_sua_hoadon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.tp_thanh_vien = new System.Windows.Forms.TabPage();
            this.gv_thanh_vien = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_tim_kiem_thanh_vien = new System.Windows.Forms.Button();
            this.txt_tim_kiem_thanh_vien = new System.Windows.Forms.TextBox();
            this.btn_them_thanh_vien = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tc_ban_hang.SuspendLayout();
            this.tp_spdv.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tb_types.SuspendLayout();
            this.tp_thu_cung.SuspendLayout();
            this.tp_vat_pham.SuspendLayout();
            this.tp_dich_vu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tp_hoa_don.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_hoadon)).BeginInit();
            this.panel4.SuspendLayout();
            this.tp_thanh_vien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thanh_vien)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_ban_hang
            // 
            this.tc_ban_hang.Controls.Add(this.tp_spdv);
            this.tc_ban_hang.Controls.Add(this.tp_hoa_don);
            this.tc_ban_hang.Controls.Add(this.tp_thanh_vien);
            this.tc_ban_hang.Location = new System.Drawing.Point(0, 50);
            this.tc_ban_hang.Margin = new System.Windows.Forms.Padding(0);
            this.tc_ban_hang.Name = "tc_ban_hang";
            this.tc_ban_hang.SelectedIndex = 0;
            this.tc_ban_hang.Size = new System.Drawing.Size(1500, 750);
            this.tc_ban_hang.TabIndex = 7;
            this.tc_ban_hang.SelectedIndexChanged += new System.EventHandler(this.tc_ban_hang_SelectedIndexChanged);
            // 
            // tp_spdv
            // 
            this.tp_spdv.Controls.Add(this.panel2);
            this.tp_spdv.Controls.Add(this.tb_types);
            this.tp_spdv.Controls.Add(this.panel1);
            this.tp_spdv.Location = new System.Drawing.Point(4, 25);
            this.tp_spdv.Name = "tp_spdv";
            this.tp_spdv.Padding = new System.Windows.Forms.Padding(3);
            this.tp_spdv.Size = new System.Drawing.Size(1492, 721);
            this.tp_spdv.TabIndex = 0;
            this.tp_spdv.Text = "Sản phẩm và dịch vụ";
            this.tp_spdv.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.lv_hoa_don);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(964, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 711);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_huy_bo);
            this.panel7.Controls.Add(this.btn_xac_nhan_id_khachhang);
            this.panel7.Controls.Add(this.btn_xac_nhan);
            this.panel7.Controls.Add(this.btn_xoa);
            this.panel7.Controls.Add(this.lbl_tong_tien);
            this.panel7.Controls.Add(this.lbl_id_khachhang);
            this.panel7.Controls.Add(this.lbl_title_tongtien);
            this.panel7.Controls.Add(this.txt_id_khachhang);
            this.panel7.Controls.Add(this.lbl_title_hoten);
            this.panel7.Controls.Add(this.lbl_ten_khachhang);
            this.panel7.Controls.Add(this.lbl_giam_gia);
            this.panel7.Controls.Add(this.lbl_title_giam_gia);
            this.panel7.Location = new System.Drawing.Point(2, 564);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(520, 147);
            this.panel7.TabIndex = 24;
            // 
            // btn_huy_bo
            // 
            this.btn_huy_bo.Location = new System.Drawing.Point(315, 111);
            this.btn_huy_bo.Name = "btn_huy_bo";
            this.btn_huy_bo.Size = new System.Drawing.Size(100, 33);
            this.btn_huy_bo.TabIndex = 22;
            this.btn_huy_bo.Text = "Hủy bỏ";
            this.btn_huy_bo.UseVisualStyleBackColor = true;
            this.btn_huy_bo.Click += new System.EventHandler(this.btn_huy_bo_Click);
            // 
            // btn_xac_nhan_id_khachhang
            // 
            this.btn_xac_nhan_id_khachhang.Location = new System.Drawing.Point(406, 9);
            this.btn_xac_nhan_id_khachhang.Name = "btn_xac_nhan_id_khachhang";
            this.btn_xac_nhan_id_khachhang.Size = new System.Drawing.Size(96, 27);
            this.btn_xac_nhan_id_khachhang.TabIndex = 29;
            this.btn_xac_nhan_id_khachhang.Text = "Xác nhận";
            this.btn_xac_nhan_id_khachhang.UseVisualStyleBackColor = true;
            this.btn_xac_nhan_id_khachhang.Click += new System.EventHandler(this.btn_xac_nhan_id_khachhang_Click);
            // 
            // btn_xac_nhan
            // 
            this.btn_xac_nhan.Location = new System.Drawing.Point(421, 111);
            this.btn_xac_nhan.Name = "btn_xac_nhan";
            this.btn_xac_nhan.Size = new System.Drawing.Size(96, 33);
            this.btn_xac_nhan.TabIndex = 23;
            this.btn_xac_nhan.Text = "Xác nhận";
            this.btn_xac_nhan.UseVisualStyleBackColor = true;
            this.btn_xac_nhan.Click += new System.EventHandler(this.btn_xac_nhan_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(209, 111);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 33);
            this.btn_xoa.TabIndex = 24;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // lbl_tong_tien
            // 
            this.lbl_tong_tien.Location = new System.Drawing.Point(170, 75);
            this.lbl_tong_tien.Name = "lbl_tong_tien";
            this.lbl_tong_tien.Size = new System.Drawing.Size(203, 19);
            this.lbl_tong_tien.TabIndex = 33;
            this.lbl_tong_tien.Text = "000000000000";
            // 
            // lbl_id_khachhang
            // 
            this.lbl_id_khachhang.AutoSize = true;
            this.lbl_id_khachhang.Location = new System.Drawing.Point(5, 9);
            this.lbl_id_khachhang.Name = "lbl_id_khachhang";
            this.lbl_id_khachhang.Size = new System.Drawing.Size(96, 16);
            this.lbl_id_khachhang.TabIndex = 25;
            this.lbl_id_khachhang.Text = "ID Khách hàng:";
            // 
            // lbl_title_tongtien
            // 
            this.lbl_title_tongtien.Location = new System.Drawing.Point(5, 75);
            this.lbl_title_tongtien.Name = "lbl_title_tongtien";
            this.lbl_title_tongtien.Size = new System.Drawing.Size(82, 19);
            this.lbl_title_tongtien.TabIndex = 32;
            this.lbl_title_tongtien.Text = "Tổng tiền:";
            // 
            // txt_id_khachhang
            // 
            this.txt_id_khachhang.Location = new System.Drawing.Point(173, 6);
            this.txt_id_khachhang.Name = "txt_id_khachhang";
            this.txt_id_khachhang.Size = new System.Drawing.Size(65, 22);
            this.txt_id_khachhang.TabIndex = 26;
            this.txt_id_khachhang.Text = "0";
            // 
            // lbl_title_hoten
            // 
            this.lbl_title_hoten.Location = new System.Drawing.Point(5, 34);
            this.lbl_title_hoten.Name = "lbl_title_hoten";
            this.lbl_title_hoten.Size = new System.Drawing.Size(112, 22);
            this.lbl_title_hoten.TabIndex = 27;
            this.lbl_title_hoten.Text = "Tên khách hàng:";
            // 
            // lbl_ten_khachhang
            // 
            this.lbl_ten_khachhang.Location = new System.Drawing.Point(170, 34);
            this.lbl_ten_khachhang.Name = "lbl_ten_khachhang";
            this.lbl_ten_khachhang.Size = new System.Drawing.Size(206, 22);
            this.lbl_ten_khachhang.TabIndex = 30;
            this.lbl_ten_khachhang.Text = "vãng lai";
            // 
            // lbl_giam_gia
            // 
            this.lbl_giam_gia.Location = new System.Drawing.Point(170, 56);
            this.lbl_giam_gia.Name = "lbl_giam_gia";
            this.lbl_giam_gia.Size = new System.Drawing.Size(206, 19);
            this.lbl_giam_gia.TabIndex = 31;
            this.lbl_giam_gia.Text = "0";
            // 
            // lbl_title_giam_gia
            // 
            this.lbl_title_giam_gia.Location = new System.Drawing.Point(5, 56);
            this.lbl_title_giam_gia.Name = "lbl_title_giam_gia";
            this.lbl_title_giam_gia.Size = new System.Drawing.Size(96, 19);
            this.lbl_title_giam_gia.TabIndex = 28;
            this.lbl_title_giam_gia.Text = "Điểm tích lũy:";
            // 
            // lv_hoa_don
            // 
            this.lv_hoa_don.FullRowSelect = true;
            this.lv_hoa_don.HideSelection = false;
            this.lv_hoa_don.Location = new System.Drawing.Point(3, 31);
            this.lv_hoa_don.Name = "lv_hoa_don";
            this.lv_hoa_don.Size = new System.Drawing.Size(519, 527);
            this.lv_hoa_don.TabIndex = 23;
            this.lv_hoa_don.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tạo hóa đơn mới";
            // 
            // tb_types
            // 
            this.tb_types.Controls.Add(this.tp_thu_cung);
            this.tb_types.Controls.Add(this.tp_vat_pham);
            this.tb_types.Controls.Add(this.tp_dich_vu);
            this.tb_types.Location = new System.Drawing.Point(3, 120);
            this.tb_types.Name = "tb_types";
            this.tb_types.SelectedIndex = 0;
            this.tb_types.Size = new System.Drawing.Size(962, 598);
            this.tb_types.TabIndex = 1;
            this.tb_types.SelectedIndexChanged += new System.EventHandler(this.tb_types_SelectedIndexChanged);
            // 
            // tp_thu_cung
            // 
            this.tp_thu_cung.Controls.Add(this.flp_thu_cung);
            this.tp_thu_cung.Location = new System.Drawing.Point(4, 25);
            this.tp_thu_cung.Name = "tp_thu_cung";
            this.tp_thu_cung.Padding = new System.Windows.Forms.Padding(3);
            this.tp_thu_cung.Size = new System.Drawing.Size(954, 569);
            this.tp_thu_cung.TabIndex = 0;
            this.tp_thu_cung.Text = "Thú cưng";
            this.tp_thu_cung.UseVisualStyleBackColor = true;
            // 
            // flp_thu_cung
            // 
            this.flp_thu_cung.AutoScroll = true;
            this.flp_thu_cung.Location = new System.Drawing.Point(0, 0);
            this.flp_thu_cung.Name = "flp_thu_cung";
            this.flp_thu_cung.Size = new System.Drawing.Size(954, 566);
            this.flp_thu_cung.TabIndex = 1;
            this.flp_thu_cung.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_thu_cung_Paint);
            // 
            // tp_vat_pham
            // 
            this.tp_vat_pham.Controls.Add(this.flp_vatpham);
            this.tp_vat_pham.Location = new System.Drawing.Point(4, 25);
            this.tp_vat_pham.Name = "tp_vat_pham";
            this.tp_vat_pham.Padding = new System.Windows.Forms.Padding(3);
            this.tp_vat_pham.Size = new System.Drawing.Size(954, 569);
            this.tp_vat_pham.TabIndex = 1;
            this.tp_vat_pham.Text = "Vật phẩm";
            this.tp_vat_pham.UseVisualStyleBackColor = true;
            // 
            // flp_vatpham
            // 
            this.flp_vatpham.AutoScroll = true;
            this.flp_vatpham.Location = new System.Drawing.Point(2, 0);
            this.flp_vatpham.Name = "flp_vatpham";
            this.flp_vatpham.Size = new System.Drawing.Size(951, 569);
            this.flp_vatpham.TabIndex = 2;
            // 
            // tp_dich_vu
            // 
            this.tp_dich_vu.Controls.Add(this.flp_dichvu);
            this.tp_dich_vu.Location = new System.Drawing.Point(4, 25);
            this.tp_dich_vu.Name = "tp_dich_vu";
            this.tp_dich_vu.Padding = new System.Windows.Forms.Padding(3);
            this.tp_dich_vu.Size = new System.Drawing.Size(954, 569);
            this.tp_dich_vu.TabIndex = 2;
            this.tp_dich_vu.Text = "Dịch vụ";
            this.tp_dich_vu.UseVisualStyleBackColor = true;
            // 
            // flp_dichvu
            // 
            this.flp_dichvu.Location = new System.Drawing.Point(3, 3);
            this.flp_dichvu.Name = "flp_dichvu";
            this.flp_dichvu.Size = new System.Drawing.Size(951, 563);
            this.flp_dichvu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_gia_ket_thuc);
            this.panel1.Controls.Add(this.txt_gia_bat_dau);
            this.panel1.Controls.Add(this.btn_chon_khoang_gia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_title_alphabet);
            this.panel1.Controls.Add(this.lbl_title_sap_xep_gia);
            this.panel1.Controls.Add(this.cb_alphabet);
            this.panel1.Controls.Add(this.cb_gia);
            this.panel1.Controls.Add(this.btn_tim_kiem);
            this.panel1.Controls.Add(this.txt_tim_kiem);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 114);
            this.panel1.TabIndex = 0;
            // 
            // txt_gia_ket_thuc
            // 
            this.txt_gia_ket_thuc.Location = new System.Drawing.Point(578, 40);
            this.txt_gia_ket_thuc.Name = "txt_gia_ket_thuc";
            this.txt_gia_ket_thuc.Size = new System.Drawing.Size(180, 22);
            this.txt_gia_ket_thuc.TabIndex = 32;
            this.txt_gia_ket_thuc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_gia_ket_thuc_MouseClick);
            this.txt_gia_ket_thuc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_gia_ket_thuc_MouseDoubleClick);
            // 
            // txt_gia_bat_dau
            // 
            this.txt_gia_bat_dau.Location = new System.Drawing.Point(578, 12);
            this.txt_gia_bat_dau.Name = "txt_gia_bat_dau";
            this.txt_gia_bat_dau.Size = new System.Drawing.Size(180, 22);
            this.txt_gia_bat_dau.TabIndex = 31;
            this.txt_gia_bat_dau.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_gia_bat_dau_MouseDoubleClick);
            // 
            // btn_chon_khoang_gia
            // 
            this.btn_chon_khoang_gia.Location = new System.Drawing.Point(578, 68);
            this.btn_chon_khoang_gia.Name = "btn_chon_khoang_gia";
            this.btn_chon_khoang_gia.Size = new System.Drawing.Size(180, 32);
            this.btn_chon_khoang_gia.TabIndex = 28;
            this.btn_chon_khoang_gia.Text = "Chọn khoảng giá";
            this.btn_chon_khoang_gia.UseVisualStyleBackColor = true;
            this.btn_chon_khoang_gia.Click += new System.EventHandler(this.btn_chon_khoang_gia_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Từ";
            // 
            // lbl_title_alphabet
            // 
            this.lbl_title_alphabet.Location = new System.Drawing.Point(4, 48);
            this.lbl_title_alphabet.Name = "lbl_title_alphabet";
            this.lbl_title_alphabet.Size = new System.Drawing.Size(172, 24);
            this.lbl_title_alphabet.TabIndex = 26;
            this.lbl_title_alphabet.Text = "Sắp xếp theo bảng chữ cái:";
            // 
            // lbl_title_sap_xep_gia
            // 
            this.lbl_title_sap_xep_gia.Location = new System.Drawing.Point(4, 76);
            this.lbl_title_sap_xep_gia.Name = "lbl_title_sap_xep_gia";
            this.lbl_title_sap_xep_gia.Size = new System.Drawing.Size(172, 23);
            this.lbl_title_sap_xep_gia.TabIndex = 25;
            this.lbl_title_sap_xep_gia.Text = "Sắp xếp theo giá:";
            // 
            // cb_alphabet
            // 
            this.cb_alphabet.FormattingEnabled = true;
            this.cb_alphabet.Items.AddRange(new object[] {
            "Tùy chọn",
            "A - Z",
            "Z - A"});
            this.cb_alphabet.Location = new System.Drawing.Point(182, 43);
            this.cb_alphabet.Name = "cb_alphabet";
            this.cb_alphabet.Size = new System.Drawing.Size(332, 24);
            this.cb_alphabet.TabIndex = 24;
            this.cb_alphabet.SelectedIndexChanged += new System.EventHandler(this.cb_alphabet_SelectedIndexChanged);
            // 
            // cb_gia
            // 
            this.cb_gia.FormattingEnabled = true;
            this.cb_gia.Items.AddRange(new object[] {
            "Tùy chọn",
            "Tăng dần",
            "Giảm dần"});
            this.cb_gia.Location = new System.Drawing.Point(182, 76);
            this.cb_gia.Name = "cb_gia";
            this.cb_gia.Size = new System.Drawing.Size(332, 24);
            this.cb_gia.TabIndex = 23;
            this.cb_gia.SelectedIndexChanged += new System.EventHandler(this.cb_gia_SelectedIndexChanged);
            // 
            // btn_tim_kiem
            // 
            this.btn_tim_kiem.Location = new System.Drawing.Point(7, 10);
            this.btn_tim_kiem.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.btn_tim_kiem.Name = "btn_tim_kiem";
            this.btn_tim_kiem.Size = new System.Drawing.Size(52, 24);
            this.btn_tim_kiem.TabIndex = 6;
            this.btn_tim_kiem.Text = "Tìm";
            this.btn_tim_kiem.UseVisualStyleBackColor = true;
            this.btn_tim_kiem.Click += new System.EventHandler(this.btn_tim_kiem_Click);
            // 
            // txt_tim_kiem
            // 
            this.txt_tim_kiem.Location = new System.Drawing.Point(65, 10);
            this.txt_tim_kiem.Multiline = true;
            this.txt_tim_kiem.Name = "txt_tim_kiem";
            this.txt_tim_kiem.Size = new System.Drawing.Size(449, 24);
            this.txt_tim_kiem.TabIndex = 5;
            this.txt_tim_kiem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_tim_kiem_MouseDoubleClick);
            // 
            // tp_hoa_don
            // 
            this.tp_hoa_don.Controls.Add(this.gv_hoadon);
            this.tp_hoa_don.Controls.Add(this.panel4);
            this.tp_hoa_don.Location = new System.Drawing.Point(4, 25);
            this.tp_hoa_don.Name = "tp_hoa_don";
            this.tp_hoa_don.Padding = new System.Windows.Forms.Padding(3);
            this.tp_hoa_don.Size = new System.Drawing.Size(1492, 721);
            this.tp_hoa_don.TabIndex = 2;
            this.tp_hoa_don.Text = "Hóa đơn";
            this.tp_hoa_don.UseVisualStyleBackColor = true;
            // 
            // gv_hoadon
            // 
            this.gv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_hoadon.Location = new System.Drawing.Point(3, 62);
            this.gv_hoadon.Name = "gv_hoadon";
            this.gv_hoadon.RowHeadersWidth = 51;
            this.gv_hoadon.RowTemplate.Height = 24;
            this.gv_hoadon.Size = new System.Drawing.Size(1486, 656);
            this.gv_hoadon.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_chinh_sua_hoadon);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dtp);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1486, 56);
            this.panel4.TabIndex = 0;
            // 
            // btn_chinh_sua_hoadon
            // 
            this.btn_chinh_sua_hoadon.Location = new System.Drawing.Point(1377, 8);
            this.btn_chinh_sua_hoadon.Name = "btn_chinh_sua_hoadon";
            this.btn_chinh_sua_hoadon.Size = new System.Drawing.Size(97, 40);
            this.btn_chinh_sua_hoadon.TabIndex = 11;
            this.btn_chinh_sua_hoadon.Text = "Chỉnh sửa";
            this.btn_chinh_sua_hoadon.UseVisualStyleBackColor = true;
            this.btn_chinh_sua_hoadon.Click += new System.EventHandler(this.btn_chinh_sua_hoadon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chọn ngày xác định";
            this.label2.Visible = false;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(143, 15);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(271, 22);
            this.dtp.TabIndex = 9;
            this.dtp.Visible = false;
            // 
            // tp_thanh_vien
            // 
            this.tp_thanh_vien.Controls.Add(this.gv_thanh_vien);
            this.tp_thanh_vien.Controls.Add(this.panel3);
            this.tp_thanh_vien.Location = new System.Drawing.Point(4, 25);
            this.tp_thanh_vien.Name = "tp_thanh_vien";
            this.tp_thanh_vien.Padding = new System.Windows.Forms.Padding(3);
            this.tp_thanh_vien.Size = new System.Drawing.Size(1492, 721);
            this.tp_thanh_vien.TabIndex = 3;
            this.tp_thanh_vien.Text = "Thành viên";
            this.tp_thanh_vien.UseVisualStyleBackColor = true;
            // 
            // gv_thanh_vien
            // 
            this.gv_thanh_vien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_thanh_vien.Location = new System.Drawing.Point(3, 62);
            this.gv_thanh_vien.Name = "gv_thanh_vien";
            this.gv_thanh_vien.RowHeadersWidth = 51;
            this.gv_thanh_vien.RowTemplate.Height = 24;
            this.gv_thanh_vien.Size = new System.Drawing.Size(1486, 656);
            this.gv_thanh_vien.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_tim_kiem_thanh_vien);
            this.panel3.Controls.Add(this.txt_tim_kiem_thanh_vien);
            this.panel3.Controls.Add(this.btn_them_thanh_vien);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1486, 56);
            this.panel3.TabIndex = 13;
            // 
            // btn_tim_kiem_thanh_vien
            // 
            this.btn_tim_kiem_thanh_vien.Location = new System.Drawing.Point(10, 17);
            this.btn_tim_kiem_thanh_vien.Name = "btn_tim_kiem_thanh_vien";
            this.btn_tim_kiem_thanh_vien.Size = new System.Drawing.Size(29, 24);
            this.btn_tim_kiem_thanh_vien.TabIndex = 14;
            this.btn_tim_kiem_thanh_vien.UseVisualStyleBackColor = true;
            this.btn_tim_kiem_thanh_vien.Click += new System.EventHandler(this.btn_tim_kiem_thanh_vien_Click);
            // 
            // txt_tim_kiem_thanh_vien
            // 
            this.txt_tim_kiem_thanh_vien.Location = new System.Drawing.Point(45, 17);
            this.txt_tim_kiem_thanh_vien.Name = "txt_tim_kiem_thanh_vien";
            this.txt_tim_kiem_thanh_vien.Size = new System.Drawing.Size(273, 22);
            this.txt_tim_kiem_thanh_vien.TabIndex = 13;
            this.txt_tim_kiem_thanh_vien.Text = "Tìm kiếm";
            this.txt_tim_kiem_thanh_vien.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_tim_kiem_thanh_vien_MouseDoubleClick);
            // 
            // btn_them_thanh_vien
            // 
            this.btn_them_thanh_vien.Location = new System.Drawing.Point(1383, 11);
            this.btn_them_thanh_vien.Name = "btn_them_thanh_vien";
            this.btn_them_thanh_vien.Size = new System.Drawing.Size(90, 34);
            this.btn_them_thanh_vien.TabIndex = 12;
            this.btn_them_thanh_vien.Text = "Thêm";
            this.btn_them_thanh_vien.UseVisualStyleBackColor = true;
            this.btn_them_thanh_vien.Click += new System.EventHandler(this.btn_them_thanh_vien_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(362, 50);
            this.label12.TabIndex = 1;
            this.label12.Text = "Bán hàng";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.label12);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1501, 50);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // UC_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tc_ban_hang);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "UC_BanHang";
            this.Size = new System.Drawing.Size(1500, 800);
            this.Load += new System.EventHandler(this.UC_BanHang_Load);
            this.tc_ban_hang.ResumeLayout(false);
            this.tp_spdv.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tb_types.ResumeLayout(false);
            this.tp_thu_cung.ResumeLayout(false);
            this.tp_vat_pham.ResumeLayout(false);
            this.tp_dich_vu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tp_hoa_don.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_hoadon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tp_thanh_vien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_thanh_vien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tc_ban_hang;
        private System.Windows.Forms.TabPage tp_spdv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_huy_bo;
        private System.Windows.Forms.Button btn_xac_nhan_id_khachhang;
        private System.Windows.Forms.Button btn_xac_nhan;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label lbl_tong_tien;
        private System.Windows.Forms.Label lbl_id_khachhang;
        private System.Windows.Forms.Label lbl_title_tongtien;
        private System.Windows.Forms.TextBox txt_id_khachhang;
        private System.Windows.Forms.Label lbl_title_hoten;
        private System.Windows.Forms.Label lbl_ten_khachhang;
        private System.Windows.Forms.Label lbl_giam_gia;
        private System.Windows.Forms.Label lbl_title_giam_gia;
        private System.Windows.Forms.ListView lv_hoa_don;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tb_types;
        private System.Windows.Forms.TabPage tp_thu_cung;
        private System.Windows.Forms.FlowLayoutPanel flp_thu_cung;
        private System.Windows.Forms.TabPage tp_dich_vu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_chon_khoang_gia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_title_alphabet;
        private System.Windows.Forms.Label lbl_title_sap_xep_gia;
        private System.Windows.Forms.ComboBox cb_alphabet;
        private System.Windows.Forms.ComboBox cb_gia;
        private System.Windows.Forms.Button btn_tim_kiem;
        private System.Windows.Forms.TextBox txt_tim_kiem;
        private System.Windows.Forms.TabPage tp_hoa_don;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage tp_thanh_vien;
        private System.Windows.Forms.Button btn_chinh_sua_hoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.DataGridView gv_hoadon;
        private System.Windows.Forms.DataGridView gv_thanh_vien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_tim_kiem_thanh_vien;
        private System.Windows.Forms.TextBox txt_tim_kiem_thanh_vien;
        private System.Windows.Forms.Button btn_them_thanh_vien;
        private System.Windows.Forms.TextBox txt_gia_ket_thuc;
        private System.Windows.Forms.TextBox txt_gia_bat_dau;
        private System.Windows.Forms.TabPage tp_vat_pham;
        private System.Windows.Forms.FlowLayoutPanel flp_vatpham;
        private System.Windows.Forms.FlowLayoutPanel flp_dichvu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
