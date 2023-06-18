using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        public static int IdServicio = 0;
        public Principal()
        {
            InitializeComponent();
            
        }
        #region
        private void CargarForm(Form NuevoFormulario)
        {
            this.PanelHome.Controls.Clear();
            NuevoFormulario.TopLevel = false;
            NuevoFormulario.Dock = DockStyle.Fill;
            this.PanelHome.Controls.Add(NuevoFormulario);
            NuevoFormulario.Show();
        }
        

        #endregion
        private void Principal_Load(object sender, EventArgs e)
        {

        }
     

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            //CargarForm(new Perfil());
            Perfil perfil = new Perfil();
            perfil.Show();
            this.Hide();
        }

        private void BtnCorteNiño_Click(object sender, EventArgs e)
        {
            CargarForm(new Personal());
            IdServicio = 3;
        }

        private void BtnCorteAdulto_Click(object sender, EventArgs e)
        {
            CargarForm(new Personal());
            IdServicio = 4;
        }

        private void BtnCorteFiguras_Click(object sender, EventArgs e)
        {
            CargarForm(new Personal());
            IdServicio = 5;
        }

        private void BtnManicuraHombre_Click(object sender, EventArgs e)
        {
            CargarForm(new PersonalManicuristas());
            IdServicio = 1;
        }

        private void BtnManicuraMujer_Click(object sender, EventArgs e)
        {
            CargarForm(new PersonalManicuristas());
            IdServicio = 2;
        }

        private void BtnComentarios_Click(object sender, EventArgs e)
        {
            CargarForm(new Comentario());
        }

        private void BtnCitas_Click(object sender, EventArgs e)
        {
            CargarForm(new CitaHistorial());
        }
    }
}
