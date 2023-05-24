using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace COMPILADORCS
{
    class Conexion
    {

        public static DataTable query(string query)
        {
            SqlConnection con;
            string server = "localhost\\SQLEXPRESS", db = "Compiladores";
            con = new SqlConnection("Server=" + server + ";Database=" + db + ";Trusted_Connection=True;");

            DataTable resultados = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader read = cmd.ExecuteReader();
            resultados.Load(read);
            read.Close();
            cmd.Dispose();
            con.Close();
            return resultados;
        }
    }
}
