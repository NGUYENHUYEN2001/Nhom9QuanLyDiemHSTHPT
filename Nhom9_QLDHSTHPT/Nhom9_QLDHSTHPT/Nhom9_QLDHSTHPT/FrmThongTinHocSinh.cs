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
    public partial class FrmThongTinHocSinh : Form
    {
        public FrmThongTinHocSinh()
        {
            InitializeComponent();
        }
        private void FrmThongTinHocSinh_Load(object sender, EventArgs e)
        {
            LAYBANG_HOCSINH();
            LAYBANG_LOP();
        }
        Ketnoi_csdl ketnoi = new Ketnoi_csdl();
        private void LAYBANG_HOCSINH()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From HOCSINH");
            dGV_HS.DataSource = dta;
            Hienthi_Dulieu();
        }
        private void LAYBANG_LOP()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From LOP");
            cmbMaLop.DataSource = dta;
            cmbMaLop.DisplayMember = "MaLop";
            cmbMaLop.ValueMember = "MaLop";
        }
        private void Hienthi_Dulieu()
        {
            txtMaHS.DataBindings.Clear();
            txtMaHS.DataBindings.Add("Text", dGV_HS.DataSource, "MaHS");

            txtTenHS.DataBindings.Clear();
            txtTenHS.DataBindings.Add("Text", dGV_HS.DataSource, "TenHS");

            txtGT.DataBindings.Clear();
            txtGT.DataBindings.Add("Value", dGV_HS.DataSource, "GioiTinh");

            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", dGV_HS.DataSource, "NgaySinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dGV_HS.DataSource, "DiaChi");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dGV_HS.DataSource, "Sdt");

            cmbMaLop.DataBindings.Clear();
            cmbMaLop.DataBindings.Add("Text", dGV_HS.DataSource, "MaLop");
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
                this.Close();
        }

        private void butTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaHS.Text = "";
            txtTenHS.Text = "";
            txtGT.Value = 0;
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            string strktra = "Select MaHS from HOCSINH where MaHS = '" + txtMaHS.Text + "'";
            SqlCommand cmd = new SqlCommand(strktra, ketnoi.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();

            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã chức vụ này đã tồn tại, nhập lại mã khác", "Thông báo");
                txtMaHS.Focus();
                doc_dl.Close();
                doc_dl.Dispose();

            }
            else
            {
                string sql1 = "Insert into HOCSINH Values('" + txtMaHS.Text + "' , '" + txtTenHS.Text + "' , '" + txtGT.Value + "' , '" + txtNgaySinh.Text + "' , '" + txtDiaChi.Text + "', '" + txtSDT.Text + "', '" + cmbMaLop.Text + "')";
                ketnoi.Execute(sql1);
                LAYBANG_HOCSINH();
            }
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            string sql2;
            sql2 = "Update HOCSINH Set TenHS ='" + txtTenHS.Text + "', GioiTinh = '" + txtGT.Value + "', NgaySinh = '" + txtNgaySinh.Text + "', DiaChi= '" + txtDiaChi.Text + "', Sdt = '" + txtSDT.Text + "', MaLop = '" + cmbMaLop.Text + "' where  MaHS = '" + txtMaHS.Text + "'";
            ketnoi.Execute(sql2);
            LAYBANG_HOCSINH();
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (thongbao == DialogResult.Yes)
            {
                ketnoi.Execute("Delete HOCSINH Where MaHS = '" + txtMaHS.Text + "'");
                LAYBANG_HOCSINH();
            }
        }
    }
}
