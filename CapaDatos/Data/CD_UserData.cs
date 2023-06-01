using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_UserData
    {
        public bool LogIn(string Phone, string Password)
        {
            try
            {
                string query = "SELECT Phone, Password FROM AppUser WHERE Phone=@Phone AND Password=@Password";
                using (SqlConnection conexion = new SqlConnection("Server=(Local); Database=Barberia; Integrated Security=true"))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        SqlDataReader dr = cmd.ExecuteReader();
                        return dr.Read();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool LogInBarber(string BarberUser, string Password)
        {
            try
            {
                string query = "SELECT BarberUser, Password FROM Barber WHERE BarberUser=@BarberUser AND Password=@Password";
                using (SqlConnection conexion = new SqlConnection("Server=(Local); Database=Barberia; Integrated Security=true"))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@BarberUser", BarberUser);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        SqlDataReader dr = cmd.ExecuteReader();

                        return dr.Read();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
