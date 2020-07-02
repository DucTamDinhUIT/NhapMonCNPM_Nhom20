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

namespace QuanLyCLBVoThuat
{
    public partial class BM1 : Form
    {
        public BM1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
            //string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QuanLyCLB;Integrated Security=True";


            SqlConnection con = new SqlConnection(@"Data Source =.\\sqlexpress; Initial Catalog = QuanLyCLB; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@STT", textBox6.Text);
            cmd.Parameters.AddWithValue("@TenVoSinh", textBox1.Text);
            cmd.Parameters.AddWithValue("@Truong", textBox2.Text);
            cmd.Parameters.AddWithValue("@SinhNhat", textBox3.Text);
            cmd.Parameters.AddWithValue("@CapBac", comboBox1.Text);
            cmd.Parameters.AddWithValue("@NgayThamGia", textBox4.Text);


            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }
        }
    }
}
