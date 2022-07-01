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
    public partial class FrmNhapDiem : Form
    {
        public FrmNhapDiem()
        {
            InitializeComponent();
        }
        Ketnoi_csdl ketnoi = new Ketnoi_csdl();
        public void LAYBANG_DIEMMONHOC()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("SELECT * FROM DIEMMONHOC");
            dataGridView1.DataSource = dta;
            HIENTHI_DULIEU();
        }
        public void LAYBANG_HOCSINH()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From HOCSINH");
            cbomahs.DataSource = dta;
            cbomahs.DisplayMember = "MaHS";
            cbomahs.ValueMember = "MaHS";
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
        public void LAYBANG_MONHOC()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From MONHOC");
            cbomamh.DataSource = dta;
            cbomamh.DisplayMember = "MaMH";
            cbomamh.ValueMember = "MaMH";
        }
        public void LAYBANG_LOAIDIEM()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From LOAIDIEM");
            cbomaloaidiem.DataSource = dta;
            cbomaloaidiem.DisplayMember = "MaLoaiDiem";
            cbomaloaidiem.ValueMember = "MaLoaiDiem";
        }
        public void HIENTHI_DULIEU()
        {
            cbomahk.DataBindings.Clear();
            cbomahk.DataBindings.Add("Text", dataGridView1.DataSource, "MaHK");

            cbomanh.DataBindings.Clear();
            cbomanh.DataBindings.Add("Text", dataGridView1.DataSource, "MaNH");

            cbomahs.DataBindings.Clear();
            cbomahs.DataBindings.Add("Text", dataGridView1.DataSource, "MaHS");

            cbomamh.DataBindings.Clear();
            cbomamh.DataBindings.Add("Text", dataGridView1.DataSource, "MaMH");

            cbomaloaidiem.DataBindings.Clear();
            cbomaloaidiem.DataBindings.Add("Text", dataGridView1.DataSource, "MaLoaiDiem");

            txtdiem.DataBindings.Clear();
            txtdiem.DataBindings.Add("Text", dataGridView1.DataSource, "Diem");

        }
        private void FrmNhapDiem_Load(object sender, EventArgs e)
        {
            LAYBANG_DIEMMONHOC();
            LAYBANG_HOCKY();
            LAYBANG_HOCSINH();
            LAYBANG_LOAIDIEM();
            LAYBANG_MONHOC();
            LAYBANG_NAMHOC();
            HIENTHI_DULIEU();
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            cbomahs.Text = "";
            cbomahk.Text = "";
            cbomanh.Text = "";
            cbomamh.Text = "";
            cbomaloaidiem.Text = "";
            txtdiem.Text = "";
            
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string strKtra = "select MaHS, MaMH, MaHK , MaNH,  MaLoaiDiem from DIEMMONHOC where MaHS = '" + cbomahs.Text + "' and  MaMH= '" + cbomamh.Text + "'and MaHK='" + cbomahk.Text + "'and MaNH='" + cbomanh.Text + "' and MaLoaiDiem='" + cbomaloaidiem.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, ketnoi.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Học sinh này đã được nhập điểm", "Thông báo");
                cbomahs.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sqlluu;
                sqlluu = "insert into DIEMMONHOC values ('" + cbomahs.Text + "','" + cbomamh.Text + "','" + cbomahk.Text + "', '" + cbomanh.Text + "','" + cbomaloaidiem.Text + "','" + txtdiem.Text + "')";
                ketnoi.Execute(sqlluu);
                LAYBANG_DIEMMONHOC();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sqlsua;
            sqlsua = "Update DIEMMONHOC Set Diem = '"+txtdiem.Text+"' where MaHS = '"+cbomahs.Text + "' and MaMH= '" + cbomamh.Text + "' and MaHK='" + cbomahk.Text + "' and MaNH='" + cbomanh.Text + "'and MaLoaiDiem='" + cbomaloaidiem.Text + "'";
            ketnoi.Execute(sqlsua);
            LAYBANG_DIEMMONHOC();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (thongbao == DialogResult.Yes)
            {
                string sqlxoa = "Delete From DIEMMONHOC where MaHS = '" + cbomahs.Text + "' and MaMH= '" + cbomamh.Text + "' and MaHK='" + cbomahk.Text + "' and MaNH='" + cbomanh.Text + "'and MaLoaiDiem='" + cbomaloaidiem.Text + "'";
                ketnoi.Execute(sqlxoa);
                LAYBANG_DIEMMONHOC();
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
