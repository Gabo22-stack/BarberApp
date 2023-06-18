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
    public partial class AñadirManicurista : Form
    {
        public AñadirManicurista()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            PersonalBarber FrmPersonal = new PersonalBarber();
            FrmPersonal.Show();
            this.Hide();
        }
    }
}
