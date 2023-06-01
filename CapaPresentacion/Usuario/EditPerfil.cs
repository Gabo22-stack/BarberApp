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
    public partial class EditPerfil : Form
    {
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
    }
}
