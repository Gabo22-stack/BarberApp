using CapaDatos.Data;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Modulos
{
    public class CN_GetDataBarber
    {
        public static void ProcessData(string userInput)
        {
            DataTable tabla = CD_GetDataBarber.GetData(userInput);

            if (tabla.Rows.Count > 0)
            {
                CE_Global.NameBarber = tabla.Rows[0][3].ToString();
                CE_Global.PhoneBarber = tabla.Rows[0][6].ToString();
                CE_Global.EmailBarber = tabla.Rows[0][7].ToString();
                CE_Global.Address = tabla.Rows[0][5].ToString();
                CE_Global.Nit = tabla.Rows[0][4].ToString();
            }
            else
            {
                // Manejar el caso en el que no se encuentren datos
            }
        }
    }
}
