using QuanLyCLBVoThuat.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLBVoThuat.DTO
{
    public class VoSinh
    {
        public VoSinh(string stt, string tenvosinh, string truong)
        {
            this.Stt = stt;
            this.TenVoSinh = tenvosinh;
            this.Truong = truong;

        }
        /*
        public VoSinh(DataRow row)
        {
            //STT,TenVoSinh,Truong,SinhNhat,CapBac,NgayThamGia
            this.Stt = (int)row["STT"];
            this.stt = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CategoryID = (int)row["idcategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
        */
        DataTable TimKiem(string hoTen, string capBac)
        {
            return VoSinhDAO.Instance.TimKiem(hoTen, capBac);
        }
        private string truong;

        public string Truong
        {
            get { return truong; }
            set { truong = value; }
        }

        private string tenvosinh;

        public string TenVoSinh
        {
            get { return tenvosinh; }
            set { tenvosinh = value; }
        }

        public string Stt { get; set; }
    }
}
