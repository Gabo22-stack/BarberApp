
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Login
    {
        // ANGEL\SQLEXP
        //
        //
        // RESS
        CN_Encrypt Encrypt = new CN_Encrypt();
        private CD_UserData datosUsuario = new CD_UserData();

        public bool LOGINUSER(string Phone, string Password)
        {
            return datosUsuario.LogIn(Phone,Encrypt.HashPassword(Password));
        }
        public bool LOGINBARBER(string BarberUser, string Password)
        {
            return datosUsuario.LogInBarber(BarberUser,Encrypt.HashPassword(Password));
        }
    }

}