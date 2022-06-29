
namespace Nhom9_QLDHSTHPT
{
    partial class FrmNhapHanhKiem
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
            this.cbomanh = new System.Windows.Forms.ComboBox();
            this.cbomahk = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttenhk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btntaomoi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmahk = new System.Windows.Forms.TextBox();
            this.cbomahs = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbomanh
            // 
            this.cbomanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomanh.FormattingEnabled = true;
            this.cbomanh.Location = new System.Drawing.Point(222, 204);
            this.cbomanh.Name = "cbomanh";
            this.cbomanh.Size = new System.Drawing.Size(215, 24);
            this.cbomanh.TabIndex = 67;
            // 
            // cbomahk
            // 
            this.cbomahk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomahk.FormattingEnabled = true;
            this.cbomahk.Location = new System.Drawing.Point(638, 112);
            this.cbomahk.Name = "cbomahk";
            this.cbomahk.Size = new System.Drawing.Size(215, 24);
            this.cbomahk.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 63;
            this.label7.Text = "Mã học sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Mã năm học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Mã học kỳ:";
            // 
            // txttenhk
            // 
            this.txttenhk.AutoSize = true;
            this.txttenhk.Location = new System.Drawing.Point(113, 161);
            this.txttenhk.Name = "txttenhk";
            this.txttenhk.Size = new System.Drawing.Size(106, 17);
            this.txttenhk.TabIndex = 59;
            this.txttenhk.Text = "Tên hạnh kiểm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Mã hạnh kiểm:";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnthoat.Location = new System.Drawing.Point(1000, 583);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(120, 50);
            this.btnthoat.TabIndex = 57;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnxoa.Location = new System.Drawing.Point(1000, 518);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(120, 50);
            this.btnxoa.TabIndex = 56;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsua.Location = new System.Drawing.Point(1000, 462);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(120, 50);
            this.btnsua.TabIndex = 55;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnluu.Location = new System.Drawing.Point(1000, 406);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(120, 50);
            this.btnluu.TabIndex = 54;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btntaomoi
            // 
            this.btntaomoi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btntaomoi.Location = new System.Drawing.Point(1000, 339);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(120, 50);
            this.btntaomoi.TabIndex = 53;
            this.btntaomoi.Text = "Tạo mới";
            this.btntaomoi.UseVisualStyleBackColor = false;
            this.btntaomoi.Click += new System.EventHandler(this.btntaomoi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(850, 329);
            this.dataGridView1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "NHẬP HẠNH KIỂM HỌC SINH";
            // 
            // txtmahk
            // 
            this.txtmahk.Location = new System.Drawing.Point(222, 119);
            this.txtmahk.Name = "txtmahk";
            this.txtmahk.Size = new System.Drawing.Size(215, 22);
            this.txtmahk.TabIndex = 70;
            // 
            // cbomahs
            // 
            this.cbomahs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomahs.FormattingEnabled = true;
            this.cbomahs.Location = new System.Drawing.Point(638, 158);
            this.cbomahs.Name = "cbomahs";
            this.cbomahs.Size = new System.Drawing.Size(215, 24);
            this.cbomahs.TabIndex = 71;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 72;
            // 
            // FrmNhapHanhKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1189, 687);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbomahs);
            this.Controls.Add(this.txtmahk);
            this.Controls.Add(this.cbomanh);
            this.Controls.Add(this.cbomahk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttenhk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btntaomoi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmNhapHanhKiem";
            this.Text = "FrmNhapHanhKiem";
            this.Load += new System.EventHandler(this.FrmNhapHanhKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbomanh;
        private System.Windows.Forms.ComboBox cbomahk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txttenhk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btntaomoi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmahk;
        private System.Windows.Forms.ComboBox cbomahs;
        private System.Windows.Forms.TextBox textBox1;
    }
}