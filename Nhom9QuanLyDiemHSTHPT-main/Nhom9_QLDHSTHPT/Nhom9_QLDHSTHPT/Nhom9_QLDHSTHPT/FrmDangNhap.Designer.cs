﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblthpt = new System.Windows.Forms.Label();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.radGV = new System.Windows.Forms.RadioButton();
            this.radHS = new System.Windows.Forms.RadioButton();
            this.butDangNhap = new System.Windows.Forms.Button();
            this.butThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lblthpt
            // 
            this.lblthpt.AutoSize = true;
            this.lblthpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthpt.Location = new System.Drawing.Point(108, 23);
            this.lblthpt.Name = "lblthpt";
            this.lblthpt.Size = new System.Drawing.Size(334, 24);
            this.lblthpt.TabIndex = 1;
            this.lblthpt.Text = "TRƯỜNG THPT TRẦN HƯNG ĐẠO";
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDN.Location = new System.Drawing.Point(58, 76);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(109, 18);
            this.lblTenDN.TabIndex = 2;
            this.lblTenDN.Text = "Tên đăng nhập:";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK.Location = new System.Drawing.Point(58, 108);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(73, 18);
            this.lblMK.TabIndex = 2;
            this.lblMK.Text = "Mật khẩu:";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(174, 73);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(268, 20);
            this.txtTenDN.TabIndex = 3;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(174, 107);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(268, 20);
            this.txtMK.TabIndex = 3;
            // 
            // radGV
            // 
            this.radGV.AutoSize = true;
            this.radGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGV.Location = new System.Drawing.Point(143, 153);
            this.radGV.Name = "radGV";
            this.radGV.Size = new System.Drawing.Size(76, 19);
            this.radGV.TabIndex = 4;
            this.radGV.TabStop = true;
            this.radGV.Text = "Giáo viên";
            this.radGV.UseVisualStyleBackColor = true;
            this.radGV.CheckedChanged += new System.EventHandler(this.radGV_CheckedChanged);
            // 
            // radHS
            // 
            this.radHS.AutoSize = true;
            this.radHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHS.Location = new System.Drawing.Point(289, 153);
            this.radHS.Name = "radHS";
            this.radHS.Size = new System.Drawing.Size(73, 19);
            this.radHS.TabIndex = 4;
            this.radHS.TabStop = true;
            this.radHS.Text = "Học sinh";
            this.radHS.UseVisualStyleBackColor = true;
            // 
            // butDangNhap
            // 
            this.butDangNhap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.butDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDangNhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.butDangNhap.Location = new System.Drawing.Point(126, 196);
            this.butDangNhap.Name = "butDangNhap";
            this.butDangNhap.Size = new System.Drawing.Size(93, 38);
            this.butDangNhap.TabIndex = 5;
            this.butDangNhap.Text = "Đăng nhập";
            this.butDangNhap.UseVisualStyleBackColor = false;
            this.butDangNhap.Click += new System.EventHandler(this.butDangNhap_Click);
            // 
            // butThoat
            // 
            this.butThoat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.butThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThoat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.butThoat.Location = new System.Drawing.Point(289, 196);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(93, 38);
            this.butThoat.TabIndex = 5;
            this.butThoat.Text = "Thoát";
            this.butThoat.UseVisualStyleBackColor = false;
            this.butThoat.Click += new System.EventHandler(this.butThoat_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 258);
            this.Controls.Add(this.butThoat);
            this.Controls.Add(this.butDangNhap);
            this.Controls.Add(this.radHS);
            this.Controls.Add(this.radGV);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lblTenDN);
            this.Controls.Add(this.lblthpt);
            this.Controls.Add(this.label1);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblthpt;
        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.RadioButton radGV;
        private System.Windows.Forms.RadioButton radHS;
        private System.Windows.Forms.Button butDangNhap;
        private System.Windows.Forms.Button butThoat;
    }
}