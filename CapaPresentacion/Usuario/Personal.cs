using CapaNegocio.Modulos;
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
    public partial class Personal : Form
    {
       
        public Personal()
        {
            InitializeComponent();
        }

        private void BtnVolveraprincipal_Click(object sender, EventArgs e)
        {
            Principal FormPrincipal = new Principal();
            this.PanelPersonal.Hide();
            FormPrincipal.Show();

        }

        private void Personal_Load(object sender, EventArgs e)
        {

        }

        private void btnBarber1_Click(object sender, EventArgs e)
        {
            Cita FormCita = new Cita();
            FormCita.Show();
            this.Hide();
            GlobalEmpleados.IdEmpleado = 1;
        }

        private void btnBarber2_Click(object sender, EventArgs e)
        {
            Cita FormCita = new Cita();
            FormCita.Show();
            this.Hide();
            GlobalEmpleados.IdEmpleado = 2;
        }

        private void btnBarber3_Click(object sender, EventArgs e)
        {
            Cita FormCita = new Cita();
            FormCita.Show();
            this.Hide();
            GlobalEmpleados.IdEmpleado = 3;
        }
    }
}
