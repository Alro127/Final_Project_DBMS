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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbTen = new System.Windows.Forms.GroupBox();
            this.lblGiaGoc = new System.Windows.Forms.Label();
            this.lblGiaKhuyenMai = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbTen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grbTen
            // 
            this.grbTen.Controls.Add(this.lblGiaKhuyenMai);
            this.grbTen.Controls.Add(this.lblGiaGoc);
            this.grbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTen.Location = new System.Drawing.Point(3, 200);
            this.grbTen.Name = "grbTen";
            this.grbTen.Size = new System.Drawing.Size(194, 97);
            this.grbTen.TabIndex = 1;
            this.grbTen.TabStop = false;
            this.grbTen.Text = "Tên sản phẩm";
            // 
            // lblGiaGoc
            // 
            this.lblGiaGoc.AutoSize = true;
            this.lblGiaGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaGoc.Location = new System.Drawing.Point(6, 29);
            this.lblGiaGoc.Name = "lblGiaGoc";
            this.lblGiaGoc.Size = new System.Drawing.Size(64, 18);
            this.lblGiaGoc.TabIndex = 0;
            this.lblGiaGoc.Text = "Giá Gốc";
            // 
            // lblGiaKhuyenMai
            // 
            this.lblGiaKhuyenMai.AutoSize = true;
            this.lblGiaKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaKhuyenMai.Location = new System.Drawing.Point(6, 58);
            this.lblGiaKhuyenMai.Name = "lblGiaKhuyenMai";
            this.lblGiaKhuyenMai.Size = new System.Drawing.Size(112, 18);
            this.lblGiaKhuyenMai.TabIndex = 1;
            this.lblGiaKhuyenMai.Text = "Giá Khuyến Mãi";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(3, 303);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 44);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(104, 303);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(93, 44);
            this.btnChiTiet.TabIndex = 3;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            // 
            // itemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbTen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "itemCard";
            this.Size = new System.Drawing.Size(200, 350);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbTen.ResumeLayout(false);
            this.grbTen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbTen;
        private System.Windows.Forms.Label lblGiaKhuyenMai;
        private System.Windows.Forms.Label lblGiaGoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChiTiet;
    }
}
