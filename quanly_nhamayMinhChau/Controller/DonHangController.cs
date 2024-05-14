using quanly_nhamayMinhChau.Models;
using quanly_nhamayMinhChau.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_nhamayMinhChau.Controller
{
    internal class DonHangController
    {
        DonHangService service = new DonHangService();

        public List<DonHang> GetAll()
        {
            return service.GetAll();
        }
        public void Add(string maDonHang, string maKhachHang, string maSanPham, string moTa, int thanhTien)
        {
            DonHang donHang = new DonHang();
            donHang.maDonHang = maDonHang;
            donHang.maKhachHang = maKhachHang;
            donHang.maSanPham = maSanPham;
            donHang.moTa = moTa;
            donHang.thanhTien = thanhTien;

            service.Add(donHang);
        }
        public void Update(string maDonHang, string maKhachHang, string maSanPham, string moTa, int thanhTien)
        {
            DonHang donHang = new DonHang();
            donHang.maDonHang = maDonHang;
            donHang.maKhachHang = maKhachHang;
            donHang.maSanPham = maSanPham;
            donHang.moTa = moTa;
            donHang.thanhTien = thanhTien;

            service.Update(donHang);
        }

        public void Delete(string maDonHang)
        {
            service.Delete(maDonHang);
        }

        public string GetNextId()
        {
            string lastid = service.GetID();
            string[] separatingStrings = { "NV", "KH", "NL", "SP", "DH" };

            Console.WriteLine(lastid);
            string[] nextNum = lastid.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            int num = int.Parse(nextNum[0]) + 1;
            return "DH00" + num.ToString();
        }
    }
}
