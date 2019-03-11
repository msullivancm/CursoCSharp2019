using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaProtheus
{
    public static class Sessao
    {
        public static SqlConnection session = Sessao.GetConnection();

        private static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Database=P12TST;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}
