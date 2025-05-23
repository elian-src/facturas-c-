using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
    public class Connec
    {
        private readonly string connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_FacturacionPruebas;Trusted_Connection=True;";
        public SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
