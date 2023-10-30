using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace forms_bán_cá
{
    internal class connection
    {
        private static String Stringconnection = @"Data Source=DESKTOP-Q4PGA0S;Initial Catalog=""lưu thông tin"";Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(Stringconnection);
        }
    }
}
