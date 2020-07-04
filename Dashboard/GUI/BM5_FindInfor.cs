using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCLBVoThuat.DAO;
using System.Data.SqlClient;

namespace QuanLyCLBVoThuat
{
    public partial class BM5_FindInfor : Form
    {
        public BM5_FindInfor()
        {
            InitializeComponent();
            FindInfor_Load();
        }
        //string connecSTR = "Data Source=.\\sqlexpress;Initial Catalog=QuanLyCLB;Integrated Security=True";

        SqlConnection conn = new SqlConnection(@"Data Source =.\\sqlexpress; Initial Catalog = QuanLyCLB; Integrated Security = True");
       
        void FindInfor_Load()
        {
            string query = "SELECT * FROM dbo.VoSinh ";
            //conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            
            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command); 

            adapter.Fill(data);

            //conn.Close();

            dataGridView1.DataSource = data;

        }
        private void TimKiem(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM dbo.VoSinh ", conn);
            var table = new DataTable();
            dap.Fill(table);
            dataGridView1.DataSource = table;
        }

    }
}
