
namespace Nhom9_QLDHSTHPT
{
    partial class FrmDangNhap
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
            this.butThoat = new System.Windows.Forms.Button();
            this.butDangNhap = new System.Windows.Forms.Button();
            this.radHS = new System.Windows.Forms.RadioButton();
            this.radGV = new System.Windows.Forms.RadioButton();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.lblthpt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butThoat
            // 
            this.butThoat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.butThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThoat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.butThoat.Location = new System.Drawing.Point(397, 240);
            this.butThoat.Margin = new System.Windows.Forms.Padding(4);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(124, 47);
            this.butThoat.TabIndex = 24;
            this.butThoat.Text = "Thoát";
            this.butThoat.UseVisualStyleBackColor = false;
            this.butThoat.Click += new System.EventHandler(this.butThoat_Click);
            // 
            // butDangNhap
            // 
            this.butDangNhap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.butDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDangNhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.butDangNhap.Location = new System.Drawing.Point(201, 239);
            this.butDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.butDangNhap.Name = "butDangNhap";
            this.butDangNhap.Size = new System.Drawing.Size(124, 47);
            this.butDangNhap.TabIndex = 25;
            this.butDangNhap.Text = "Đăng nhập";
            this.butDangNhap.UseVisualStyleBackColor = false;
            this.butDangNhap.Click += new System.EventHandler(this.butDangNhap_Click);
            // 
            // radHS
            // 
            this.radHS.AutoSize = true;
            this.radHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHS.Location = new System.Drawing.Point(221, 177);
            this.radHS.Margin = new System.Windows.Forms.Padding(4);
            this.radHS.Name = "radHS";
            this.radHS.Size = new System.Drawing.Size(88, 22);
            this.radHS.TabIndex = 22;
            this.radHS.TabStop = true;
            this.radHS.Text = "Học sinh";
            this.radHS.UseVisualStyleBackColor = true;
            // 
            // radGV
            // 
            this.radGV.AutoSize = true;
            this.radGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGV.Location = new System.Drawing.Point(367, 177);
            this.radGV.Margin = new System.Windows.Forms.Padding(4);
            this.radGV.Name = "radGV";
            this.radGV.Size = new System.Drawing.Size(91, 22);
            this.radGV.TabIndex = 23;
            this.radGV.TabStop = true;
            this.radGV.Text = "Giáo viên";
            this.radGV.UseVisualStyleBackColor = true;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(201, 87);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(356, 22);
            this.txtTenDN.TabIndex = 21;
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK.Location = new System.Drawing.Point(47, 130);
            this.lblMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(91, 24);
            this.lblMK.TabIndex = 18;
            this.lblMK.Text = "Mật khẩu:";
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDN.Location = new System.Drawing.Point(47, 91);
            this.lblTenDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(146, 24);
            this.lblTenDN.TabIndex = 19;
            this.lblTenDN.Text = "Tên đăng nhập:";
            // 
            // lblthpt
            // 
            this.lblthpt.AutoSize = true;
            this.lblthpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthpt.Location = new System.Drawing.Point(155, 15);
            this.lblthpt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthpt.Name = "lblthpt";
            this.lblthpt.Size = new System.Drawing.Size(328, 29);
            this.lblthpt.TabIndex = 17;
            this.lblthpt.Text = "TRƯỜNG THPT PHÚ BÌNH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 16;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(201, 127);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(355, 22);
            this.txtMK.TabIndex = 26;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 300);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.butThoat);
            this.Controls.Add(this.butDangNhap);
            this.Controls.Add(this.radHS);
            this.Controls.Add(this.radGV);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lblTenDN);
            this.Controls.Add(this.lblthpt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butThoat;
        private System.Windows.Forms.Button butDangNhap;
        private System.Windows.Forms.RadioButton radHS;
        private System.Windows.Forms.RadioButton radGV;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.Label lblthpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMK;
    }
}