using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đề_1_720_2212404_PhamKhanhLinh
{
    public partial class frmQuanLyMonHoc : Form
    {
        public frmQuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void rdTatCa_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString = "server=.;database=QLDKHP; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            string query = "SELECT MaMH, TenMH, MaCTĐT, SoTC FROM MonHoc";
            cmd.CommandText = query;
            conn.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            this.DisplayMonHoc(sqlDataReader);
            conn.Close();
        }
        private void DisplayMonHoc(SqlDataReader reader)
        {
            lvDanhSachMH.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["MaMH"].ToString());
                lvDanhSachMH.Items.Add(item);
                item.SubItems.Add(reader["TenMH"].ToString());
                item.SubItems.Add(reader["MaCTĐT"].ToString());
                item.SubItems.Add(reader["SoTC"].ToString());
            }
        }

        private void lvDanhSachMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "server=.;database=QLDKHP; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            string mhTen = cmd.ExecuteScalar().ToString();
            this.Text = "Danh sách môn học: " + mhTen;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }
    }
}
