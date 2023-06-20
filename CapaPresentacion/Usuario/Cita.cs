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
            string Horaseleccionada = string.Empty;
            if (Op1.Checked)
            {
                Horaseleccionada = Op1.Text;
            }
            else if (Op2.Checked)
            {
                Horaseleccionada = Op2.Text;
            }
            else if (Op3.Checked)
            {
                Horaseleccionada = Op3.Text;
            }
            else if (Op4.Checked)
            {
                Horaseleccionada = Op4.Text;
            }
            else if (Op5.Checked)
            {
                Horaseleccionada = Op5.Text;
            }
            else if (Op6.Checked)
            {
                Horaseleccionada = Op6.Text;
            }
            else if (Op7.Checked)
            {
                Horaseleccionada = Op7.Text;
            }
            else if (Op8.Checked)
            {
                Horaseleccionada = Op8.Text;
            }
            else if (Op9.Checked)
            {
                Horaseleccionada = Op9.Text;
            }
            else if (Op10.Checked)
            {
                Horaseleccionada = Op10.Text;
            }
            else if (Op11.Checked)
            {
                Horaseleccionada = Op11.Text;
            }
            else if (Op12.Checked)
            {
                Horaseleccionada = Op12.Text;
            }
            else if (Op13.Checked)
            {
                Horaseleccionada = Op13.Text;
            }
            else if (Op14.Checked)
            {
                Horaseleccionada = Op14.Text;
            }
            else if (Op15.Checked)
            {
                Horaseleccionada = Op15.Text;
            }

            OCE_CITA.Date = MonthCa.SelectionStart;
            OCE_CITA.Time = DateTime.Parse(Horaseleccionada);
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
            this.Hide();
            Principal newform = new Principal();
            newform.Show();
            MonthCa.Size = new Size(369, 307);

        }


    }
}
