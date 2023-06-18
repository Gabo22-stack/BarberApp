using CapaEntidades;
using CapaNegocio;
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
    public partial class EditPasswordUser : Form
    {
        CN_Encrypt ocn_encrypt = new CN_Encrypt();
        CN_Usuario ocn_usuario = new CN_Usuario();
        CE_Usuario oce_usuario = new CE_Usuario();
        public EditPasswordUser()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EditPasswordUser_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "" || txtNewPass.Text == "")
            {
                MessageBox.Show("Algunos campos se encuentran vacios");
            }
            else
            {
                oce_usuario.Name = CE_Global.Name;
                oce_usuario.Email = CE_Global.Email;
                oce_usuario.Phone = CE_Global.Phone;
                oce_usuario.VerificationCode = "";
                oce_usuario.Password = ocn_encrypt.HashPassword(txtNewPass.Text);
                oce_usuario.State = 1;
                ocn_usuario.EditarUsuario(oce_usuario);
                MessageBox.Show("Se cambio la contraseña correctamente.\nIngrese sesion Nuevamente.");
            }
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            if (ocn_encrypt.HashPassword(txtOldPass.Text) == CE_Global.Password)
            {
                btnGuardar.Enabled = true;
            }
            else
            { btnGuardar.Enabled = false; }
        }
    }
}
