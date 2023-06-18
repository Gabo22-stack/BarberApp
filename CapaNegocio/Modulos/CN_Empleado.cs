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
    public  class CN_Empleado
    {
        private CD_Empleado OEmpleado = new CD_Empleado();
        public DataTable VisualizarEmpleado()
        {
            DataTable TablaEmpleado = new DataTable();
            TablaEmpleado = OEmpleado.VisualizarEmpleado();
            return TablaEmpleado;
        }
        public void InsertarUsuario(CE_Empleado Empleado)
        {
            OEmpleado.CrearEmpleado(Empleado);
        }
        public void EditarUsuario(CE_Empleado Empleado)
        {
            OEmpleado.EditarEmpleado(Empleado);
        }
        public void EliminarUsuario(CE_Empleado Empleado)
        {
            OEmpleado.EliminarEmpleado(Empleado);
        }
    }
}

