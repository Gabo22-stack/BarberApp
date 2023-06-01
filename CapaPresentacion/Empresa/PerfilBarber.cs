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
    }
}
