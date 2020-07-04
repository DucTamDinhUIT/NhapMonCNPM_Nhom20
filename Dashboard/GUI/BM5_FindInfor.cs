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

namespace QuanLyCLBVoThuat
{
    public partial class BM5_FindInfor : Form
    {

        BindingSource vosinhList = new BindingSource();

        public BM5_FindInfor()
        {
            InitializeComponent();
        }

        private void TimKiem(object sender, EventArgs e)
        {
            string hoTen = textBox1.Text;
            string capBac = comboBox1.Text;
                LoadTimKiem();
        }

        private void LoadTimKiem()
        {
            vosinhList.DataSource = AccountDAO.Instance.TimKiem();
        }

        DataTable TimKiem(string hoTen, string capBac)
        {
            return VoSinhDAO.Instance.TimKiem(hoTen, capBac);
        }
    }
}
