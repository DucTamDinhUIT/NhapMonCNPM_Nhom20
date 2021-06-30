using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using QuanLyCLBVoThuat.DTO;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyCLBVoThuat.DAO
{
    public class VoSinhDAO
    {
        private static VoSinhDAO instance;

        public static VoSinhDAO Instance
        {
            get { if (instance == null) instance = new VoSinhDAO(); return instance; }
            private set { instance = value; }
        }

        public bool InsertInfo(string stt, string tenvosinh, string truong, string sinhnhat, string capbac, string ngaythamgia)
        {
            //string query = "INSERT INTO dbo.Information ( STT , TenVoSinh , Truong ) VALUES  ( N'{0}' , {1} , {2})" , stt , tenvosinh , truong )";
            string query = "INSERT INTO dbo.VoSinh (STT, TenVoSinh, Truong, SinhNhat, CapBac, NgayThamGia)  VALUES(' " + stt + " ', ' " + tenvosinh + " ', '  " + truong + " ', '" + sinhnhat + "', '" + capbac + "', '" + ngaythamgia + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool InsertPrice(string stt_old, string maphieuthu, string sotiendong, string ngaythu, string ghichu)
        {
            //string query = "INSERT INTO dbo.Information ( STT , TenVoSinh , Truong ) VALUES  ( N'{0}' , {1} , {2})" , stt , tenvosinh , truong )";
            string query = "INSERT dbo.PhieuThu ( STT , MaPhieuThu , SoTienNop , NgayThu , GhiChu )  VALUES('" + stt_old + "',' " + maphieuthu + " ', ' " + sotiendong + " ', '  " + ngaythu + " ', '" + ghichu + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ExportPrice(string maphieuchi, string sotienchi, string ngaychi, string noidung)
        {
            string query = "INSERT dbo.PhieuChi (MaPhieuChi , SoTienChi , NgayChi, NoiDung )  VALUES ('" + maphieuchi + "',' " + sotienchi + " ', ' " + ngaychi + " ', '  " + noidung + " ')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateInfo(string stt, string tenvosinh, string truong, string sinhnhat, string capbac, string ngaythamgia)
        {
            //string query = string.Format("UPDATE dbo.Information SET TenVoSinh = N'{0}', Truong = {1}, WHERE STT = {3}", stt, tenvosinh, truong);
            string query = "UPDATE dbo.VoSinh SET TenVoSinh = ' " + tenvosinh + " ', Truong = '  " + truong + " ', SinhNhat = '" + sinhnhat + "', CapBac = '" + capbac + "', NgayThamGia = '" + ngaythamgia + "' WHERE STT = '" + stt + "' ";
            //string query = "UPDATE dbo.VoSinh SET TenVoSinh = '@a1', Truong = '@a2', SinhNhat '@a3', CapBac = '@a4', NgayThamGia = '@' WHERE STT = '@' ";
            //string query = "INSERT dbo.DiemThi (MaDiemThi, STT, DiemThi, KetQua, CapBacKeTiep, NgayKiemTra, NguoiKiemTra, GhiChu) VALUES ('2', '2','10','Dat', 'Black', '26 March, 2020', 'Admin', 'no')";

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateInfo(string stt, string diemthi, string ketqua, string caphientai, string capketiep, string ngaykiemtra, string nguoikiemtra,string ghichu)
        {
            //string query = string.Format("UPDATE dbo.Information SET TenVoSinh = N'{0}', Truong = {1}, WHERE STT = {3}", stt, tenvosinh, truong);
            //string query = "UPDATE dbo.VoSinh SET TenVoSinh = ' " + tenvosinh + " ', Truong = '  " + truong + " ', SinhNhat = '" + sinhnhat + "', CapBac = '" + capbac + "', NgayThamGia = '" + ngaythamgia + "' WHERE STT = '" + stt + "' ";
            //string query = "UPDATE dbo.VoSinh SET TenVoSinh = '@a1', Truong = '@a2', SinhNhat '@a3', CapBac = '@a4', NgayThamGia = '@' WHERE STT = '@' ";
            string query = "INSERT dbo.DiemThi (MaDiemThi, STT, DiemThi, KetQua, CapBacKeTiep, NgayKiemTra, NguoiKiemTra, GhiChu) VALUES ('2', '2','10','Dat', 'Black', '26 March, 2020', 'Admin', 'no')";

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateMatch(string stt, string diemthi, string ketqua, string caphientai, string capketiep, string ngaykiemtra, string nguoikiemtra, string ghichu)
        {
            //string query = string.Format("UPDATE dbo.Information SET TenVoSinh = N'{0}', Truong = {1}, WHERE STT = {3}", stt, tenvosinh, truong);
            string query = "UPDATE dbo.DiemThi SET MaDiemThi = '"+stt+ "', DiemThi = '" + diemthi + "', KetQua = '" + ketqua + "', CapBacKeTiep = '" + capketiep + "', NgayKiemTra = '" + ngaykiemtra + "', NguoiKiemTra = '" + nguoikiemtra + "', GhiChu = '"+ghichu+"' WHERE STT = '"+stt+"'";
            //string query = "UPDATE dbo.VoSinh SET TenVoSinh = '@a1', Truong = '@a2', SinhNhat '@a3', CapBac = '@a4', NgayThamGia = '@' WHERE STT = '@' ";

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
                public bool InsertMatch(string madiemthi, string stt, string diemthi, string ketqua, string caphientai, string capketiep, string ngaykiemtra, string nguoikiemtra, string ghichu)
        {
            //string query = "UPDATE dbo.DiemThi SET MaDiemThi = '" + stt + "', DiemThi = '" + diemthi + "', KetQua = '" + ketqua + "', CapBacKeTiep = '" + capketiep + "', NgayKiemTra = '" + ngaykiemtra + "', NguoiKiemTra = '" + nguoikiemtra + "', GhiChu = '" + ghichu + "' WHERE STT = '" + stt + "'";
            string query = "INSERT dbo.DiemThi (MaDiemThi, STT, DiemThi, KetQua, CapBacHienTai, CapBacKeTiep, NgayKiemTra, NguoiKiemTra, GhiChu) VALUES ('" + madiemthi + "','" + stt + "', '" + diemthi + "','" + ketqua + "','" + caphientai + "', '" + capketiep + "', '" + ngaykiemtra + "', '" + nguoikiemtra + "', '" + ghichu + "') ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteInfo(string stt)
        {
            string query = "DELETE dbo.PhieuThu WHERE STT = '" + stt + "' ";
            string query2 = "DELETE dbo.VoSinh WHERE STT = '" + stt + "' ";

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            int result2 = DataProvider.Instance.ExecuteNonQuery(query2);

            return result > 0;
        }

        public DataTable TimKiem(string hoTen, string capBac)
        {
            string query = string.Format("SELECT * dbo.Information");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        /*
        public bool DeleteInfo(int idInfo)
        {
            BillInfoDAO.Instance.DeleteBillInfoByInfoID(idInfo);

            string query = string.Format("Delete Info where id = {0}", idInfo);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        
        public List<VoSinh> GetListVoSinh()
        {
            List<VoSinh> list = new List<VoSinh>();

            string query = "select * from VoSinh";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                VoSinh food = new VoSinh(item);
                list.Add(food);
            }

            return list;
        }
        
        public List<VoSinh> SearchVoSinhByName(string name)
        {

            List<VoSinh> list = new List<VoSinh>();

            string query = string.Format("SELECT * FROM dbo.VoSinh WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                VoSinh food = new VoSinh(item);
                list.Add(food);
            }

            return list;
        }
        */
    }
}
