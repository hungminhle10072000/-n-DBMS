namespace QuanLyKhoHang.Views.QuanLy
{
    partial class frmThemDonNhapHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtMoTa = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapTu = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng: ";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDonHang.Location = new System.Drawing.Point(122, 7);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(213, 27);
            this.txtMaDonHang.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtMoTa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNhapTu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaDonHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 127);
            this.panel1.TabIndex = 2;
            // 
            // rtMoTa
            // 
            this.rtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtMoTa.Location = new System.Drawing.Point(122, 53);
            this.rtMoTa.Name = "rtMoTa";
            this.rtMoTa.Size = new System.Drawing.Size(359, 56);
            this.rtMoTa.TabIndex = 2;
            this.rtMoTa.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Location = new System.Drawing.Point(617, 69);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(213, 27);
            this.txtTongTien.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập từ:";
            // 
            // txtNhapTu
            // 
            this.txtNhapTu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhapTu.Location = new System.Drawing.Point(617, 12);
            this.txtNhapTu.Name = "txtNhapTu";
            this.txtNhapTu.Size = new System.Drawing.Size(213, 27);
            this.txtNhapTu.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 416);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMatHang,
            this.colTenMatHang,
            this.colSoLuong,
            this.colDonGia,
            this.colDel});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(842, 416);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // colMaMatHang
            // 
            this.colMaMatHang.HeaderText = "Mã mặt hàng";
            this.colMaMatHang.MinimumWidth = 6;
            this.colMaMatHang.Name = "colMaMatHang";
            this.colMaMatHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTenMatHang
            // 
            this.colTenMatHang.HeaderText = "Tên mặt hàng";
            this.colTenMatHang.MinimumWidth = 6;
            this.colTenMatHang.Name = "colTenMatHang";
            this.colTenMatHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            this.colDonGia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDel
            // 
            this.colDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDel.HeaderText = "";
            this.colDel.MinimumWidth = 6;
            this.colDel.Name = "colDel";
            this.colDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDel.Text = "Delete";
            this.colDel.UseColumnTextForButtonValue = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTao);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 499);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(842, 44);
            this.panel3.TabIndex = 4;
            // 
            // btnTao
            // 
            this.btnTao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTao.Location = new System.Drawing.Point(586, 6);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(63, 32);
            this.btnTao.TabIndex = 0;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // frmThemDonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 543);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmThemDonNhapHang";
            this.Text = "frmThemDonNhapHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapTu;
        private System.Windows.Forms.RichTextBox rtMoTa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
    }
}