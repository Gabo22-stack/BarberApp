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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }
        CN_Encrypt encrypt = new CN_Encrypt();
        CN_Usuario ocn_usuario = new CN_Usuario();
        CE_Usuario oce_usuario = new CE_Usuario();

        #region metodos
        private void Volver()
        {
            IniciarSesion newform = new IniciarSesion();
            newform.Show();
            this.Hide();
        }
        public Boolean ValidPass()
        {
            string PassReg = txtContraseña.Text, PassRegConf = txtConfContra.Text;
            if (PassReg == PassRegConf)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Las Contraseñas No coinciden.");
                return false;
            }
        }
        public void Confirm()
        {
            if (txtNombre.Text == "" || txtTelefono.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Introduzca los datos en los campos");
            }
            else
            {
                oce_usuario.Name = txtNombre.Text;
                oce_usuario.Phone = txtTelefono.Text;
                oce_usuario.Password = encrypt.HashPassword(txtContraseña.Text);
                oce_usuario.Email = "";
                oce_usuario.VerificationCode = "";
                oce_usuario.State = 1;

                ocn_usuario.InsertarUsuario(oce_usuario);
                MessageBox.Show("Se registro correctamente.");
                IniciarSesion step = new IniciarSesion();
                step.Show();
                this.Hide();
            }
        }


        #endregion

        private void pbxBack_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidPass() == true)
            {
                Confirm();
            }
        }
    }
}
