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
    public partial class FrmChiTietDiem : Form
    {
        Ketnoi_csdl connection = new Ketnoi_csdl();
        public FrmChiTietDiem()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void FrmChiTietDiem_Load(object sender, EventArgs e)
        {
            loadStudentView();
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "MaHS");
        }

        private void loadStudentView()
        {
            DataTable dta = new DataTable();
            string sql = $"select * from HOCSINH";
            dta = connection.Lay_Dulieu(sql);
            dataGridView1.DataSource = dta;
        }

        private void loadScoreView(string MaHS)
        {
            DataTable dta = new DataTable();
            string sql = $"select * from DIEMMONHOC where MaHS = {MaHS}";
            dta = connection.Lay_Dulieu(sql);
            dataGridView2.DataSource = dta;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadScoreView(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadScoreView(textBox1.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
