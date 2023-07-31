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

        public DataTable HistorialCitas()
        {
            DataTable TablaCita = new DataTable();
            using (SqlCommand cmd = new SqlCommand(
                "SELECT a.AppointmentID, a.Date, b.Name AS Barber, s.Name AS State, a.Price, a.Time, ser.ServiceType AS Service, CONCAT(e.FirstName, ' ', e.LastName) AS Employee " +
                "FROM Appointment AS a " +
                "INNER JOIN Barber AS b ON a.Barber = b.BarberID " +
                "INNER JOIN State AS s ON a.State = s.StateID " +
                "INNER JOIN Service AS ser ON a.Service = ser.ServiceID " +
                "INNER JOIN Employee AS e ON a.Employee = e.EmployeeID",
                conexion.AbrirConexion()))
            {
                using (SqlDataReader Leer = cmd.ExecuteReader())
                {
                    TablaCita.Load(Leer);
                }
            }
            return TablaCita;
        }
        public DataTable HistorialCitasPorFecha(DateTime fecha)
        {
            DataTable tablaCitasPorFecha = new DataTable();
            SqlCommand cmd = new SqlCommand("Sp_ViewAppointmentByDate", conexion.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            // Agregar el parámetro de fecha a la consulta
            cmd.Parameters.AddWithValue("@Fecha", fecha);

            SqlDataReader leer = cmd.ExecuteReader();
            tablaCitasPorFecha.Load(leer);
            conexion.CerrarConexion();
            return tablaCitasPorFecha;
        }
    }
}
