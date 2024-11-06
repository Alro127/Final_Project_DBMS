namespace Final_Project_DBMS.View.Screen_BanHang
{
    partial class Form_ChiTietSPDV
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
            this.pb_main = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ten_spdv = new System.Windows.Forms.Label();
            this.lbl_gia_khuyen_mai = new System.Windows.Forms.Label();
            this.lbl_gia_ban_goc = new System.Windows.Forms.Label();
            this.rtxt_detail = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flp_hinhanh = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_main)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_main
            // 
            this.pb_main.Location = new System.Drawing.Point(12, 12);
            this.pb_main.Name = "pb_main";
            this.pb_main.Size = new System.Drawing.Size(433, 306);
            this.pb_main.TabIndex = 0;
            this.pb_main.TabStop = false;
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
            this.groupBox1.Location = new System.Drawing.Point(451, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_ten_spdv
            // 
            this.lbl_ten_spdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten_spdv.Location = new System.Drawing.Point(6, -3);
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
            this.lbl_gia_khuyen_mai.Click += new System.EventHandler(this.lbl_gia_khuyen_mai_Click);
            // 
            // lbl_gia_ban_goc
            // 
            this.lbl_gia_ban_goc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gia_ban_goc.Location = new System.Drawing.Point(126, 45);
            this.lbl_gia_ban_goc.Name = "lbl_gia_ban_goc";
            this.lbl_gia_ban_goc.Size = new System.Drawing.Size(312, 23);
            this.lbl_gia_ban_goc.TabIndex = 53;
            this.lbl_gia_ban_goc.Text = "label11";
            this.lbl_gia_ban_goc.Click += new System.EventHandler(this.lbl_gia_ban_goc_Click);
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
            this.rtxt_detail.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
            // flp_hinhanh
            // 
            this.flp_hinhanh.AutoScroll = true;
            this.flp_hinhanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flp_hinhanh.Location = new System.Drawing.Point(12, 324);
            this.flp_hinhanh.Name = "flp_hinhanh";
            this.flp_hinhanh.Size = new System.Drawing.Size(433, 114);
            this.flp_hinhanh.TabIndex = 2;
            // 
            // Form_ChiTietSPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.flp_hinhanh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pb_main);
            this.Name = "Form_ChiTietSPDV";
            this.Text = "FormChiTietSPDV";
            this.Load += new System.EventHandler(this.Form_ChiTietSPDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_main)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_main;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxt_detail;
        private System.Windows.Forms.FlowLayoutPanel flp_hinhanh;
        private System.Windows.Forms.Label lbl_gia_ban_goc;
        private System.Windows.Forms.Label lbl_gia_khuyen_mai;
        private System.Windows.Forms.Label lbl_ten_spdv;
    }
}