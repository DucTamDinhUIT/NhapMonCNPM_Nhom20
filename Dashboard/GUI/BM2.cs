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
using QuanLyCLBVoThuat.DAO;
using QuanLyCLBVoThuat.DTO;
using System.Configuration;

namespace QuanLyCLBVoThuat
{
    public partial class BM2 : Form
    {
        public BM2()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            /*
            int stt = stt;
            string tenvosinh = tenVoSinh.Text;
            string truong = truongTh.Text;
            string sinhnhat = sinhNhat.Text;
            string capbac = capBac.Text;
            string ngaythamgia = ngayThamGia.Text;

            if (VoSinhDAO.Instance.InsertPrice(stt, tenvosinh, truong, sinhnhat, capbac, ngaythamgia))
            {
                MessageBox.Show("Thêm thành công");
                SoThuTu_load();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }

            dataShow.DataSource = GetData();
        }

        private DataTable GetData()
        {
            DataTable dataTable = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                //INSERT INTO dbo.VoSinh(STT, TenVoSinh, Truong, SinhNhat, CapBac, NgayThamGia)  VALUES('3', 'Thanh', 'UIT', 'Haiphong', 'trắng', '26/8');
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.VoSinh", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                    con.Close();
                };
            }
            return dataTable;
            */
        }
        
    }

}
