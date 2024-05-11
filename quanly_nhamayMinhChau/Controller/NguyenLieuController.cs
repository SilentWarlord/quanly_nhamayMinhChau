using quanly_nhamayMinhChau.Models;
using quanly_nhamayMinhChau.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_nhamayMinhChau.Controller
{
    internal class NguyenLieuController
    {
        NguyenLieuService service = new NguyenLieuService();

        public List<NguyenLieu> GetAll()
        {
            return service.GetAll();
        }
        public void Add(string maNL, string tenNL, string DVD, int giaThanh, DateTime ngayNhap)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            nguyenLieu.maNL = maNL;
            nguyenLieu.tenNL = tenNL;
            nguyenLieu.DVD = DVD;
            nguyenLieu.giaThanh = giaThanh;
            nguyenLieu.ngayNhap = ngayNhap;

            service.Add(nguyenLieu);
        }
        public void Update(string maNL, string tenNL, string DVD, int giaThanh, DateTime ngayNhap)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            nguyenLieu.maNL = maNL;
            nguyenLieu.tenNL = tenNL;
            nguyenLieu.DVD = DVD;
            nguyenLieu.giaThanh = giaThanh;
            nguyenLieu.ngayNhap = ngayNhap;

            service.Update(nguyenLieu);
        }

        public void Delete(string maNL)
        {
            service.Delete(maNL);
        }
    }
}
