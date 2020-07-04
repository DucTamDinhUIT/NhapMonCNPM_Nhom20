using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyCLBVoThuat.DTO
{
    public class Information
    {
        public Information(string stt, string tenvosinh, string truong)
        {
            this.STT = stt;
            this.TenVoSinh = tenvosinh;
            this.Truong = truong;

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

        public string STT { get; set; }
    }
}
