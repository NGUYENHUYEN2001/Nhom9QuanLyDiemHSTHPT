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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        Ketnoi_csdl ketnoi = new Ketnoi_csdl();

        private void butThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void butDangNhap_Click(object sender, EventArgs e)
        {
            ketnoi.ketnoi_dl();

            string username = txtTenDN.Text;
            string passw = txtMK.Text;
            int status = (radGV.Checked == true) ? 1 : 0;

            string sql_login = "select [Username], MatKhau from DANGNHAP where [Username] = '" + username + "' and MatKhau = '" + passw + "' and [Status] = " + status;

            SqlCommand cmd = new SqlCommand(sql_login, ketnoi.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();

            if (datRed.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Globals.USER_ID = username;
                Globals.STATUS = status;
                Form frmmain = new FrmMain();
                frmmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
