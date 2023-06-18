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
    public class CD_Empleado
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader Leer;
        DataTable TablaUsuario = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public DataTable VisualizarEmpleado()
        {
            TablaUsuario.Clear();
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "Sp_ViewEmployees";
            cmd.CommandType = CommandType.StoredProcedure;
            Leer = cmd.ExecuteReader();
            TablaUsuario.Load(Leer);
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
            return TablaUsuario;
        }
        public void CrearEmpleado(CE_Empleado Empleado)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "SP_CrearEmpleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", Empleado.FirstName);
            cmd.Parameters.AddWithValue("@LastName", Empleado.LastName);
            cmd.Parameters.AddWithValue("@Phone", Empleado.Phone);
            cmd.Parameters.AddWithValue("@Description", Empleado.Description);
            cmd.Parameters.AddWithValue("@State", Empleado.State);
            cmd.Parameters.AddWithValue("@Barber", Empleado.Barber);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EditarEmpleado(CE_Empleado Empleado)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "Sp_EditarEmpleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StateID", Empleado.State);
            cmd.Parameters.AddWithValue("@FirstName", Empleado.FirstName);
            cmd.Parameters.AddWithValue("@LastName", Empleado.LastName);
            cmd.Parameters.AddWithValue("@Phone", Empleado.Phone);
            cmd.Parameters.AddWithValue("@Description", Empleado.Description);
            cmd.Parameters.AddWithValue("@State", Empleado.State);
            cmd.Parameters.AddWithValue("@Barber", Empleado.Barber);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarEmpleado(CE_Empleado Empleado)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "Sp_EliminarEmpleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StateID", Empleado.State);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
