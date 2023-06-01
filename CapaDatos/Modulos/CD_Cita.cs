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
    public class CD_Cita
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader Leer;
        DataTable TablaCita = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public DataTable VisualizarCita()
        {
            TablaCita.Clear();
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "Sp_ViewAppointments";
            cmd.CommandType = CommandType.StoredProcedure;
            Leer = cmd.ExecuteReader();
            TablaCita.Load(Leer);
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
            return TablaCita;
        }
        public void CrearCita(CE_Cita Cita)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "Sp_CreateAppointment";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Date", Cita.Date);
            cmd.Parameters.AddWithValue("@Time", Cita.Time);
            cmd.Parameters.AddWithValue("@Comment", Cita.Comment);
            cmd.Parameters.AddWithValue("@Rating", Cita.Rating);
            cmd.Parameters.AddWithValue("@Price", Cita.Price);
            cmd.Parameters.AddWithValue("@StateID", Cita.State);
            cmd.Parameters.AddWithValue("@EmployeeID", Cita.Employee);
            cmd.Parameters.AddWithValue("@UserID", Cita.User);
            cmd.Parameters.AddWithValue("@ServiceID", Cita.Service);
            cmd.Parameters.AddWithValue("@BarberID", Cita.Barber);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EditarCita(CE_Cita Cita)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "Sp_EditAppointment";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AppointmentID", Cita.AppointmentID);
            cmd.Parameters.AddWithValue("@Date", Cita.Date);
            cmd.Parameters.AddWithValue("@Time", Cita.Time);
            cmd.Parameters.AddWithValue("@Comment", Cita.Comment);
            cmd.Parameters.AddWithValue("@Rating", Cita.Rating);
            cmd.Parameters.AddWithValue("@Price", Cita.Price);
            cmd.Parameters.AddWithValue("@StateID", Cita.State);
            cmd.Parameters.AddWithValue("@EmployeeID", Cita.Employee);
            cmd.Parameters.AddWithValue("@UserID", Cita.User);
            cmd.Parameters.AddWithValue("@ServiceID", Cita.Service);
            cmd.Parameters.AddWithValue("@BarberID", Cita.Barber);
            cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarCita(CE_Cita Cita)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "Sp_DeleteAppointment";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AppointmentID", Cita.AppointmentID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
