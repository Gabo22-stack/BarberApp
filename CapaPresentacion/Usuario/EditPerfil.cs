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
    public partial class EditPerfil : Form
    {
        CN_Usuario ocn_usuario = new CN_Usuario();
        CE_Usuario oce_usuario = new CE_Usuario();
        public EditPerfil()
        {
            InitializeComponent();
            txtNombre.Text = CE_Global.Name;
            txtCorreo.Text = CE_Global.Email;
        }
        
        private void btnEditarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Actualiza la imagen en el PictureBox con la imagen seleccionada por el usuario
                fotoRedonda1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            EditPasswordUser newform = new EditPasswordUser();
            newform.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            oce_usuario.Name = txtNombre.Text;
            oce_usuario.Email = txtCorreo.Text;
            oce_usuario.Phone = CE_Global.Phone;
            oce_usuario.VerificationCode = "";
            oce_usuario.Password = CE_Global.Password;
            oce_usuario.State = 1;

            ocn_usuario.EditarUsuario(oce_usuario);
            MessageBox.Show("Sus datos se han editado correctamente.");
        }
    }
}
