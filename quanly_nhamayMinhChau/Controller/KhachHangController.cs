using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using quanly_nhamayMinhChau.Models;
using quanly_nhamayMinhChau.Service;

namespace quanly_nhamayMinhChau.Controller
{
    internal class KhachHangController
    {
        KhachHangService service = new KhachHangService();
        public List<KhachHang> GetAll()
        {
            return service.GetAll();
        }

        public void Add(string maKhachHang,string tenKhachHang,string SDT,string diaChi,DateTime ngaySinh)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.maKhachHang = maKhachHang;
            khachHang.tenKhachHang = tenKhachHang;
            khachHang.SDT = SDT;
            khachHang.diaChi = diaChi;
            khachHang.ngaySinh = ngaySinh;

            service.Add(khachHang);
        }

        public void Update(string maKhachHang, string tenKhachHang, string SDT, string diaChi, DateTime ngaySinh)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.maKhachHang = maKhachHang;
            khachHang.tenKhachHang = tenKhachHang;
            khachHang.SDT = SDT;
            khachHang.diaChi = diaChi;
            khachHang.ngaySinh = ngaySinh;

            service.Update(khachHang);
        }
        public List<KhachHang> Search(string type, string key)
        {
            return service.Search(type, key);
        }
        public void Delete(string maKhachHang)
        {
            service.Delete(maKhachHang);
        }
    }
}
