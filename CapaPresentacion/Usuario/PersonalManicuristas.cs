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
    public partial class PersonalManicuristas : Form
    {
     
        public PersonalManicuristas()
        {
            InitializeComponent();
        }

        private void BtnVolveraprincipal_Click(object sender, EventArgs e)
        {
            Principal FormPrincipal = new Principal();
            this.PnlPersonalManicurista.Hide();
            FormPrincipal.Show();
        }

        private void btnManicura1_Click(object sender, EventArgs e)
        {
            Cita newform = new Cita();
            newform.Show();
            this.Hide();
            GlobalEmpleados.IdEmpleado = 4;
        }

        private void btnManicura2_Click(object sender, EventArgs e)
        {
            Cita newform = new Cita();
            newform.Show();
            this.Hide();
            GlobalEmpleados.IdEmpleado = 5;
        }
    }
}
