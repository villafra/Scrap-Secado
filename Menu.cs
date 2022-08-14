using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automatización;
using BE;
using BLL;

namespace Scrap_Secado
{
    public partial class frmMenu : Form
    {
        BLL_KF oBLL_KF;
        private Timer timer;
        private WindowsIdentity usuario;
        public frmMenu()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerEvent);
            InitializeComponent();
            Aspecto.FormatearForm(this, PanelMenu, PanelTiempo, this.Width, this.Height);
            Aspecto.FormatearLabelExterno(PanelTiempo);
            timer.Enabled = true;
            oBLL_KF = new BLL_KF();
            oBLL_KF.Listar();
        }
        private void TimerEvent(object obj, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            lblHora.Text = hora.ToString("HH:mm");
            lblPxWx.Text = MarsCalendar.MarsLote(Convert.ToDateTime("01/01/2022"),hora,3);
            lblFecha.Text = hora.ToString("dd/MM/yyyy");
            lblUsuario.Text = usuario.Name;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            usuario = WindowsIdentity.GetCurrent();
        }

        private void btnScrap_Secado_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmScrap_Secado);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmScrap_Secado();
                lblTransacción.Text = btnScrap_Secado.Text;
                Aspecto.AbrirNuevoForm(this, frm);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Cálculos.Salir();
        }
    }
}
