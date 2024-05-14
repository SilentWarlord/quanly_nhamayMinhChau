using quanly_nhamayMinhChau.Models;
using quanly_nhamayMinhChau.Service;
using quanly_nhamayMinhChau.usercontrol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace quanly_nhamayMinhChau.Controller
{
    internal class NhanVienController
    {
        NhanVienService service = new NhanVienService();
        public List<NhanVien> GetAll()
        {
            return service.GetAll();
        }
        public void Add(string maNhanVien,string tenNhanVien,string chucVu,string SDT,string email,string password,string queQuan,DateTime ngaySinh,DateTime ngayLam,int luong)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.maNhanVien = maNhanVien;
            nhanVien.tenNhanVien = tenNhanVien;
            nhanVien.chucVu = chucVu;
            nhanVien.SDT = SDT;
            nhanVien.email = email;
            nhanVien.password = password;
            nhanVien.queQuan = queQuan;
            nhanVien.ngaySinh = ngaySinh;
            nhanVien.ngayLam = ngayLam;
            nhanVien.luong = luong;

            service.Add(nhanVien);
            string subject = "Tao tai khoan thanh cong";
            string body = "Mat khau cua ban la: " + password;
            service.SendEmail(email, subject, body);
            
        }
        public void Update(string maNhanVien, string tenNhanVien, string chucVu, string SDT, string email, string password, string queQuan, DateTime ngaySinh, DateTime ngayLam, int luong)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.maNhanVien = maNhanVien;
            nhanVien.tenNhanVien = tenNhanVien;
            nhanVien.chucVu = chucVu;
            nhanVien.SDT = SDT;
            nhanVien.email = email;
            nhanVien.password = password;
            nhanVien.queQuan = queQuan;
            nhanVien.ngaySinh = ngaySinh;
            nhanVien.ngayLam = ngayLam;
            nhanVien.luong = luong;

            service.Update(nhanVien);
        }

        public void Delete(string maNhanVien)
        {
            service.Delete(maNhanVien);
        }

        public List<NhanVien> Search(string type,string key) 
        {
            return service.Search(type, key);
        }

        public string GetNextId()
        {
            string lastid = service.GetID();
            string[] separatingStrings = { "NV", "KH", "NL", "SP", "DH" };

            Console.WriteLine(lastid);
            string[] nextNum = lastid.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            int num = int.Parse(nextNum[0]) + 1;
            return "NV00" + num.ToString();
        }
    }
}
