namespace Final_Project_DBMS.View.Screen_BanHang
{
    partial class Form_ThemKhachHang
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
            this.btn_huy_bo = new System.Windows.Forms.Button();
            this.btn_xac_nhan = new System.Windows.Forms.Button();
            this.txt_dtl = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_diem_tich_luy = new System.Windows.Forms.Label();
            this.lbl_sdt = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_huy_bo
            // 
            this.btn_huy_bo.Location = new System.Drawing.Point(238, 220);
            this.btn_huy_bo.Name = "btn_huy_bo";
            this.btn_huy_bo.Size = new System.Drawing.Size(82, 35);
            this.btn_huy_bo.TabIndex = 17;
            this.btn_huy_bo.Text = "Hủy bỏ";
            this.btn_huy_bo.UseVisualStyleBackColor = true;
            this.btn_huy_bo.Click += new System.EventHandler(this.btn_huy_bo_Click);
            // 
            // btn_xac_nhan
            // 
            this.btn_xac_nhan.Location = new System.Drawing.Point(326, 220);
            this.btn_xac_nhan.Name = "btn_xac_nhan";
            this.btn_xac_nhan.Size = new System.Drawing.Size(82, 35);
            this.btn_xac_nhan.TabIndex = 16;
            this.btn_xac_nhan.Text = "Xác nhận";
            this.btn_xac_nhan.UseVisualStyleBackColor = true;
            this.btn_xac_nhan.Click += new System.EventHandler(this.btn_xac_nhan_Click);
            // 
            // txt_dtl
            // 
            this.txt_dtl.Location = new System.Drawing.Point(31, 179);
            this.txt_dtl.Name = "txt_dtl";
            this.txt_dtl.Size = new System.Drawing.Size(382, 22);
            this.txt_dtl.TabIndex = 15;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(31, 125);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(382, 22);
            this.txt_sdt.TabIndex = 14;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(31, 72);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(382, 22);
            this.txt_name.TabIndex = 13;
            // 
            // lbl_diem_tich_luy
            // 
            this.lbl_diem_tich_luy.AutoSize = true;
            this.lbl_diem_tich_luy.Location = new System.Drawing.Point(28, 160);
            this.lbl_diem_tich_luy.Name = "lbl_diem_tich_luy";
            this.lbl_diem_tich_luy.Size = new System.Drawing.Size(81, 16);
            this.lbl_diem_tich_luy.TabIndex = 12;
            this.lbl_diem_tich_luy.Text = "Điểm tích lũy";
            // 
            // lbl_sdt
            // 
            this.lbl_sdt.AutoSize = true;
            this.lbl_sdt.Location = new System.Drawing.Point(28, 106);
            this.lbl_sdt.Name = "lbl_sdt";
            this.lbl_sdt.Size = new System.Drawing.Size(85, 16);
            this.lbl_sdt.TabIndex = 11;
            this.lbl_sdt.Text = "Số điện thoại";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Location = new System.Drawing.Point(28, 53);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(103, 16);
            this.lbl_ten.TabIndex = 10;
            this.lbl_ten.Text = "Tên khách hàng";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(149, 20);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(33, 16);
            this.lbl_title.TabIndex = 9;
            this.lbl_title.Text = "Title";
            // 
            // Form_ThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 283);
            this.Controls.Add(this.btn_huy_bo);
            this.Controls.Add(this.btn_xac_nhan);
            this.Controls.Add(this.txt_dtl);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_diem_tich_luy);
            this.Controls.Add(this.lbl_sdt);
            this.Controls.Add(this.lbl_ten);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form_ThemKhachHang";
            this.Text = "Form_ThemKhachHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_huy_bo;
        private System.Windows.Forms.Button btn_xac_nhan;
        private System.Windows.Forms.TextBox txt_dtl;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_diem_tich_luy;
        private System.Windows.Forms.Label lbl_sdt;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.Label lbl_title;
    }
}