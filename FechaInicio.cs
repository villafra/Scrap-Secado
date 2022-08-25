using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automatización;

namespace Scrap_Secado
{
    public partial class FechaInicio : Form
    {
        public FechaInicio()
        {
            InitializeComponent();
            Aspecto.FormatearFormIndividual(this,grpFechaInicio,this.Width, this.Height);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarsCalendar.CambiarFechaInicio(dtpFechaInicio.Value);
            this.Close();
        }
    }
}
