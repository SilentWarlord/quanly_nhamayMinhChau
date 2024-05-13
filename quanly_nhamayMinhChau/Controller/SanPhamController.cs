using quanly_nhamayMinhChau.Models;
using quanly_nhamayMinhChau.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_nhamayMinhChau.Controller
{
    internal class SanPhamController
    {
        SanPhamService service = new SanPhamService();
        public List<SanPham> GetAll()
        {
            return service.GetAll();
        }

        public void Add(string maSanPham, string tenSanPham)
        {
            SanPham sanPham = new SanPham();
            sanPham.maSanPham = maSanPham;
            sanPham.tenSanPham = tenSanPham;

            service.Add(sanPham);
        }
        public void Update(string maSanPham, string tenSanPham)
        {
            SanPham sanPham = new SanPham();
            sanPham.maSanPham = maSanPham;
            sanPham.tenSanPham = tenSanPham;

            service.Update(sanPham);
        }

        public void Delete(string maSanPham)
        {
            service.Delete(maSanPham);
        }
    }
}
