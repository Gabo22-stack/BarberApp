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
    public partial class Home : Form
    {
        private Timer timer;
        #region metodos
        private void TraerHome()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        #endregion
        public Home()
        {
            InitializeComponent();
            TraerHome();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            IniciarSesion newform = new IniciarSesion();
            newform.Show();
            this.Hide();
        }

        
    }
}
