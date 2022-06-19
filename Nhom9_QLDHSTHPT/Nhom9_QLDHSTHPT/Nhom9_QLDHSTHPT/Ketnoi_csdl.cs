using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Nhom9_QLDHSTHPT
{
    class Ketnoi_csdl
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void ketnoi_dl()
        {
            string strketnoi = @"Data Source=DESKTOP-O631SU0\SQLEXPRESS;Initial Catalog=QLDHSTHPT;Integrated Security=True";
            cnn = new SqlConnection(strketnoi);
            cnn.Open();
        }
        public void huyketnoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public DataTable Lay_Dulieu(string Sql)
        {
            ketnoi_dl();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }
        public void Execute(String sql)
        {
            ketnoi_dl();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            huyketnoi();

        }
    }
}
