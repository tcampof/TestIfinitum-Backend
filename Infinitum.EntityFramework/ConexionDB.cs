using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinitum.Data
{
    public class ConexionDB
    {
        private SqlConnection con;
        public string ConnectionString = "Server=TOMAS-CAMPO;Database=db_Infinitum;Trusted_Connection=True;";
        public IDbConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public ConexionDB()
        {

        }
    }
}
