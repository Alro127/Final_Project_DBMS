namespace Final_Project_DBMS.View.Screen_BanHang
{
    partial class Form_ChiTietDichVu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_chitietdv = new System.Windows.Forms.TabControl();
            this.tp_chitiet = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flp_hinhanh = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ten_spdv = new System.Windows.Forms.Label();
            this.lbl_gia_khuyen_mai = new System.Windows.Forms.Label();
            this.lbl_gia_ban_goc = new System.Windows.Forms.Label();
            this.rtxt_detail = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_main = new System.Windows.Forms.PictureBox();
            this.pn_maphong = new System.Windows.Forms.Panel();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dg_dsPhong = new System.Windows.Forms.DataGridView();
            this.tc_chitietdv.SuspendLayout();
            this.tp_chitiet.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_main)).BeginInit();
            this.pn_maphong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dsPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_chitietdv
            // 
            this.tc_chitietdv.Controls.Add(this.tp_chitiet);
            this.tc_chitietdv.Controls.Add(this.tabPage2);
            this.tc_chitietdv.Location = new System.Drawing.Point(0, 0);
            this.tc_chitietdv.Name = "tc_chitietdv";
            this.tc_chitietdv.SelectedIndex = 0;
            this.tc_chitietdv.Size = new System.Drawing.Size(870, 462);
            this.tc_chitietdv.TabIndex = 0;
            this.tc_chitietdv.SelectedIndexChanged += new System.EventHandler(this.tc_chitietdv_SelectedIndexChanged);
            // 
            // tp_chitiet
            // 
            this.tp_chitiet.Controls.Add(this.flp_hinhanh);
            this.tp_chitiet.Controls.Add(this.groupBox1);
            this.tp_chitiet.Controls.Add(this.pb_main);
            this.tp_chitiet.Location = new System.Drawing.Point(4, 25);
            this.tp_chitiet.Name = "tp_chitiet";
            this.tp_chitiet.Padding = new System.Windows.Forms.Padding(3);
            this.tp_chitiet.Size = new System.Drawing.Size(862, 433);
            this.tp_chitiet.TabIndex = 0;
            this.tp_chitiet.Text = "Chi tiết";
            this.tp_chitiet.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dg_dsPhong);
            this.tabPage2.Controls.Add(this.pn_maphong);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phòng dịch vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flp_hinhanh
            // 
            this.flp_hinhanh.AutoScroll = true;
            this.flp_hinhanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flp_hinhanh.Location = new System.Drawing.Point(0, 315);
            this.flp_hinhanh.Name = "flp_hinhanh";
            this.flp_hinhanh.Size = new System.Drawing.Size(433, 114);
            this.flp_hinhanh.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ten_spdv);
            this.groupBox1.Controls.Add(this.lbl_gia_khuyen_mai);
            this.groupBox1.Controls.Add(this.lbl_gia_ban_goc);
            this.groupBox1.Controls.Add(this.rtxt_detail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(439, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 426);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lbl_ten_spdv
            // 
            this.lbl_ten_spdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten_spdv.Location = new System.Drawing.Point(1, 0);
            this.lbl_ten_spdv.Name = "lbl_ten_spdv";
            this.lbl_ten_spdv.Size = new System.Drawing.Size(413, 34);
            this.lbl_ten_spdv.TabIndex = 55;
            this.lbl_ten_spdv.Text = "label1";
            // 
            // lbl_gia_khuyen_mai
            // 
            this.lbl_gia_khuyen_mai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gia_khuyen_mai.Location = new System.Drawing.Point(125, 78);
            this.lbl_gia_khuyen_mai.Name = "lbl_gia_khuyen_mai";
            this.lbl_gia_khuyen_mai.Size = new System.Drawing.Size(312, 23);
            this.lbl_gia_khuyen_mai.TabIndex = 54;
            this.lbl_gia_khuyen_mai.Text = "label11";
            // 
            // lbl_gia_ban_goc
            // 
            this.lbl_gia_ban_goc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gia_ban_goc.Location = new System.Drawing.Point(126, 45);
            this.lbl_gia_ban_goc.Name = "lbl_gia_ban_goc";
            this.lbl_gia_ban_goc.Size = new System.Drawing.Size(312, 23);
            this.lbl_gia_ban_goc.TabIndex = 53;
            this.lbl_gia_ban_goc.Text = "label11";
            // 
            // rtxt_detail
            // 
            this.rtxt_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_detail.Location = new System.Drawing.Point(22, 119);
            this.rtxt_detail.Name = "rtxt_detail";
            this.rtxt_detail.ReadOnly = true;
            this.rtxt_detail.Size = new System.Drawing.Size(378, 284);
            this.rtxt_detail.TabIndex = 2;
            this.rtxt_detail.Text = "Loài: Chó\nGiống: Husky\nGiới tính: Đực\nNgày sinh: 1/1/2023\nSố mũi tiêm: 1\nTình trạ" +
    "ng sức khỏe: Tốt\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá bán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá gốc:";
            // 
            // pb_main
            // 
            this.pb_main.Location = new System.Drawing.Point(0, 3);
            this.pb_main.Name = "pb_main";
            this.pb_main.Size = new System.Drawing.Size(433, 306);
            this.pb_main.TabIndex = 3;
            this.pb_main.TabStop = false;
            // 
            // pn_maphong
            // 
            this.pn_maphong.Controls.Add(this.btn_confirm);
            this.pn_maphong.Controls.Add(this.cb_trangthai);
            this.pn_maphong.Controls.Add(this.label3);
            this.pn_maphong.Controls.Add(this.label4);
            this.pn_maphong.Location = new System.Drawing.Point(583, 6);
            this.pn_maphong.Name = "pn_maphong";
            this.pn_maphong.Size = new System.Drawing.Size(273, 151);
            this.pn_maphong.TabIndex = 2;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(186, 95);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 30);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "OK";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Items.AddRange(new object[] {
            "Sẵn sàng",
            "Chưa sẵn sàng"});
            this.cb_trangthai.Location = new System.Drawing.Point(125, 56);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(136, 24);
            this.cb_trangthai.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trạng thái:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Phòng";
            // 
            // dg_dsPhong
            // 
            this.dg_dsPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dsPhong.Location = new System.Drawing.Point(1, 6);
            this.dg_dsPhong.Name = "dg_dsPhong";
            this.dg_dsPhong.RowHeadersWidth = 51;
            this.dg_dsPhong.RowTemplate.Height = 24;
            this.dg_dsPhong.Size = new System.Drawing.Size(576, 417);
            this.dg_dsPhong.TabIndex = 3;
            this.dg_dsPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dsPhong_CellClick);
            this.dg_dsPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dsPhong_CellContentClick);
            this.dg_dsPhong.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_dsPhong_CellMouseClick);
            // 
            // Form_ChiTietDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 460);
            this.Controls.Add(this.tc_chitietdv);
            this.Name = "Form_ChiTietDichVu";
            this.Text = "Form_ChiTietDichVu";
            this.tc_chitietdv.ResumeLayout(false);
            this.tp_chitiet.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_main)).EndInit();
            this.pn_maphong.ResumeLayout(false);
            this.pn_maphong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dsPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_chitietdv;
        private System.Windows.Forms.TabPage tp_chitiet;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flp_hinhanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_ten_spdv;
        private System.Windows.Forms.Label lbl_gia_khuyen_mai;
        private System.Windows.Forms.Label lbl_gia_ban_goc;
        private System.Windows.Forms.RichTextBox rtxt_detail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_main;
        private System.Windows.Forms.Panel pn_maphong;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dg_dsPhong;
    }
}