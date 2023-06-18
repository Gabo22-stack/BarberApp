using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modulos
{
    public class CD_Barberia
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand cmd = new SqlCommand();
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
    }
}
