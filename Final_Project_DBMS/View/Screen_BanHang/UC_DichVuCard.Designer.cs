namespace Final_Project_DBMS.View.Screen_BanHang
{
    partial class UC_DichVuCard
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
            this.btnThem = new System.Windows.Forms.Button();
            this.grbTen = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_gia_uu_dai = new System.Windows.Forms.Label();
            this.lbl_gia_goc = new System.Windows.Forms.Label();
            this.picture_spdv = new System.Windows.Forms.PictureBox();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.lbl_so_phong = new System.Windows.Forms.Label();
            this.grbTen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_spdv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(3, 323);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 44);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // grbTen
            // 
            this.grbTen.Controls.Add(this.lbl_so_phong);
            this.grbTen.Controls.Add(this.lbl_ten);
            this.grbTen.Controls.Add(this.label1);
            this.grbTen.Controls.Add(this.lbl_gia_uu_dai);
            this.grbTen.Controls.Add(this.lbl_gia_goc);
            this.grbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTen.Location = new System.Drawing.Point(3, 200);
            this.grbTen.Name = "grbTen";
            this.grbTen.Size = new System.Drawing.Size(194, 117);
            this.grbTen.TabIndex = 5;
            this.grbTen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phòng trống: ";
            // 
            // lbl_gia_uu_dai
            // 
            this.lbl_gia_uu_dai.AutoSize = true;
            this.lbl_gia_uu_dai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gia_uu_dai.Location = new System.Drawing.Point(6, 58);
            this.lbl_gia_uu_dai.Name = "lbl_gia_uu_dai";
            this.lbl_gia_uu_dai.Size = new System.Drawing.Size(112, 18);
            this.lbl_gia_uu_dai.TabIndex = 1;
            this.lbl_gia_uu_dai.Text = "Giá Khuyến Mãi";
            // 
            // lbl_gia_goc
            // 
            this.lbl_gia_goc.AutoSize = true;
            this.lbl_gia_goc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gia_goc.Location = new System.Drawing.Point(6, 29);
            this.lbl_gia_goc.Name = "lbl_gia_goc";
            this.lbl_gia_goc.Size = new System.Drawing.Size(64, 18);
            this.lbl_gia_goc.TabIndex = 0;
            this.lbl_gia_goc.Text = "Giá Gốc";
            // 
            // picture_spdv
            // 
            this.picture_spdv.Location = new System.Drawing.Point(3, 3);
            this.picture_spdv.Name = "picture_spdv";
            this.picture_spdv.Size = new System.Drawing.Size(194, 190);
            this.picture_spdv.TabIndex = 4;
            this.picture_spdv.TabStop = false;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(104, 323);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(93, 44);
            this.btnChiTiet.TabIndex = 7;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoEllipsis = true;
            this.lbl_ten.Font = new System.Drawing.Font("Yu Gothic UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten.Location = new System.Drawing.Point(1, 0);
            this.lbl_ten.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(196, 29);
            this.lbl_ten.TabIndex = 5;
            this.lbl_ten.Text = "label1";
            this.lbl_ten.Click += new System.EventHandler(this.lbl_ten_Click);
            // 
            // lbl_so_phong
            // 
            this.lbl_so_phong.AutoSize = true;
            this.lbl_so_phong.Location = new System.Drawing.Point(129, 87);
            this.lbl_so_phong.Name = "lbl_so_phong";
            this.lbl_so_phong.Size = new System.Drawing.Size(59, 20);
            this.lbl_so_phong.TabIndex = 6;
            this.lbl_so_phong.Text = "label2";
            // 
            // UC_DichVuCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbTen);
            this.Controls.Add(this.picture_spdv);
            this.Controls.Add(this.btnChiTiet);
            this.Name = "UC_DichVuCard";
            this.Size = new System.Drawing.Size(200, 370);
            this.grbTen.ResumeLayout(false);
            this.grbTen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_spdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbTen;
        private System.Windows.Forms.Label lbl_gia_uu_dai;
        private System.Windows.Forms.Label lbl_gia_goc;
        private System.Windows.Forms.PictureBox picture_spdv;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.Label lbl_so_phong;
    }
}
