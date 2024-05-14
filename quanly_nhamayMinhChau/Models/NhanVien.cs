using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace quanly_nhamayMinhChau.Models
{
    public class NhanVien
    {
        public string maNhanVien {  get; set; }
        public string tenNhanVien { get; set;}
        public string chucVu {  get; set; }
        public string SDT { get; set; }
        public string email {  get; set; }
        public string password {  get; set; }
        public string queQuan {  get; set; }
        public DateTime ngaySinh { get; set; }
        public DateTime ngayLam { get; set; }
        public int luong {  get; set; }    

    }
}
