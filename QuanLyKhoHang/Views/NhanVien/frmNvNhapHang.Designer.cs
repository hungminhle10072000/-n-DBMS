namespace QuanLyKhoHang.Views.NhanVien
{
    partial class frmNvNhapHang
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 30);
            this.panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(83, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm :";
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
            this.colMoTa,
            this.colNgayTao,
            this.colNguoiTao,
            this.colNhaCungCap});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(700, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 308);
            this.panel2.TabIndex = 1;
            // 
            // colMaDonHang
            // 
            this.colMaDonHang.DataPropertyName = "MaPhieu";
            this.colMaDonHang.HeaderText = "Mã đơn hàng";
            this.colMaDonHang.MinimumWidth = 6;
            this.colMaDonHang.Name = "colMaDonHang";
            this.colMaDonHang.ReadOnly = true;
            this.colMaDonHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.MinimumWidth = 6;
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            this.colMoTa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colNgayTao
            // 
            this.colNgayTao.DataPropertyName = "NgayNhap";
            this.colNgayTao.HeaderText = "Ngày tạo";
            this.colNgayTao.MinimumWidth = 6;
            this.colNgayTao.Name = "colNgayTao";
            this.colNgayTao.ReadOnly = true;
            this.colNgayTao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colNguoiTao
            // 
            this.colNguoiTao.DataPropertyName = "TenNhanVien";
            this.colNguoiTao.HeaderText = "Người tạo";
            this.colNguoiTao.MinimumWidth = 6;
            this.colNguoiTao.Name = "colNguoiTao";
            this.colNguoiTao.ReadOnly = true;
            this.colNguoiTao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colNhaCungCap
            // 
            this.colNhaCungCap.DataPropertyName = "NhapTu";
            this.colNhaCungCap.HeaderText = "Nhà cung cấp";
            this.colNhaCungCap.Name = "colNhaCungCap";
            this.colNhaCungCap.ReadOnly = true;
            this.colNhaCungCap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmNvNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNvNhapHang";
            this.Text = "frmNvNhapHang";
            this.DoubleClick += new System.EventHandler(this.frmNvNhapHang_DoubleClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaCungCap;
    }
}