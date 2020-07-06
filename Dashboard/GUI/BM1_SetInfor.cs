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
    public partial class BM1_SetInfor : Form
    {
        public BM1_SetInfor()
        {
            InitializeComponent();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = GetData();
            
                string stt = textBox6.Text;
                string tenvosinh = textBox2.Text;
                string truong = textBox3.Text;
            if (VoSinhDAO.Instance.InsertInfo(stt, tenvosinh, truong))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
            

        } 
            private DataTable GetData()
            {
                DataTable dataTable = new DataTable();
                string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.VoSinh", con))
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dataTable.Load(reader);
                    };
                }
                return dataTable;
            }
        
    }
}
