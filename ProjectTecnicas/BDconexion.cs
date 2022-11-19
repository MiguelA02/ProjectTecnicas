using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTecnicas
{
    public class BDconexion
    {
        public static SqlConnection obtenerConexion() 
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProjectTecnicas;Data Source=MIGUELA02");
            conexion.Open();
            return conexion;
        }
    }
}
