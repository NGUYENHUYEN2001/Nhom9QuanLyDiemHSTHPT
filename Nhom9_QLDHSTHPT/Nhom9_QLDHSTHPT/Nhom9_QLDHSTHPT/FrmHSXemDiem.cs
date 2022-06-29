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
    public partial class FrmHSXemDiem : Form
    {
        public FrmHSXemDiem()
        {
            InitializeComponent();
        }
        Ketnoi_csdl ketnoi = new Ketnoi_csdl();
        public void LAYBANG_TONGHOP()
        {
            DataTable dta = new DataTable();
            string sql = "select * from XemdiemHS where Ma_Hoc_Sinh = '"+Globals.USER_ID+"'";
            dta = ketnoi.Lay_Dulieu(sql);
            dataGridView1.DataSource = dta;

        }
        public void LAYBANG_HOCKY()
        {
            DataTable dta = new DataTable();
            string sql = "select distinct TenHK from  HOCKY";
            dta = ketnoi.Lay_Dulieu(sql);
            cbomahk.DataSource = dta;
            cbomahk.DisplayMember = "TenHK";
            cbomahk.ValueMember = "TenHK";
        }
        public void LAYBANG_NAMHOC()
        {
            DataTable dta = new DataTable();
            string sql = "select distinct TenNH from  NAMHOC";
            dta = ketnoi.Lay_Dulieu(sql);
            cbonamhoc.DataSource = dta;
            cbonamhoc.DisplayMember = "TenNH";
            cbonamhoc.ValueMember = "TenNH";
        }
        public void LAYBANG_MONHOC()
        {
            DataTable dta = new DataTable();
            string sql = "select distinct TenMH from  MONHOC";
            dta = ketnoi.Lay_Dulieu(sql);
            cbomonhoc.DataSource = dta;
            cbomonhoc.DisplayMember = "TenMH";
            cbomonhoc.ValueMember = "TenMH";
        }
        public void LAYBANG_NAMHOC1()
        {
            DataTable dta = new DataTable();
            string sql = "select distinct Nam_Hoc from  bc_hk1";
            dta = ketnoi.Lay_Dulieu(sql);
            cbonh1.DataSource = dta;
            cbonh1.DisplayMember = "Nam_Hoc";
            cbonh1.ValueMember = "Nam_Hoc";
        }
        public void LAYBANG_NAMHOC2()
        {
            DataTable dta = new DataTable();
            string sql = "select distinct Nam_Hoc from bc_hk2";
            dta = ketnoi.Lay_Dulieu(sql);
            cbonh2.DataSource = dta;
            cbonh2.DisplayMember = "Nam_Hoc";
            cbonh2.ValueMember = "Nam_Hoc";
        }
        public void LAYBANG_NAMHOC3()
        {
            DataTable dta = new DataTable();
            string sql = "select distinct Nam_Hoc from  bc_canam";
            dta = ketnoi.Lay_Dulieu(sql);
            cbonh3.DataSource = dta;
            cbonh3.DisplayMember = "Nam_Hoc";
            cbonh3.ValueMember = "Nam_Hoc";
        }
        public void LAYBANG_NAMHOChk1gr3()
        {
            DataTable dta = new DataTable();
            string sql = "select distinct TenNH from  NAMHOC";
            dta = ketnoi.Lay_Dulieu(sql);
            cbonhhk1gr3.DataSource = dta;
            cbonhhk1gr3.DisplayMember = "TenNH";
            cbonhhk1gr3.ValueMember = "TenNH";
        }
        public void LAYBANG_NAMHOChk2gr3()
        {
            DataTable dta = new DataTable();
            string sql = "select distinct TenNH from  NAMHOC";
            dta = ketnoi.Lay_Dulieu(sql);
            cbonhhk2gr3.DataSource = dta;
            cbonhhk2gr3.DisplayMember = "TenNH";
            cbonhhk2gr3.ValueMember = "TenNH";
        }
        public void LAYBANG_NAMHOCcanamgr3()
        {
            DataTable dta = new DataTable();
            string sql = "select distinct TenNH from  NAMHOC";
            dta = ketnoi.Lay_Dulieu(sql);
            cbonhgr3.DataSource = dta;
            cbonhgr3.DisplayMember = "TenNH";
            cbonhgr3.ValueMember = "TenNH";
        }
        private void FrmHSXemDiem_Load(object sender, EventArgs e)
        {
            LAYBANG_HOCKY();
            LAYBANG_MONHOC();
            LAYBANG_NAMHOC();
            LAYBANG_TONGHOP();
            LAYBANG_NAMHOC1();
            LAYBANG_NAMHOC2();
            LAYBANG_NAMHOC3();
            LAYBANG_NAMHOCcanamgr3();
            LAYBANG_NAMHOChk1gr3();
            LAYBANG_NAMHOChk2gr3();
        }

        private void bnttk_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;

            if (rdbhk1.Checked)
            {
                sqltk = "SELECT * from bc_hk1 where Ma_Hoc_Sinh = '"+Globals.USER_ID+"' and Nam_Hoc like '" + cbonh1.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }
            else if (rdbhk2.Checked)
            {
                sqltk = "SELECT * from bc_hk2 where Ma_Hoc_Sinh = '" + Globals.USER_ID + "' and Nam_Hoc like '" + cbonh2.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }
            else if (rdbnamhoc.Checked)
            {
                sqltk = "SELECT * from bc_canam where Ma_Hoc_Sinh = '" + Globals.USER_ID + "' and Nam_Hoc like '" + cbonh3.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }
            dataGridView1.DataSource = dta;
        }

        private void btntk_Click(object sender, EventArgs e)
        {

            DataTable dta = new DataTable();
            string NamHoc = "";
            string HocKy = "";
            //string MaHS = "";
            string MonHoc = "";


            if (chknamhoc.Checked == true)
                NamHoc = cbonamhoc.Text;

            if (chkhocky.Checked == true)
                HocKy = cbomahk.Text;

            if (chkmonhoc.Checked == true)
                MonHoc = cbomonhoc.Text;

            string sql_tk = string.Format("EXEC SP_TIMKIEM_CHITIET '{0}', '{1}', '{2}', N'{3}'", NamHoc, HocKy, Globals.USER_ID, MonHoc);
            dta = ketnoi.Lay_Dulieu(sql_tk);
            dataGridView1.DataSource = dta;

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn thoát khỏi form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
                this.Close();
        }

        private void btntracuugr3_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;

            if (rdbhk1gr3.Checked)
            {
                sqltk = "SELECT * from Diem_Hoc_Sinh_HK1 where Ma_Hoc_Sinh ='" + Globals.USER_ID + "' and Nam_Hoc like '" + cbonhhk1gr3.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }
            else if (rdbhk2gr3.Checked)
            {
                sqltk = "SELECT * from Diem_Hoc_Sinh_HK2 where Ma_Hoc_Sinh = '" + Globals.USER_ID + "' and Nam_Hoc like '" + cbonhhk2gr3.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }
            else if (rdbnamhocgr3.Checked)
            {
                sqltk = "SELECT * from vm_tinhdiem where Ma_Hoc_Sinh ='" + Globals.USER_ID + "' and Nam_Hoc like '" + cbonhgr3.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }
            dataGridView1.DataSource = dta;
        }
    }
}
