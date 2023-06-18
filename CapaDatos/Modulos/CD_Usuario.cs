using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Usuario
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader Leer;
        DataTable TablaUsuario = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public DataTable VisualizarPerfil()
        {
            TablaUsuario.Clear();
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "Sp_ViewUserProfiles";
            cmd.CommandType = CommandType.StoredProcedure;
            Leer = cmd.ExecuteReader();
            TablaUsuario.Load(Leer);
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
            return TablaUsuario;
        }
        public void InsertarUsuario(CE_Usuario User)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "Sp_CreateUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Phone", User.Phone);
            cmd.Parameters.AddWithValue("@Name", User.Name);
            cmd.Parameters.AddWithValue("@Email", User.Email);
            cmd.Parameters.AddWithValue("@Password", User.Password);
            cmd.Parameters.AddWithValue("@VerificationCode", User.VerificationCode);
            cmd.Parameters.AddWithValue("@State", User.State);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EditarUsuario(CE_Usuario User)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "Sp_EditUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Phone", User.Phone);
            cmd.Parameters.AddWithValue("@Name", User.Name);
            cmd.Parameters.AddWithValue("@Email", User.Email);
            cmd.Parameters.AddWithValue("@Password", User.Password);
            cmd.Parameters.AddWithValue("@VerificationCode", User.VerificationCode);
            cmd.Parameters.AddWithValue("@State", User.State);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarUsuario(CE_Usuario User)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "Sp_DeleteUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Phone", User.Phone);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
