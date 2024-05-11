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
        public void Add(string maDonHang, string maKhachHang, string maSanPham, string moTa, string trangThai)
        {
            DonHang donHang = new DonHang();
            donHang.maDonHang = maDonHang;
            donHang.maKhachHang = maKhachHang;
            donHang.maSanPham = maSanPham;
            donHang.moTa = moTa;
            donHang.trangThai = trangThai;

            service.Add(donHang);
        }
        public void Update(string maDonHang, string maKhachHang, string maSanPham, string moTa, string trangThai)
        {
            DonHang donHang = new DonHang();
            donHang.maDonHang = maDonHang;
            donHang.maKhachHang = maKhachHang;
            donHang.maSanPham = maSanPham;
            donHang.moTa = moTa;
            donHang.trangThai = trangThai;

            service.Update(donHang);
        }

        public void Delete(string maDonHang)
        {
            service.Delete(maDonHang);
        }
    }
}
