using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Historial
    {
        private CD_Historial ocd_historial = new CD_Historial();
        public DataTable VisualizarCita()
        {
            DataTable TablaCita = new DataTable();
            TablaCita = ocd_historial.HistorialCitas();
            return TablaCita;
        }
        public DataTable VisualizarCitaPorFecha(DateTime fecha)
        {
            DataTable tablaCitasPorFecha = new DataTable();
            tablaCitasPorFecha = ocd_historial.HistorialCitasPorFecha(fecha);
            return tablaCitasPorFecha;
        }
    }
}
