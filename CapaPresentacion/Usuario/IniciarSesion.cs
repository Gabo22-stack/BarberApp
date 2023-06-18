using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using CapaNegocio.Modulos;

namespace CapaPresentacion
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }
        CN_Login ObjetoLogin = new CN_Login();
        CN_Encrypt encrypt = new CN_Encrypt();

        #region metodos
        private void GetDataUser()
        {
            string userInput = TbxUser.Text; // Obtener el valor de TbxUser.Text

            CN_GetDataUser.ProcessData(userInput);
        }
        private void GetDataBarber()
        {
            string userInput = TbxUser.Text; // Obtener el valor de TbxUser.Text

            CN_GetDataBarber.ProcessData(userInput);
        }

        private void InicioSesion()
        {
            try
            {
                bool inicioSesionExitoso = ObjetoLogin.LOGINUSER(TbxUser.Text, TbxPass.Text);

                if (inicioSesionExitoso)
                {
                    GetDataUser();
                    Principal FORMPrincipal = new Principal();
                    FORMPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Telefono o Contraseña incorrecta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void InicioSesionEmpresa()
        {
            try
            {
                bool inicioSesionExitoso = ObjetoLogin.LOGINBARBER(TbxUser.Text, TbxPass.Text);

                if (inicioSesionExitoso)
                {
                    GetDataBarber();
                    PrincipalEmpresa FORMPrincipal = new PrincipalEmpresa();
                    FORMPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MostrarContraseña()
        {
            if (ChbMostrar.Checked)
            {
                TbxPass.UseSystemPasswordChar = false;
            }
            else
            {
                TbxPass.UseSystemPasswordChar = true;
            }
        }
        #endregion
        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            if (chbEmpresa.Checked)
            {
                InicioSesionEmpresa();
            }
            else
            {
                InicioSesion();
            }            
        }

        private void ChbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            MostrarContraseña();
        }

        private void BtnRegistrate_Click(object sender, EventArgs e)
        {
            Registrarse newform = new Registrarse();
            newform.Show();
            this.Hide();
        }

        private void chbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEmpresa.Checked)
            {
                LblUser.Text = "Usuario:";
            }
            else
            {
                LblUser.Text = "Teléfono:";
            }
        }
    }
}
