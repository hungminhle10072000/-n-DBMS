namespace QuanLyKhoHang.Views.QuanLy
{
    partial class frmQLNhapHang
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colMaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhapTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiTaoDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTaoDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(726, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Tạo mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(99, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm : ";
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
            // ColMoTa
            // 
            this.ColMoTa.DataPropertyName = "MoTa";
            this.ColMoTa.HeaderText = "Mô tả";
            this.ColMoTa.MinimumWidth = 6;
            this.ColMoTa.Name = "ColMoTa";
            this.ColMoTa.ReadOnly = true;
            this.ColMoTa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colNhapTu
            // 
            this.colNhapTu.DataPropertyName = "NhapTu";
            this.colNhapTu.HeaderText = "Nhập từ";
            this.colNhapTu.MinimumWidth = 6;
            this.colNhapTu.Name = "colNhapTu";
            this.colNhapTu.ReadOnly = true;
            this.colNhapTu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colNguoiTaoDon
            // 
            this.colNguoiTaoDon.DataPropertyName = "NhanVienNhap";
            this.colNguoiTaoDon.HeaderText = "Người tạo đơn";
            this.colNguoiTaoDon.MinimumWidth = 6;
            this.colNguoiTaoDon.Name = "colNguoiTaoDon";
            this.colNguoiTaoDon.ReadOnly = true;
            this.colNguoiTaoDon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colNgayTaoDon
            // 
            this.colNgayTaoDon.DataPropertyName = "NgayNhap";
            this.colNgayTaoDon.HeaderText = "Ngày tạo đơn";
            this.colNgayTaoDon.MinimumWidth = 6;
            this.colNgayTaoDon.Name = "colNgayTaoDon";
            this.colNgayTaoDon.ReadOnly = true;
            this.colNgayTaoDon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colGiaTri
            // 
            this.colGiaTri.DataPropertyName = "GiaTri";
            this.colGiaTri.HeaderText = "Giá trị đơn hàng";
            this.colGiaTri.MinimumWidth = 6;
            this.colGiaTri.Name = "colGiaTri";
            this.colGiaTri.ReadOnly = true;
            this.colGiaTri.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmQLNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 543);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDonHang,
            this.ColMoTa,
            this.colNhapTu,
            this.colNguoiTaoDon,
            this.colNgayTaoDon,
            this.colGiaTri});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(842, 478);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmQLNhapHang";
            this.Text = "frmQLNhapHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhapTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiTaoDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTaoDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTri;
    }
}