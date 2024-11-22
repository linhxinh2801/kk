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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }
        private void LoadChuongtrinhDT()
        {
            string connectionString = "server=.;database=QLDKHP; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MaCTDT, TenCTDT, MoTa FROM ChuongtrinhDT";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            cbbDT.DataSource = dt;
            cbbDT.DisplayMember = "TenCTDT";
            cbbDT.ValueMember = "MaCTDT";
        }
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            this.LoadChuongtrinhDT();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=.;database=QLDKHP; Integrated Security=true;";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE InsertMH @mamh, @tenmh, @sotc, @mactdt";
                cmd.Parameters.Add("@mamh", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@tenmh", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@sotc", SqlDbType.Int);
                cmd.Parameters.Add("@mactdt", SqlDbType.Int);

                cmd.Parameters["@mamh"].Value = txtMaMH.Text;
                cmd.Parameters["@tenmh"].Value = txtTenMH.Text;
                cmd.Parameters["@sotc"].Value = nudSoTC.Value;
                cmd.Parameters["@mactdt"].Value = cbbDT.SelectedValue;

                conn.Open();
                int numRowAffect = cmd.ExecuteNonQuery();
                if (numRowAffect > 0)
                {
                    MessageBox.Show("Cập nhật môn học thành công");
                    this.ResetText();

                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
                conn.Close();
                conn.Dispose();
            }
            catch ( SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
        }
    }
}
