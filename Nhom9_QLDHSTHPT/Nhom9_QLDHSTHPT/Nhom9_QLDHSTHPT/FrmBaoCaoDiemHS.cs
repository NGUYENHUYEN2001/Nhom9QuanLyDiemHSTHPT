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
    public partial class FrmBaoCaoDiemHS : Form
    {
        public FrmBaoCaoDiemHS()
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
        private void FrmBaoCaoDiemHS_Load(object sender, EventArgs e)
        {
            LAYBANG_NAMHOC1();
            LAYBANG_NAMHOC2();
            LAYBANG_NAMHOC3();

            DataTable data = new DataTable();
            data = ketnoi.Lay_Dulieu("SELECT * FROM bc_hk1");
            bchk1 frmBaoCao1 = new bchk1();
            frmBaoCao1.SetDataSource(data);
            crystalReportViewer1.ReportSource = frmBaoCao1;

            data = ketnoi.Lay_Dulieu("SELECT * FROM bc_hk2");
            bchk2 frmBaoCao2 = new bchk2();
            frmBaoCao2.SetDataSource(data);
            crystalReportViewer1.ReportSource = frmBaoCao2;

            data = ketnoi.Lay_Dulieu("SELECT * FROM bc_canam");
            bcnamhoc frmBaoCao3 = new bcnamhoc();
            frmBaoCao3.SetDataSource(data);
            crystalReportViewer1.ReportSource = frmBaoCao3;
        }

        private void btntk1_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            string namHoc = "";
            string maSv = "";

            if (chknamhoc1.Checked == true)
            {
                namHoc = cbonamhoc1.Text;
            }
            if (chkhs1.Checked == true)
            {
                maSv = txtmahs1.Text;
            }

            string sqlBc = string.Format("EXEC  SP_BCHK1 '{0}', '{1}'", namHoc, maSv);
            data = ketnoi.Lay_Dulieu(sqlBc);
            bchk1 frmBaoCao = new bchk1();
            frmBaoCao.SetDataSource(data);
            crystalReportViewer1.ReportSource = frmBaoCao;


        }

        private void btntk2_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            string namHoc = "";
            string maSv = "";

            if (chknamhoc2.Checked == true)
            {
                namHoc = cbonamhoc2.Text;
            }
            if (chkmhs2.Checked == true)
            {
                maSv = txtmhs2.Text;
            }

            string sqlBc = string.Format("EXEC  SP_BCHK2 '{0}', '{1}'", namHoc, maSv);
            data = ketnoi.Lay_Dulieu(sqlBc);
            bchk2 frmBaoCao = new bchk2();
            frmBaoCao.SetDataSource(data);
            crystalReportViewer1.ReportSource = frmBaoCao;

        }

        private void btntk3_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            string namHoc = "";
            string maSv = "";

            if (chknamhoc3.Checked == true)
            {
                namHoc = cbonamhoc3.Text;
            }
            if (chkmhs3.Checked == true)
            {
                maSv = txtmhs3.Text;
            }

            string sqlBc = string.Format("EXEC  SP_BCCANAM '{0}', '{1}'", namHoc, maSv);
            data = ketnoi.Lay_Dulieu(sqlBc);
            bcnamhoc frmBaoCao = new bcnamhoc();
            frmBaoCao.SetDataSource(data);
            crystalReportViewer1.ReportSource = frmBaoCao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn thoát khỏi form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
                this.Close();
        }
    }
}
