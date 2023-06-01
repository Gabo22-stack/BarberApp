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
    public class CN_Usuario
    {
        private CD_Usuario Usuario = new CD_Usuario();
        public DataTable VisualizarPerfil()
        {
            DataTable TablaUsuario = new DataTable();
            TablaUsuario = Usuario.VisualizarPerfil();
            return TablaUsuario;
        }
        public void InsertarUsuario(CE_Usuario User)
        {
            Usuario.InsertarUsuario(User);
        }
        public void EditarUsuario(CE_Usuario User)
        {
            Usuario.EditarUsuario(User);
        }
        public void EliminarUsuario(CE_Usuario User)
        {
            Usuario.EliminarUsuario(User);
        }
    }
}
