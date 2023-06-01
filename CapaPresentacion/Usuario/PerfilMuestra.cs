using CapaEntidades;
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
    public partial class PerfilMuestra : Form
    {
        public PerfilMuestra()
        {
            InitializeComponent();
            txtName.Text = CE_Global.Name;
            txtPhone.Text = CE_Global.Phone;
            txtEmail.Text = CE_Global.Email;
        }
    }
}
