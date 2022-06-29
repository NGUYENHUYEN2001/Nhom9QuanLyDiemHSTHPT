
namespace Nhom9_QLDHSTHPT
{
    partial class FrmThongTinHocSinh
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
            this.txtGT = new System.Windows.Forms.NumericUpDown();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblTenHS = new System.Windows.Forms.Label();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.dGV_HS = new System.Windows.Forms.DataGridView();
            this.butThoat = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.butThem = new System.Windows.Forms.Button();
            this.butTaoMoi = new System.Windows.Forms.Button();
            this.lblTTHS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtGT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_HS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(111, 137);
            this.txtGT.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(218, 20);
            this.txtGT.TabIndex = 49;
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(436, 159);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(218, 21);
            this.cmbMaLop.TabIndex = 48;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaySinh.Location = new System.Drawing.Point(111, 173);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(218, 20);
            this.txtNgaySinh.TabIndex = 47;
            // 
            // txtTenHS
            // 
            this.txtTenHS.Location = new System.Drawing.Point(111, 101);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(218, 20);
            this.txtTenHS.TabIndex = 46;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(436, 115);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(218, 20);
            this.txtSDT.TabIndex = 45;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(436, 76);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(218, 20);
            this.txtDiaChi.TabIndex = 44;
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(111, 65);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(218, 20);
            this.txtMaHS.TabIndex = 43;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.Location = new System.Drawing.Point(353, 160);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(48, 15);
            this.lblMaLop.TabIndex = 41;
            this.lblMaLop.Text = "Mã lớp:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(353, 120);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(82, 15);
            this.lblSDT.TabIndex = 40;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDC.Location = new System.Drawing.Point(353, 76);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(48, 15);
            this.lblDC.TabIndex = 42;
            this.lblDC.Text = "Địa chỉ:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(28, 173);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(64, 15);
            this.lblNgaySinh.TabIndex = 39;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGT.Location = new System.Drawing.Point(28, 137);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(55, 15);
            this.lblGT.TabIndex = 38;
            this.lblGT.Text = "Giới tính:";
            // 
            // lblTenHS
            // 
            this.lblTenHS.AutoSize = true;
            this.lblTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHS.Location = new System.Drawing.Point(28, 102);
            this.lblTenHS.Name = "lblTenHS";
            this.lblTenHS.Size = new System.Drawing.Size(80, 15);
            this.lblTenHS.TabIndex = 37;
            this.lblTenHS.Text = "Tên học sinh:";
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHS.Location = new System.Drawing.Point(28, 66);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(77, 15);
            this.lblMaHS.TabIndex = 36;
            this.lblMaHS.Text = "Mã học sinh:";
            // 
            // dGV_HS
            // 
            this.dGV_HS.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dGV_HS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_HS.Location = new System.Drawing.Point(31, 236);
            this.dGV_HS.Name = "dGV_HS";
            this.dGV_HS.Size = new System.Drawing.Size(623, 185);
            this.dGV_HS.TabIndex = 35;
            // 
            // butThoat
            // 
            this.butThoat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.butThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThoat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.butThoat.Location = new System.Drawing.Point(686, 310);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(86, 33);
            this.butThoat.TabIndex = 33;
            this.butThoat.Text = "Thoát";
            this.butThoat.UseVisualStyleBackColor = false;
            this.butThoat.Click += new System.EventHandler(this.butThoat_Click);
            // 
            // butXoa
            // 
            this.butXoa.BackColor = System.Drawing.SystemColors.HighlightText;
            this.butXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXoa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.butXoa.Location = new System.Drawing.Point(686, 259);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(86, 33);
            this.butXoa.TabIndex = 32;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = false;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butSua
            // 
            this.butSua.BackColor = System.Drawing.SystemColors.HighlightText;
            this.butSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSua.ForeColor = System.Drawing.SystemColors.Highlight;
            this.butSua.Location = new System.Drawing.Point(686, 206);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(86, 33);
            this.butSua.TabIndex = 31;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = false;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butThem
            // 
            this.butThem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.butThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.butThem.Location = new System.Drawing.Point(686, 155);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(86, 33);
            this.butThem.TabIndex = 30;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = false;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butTaoMoi
            // 
            this.butTaoMoi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.butTaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTaoMoi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.butTaoMoi.Location = new System.Drawing.Point(686, 102);
            this.butTaoMoi.Name = "butTaoMoi";
            this.butTaoMoi.Size = new System.Drawing.Size(86, 33);
            this.butTaoMoi.TabIndex = 34;
            this.butTaoMoi.Text = "Tạo mới";
            this.butTaoMoi.UseVisualStyleBackColor = false;
            this.butTaoMoi.Click += new System.EventHandler(this.butTaoMoi_Click);
            // 
            // lblTTHS
            // 
            this.lblTTHS.AutoSize = true;
            this.lblTTHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTHS.Location = new System.Drawing.Point(279, 29);
            this.lblTTHS.Name = "lblTTHS";
            this.lblTTHS.Size = new System.Drawing.Size(228, 24);
            this.lblTTHS.TabIndex = 29;
            this.lblTTHS.Text = "THÔNG TIN HỌC SINH";
            // 
            // FrmThongTinHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.cmbMaLop);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtTenHS);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblGT);
            this.Controls.Add(this.lblTenHS);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.dGV_HS);
            this.Controls.Add(this.butThoat);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.butTaoMoi);
            this.Controls.Add(this.lblTTHS);
            this.Name = "FrmThongTinHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin học sinh";
            this.Load += new System.EventHandler(this.FrmThongTinHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_HS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtGT;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblTenHS;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.DataGridView dGV_HS;
        private System.Windows.Forms.Button butThoat;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.Button butTaoMoi;
        private System.Windows.Forms.Label lblTTHS;
    }
}