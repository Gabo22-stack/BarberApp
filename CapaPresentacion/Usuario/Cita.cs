using CapaEntidades;
using CapaNegocio;
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
    public partial class Cita : Form
    {
        public Cita()
        {
            InitializeComponent();
            
        }
        CE_Cita OCE_CITA = new CE_Cita();
        CN_Cita OCN_CITA = new CN_Cita();
        public int ValorHora = 0;
        #region Metodos
        private void FechaActual()
        {
            var fechaActual = DateTime.Now;
            MonthCa.MinDate = fechaActual;
        }
        #endregion
        private void Cita_Load(object sender, EventArgs e)
        {
            FechaActual();
        }
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Principal newform = new Principal();
            this.Hide();
            newform.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Op1.Checked)
            {
                ValorHora = 1;
            }
            else if (Op2.Checked)
            {
                ValorHora = 2;
            }
            else if (Op3.Checked)
            {
                ValorHora = 3;
            }
            else if (Op4.Checked)
            {
                ValorHora = 4;
            }
            else if (Op5.Checked)
            {
                ValorHora = 5;
            }
            else if (Op6.Checked)
            {
                ValorHora = 6;
            }
            else if (Op7.Checked)
            {
                ValorHora = 7;
            }
            else if (Op8.Checked)
            {
                ValorHora = 8;
            }
            else if (Op9.Checked)
            {
                ValorHora = 9;
            }
            else if (Op10.Checked)
            {
                ValorHora = 10;
            }
            OCE_CITA.Date = MonthCa.SelectionStart; // Obtener el valor de MonthCalendar
            OCE_CITA.Time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, ValorHora, 0, 0);// Crear un objeto DateTime con la fecha actual y
            OCE_CITA.Comment = "";
            OCE_CITA.Rating = 0;
            float Valorcorte = Convert.ToSingle(LblDinero.Text);
            OCE_CITA.Price = Valorcorte;                                            
            OCE_CITA.State = 1;
            OCE_CITA.User = Convert.ToString(CE_Global.Phone);
            OCE_CITA.Service = Principal.IdServicio;
            OCE_CITA.Barber = 1;
            OCE_CITA.Employee = GlobalEmpleados.IdEmpleado;
            OCN_CITA.CrearCita(OCE_CITA);
            MessageBox.Show("¡Su cita ha sido agendada con exito!");
            Principal newform = new Principal();
            this.Hide();
            //newform.Show();
            
        }

     
    }
}
