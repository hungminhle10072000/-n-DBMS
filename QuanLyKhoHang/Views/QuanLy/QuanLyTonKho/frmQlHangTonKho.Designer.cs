namespace QuanLyKhoHang.Views.QuanLy
{
    partial class frmQlHangTonKho
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colMaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhapKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThaihai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKiemKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKiemKe = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDonHang,
            this.colTenMatHang,
            this.colNgayNhapKho,
            this.colMaPhieuNhap,
            this.colTrangThaihai,
            this.colNgayKiemKe,
            this.colKiemKe});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(800, 407);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 407);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(88, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 27);
            this.textBox1.TabIndex = 1;
            // 
            // colMaDonHang
            // 
            this.colMaDonHang.HeaderText = "Mã đơn hàng";
            this.colMaDonHang.MinimumWidth = 6;
            this.colMaDonHang.Name = "colMaDonHang";
            this.colMaDonHang.ReadOnly = true;
            // 
            // colTenMatHang
            // 
            this.colTenMatHang.HeaderText = "Tên mặt hàng";
            this.colTenMatHang.MinimumWidth = 6;
            this.colTenMatHang.Name = "colTenMatHang";
            this.colTenMatHang.ReadOnly = true;
            // 
            // colNgayNhapKho
            // 
            this.colNgayNhapKho.HeaderText = "Ngày nhập kho";
            this.colNgayNhapKho.MinimumWidth = 6;
            this.colNgayNhapKho.Name = "colNgayNhapKho";
            this.colNgayNhapKho.ReadOnly = true;
            // 
            // colMaPhieuNhap
            // 
            this.colMaPhieuNhap.HeaderText = "Lô hàng";
            this.colMaPhieuNhap.MinimumWidth = 6;
            this.colMaPhieuNhap.Name = "colMaPhieuNhap";
            this.colMaPhieuNhap.ReadOnly = true;
            // 
            // colTrangThaihai
            // 
            this.colTrangThaihai.HeaderText = "Trạng thái";
            this.colTrangThaihai.MinimumWidth = 6;
            this.colTrangThaihai.Name = "colTrangThaihai";
            this.colTrangThaihai.ReadOnly = true;
            // 
            // colNgayKiemKe
            // 
            this.colNgayKiemKe.HeaderText = "Ngày kiểm kê gần nhất";
            this.colNgayKiemKe.MinimumWidth = 6;
            this.colNgayKiemKe.Name = "colNgayKiemKe";
            this.colNgayKiemKe.ReadOnly = true;
            // 
            // colKiemKe
            // 
            this.colKiemKe.HeaderText = "";
            this.colKiemKe.MinimumWidth = 6;
            this.colKiemKe.Name = "colKiemKe";
            this.colKiemKe.ReadOnly = true;
            this.colKiemKe.Text = "Kiểm kê";
            this.colKiemKe.UseColumnTextForButtonValue = true;
            // 
            // frmQlHangTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmQlHangTonKho";
            this.Text = "frmQlHangTonKho";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaihai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKiemKe;
        private System.Windows.Forms.DataGridViewButtonColumn colKiemKe;
    }
}