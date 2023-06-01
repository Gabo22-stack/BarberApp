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
    public class CN_Cita
    {
        private CD_Cita ObjetoCita = new CD_Cita();
        public DataTable VisualizarCita()
        {
            DataTable TablaCita = new DataTable();
            TablaCita = ObjetoCita.VisualizarCita();
            return TablaCita;
        }
        public void CrearCita(CE_Cita Cita)
        {
            ObjetoCita.CrearCita(Cita);
        }
        public void EditarUsuario(CE_Cita Cita)
        {
            ObjetoCita.EditarCita(Cita);
        }
        public void EliminarUsuario(CE_Cita Cita)
    {
            ObjetoCita.EliminarCita(Cita);
        }
    }
}

