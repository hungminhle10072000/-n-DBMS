namespace QuanLyKhoHang.Views.QuanLy
{
    partial class frmKiemKe
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
            this.btnDatLich = new System.Windows.Forms.Button();
            this.btnKiemKeToanBo = new System.Windows.Forms.Button();
            this.btnKiemKeTheoMatHang = new System.Windows.Forms.Button();
            this.btnKiemKeTheoDonNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDatLich
            // 
            this.btnDatLich.Location = new System.Drawing.Point(286, 75);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(300, 150);
            this.btnDatLich.TabIndex = 0;
            this.btnDatLich.Text = "Đặt lịch định kỳ";
            this.btnDatLich.UseVisualStyleBackColor = true;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);
            // 
            // btnKiemKeToanBo
            // 
            this.btnKiemKeToanBo.Location = new System.Drawing.Point(626, 75);
            this.btnKiemKeToanBo.Name = "btnKiemKeToanBo";
            this.btnKiemKeToanBo.Size = new System.Drawing.Size(300, 150);
            this.btnKiemKeToanBo.TabIndex = 0;
            this.btnKiemKeToanBo.Text = "Kiểm kê toàn bộ";
            this.btnKiemKeToanBo.UseVisualStyleBackColor = true;
            this.btnKiemKeToanBo.Click += new System.EventHandler(this.btnKiemKeToanBo_Click);
            // 
            // btnKiemKeTheoMatHang
            // 
            this.btnKiemKeTheoMatHang.Location = new System.Drawing.Point(286, 248);
            this.btnKiemKeTheoMatHang.Name = "btnKiemKeTheoMatHang";
            this.btnKiemKeTheoMatHang.Size = new System.Drawing.Size(300, 150);
            this.btnKiemKeTheoMatHang.TabIndex = 0;
            this.btnKiemKeTheoMatHang.Text = "Kiểm kê theo mặt hàng";
            this.btnKiemKeTheoMatHang.UseVisualStyleBackColor = true;
            this.btnKiemKeTheoMatHang.Click += new System.EventHandler(this.btnKiemKeTheoMatHang_Click);
            // 
            // btnKiemKeTheoDonNhap
            // 
            this.btnKiemKeTheoDonNhap.Location = new System.Drawing.Point(626, 248);
            this.btnKiemKeTheoDonNhap.Name = "btnKiemKeTheoDonNhap";
            this.btnKiemKeTheoDonNhap.Size = new System.Drawing.Size(300, 150);
            this.btnKiemKeTheoDonNhap.TabIndex = 0;
            this.btnKiemKeTheoDonNhap.Text = "Kiểm kê theo đơn nhập";
            this.btnKiemKeTheoDonNhap.UseVisualStyleBackColor = true;
            this.btnKiemKeTheoDonNhap.Click += new System.EventHandler(this.btnKiemKeTheoDonNhap_Click);
            // 
            // frmKiemKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 517);
            this.Controls.Add(this.btnKiemKeTheoDonNhap);
            this.Controls.Add(this.btnKiemKeToanBo);
            this.Controls.Add(this.btnKiemKeTheoMatHang);
            this.Controls.Add(this.btnDatLich);
            this.Name = "frmKiemKe";
            this.Text = "frmKiemKe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.Button btnKiemKeToanBo;
        private System.Windows.Forms.Button btnKiemKeTheoMatHang;
        private System.Windows.Forms.Button btnKiemKeTheoDonNhap;
    }
}