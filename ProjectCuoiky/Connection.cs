using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectCuoiky
{
    internal class Connection
    {
        private static string connectionstring =
@"Data Source=DESKTOP-CO09DFI\MSSQLSERVER01;Initial Catalog=Final;Integrated Security=True;TrustServerCertificate=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionstring);
        }
    }
}
