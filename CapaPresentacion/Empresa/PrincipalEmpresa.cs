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
    public partial class PrincipalEmpresa : Form
    {
        public PrincipalEmpresa()
        {
            InitializeComponent();
        }

        private void btnBarberia_Click(object sender, EventArgs e)
        {
            PerfilBarber FormBarber = new PerfilBarber();
            FormBarber.Show();
            this.Hide();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            PersonalBarber FormBarber = new PersonalBarber();
            FormBarber.Show();
            this.Hide();
        }
    }
}
