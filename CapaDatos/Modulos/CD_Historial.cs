using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Historial
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader Leer;
        DataTable TablaUsuario = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public DataTable HistorialCitas()
        {
            TablaUsuario.Clear();
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "Sp_ViewAppointments";
            cmd.CommandType = CommandType.StoredProcedure;
            Leer = cmd.ExecuteReader();
            TablaUsuario.Load(Leer);
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
            return TablaUsuario;
        }
    }
}
