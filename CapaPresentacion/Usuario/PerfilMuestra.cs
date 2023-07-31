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
    public partial class PerfilMuestra : Form
    {
        public PerfilMuestra()
        {
            InitializeComponent();
            txtName.Text = CE_Global.Name;
            txtPhone.Text = CE_Global.Phone;
            txtEmail.Text = CE_Global.Email;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Principal newform = new Principal();
            newform.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditPerfil newform = new EditPerfil();
            newform.Show();
            this.Hide();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            IniciarSesion newform = new IniciarSesion();
            newform.Show();
            this.Hide();
        }
    }
}
