namespace Final_Project_DBMS.View.Screen_PhanCa
{
    partial class Form_CheckIn
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.lbl_BuoiLam = new System.Windows.Forms.Label();
            this.lbl_NgayLamViec = new System.Windows.Forms.Label();
            this.lbl_CheckIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày làm việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Buổi làm: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Check in:";
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.Location = new System.Drawing.Point(27, 193);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(422, 35);
            this.btn_CheckIn.TabIndex = 11;
            this.btn_CheckIn.Text = "Check In";
            this.btn_CheckIn.UseVisualStyleBackColor = true;
            this.btn_CheckIn.Click += new System.EventHandler(this.btn_CheckIn_Click);
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV.Location = new System.Drawing.Point(162, 27);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(62, 20);
            this.lbl_MaNV.TabIndex = 12;
            this.lbl_MaNV.Text = "Dữ liệu";
            // 
            // lbl_BuoiLam
            // 
            this.lbl_BuoiLam.AutoSize = true;
            this.lbl_BuoiLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuoiLam.Location = new System.Drawing.Point(162, 67);
            this.lbl_BuoiLam.Name = "lbl_BuoiLam";
            this.lbl_BuoiLam.Size = new System.Drawing.Size(62, 20);
            this.lbl_BuoiLam.TabIndex = 13;
            this.lbl_BuoiLam.Text = "Dữ liệu";
            // 
            // lbl_NgayLamViec
            // 
            this.lbl_NgayLamViec.AutoSize = true;
            this.lbl_NgayLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayLamViec.Location = new System.Drawing.Point(162, 108);
            this.lbl_NgayLamViec.Name = "lbl_NgayLamViec";
            this.lbl_NgayLamViec.Size = new System.Drawing.Size(62, 20);
            this.lbl_NgayLamViec.TabIndex = 14;
            this.lbl_NgayLamViec.Text = "Dữ liệu";
            // 
            // lbl_CheckIn
            // 
            this.lbl_CheckIn.AutoSize = true;
            this.lbl_CheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckIn.Location = new System.Drawing.Point(162, 151);
            this.lbl_CheckIn.Name = "lbl_CheckIn";
            this.lbl_CheckIn.Size = new System.Drawing.Size(111, 20);
            this.lbl_CheckIn.TabIndex = 15;
            this.lbl_CheckIn.Text = "Chưa vào làm";
            // 
            // Form_CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 269);
            this.Controls.Add(this.lbl_CheckIn);
            this.Controls.Add(this.lbl_NgayLamViec);
            this.Controls.Add(this.lbl_BuoiLam);
            this.Controls.Add(this.lbl_MaNV);
            this.Controls.Add(this.btn_CheckIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_CheckIn";
            this.Text = "Form_CheckIn";
            this.Load += new System.EventHandler(this.Form_CheckIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label lbl_BuoiLam;
        private System.Windows.Forms.Label lbl_NgayLamViec;
        private System.Windows.Forms.Label lbl_CheckIn;
    }
}