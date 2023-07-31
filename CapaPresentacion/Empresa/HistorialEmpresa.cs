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
    public partial class HistorialEmpresa : Form
    {
        CN_Historial ocn_historial = new CN_Historial();
        public HistorialEmpresa()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            PrincipalEmpresa FrmPrincipal = new PrincipalEmpresa();
            FrmPrincipal.Show();
            this.Hide();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;

            ((DataTable)dgvHistorial.DataSource).DefaultView.RowFilter = string.Format("Date LIKE '%{0}%'", filtro);
        }

        private void HistorialEmpresa_Load(object sender, EventArgs e)
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
    }
}
