namespace QuanLyKhoHang.Views.QuanLy
{
    partial class frmQlXuatHang
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDaLayHang = new System.Windows.Forms.DataGridView();
            this.colMaDonHangDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTaDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiTaoDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTaoDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayXuatHangDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridChoXuatHang = new System.Windows.Forms.DataGridView();
            this.colMaDonHangCX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTaCX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiTaoCX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTaoCX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayXuatHangCX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridDangLayHang = new System.Windows.Forms.DataGridView();
            this.colMaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaLayHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChoXuatHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDangLayHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.textBox1);
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
            this.btnAdd.Location = new System.Drawing.Point(712, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Tạo mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 478);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewDaLayHang);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(842, 138);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đã xuất hàng";
            // 
            // dataGridViewDaLayHang
            // 
            this.dataGridViewDaLayHang.AllowUserToAddRows = false;
            this.dataGridViewDaLayHang.AllowUserToDeleteRows = false;
            this.dataGridViewDaLayHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDaLayHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaLayHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDonHangDX,
            this.colMoTaDX,
            this.colNguoiTaoDX,
            this.colNgayTaoDX,
            this.colNgayXuatHangDX});
            this.dataGridViewDaLayHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDaLayHang.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewDaLayHang.Name = "dataGridViewDaLayHang";
            this.dataGridViewDaLayHang.ReadOnly = true;
            this.dataGridViewDaLayHang.RowHeadersWidth = 51;
            this.dataGridViewDaLayHang.Size = new System.Drawing.Size(836, 112);
            this.dataGridViewDaLayHang.TabIndex = 0;
            this.dataGridViewDaLayHang.Text = "dataGridView3";
            // 
            // colMaDonHangDX
            // 
            this.colMaDonHangDX.HeaderText = "Mã đơn hàng";
            this.colMaDonHangDX.MinimumWidth = 6;
            this.colMaDonHangDX.Name = "colMaDonHangDX";
            this.colMaDonHangDX.ReadOnly = true;
            // 
            // colMoTaDX
            // 
            this.colMoTaDX.HeaderText = "Mô tả";
            this.colMoTaDX.MinimumWidth = 6;
            this.colMoTaDX.Name = "colMoTaDX";
            this.colMoTaDX.ReadOnly = true;
            // 
            // colNguoiTaoDX
            // 
            this.colNguoiTaoDX.HeaderText = "Người tạo";
            this.colNguoiTaoDX.MinimumWidth = 6;
            this.colNguoiTaoDX.Name = "colNguoiTaoDX";
            this.colNguoiTaoDX.ReadOnly = true;
            // 
            // colNgayTaoDX
            // 
            this.colNgayTaoDX.HeaderText = "Ngày tạo đơn";
            this.colNgayTaoDX.MinimumWidth = 6;
            this.colNgayTaoDX.Name = "colNgayTaoDX";
            this.colNgayTaoDX.ReadOnly = true;
            // 
            // colNgayXuatHangDX
            // 
            this.colNgayXuatHangDX.HeaderText = "Ngày xuất hàng";
            this.colNgayXuatHangDX.MinimumWidth = 6;
            this.colNgayXuatHangDX.Name = "colNgayXuatHangDX";
            this.colNgayXuatHangDX.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridChoXuatHang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chờ xuất hàng";
            // 
            // dataGridChoXuatHang
            // 
            this.dataGridChoXuatHang.AllowUserToAddRows = false;
            this.dataGridChoXuatHang.AllowUserToDeleteRows = false;
            this.dataGridChoXuatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridChoXuatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChoXuatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDonHangCX,
            this.colMoTaCX,
            this.colNguoiTaoCX,
            this.colNgayTaoCX,
            this.colNgayXuatHangCX});
            this.dataGridChoXuatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridChoXuatHang.Location = new System.Drawing.Point(3, 23);
            this.dataGridChoXuatHang.Name = "dataGridChoXuatHang";
            this.dataGridChoXuatHang.ReadOnly = true;
            this.dataGridChoXuatHang.RowHeadersWidth = 51;
            this.dataGridChoXuatHang.Size = new System.Drawing.Size(836, 146);
            this.dataGridChoXuatHang.TabIndex = 0;
            this.dataGridChoXuatHang.Text = "dataGridView2";
            // 
            // colMaDonHangCX
            // 
            this.colMaDonHangCX.HeaderText = "Mã đơn hàng";
            this.colMaDonHangCX.MinimumWidth = 6;
            this.colMaDonHangCX.Name = "colMaDonHangCX";
            this.colMaDonHangCX.ReadOnly = true;
            // 
            // colMoTaCX
            // 
            this.colMoTaCX.HeaderText = "Mô tả";
            this.colMoTaCX.MinimumWidth = 6;
            this.colMoTaCX.Name = "colMoTaCX";
            this.colMoTaCX.ReadOnly = true;
            // 
            // colNguoiTaoCX
            // 
            this.colNguoiTaoCX.HeaderText = "Người tạo";
            this.colNguoiTaoCX.MinimumWidth = 6;
            this.colNguoiTaoCX.Name = "colNguoiTaoCX";
            this.colNguoiTaoCX.ReadOnly = true;
            // 
            // colNgayTaoCX
            // 
            this.colNgayTaoCX.HeaderText = "Ngày tạo đơn";
            this.colNgayTaoCX.MinimumWidth = 6;
            this.colNgayTaoCX.Name = "colNgayTaoCX";
            this.colNgayTaoCX.ReadOnly = true;
            // 
            // colNgayXuatHangCX
            // 
            this.colNgayXuatHangCX.HeaderText = "Ngày xuất hàng";
            this.colNgayXuatHangCX.MinimumWidth = 6;
            this.colNgayXuatHangCX.Name = "colNgayXuatHangCX";
            this.colNgayXuatHangCX.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridDangLayHang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đang lấy hàng";
            // 
            // dataGridDangLayHang
            // 
            this.dataGridDangLayHang.AllowUserToAddRows = false;
            this.dataGridDangLayHang.AllowUserToDeleteRows = false;
            this.dataGridDangLayHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDangLayHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDangLayHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDonHang,
            this.colMoTa,
            this.colNguoiTao,
            this.colNgayTao,
            this.colNgayXuat});
            this.dataGridDangLayHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDangLayHang.Location = new System.Drawing.Point(3, 23);
            this.dataGridDangLayHang.Name = "dataGridDangLayHang";
            this.dataGridDangLayHang.ReadOnly = true;
            this.dataGridDangLayHang.RowHeadersWidth = 51;
            this.dataGridDangLayHang.Size = new System.Drawing.Size(836, 142);
            this.dataGridDangLayHang.TabIndex = 0;
            this.dataGridDangLayHang.Text = "dataGridView1";
            // 
            // colMaDonHang
            // 
            this.colMaDonHang.HeaderText = "Mã đơn hàng";
            this.colMaDonHang.MinimumWidth = 6;
            this.colMaDonHang.Name = "colMaDonHang";
            this.colMaDonHang.ReadOnly = true;
            // 
            // colMoTa
            // 
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.MinimumWidth = 6;
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            // 
            // colNguoiTao
            // 
            this.colNguoiTao.HeaderText = "Người tạo";
            this.colNguoiTao.MinimumWidth = 6;
            this.colNguoiTao.Name = "colNguoiTao";
            this.colNguoiTao.ReadOnly = true;
            // 
            // colNgayTao
            // 
            this.colNgayTao.HeaderText = "Ngày tạo";
            this.colNgayTao.MinimumWidth = 6;
            this.colNgayTao.Name = "colNgayTao";
            this.colNgayTao.ReadOnly = true;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.HeaderText = "Ngày xuất hàng";
            this.colNgayXuat.MinimumWidth = 6;
            this.colNgayXuat.Name = "colNgayXuat";
            this.colNgayXuat.ReadOnly = true;
            // 
            // frmQlXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 543);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmQlXuatHang";
            this.Text = "frmQlXuatHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaLayHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChoXuatHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDangLayHang)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewDaLayHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridChoXuatHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridDangLayHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonHangCX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTaCX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiTaoCX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTaoCX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayXuatHangCX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonHangDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTaDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiTaoDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTaoDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayXuatHangDX;
    }
}