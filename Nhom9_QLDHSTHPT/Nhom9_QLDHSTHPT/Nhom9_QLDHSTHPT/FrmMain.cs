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
    public partial class FrmMain : Form
    {
        private int childFormNumber = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mnuTTHS_Click(object sender, EventArgs e)
        {
            Form frmtths = new FrmThongTinHocSinh();
            frmtths.Show();
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        Ketnoi_csdl ketnoi = new Ketnoi_csdl();
        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtHomeName.Visible = false;
            DataTable dta = new DataTable();
            string sql = "";

            if (Globals.STATUS == 0)
            {
                mnudanhgiahk.Visible = false;
                mnunhapdiem.Visible = false;
                mnutongquat.Visible = false;
                mnuchitiet.Visible = false;
                mnubaocao.Visible = false;
                mnuTTHS.Visible = false;
                sql = "SELECT TenHS AS Name FROM HOCSINH WHERE MaHS = '" + Globals.USER_ID + "'";
            }
            else
            {
                mnuxemdiem.Visible = false;
                sql = "SELECT TenGV AS Name FROM GIAOVIEN WHERE MaGV = '" + Globals.USER_ID + "'";
            }

            dta = ketnoi.Lay_Dulieu(sql);
            txtHomeName.DataBindings.Clear();
            txtHomeName.DataBindings.Add("Text", dta, "Name");
            lblNameUser.Text = txtHomeName.Text;
        }

        private void mnunhapdiem_Click(object sender, EventArgs e)
        {
            Form frmnd = new FrmNhapDiem();
            frmnd.Show();
        }

        private void mnudanhgiahk_Click(object sender, EventArgs e)
        {
            Form frmhk = new FrmNhapHanhKiem();
            frmhk.Show();
        }

        private void mnutongquat_Click(object sender, EventArgs e)
        {
            Form frmtq = new FrmThongKeDiemHS();
            frmtq.Show();
        }

        private void mnuchitiet_Click(object sender, EventArgs e)
        {
           Form frmctd = new FrmChiTietDiem();
           frmctd.Show();
        }

        private void mnubaocao_Click(object sender, EventArgs e)
        {
            Form frmtbc = new FrmBaoCaoDiemHS();
            frmtbc.Show();
        }

        private void mnuxemdiem_Click(object sender, EventArgs e)
        {
            Form frmxd = new FrmHSXemDiem();
            frmxd.Show();
        }

        private void mnudangxuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắn chắn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                Form frm1 = new FrmDangNhap();
                this.Close();
                frm1.Show();
            }
        }
    }
}
