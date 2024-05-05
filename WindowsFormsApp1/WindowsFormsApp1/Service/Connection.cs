using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Service
{
    internal class Connection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Server=; Database=; Integrated Security = True; ";
            return new SqlConnection();
        }


    }
}
