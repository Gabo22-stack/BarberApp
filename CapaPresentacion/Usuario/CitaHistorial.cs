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
            dgvHistorial.Columns["AppointmentID"].HeaderText = "ID";
            dgvHistorial.Columns["Date"].HeaderText = "Fecha ";
            dgvHistorial.Columns["Barber"].HeaderText = "Barberia";
            dgvHistorial.Columns["State"].HeaderText = "Estado";
            dgvHistorial.Columns["Price"].HeaderText = "Precio";
            dgvHistorial.Columns["Time"].HeaderText = "Hora";
            dgvHistorial.Columns["Service"].HeaderText = "Tipo de servicio";
            dgvHistorial.Columns["Employee"].HeaderText = "Barbero";
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Principal newform = new Principal();
            newform.Show();
            this.Hide();
        }

        
    }
}
