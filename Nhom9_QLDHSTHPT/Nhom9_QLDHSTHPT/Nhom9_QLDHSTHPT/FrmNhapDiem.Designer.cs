
namespace Nhom9_QLDHSTHPT
{
    partial class FrmNhapDiem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btntaomoi = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbomahs = new System.Windows.Forms.ComboBox();
            this.cbomamh = new System.Windows.Forms.ComboBox();
            this.cbomahk = new System.Windows.Forms.ComboBox();
            this.cbomanh = new System.Windows.Forms.ComboBox();
            this.cbomaloaidiem = new System.Windows.Forms.ComboBox();
            this.txtdiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "NHẬP ĐIỂM HỌC SINH";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(850, 329);
            this.dataGridView1.TabIndex = 33;
            // 
            // btntaomoi
            // 
            this.btntaomoi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btntaomoi.Location = new System.Drawing.Point(1014, 331);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(120, 50);
            this.btntaomoi.TabIndex = 34;
            this.btntaomoi.Text = "Tạo mới";
            this.btntaomoi.UseVisualStyleBackColor = false;
            this.btntaomoi.Click += new System.EventHandler(this.btntaomoi_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnluu.Location = new System.Drawing.Point(1014, 398);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(120, 50);
            this.btnluu.TabIndex = 35;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsua.Location = new System.Drawing.Point(1014, 454);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(120, 50);
            this.btnsua.TabIndex = 36;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnxoa.Location = new System.Drawing.Point(1014, 510);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(120, 50);
            this.btnxoa.TabIndex = 37;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnthoat.Location = new System.Drawing.Point(1014, 575);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(120, 50);
            this.btnthoat.TabIndex = 38;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã học sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Mã môn học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Mã học kỳ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Mã năm học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Mã loại điểm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Điểm:";
            // 
            // cbomahs
            // 
            this.cbomahs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomahs.FormattingEnabled = true;
            this.cbomahs.Location = new System.Drawing.Point(236, 108);
            this.cbomahs.Name = "cbomahs";
            this.cbomahs.Size = new System.Drawing.Size(215, 24);
            this.cbomahs.TabIndex = 45;
            // 
            // cbomamh
            // 
            this.cbomamh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomamh.FormattingEnabled = true;
            this.cbomamh.Location = new System.Drawing.Point(236, 153);
            this.cbomamh.Name = "cbomamh";
            this.cbomamh.Size = new System.Drawing.Size(215, 24);
            this.cbomamh.TabIndex = 46;
            // 
            // cbomahk
            // 
            this.cbomahk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomahk.FormattingEnabled = true;
            this.cbomahk.Location = new System.Drawing.Point(236, 195);
            this.cbomahk.Name = "cbomahk";
            this.cbomahk.Size = new System.Drawing.Size(215, 24);
            this.cbomahk.TabIndex = 47;
            // 
            // cbomanh
            // 
            this.cbomanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomanh.FormattingEnabled = true;
            this.cbomanh.Location = new System.Drawing.Point(652, 108);
            this.cbomanh.Name = "cbomanh";
            this.cbomanh.Size = new System.Drawing.Size(215, 24);
            this.cbomanh.TabIndex = 48;
            // 
            // cbomaloaidiem
            // 
            this.cbomaloaidiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomaloaidiem.FormattingEnabled = true;
            this.cbomaloaidiem.Location = new System.Drawing.Point(652, 153);
            this.cbomaloaidiem.Name = "cbomaloaidiem";
            this.cbomaloaidiem.Size = new System.Drawing.Size(215, 24);
            this.cbomaloaidiem.TabIndex = 49;
            // 
            // txtdiem
            // 
            this.txtdiem.Location = new System.Drawing.Point(652, 196);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(215, 22);
            this.txtdiem.TabIndex = 50;
            // 
            // FrmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1205, 688);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.cbomaloaidiem);
            this.Controls.Add(this.cbomanh);
            this.Controls.Add(this.cbomahk);
            this.Controls.Add(this.cbomamh);
            this.Controls.Add(this.cbomahs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btntaomoi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmNhapDiem";
            this.Text = "FrmNhapDiem";
            this.Load += new System.EventHandler(this.FrmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntaomoi;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbomahs;
        private System.Windows.Forms.ComboBox cbomamh;
        private System.Windows.Forms.ComboBox cbomahk;
        private System.Windows.Forms.ComboBox cbomanh;
        private System.Windows.Forms.ComboBox cbomaloaidiem;
        private System.Windows.Forms.TextBox txtdiem;
    }
}