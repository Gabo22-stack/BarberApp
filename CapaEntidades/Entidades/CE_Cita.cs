using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_Cita
    {
        public int AppointmentID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public String Comment { get; set; }
        public int Rating { get; set; }
        public float Price { get; set; }
        public int State { get; set; }
        public string User { get; set; }
        public int Service { get; set; }
        public int Barber { get; set; }
        public int Employee { get; set; }
    }
}
