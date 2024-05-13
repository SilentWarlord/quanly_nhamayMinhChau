using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_nhamayMinhChau.Service
{
    internal class Connection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Server=CAUBEKINH8\\SQLEXPRESS; Database=QLNMMC; Integrated Security = True; ";
            return new SqlConnection();
        }


    }
}
