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
    public partial class Cita : Form
    {
        public Cita()
        {
            InitializeComponent();
        }

        private void Cita_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Principal newform = new Principal();
            this.Hide();
            newform.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Su cita ha sido agendada con exito!");
            Principal newform = new Principal();
            this.Hide();
            newform.Show();
        }
    }
}
