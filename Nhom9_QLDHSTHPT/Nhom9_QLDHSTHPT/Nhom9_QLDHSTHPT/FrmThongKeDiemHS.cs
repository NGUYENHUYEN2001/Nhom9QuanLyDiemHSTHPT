using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Nhom9_QLDHSTHPT
{
    public partial class FrmThongKeDiemHS : Form
    {
        public FrmThongKeDiemHS()
        {
            InitializeComponent();
        }
        Ketnoi_csdl ketnoi = new Ketnoi_csdl();
        public void LAYBANG_NAMHOC1()
        {
            DataTable dta = new DataTable();
            string sql = "select distinct TenNH from  NAMHOC";
            dta = ketnoi.Lay_Dulieu(sql);
            cbonamhoc1.DataSource = dta;
            cbonamhoc1.DisplayMember = "TenNH";
            cbonamhoc1.ValueMember = "TenNH";
        }
        public void LAYBANG_NAMHOC2()
        {
            DataTable dta = new DataTable();
            string sql = "select distinct TenNH from  NAMHOC";
            dta = ketnoi.Lay_Dulieu(sql);
            cbonamhoc2.DataSource = dta;
            cbonamhoc2.DisplayMember = "TenNH";
            cbonamhoc2.ValueMember = "TenNH";
        }
        public void LAYBANG_NAMHOC3()
        {
            DataTable dta = new DataTable();
            string sql = "select distinct TenNH from  NAMHOC";
            dta = ketnoi.Lay_Dulieu(sql);
            cbonamhoc3.DataSource = dta;
            cbonamhoc3.DisplayMember = "TenNH";
            cbonamhoc3.ValueMember = "TenNH";
        }
        private void FrmThongKeDiemHS_Load(object sender, EventArgs e)
        {
            LAYBANG_NAMHOC1();
            LAYBANG_NAMHOC2();
            LAYBANG_NAMHOC3();
        }

        private void btntk1_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string NamHoc = "";
            string MaHS = "";

            if (chknamhoc1.Checked == true)
                NamHoc = cbonamhoc1.Text;

            if (chkhs1.Checked == true)
                MaHS = txtmahs1.Text;

            string sql_tk = string.Format("EXEC  SP_BCHK1 '{0}', '{1}'", NamHoc, MaHS);
            dta = ketnoi.Lay_Dulieu(sql_tk);
            dataGridView1.DataSource = dta;
        }

        private void btntk2_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string NamHoc = "";
            string MaHS = "";

            if (chknamhoc2.Checked == true)
                NamHoc = cbonamhoc2.Text;

            if (chkmhs2.Checked == true)
                MaHS = txtmhs2.Text;

            string sql_tk = string.Format("EXEC  SP_BCHK2 '{0}', '{1}'", NamHoc, MaHS);
            dta = ketnoi.Lay_Dulieu(sql_tk);
            dataGridView1.DataSource = dta;

        }

        private void btntk2_Click_1(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string NamHoc = "";
            string MaHS = "";

            if (chknamhoc2.Checked == true)
                NamHoc = cbonamhoc2.Text;

            if (chkmhs2.Checked == true)
                MaHS = txtmhs2.Text;

            string sql_tk = string.Format("EXEC  SP_BCHK2 '{0}', '{1}'", NamHoc, MaHS);
            dta = ketnoi.Lay_Dulieu(sql_tk);
            dataGridView1.DataSource = dta;
        }

        //private void btntk2_Click(object sender, EventArgs e)
        //{
           

       // }

        private void btntk3_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string NamHoc = "";
            string MaHS = "";

            if (chknamhoc3.Checked == true)
                NamHoc = cbonamhoc3.Text;

            if (chkmhs3.Checked == true)
                MaHS = txtmhs3.Text;

            string sql_tk = string.Format("EXEC  SP_BCCANAM '{0}', '{1}'", NamHoc, MaHS);
            dta = ketnoi.Lay_Dulieu(sql_tk);
            dataGridView1.DataSource = dta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn thoát khỏi form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
                this.Close();
        }
    }
}
