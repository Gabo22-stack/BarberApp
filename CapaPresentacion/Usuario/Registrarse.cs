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
        private bool ValidPass()
        {
            string PassReg = txtContraseña.Text;
            string PassRegConf = txtConfContra.Text;

            // Verificar que las contraseñas coinciden
            if (PassReg == PassRegConf)
            {
                // Verificar que la contraseña tenga al menos 8 caracteres
                if (PassReg.Length < 8)
                {
                    lblPassStatus.Text = "La contraseña debe tener al menos 8 caracteres.";
                    lblPassStatus.ForeColor = Color.Red;
                    return false;
                }

                // Verificar que la contraseña contenga al menos un carácter especial
                if (!PassReg.Any(c => !char.IsLetterOrDigit(c)))
                {
                    lblPassStatus.Text = "La contraseña debe contener al menos un carácter especial.";
                    lblPassStatus.ForeColor = Color.Red;
                    return false;
                }
                lblPassStatus.Text = "Contraseña válida";
                lblPassStatus.ForeColor = Color.Green;
                return true;
            }
            else
            {
                lblPassStatus.Text = "Las contraseñas no coinciden.";
                lblPassStatus.ForeColor = Color.Red;
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
                try
                {
                    oce_usuario.Name = txtNombre.Text;
                    oce_usuario.Phone = txtTelefono.Text;
                    oce_usuario.Password = encrypt.HashPassword(txtContraseña.Text);
                    oce_usuario.Email = "";
                    oce_usuario.VerificationCode = "";
                    oce_usuario.State = 1;

                    ocn_usuario.InsertarUsuario(oce_usuario);
                    MessageBox.Show("Se registró correctamente.");
                    IniciarSesion step = new IniciarSesion();
                    step.Show();
                    this.Hide();
                }
                catch

                {
                    MessageBox.Show("Número ya registrado. Por favor, inicie sesión.");

                    Registrarse newform = new Registrarse();
                    newform.Show();
                    this.Hide();
                }

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
                if (long.TryParse(txtTelefono.Text.Replace(" ", ""), out long phoneNumber) && txtTelefono.Text.Length == 10)
                {
                    string nombre = txtNombre.Text.Trim();

                    if (!nombre.Any(char.IsDigit) && nombre.Any(char.IsLetter)) // Verificar que el nombre no contenga dígitos numéricos y contenga al menos una letra
                    {
                        // Convertir la primera letra a mayúscula y las demás a minúsculas
                        nombre = char.ToUpper(nombre[0]) + nombre.Substring(1).ToLower();

                        txtNombre.Text = nombre; // Actualizar el contenido del TextBox con la versión corregida del nombre

                        Confirm();
                    }
                    else
                    {
                        MessageBox.Show("El nombre no puede contener dígitos numéricos o debe tener al menos una letra.");
                    }
                }
                else
                {
                    MessageBox.Show("El número de teléfono debe tener 10 dígitos numéricos.");
                }
            }
        }
    }
}
