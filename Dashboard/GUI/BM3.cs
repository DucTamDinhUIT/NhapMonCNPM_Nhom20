using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLBVoThuat
{
    public partial class BM3 : Form
    {
        public BM3()
        {
            InitializeComponent();
            phieuThu.DataSource = ShowThu();
            phieuChi.DataSource = ShowChi();
        }

        private void BM3_Load(object sender, EventArgs e)
        {
            phieuThu.DataSource = ShowThu();
            phieuChi.DataSource = ShowChi();
        }

        private object ShowThu()
        {
            DataTable dataTable = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                //using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.VoSinh INNER JOIN dbo.BienLai ON dbo.VoSinh.STT = dbo.BienLai.STT", con))
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.PhieuThu", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                    con.Close();
                };
            }
            return dataTable;
        }

        private object ShowChi()
        {
            DataTable dataTable = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                //using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.VoSinh INNER JOIN dbo.BienLai ON dbo.VoSinh.STT = dbo.BienLai.STT", con))
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.PhieuChi", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                    con.Close();
                };
            }
            return dataTable;
        }



        private void Search_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chức năng tạm khóa", "Exit Please", MessageBoxButtons.OK);
            phieuThu.DataSource = ShowThu();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();

                if (textBox1.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("SELECT TenVoSinh, SoTienNop FROM dbo.VoSinh FULL JOIN dbo.PhieuThu ON dbo.VoSinh.STT = dbo.PhieuThu.STT WHERE dbo.VoSinh.STT = @STT", con);
                    //SqlCommand cmd = new SqlCommand("SELECT TenVoSinh, SoTienNop FROM dbo.VoSinh INNER JOIN dbo.PhieuThu ON dbo.VoSinh.STT WHERE dbo.VoSinh.STT = @STT", con);
                    cmd.Parameters.AddWithValue("@STT", int.Parse(textBox1.Text));
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //tenVoSinh.Text = reader.GetValue(0).ToString();
                        //soTien.Text = reader.GetValue(1).ToString();
                    }
                }

                con.Close();
            }
            
        }

        private void phieuThuChi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
