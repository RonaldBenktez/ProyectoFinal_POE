using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer.DbConnection
{
    public class SqlConnect : ISqlConnect
    {
        private readonly string _connectionString;
        public SqlConnect()
        {
            _connectionString = "Data Source=DESKTOP-DHSOO9J;Initial Catalog=AcademicAdministrator;Integrated Security=True;Encrypt=False";
        }
        public SqlConnection GetConnection()
        {
           return new SqlConnection(_connectionString);
        }
    }
}
