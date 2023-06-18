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
    public partial class CitaHistorial : Form
    {
        public CitaHistorial()
        {
            InitializeComponent();
        }
        CN_Historial ocn_historial = new CN_Historial();
        private void CitaHistorial_Load(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = ocn_historial.VisualizarCita();
        }
    }
}
