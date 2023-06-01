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
    public partial class PersonalBarber : Form
    {
        public PersonalBarber()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            PrincipalEmpresa FormPrincipal = new PrincipalEmpresa();
            FormPrincipal.Show();
            this.Hide();
        }

        private void btnAñadirBarbero_Click(object sender, EventArgs e)
        {
            AñadirEmpleado FrmAñadir = new AñadirEmpleado();
            FrmAñadir.Show();
            this.Hide();
        }

        private void btnAñadorMani_Click(object sender, EventArgs e)
        {
            AñadirManicurista FrmAñadir = new AñadirManicurista();
            FrmAñadir.Show();
            this.Hide();
        }
    }
}
