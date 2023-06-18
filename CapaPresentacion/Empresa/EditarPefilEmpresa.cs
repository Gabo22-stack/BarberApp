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
    public partial class EditarPefilEmpresa : Form
    {
        public EditarPefilEmpresa()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            PerfilBarber FrmPerfil = new PerfilBarber();
            FrmPerfil.Show();
            this.Hide();
        }
        private void EditarPefilEmpresa_Load_1(object sender, EventArgs e)
        {
            txtNombre.Text = CE_Global.NameBarber;
            txtNombreAdmin.Text = CE_Global.EmailBarber;
            txtTelefono.Text = CE_Global.PhoneBarber;
            txtDireccion.Text = CE_Global.Address;
        }
    }
}
