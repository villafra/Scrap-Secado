using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrap_Secado
{
    public partial class Progreso : Form
    {
        public static string Mensaje;
        public Progreso()
        {
            InitializeComponent();
        }
        public void Progress(int cuanto)
        {
            progPorcentaje.Value = cuanto;
            lblMensaje.Text = Mensaje;
            lblMensaje.Location = new Point(this.Width / 2 - lblMensaje.Width / 2, 14);
        }
    }
}
