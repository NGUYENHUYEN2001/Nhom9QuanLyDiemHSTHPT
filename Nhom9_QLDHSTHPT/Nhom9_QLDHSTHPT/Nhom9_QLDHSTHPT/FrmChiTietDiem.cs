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
            string sql = null;
            if (MaHS.Length != 0)
            {

                sql = $"select * from DIEMMONHOC where MaHS = '{MaHS}'";
                sql = appender(sql);
            }
            else
            {
                sql = $"select * from DIEMMONHOC";
            }
            dta = connection.Lay_Dulieu(sql);
            dataGridView2.DataSource = dta;
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaHS = textBox1.Text;
            yearBoxInitializer(MaHS);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string MaHS = textBox1.Text;
            yearBoxInitializer(MaHS);
            semesterBoxInitializer(MaHS);
            scoreTypeInitializer(MaHS);

            loadScoreView(MaHS);
            loadSubjectView(MaHS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadScoreView(textBox1.Text);
        }

        private void loadSubjectView(string MaHS)
        {
            DataTable dta = new DataTable();
            string sql = null;

            sql = $"select MaMH, AVG(Diem) as Mean, MAX(Diem) as Highest, MIN(Diem) as Lowest from DIEMMONHOC " +
                $"where MaHS = '{MaHS}' ";
            sql = appender(sql, "group by MaMH");   
            dta = connection.Lay_Dulieu(sql);
            dataGridView3.DataSource = dta;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void yearBoxInitializer(string MaHS)
        {
            DataTable dta = new DataTable();
     
            string sql = $"select distinct DIEMMONHOC.MaNH, NAMHOC.TenNH from DIEMMONHOC, NAMHOC " +
                $"where MaHS = '{MaHS}'" +
                $"and (DIEMMONHOC.MaNH=NAMHOC.MaNH)";
            dta = connection.Lay_Dulieu(sql);


            var dr = dta.NewRow();
            dr["MaNH"] = -1;
            dr["TenNH"] = "All";
            dta.Rows.InsertAt(dr, 0);

            comboBox1.DataSource = dta;

            comboBox1.ValueMember = "MaNH";
            comboBox1.DisplayMember = "TenNH";
        }

        private void semesterBoxInitializer(string MaHS)
        {
            DataTable dta = new DataTable();
            string sql = $"select distinct DIEMMONHOC.MaHK, HOCKY.TenHK from DIEMMONHOC, HOCKY where " +
                $"MaHS = '{MaHS}'" +
                $"and (DIEMMONHOC.MaHK=HOCKY.MaHK)";
            dta = connection.Lay_Dulieu(sql);
            var dr = dta.NewRow();
            dr["MaHK"] = -1;
            dr["TenHK"] = "All";
            dta.Rows.InsertAt(dr, 0);

            comboBox2.DataSource = dta;
            comboBox2.ValueMember = "MaHK";
            comboBox2.DisplayMember = "TenHK";
        }

        private void scoreTypeInitializer(string MaHS)
        {
            DataTable dta = new DataTable();
            string sql = $"select distinct DIEMMONHOC.MaLoaiDiem, LOAIDIEM.TenLoaiDiem from DIEMMONHOC, LOAIDIEM where " +
                $"MaHS = '{MaHS}'" +
                $"and (DIEMMONHOC.MaLoaiDiem=LOAIDIEM.MaLoaiDiem)";
            dta = connection.Lay_Dulieu(sql);
            var dr = dta.NewRow();
            dr["MaLoaiDiem"] = -1;
            dr["TenLoaiDiem"] = "All";
            dta.Rows.InsertAt(dr, 0);
            comboBox3.DataSource = dta;
            comboBox3.ValueMember = "MaLoaiDiem";
            comboBox3.DisplayMember = "TenLoaiDiem";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadScoreView(textBox1.Text);
            loadSubjectView(textBox1.Text);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadScoreView(textBox1.Text);
            loadSubjectView(textBox1.Text);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadScoreView(textBox1.Text);
            loadSubjectView(textBox1.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string appender(string query, string option = "")
        {
            if (!comboBox1.SelectedValue.Equals("-1"))
            {
                query += $"and (MaNH = '{comboBox1.SelectedValue}')";
            };

            if (comboBox2.SelectedValue != null && !comboBox2.SelectedValue.Equals("-1"))
            {
                query += $"and (MaHK = '{comboBox2.SelectedValue}')";
            }

            if (comboBox3.SelectedValue != null && !comboBox3.SelectedValue.Equals("-1"))
            {
                query += $"and (MaLoaiDiem = '{comboBox3.SelectedValue}')";
            }
            return query+option;
        }
    }
}
