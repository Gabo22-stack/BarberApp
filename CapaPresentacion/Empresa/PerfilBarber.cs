using CapaEntidades;
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
    public partial class PerfilBarber : Form
    {
        public PerfilBarber()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            PrincipalEmpresa FormBarber = new PrincipalEmpresa();
            FormBarber.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            IniciarSesion FrmSesion= new IniciarSesion();
            FrmSesion.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarPefilEmpresa FrmEditar = new EditarPefilEmpresa();
            FrmEditar.Show();
            this.Hide();
        }
        private void PerfilBarber_Load_1(object sender, EventArgs e)
        {
            lblNombre.Text = CE_Global.NameBarber;
            lblTelefono.Text = CE_Global.PhoneBarber;
            lblCorreo.Text = CE_Global.EmailBarber;
            lblDireccion.Text = CE_Global.Address;
        }
    }
}
