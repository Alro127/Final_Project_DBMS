namespace Final_Project_DBMS.View.Screen_BanHang
{
    partial class Form_DanhSachPhongDV
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
            this.gv_phongdv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_phongdv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_phongdv
            // 
            this.gv_phongdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_phongdv.Location = new System.Drawing.Point(12, 12);
            this.gv_phongdv.Name = "gv_phongdv";
            this.gv_phongdv.RowHeadersWidth = 51;
            this.gv_phongdv.RowTemplate.Height = 24;
            this.gv_phongdv.Size = new System.Drawing.Size(689, 426);
            this.gv_phongdv.TabIndex = 0;
            this.gv_phongdv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_phongdv_CellContentClick);
            this.gv_phongdv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_phongdv_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_confirm);
            this.panel1.Controls.Add(this.cb_trangthai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(721, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 151);
            this.panel1.TabIndex = 1;
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
            this.cb_trangthai.Location = new System.Drawing.Point(113, 56);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(148, 24);
            this.cb_trangthai.TabIndex = 2;
            this.cb_trangthai.SelectedIndexChanged += new System.EventHandler(this.cb_trangthai_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng";
            // 
            // Form_DanhSachPhongDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gv_phongdv);
            this.Name = "Form_DanhSachPhongDV";
            this.Text = "FormDanhSachPhongDV";
            ((System.ComponentModel.ISupportInitialize)(this.gv_phongdv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_phongdv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}