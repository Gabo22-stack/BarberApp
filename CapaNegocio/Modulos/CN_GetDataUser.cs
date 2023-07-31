using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_GetDataUser
    {
        public static void ProcessData(string userInput)
        {
            DataTable tabla = CD_GetDataUser.GetData(userInput);

            if (tabla.Rows.Count > 0)
            {
                CE_Global.Name = tabla.Rows[0][1].ToString();
                CE_Global.Phone = tabla.Rows[0][0].ToString();
                CE_Global.Email = tabla.Rows[0][2].ToString();
                CE_Global.Password = tabla.Rows[0][3].ToString();
            }
            else
            {
                // Manejar el caso en el que no se encuentren datos
            }
        }
    }
}
