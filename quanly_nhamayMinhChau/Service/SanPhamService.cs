using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanly_nhamayMinhChau.Models;

namespace quanly_nhamayMinhChau.Service
{
    internal class SanPhamService
    {
        SqlConnection conn;

        public void Add(SanPham sanPham)
        {
            using (conn = Connection.GetConnection()) { }
        }
        public void Update()
        {
            using (conn = Connection.GetConnection()) { }
        }
        public void Delete()
        {
            using (conn = Connection.GetConnection()) { }
        }
        public void Search()
        {
            using (conn = Connection.GetConnection()) { }
        }
    }
}
