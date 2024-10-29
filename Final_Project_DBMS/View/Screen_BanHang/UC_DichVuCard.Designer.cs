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
            this.lblGiaKhuyenMai = new System.Windows.Forms.Label();
            this.lblGiaGoc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.grbTen.Controls.Add(this.label1);
            this.grbTen.Controls.Add(this.lblGiaKhuyenMai);
            this.grbTen.Controls.Add(this.lblGiaGoc);
            this.grbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTen.Location = new System.Drawing.Point(3, 200);
            this.grbTen.Name = "grbTen";
            this.grbTen.Size = new System.Drawing.Size(194, 117);
            this.grbTen.TabIndex = 5;
            this.grbTen.TabStop = false;
            this.grbTen.Text = "Tên sản phẩm";
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 190);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(104, 323);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(93, 44);
            this.btnChiTiet.TabIndex = 7;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
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
            // UC_DichVuCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbTen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChiTiet);
            this.Name = "UC_DichVuCard";
            this.Size = new System.Drawing.Size(200, 370);
            this.grbTen.ResumeLayout(false);
            this.grbTen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbTen;
        private System.Windows.Forms.Label lblGiaKhuyenMai;
        private System.Windows.Forms.Label lblGiaGoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Label label1;
    }
}
