namespace QuanLyKhoHang.Views.NhanVien
{
    partial class frmNhanVienManHinhChinh
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
            this.btnKiemKe = new System.Windows.Forms.Button();
            this.btnXuatHang = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCaNhan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKiemKe
            // 
            this.btnKiemKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemKe.Location = new System.Drawing.Point(284, 0);
            this.btnKiemKe.Name = "btnKiemKe";
            this.btnKiemKe.Size = new System.Drawing.Size(130, 51);
            this.btnKiemKe.TabIndex = 0;
            this.btnKiemKe.Text = "Kiểm kê";
            this.btnKiemKe.UseVisualStyleBackColor = true;
            this.btnKiemKe.Click += new System.EventHandler(this.btnKiemKe_Click);
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHang.Location = new System.Drawing.Point(148, 0);
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.Size = new System.Drawing.Size(130, 51);
            this.btnXuatHang.TabIndex = 0;
            this.btnXuatHang.Text = "Xuất hàng";
            this.btnXuatHang.UseVisualStyleBackColor = true;
            this.btnXuatHang.Click += new System.EventHandler(this.btnXuatHang_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Location = new System.Drawing.Point(12, 0);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(130, 51);
            this.btnNhapHang.TabIndex = 0;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnCaNhan);
            this.pnlMenu.Controls.Add(this.btnKiemKe);
            this.pnlMenu.Controls.Add(this.btnXuatHang);
            this.pnlMenu.Controls.Add(this.btnNhapHang);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1007, 51);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnCaNhan
            // 
            this.btnCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaNhan.Location = new System.Drawing.Point(420, 0);
            this.btnCaNhan.Name = "btnCaNhan";
            this.btnCaNhan.Size = new System.Drawing.Size(130, 51);
            this.btnCaNhan.TabIndex = 0;
            this.btnCaNhan.Text = "Cá nhân";
            this.btnCaNhan.UseVisualStyleBackColor = true;
            this.btnCaNhan.Click += new System.EventHandler(this.btnCaNhan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 33);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "Đăng xuất";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 51);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1007, 433);
            this.pnlContainer.TabIndex = 3;
            // 
            // frmNhanVienManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 517);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmNhanVienManHinhChinh";
            this.Text = "ManHinhChinh";
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKiemKe;
        private System.Windows.Forms.Button btnXuatHang;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCaNhan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlContainer;
    }
}