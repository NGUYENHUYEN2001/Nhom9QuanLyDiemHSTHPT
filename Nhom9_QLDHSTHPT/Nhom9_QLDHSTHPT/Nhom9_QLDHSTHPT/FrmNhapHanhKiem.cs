using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Nhom9_QLDHSTHPT
{
    public partial class FrmNhapHanhKiem : Form
    {
        public FrmNhapHanhKiem()
        {
            InitializeComponent();
        }
        Ketnoi_csdl ketnoi = new Ketnoi_csdl();
        public void LAYBANG_HOCSINH()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From HOCSINH");
            cbomahs.DataSource = dta;
            cbomahs.DisplayMember = "MaHS";
            cbomahs.ValueMember = "MaHS";
        }
        public void LAYBANG_HANHKIEM()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("SELECT * FROM HANHKIEM");
            dataGridView1.DataSource = dta;
            HIENTHI_DULIEU();
        }
        private void FrmNhapHanhKiem_Load(object sender, EventArgs e)
        {
            LAYBANG_HANHKIEM();
            LAYBANG_HOCKY();
            LAYBANG_HOCSINH();
            LAYBANG_NAMHOC();
            HIENTHI_DULIEU();
        }
        public void LAYBANG_HOCKY()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From HOCKY");
            cbomahk.DataSource = dta;
            cbomahk.DisplayMember = "MaHK";
            cbomahk.ValueMember = "MaHK";
        }
        public void LAYBANG_NAMHOC()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From NAMHOC");
            cbomanh.DataSource = dta;
            cbomanh.DisplayMember = "MaNH";
            cbomanh.ValueMember = "MaNH";
        }
        
        public void HIENTHI_DULIEU()
        {
            cbomahk.DataBindings.Clear();
            cbomahk.DataBindings.Add("Text", dataGridView1.DataSource, "MaHK");

            cbomanh.DataBindings.Clear();
            cbomanh.DataBindings.Add("Text", dataGridView1.DataSource, "MaNH");

            cbomahs.DataBindings.Clear();
            cbomahs.DataBindings.Add("Text", dataGridView1.DataSource, "MaHS");

            txtmahk.DataBindings.Clear();
            txtmahk.DataBindings.Add("Text", dataGridView1.DataSource, "MaHanhKiem");

            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "TenHanhKiem");
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            cbomahs.Text = "";
            cbomahk.Text = "";
            cbomanh.Text = "";
            txtmahk.Text = "";
            textBox1.Text = "";
            txtmahk.Focus();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string strKtra = "select MaHanhKiem, MaNH, MaHK , MaHS from HANHKIEM where MaHanhKiem = '" + txtmahk.Text + "' and  MaHK= '" + cbomahk.Text + "'and MaNH='" + cbomanh.Text + "' and MaHS='" + cbomahs.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, ketnoi.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Học sinh này đã được đánh giá hạnh kiểm", "Thông báo");
                txtmahk.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sqlluu;
                sqlluu = "insert into HANHKIEM values ('" + txtmahk.Text + "',N'" + textBox1.Text + "','" + cbomanh.Text + "', '" + cbomahk.Text + "','" + cbomahs.Text + "')";
                ketnoi.Execute(sqlluu);
                LAYBANG_HANHKIEM();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sqlsua;
            sqlsua = "Update HANHKIEM Set TenHanhKiem = '" + textBox1.Text + "' where MaHanhKiem = '" + txtmahk.Text + "' and MaNH= '" + cbomanh.Text + "' and MaHK='" + cbomahk.Text + "' and MaHS='" + cbomahs.Text + "'";
            ketnoi.Execute(sqlsua);
            LAYBANG_HANHKIEM();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (thongbao == DialogResult.Yes)
            {
                string sqlxoa = "Delete From HANHKIEM where MaHanhKiem = '" + txtmahk.Text + "' and MaNH= '" + cbomanh.Text + "' and MaHK='" + cbomahk.Text + "' and MaHS='" + cbomahs.Text + "'";
                ketnoi.Execute(sqlxoa);
                LAYBANG_HANHKIEM();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn thoát khỏi form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
                this.Close();
        }
    }
}
