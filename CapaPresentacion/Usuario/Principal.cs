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
    public partial class Principal : Form
    {
        public static int IdServicio = 0;
        public float Valorcorte = 0;
        CN_Historial ocn_historial = new CN_Historial();
        public Principal()
        {
            InitializeComponent();
            
        }

        private void BtnCitas_Click(object sender, EventArgs e)
        {
            DataTable tablaCitas = ocn_historial.VisualizarCita();

            if (tablaCitas.Rows.Count == 0)
            {
                MessageBox.Show("No tienes citas agendadas.", "Citas Historial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                CitaHistorial newform = new CitaHistorial();
                newform.Show();
            }
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            PerfilMuestra newform = new PerfilMuestra();
            newform.Show();
            this.Hide();
        }

        private void BtnComentarios_Click(object sender, EventArgs e)
        {
            Comentario newform = new Comentario();
            newform.Show();
            this.Hide();
        }

        private void BtnCorteNiño_Click(object sender, EventArgs e)
        {
            Personal newform = new Personal();
            newform.Show();
            this.Hide();
            IdServicio = 1;
            
        }

        private void BtnCorteAdulto_Click(object sender, EventArgs e)
        {
            Personal newform = new Personal();
            newform.Show();
            this.Hide();
            IdServicio = 2;
            
        }

        private void BtnCorteFiguras_Click(object sender, EventArgs e)
        {
            Personal newform = new Personal();
            newform.Show();
            this.Hide();
            IdServicio = 3;
            
        }

        private void BtnManicuraHombre_Click(object sender, EventArgs e)
        {
            PersonalManicura newform = new PersonalManicura();
            newform.Show();
            this.Hide();
            IdServicio = 4;
            
        }

        private void BtnManicuraMujer_Click(object sender, EventArgs e)
        {
            PersonalManicura newform = new PersonalManicura();
            newform.Show();
            this.Hide();
            IdServicio = 5;
            
        }
    }
}
