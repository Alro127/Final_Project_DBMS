namespace Final_Project_DBMS.View.Screen_BanHang
{
    partial class UC_SanPhamCard
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
            this.picture_spdv = new System.Windows.Forms.PictureBox();
            this.grbTen = new System.Windows.Forms.GroupBox();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.lbl_gia_uu_dai = new System.Windows.Forms.Label();
            this.lbl_gia_goc = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_spdv)).BeginInit();
            this.grbTen.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture_spdv
            // 
            this.picture_spdv.Location = new System.Drawing.Point(3, 3);
            this.picture_spdv.Name = "picture_spdv";
            this.picture_spdv.Size = new System.Drawing.Size(194, 190);
            this.picture_spdv.TabIndex = 0;
            this.picture_spdv.TabStop = false;
            // 
            // grbTen
            // 
            this.grbTen.AutoSize = true;
            this.grbTen.Controls.Add(this.lbl_ten);
            this.grbTen.Controls.Add(this.lbl_gia_uu_dai);
            this.grbTen.Controls.Add(this.lbl_gia_goc);
            this.grbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTen.Location = new System.Drawing.Point(3, 200);
            this.grbTen.Name = "grbTen";
            this.grbTen.Size = new System.Drawing.Size(198, 100);
            this.grbTen.TabIndex = 1;
            this.grbTen.TabStop = false;
            this.grbTen.Enter += new System.EventHandler(this.grbTen_Enter);
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoEllipsis = true;
            this.lbl_ten.Font = new System.Drawing.Font("Yu Gothic UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten.Location = new System.Drawing.Point(-1, -4);
            this.lbl_ten.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(196, 29);
            this.lbl_ten.TabIndex = 4;
            this.lbl_ten.Text = "label1";
            this.lbl_ten.Click += new System.EventHandler(this.lbl_ten_Click);
            // 
            // lbl_gia_uu_dai
            // 
            this.lbl_gia_uu_dai.AutoSize = true;
            this.lbl_gia_uu_dai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gia_uu_dai.Location = new System.Drawing.Point(6, 67);
            this.lbl_gia_uu_dai.Name = "lbl_gia_uu_dai";
            this.lbl_gia_uu_dai.Size = new System.Drawing.Size(112, 18);
            this.lbl_gia_uu_dai.TabIndex = 1;
            this.lbl_gia_uu_dai.Text = "Giá Khuyến Mãi";
            this.lbl_gia_uu_dai.Click += new System.EventHandler(this.lblGiaKhuyenMai_Click);
            // 
            // lbl_gia_goc
            // 
            this.lbl_gia_goc.AutoSize = true;
            this.lbl_gia_goc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gia_goc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gia_goc.Location = new System.Drawing.Point(6, 29);
            this.lbl_gia_goc.Name = "lbl_gia_goc";
            this.lbl_gia_goc.Size = new System.Drawing.Size(64, 18);
            this.lbl_gia_goc.TabIndex = 0;
            this.lbl_gia_goc.Text = "Giá Gốc";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(5, 301);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 44);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(102, 301);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(93, 44);
            this.btnChiTiet.TabIndex = 3;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // UC_SanPhamCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbTen);
            this.Controls.Add(this.picture_spdv);
            this.Name = "UC_SanPhamCard";
            this.Size = new System.Drawing.Size(198, 348);
            ((System.ComponentModel.ISupportInitialize)(this.picture_spdv)).EndInit();
            this.grbTen.ResumeLayout(false);
            this.grbTen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_spdv;
        private System.Windows.Forms.GroupBox grbTen;
        private System.Windows.Forms.Label lbl_gia_uu_dai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Label lbl_gia_goc;
        private System.Windows.Forms.Label lbl_ten;
    }
}
