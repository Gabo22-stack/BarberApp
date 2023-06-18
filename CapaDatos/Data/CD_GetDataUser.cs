using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_GetDataUser
    {
        public static DataTable GetData(string userInput)
        {
            SqlConnection conexion = new SqlConnection("Server=ANGEL\\SQLEXPRESS;Database=Barberia; Integrated Security=true");
            SqlCommand cmd = new SqlCommand($"SELECT * FROM AppUser WHERE Phone='{userInput}'", conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
    }
}
