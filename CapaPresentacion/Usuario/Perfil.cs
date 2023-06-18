using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }
        #region metodos

        private void CargarForm(Form NuevoFormulario)
        {
            this.PanelVista.Controls.Clear();
            NuevoFormulario.TopLevel = false;
            NuevoFormulario.Dock = DockStyle.Fill;
            this.PanelVista.Controls.Add(NuevoFormulario);
            NuevoFormulario.Show();
        }

        #endregion

        private void Perfil_Load(object sender, EventArgs e)
        {
            CargarForm(new PerfilMuestra());
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Principal newform = new Principal();
            newform.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CargarForm(new EditPerfil());
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            IniciarSesion newform = new IniciarSesion();
            newform.Show();
            this.Hide();
        }
    }
}
