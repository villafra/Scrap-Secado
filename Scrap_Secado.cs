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
using BE;
using BLL;

namespace Scrap_Secado
{
    public partial class frmScrap_Secado : Form
    {
        BLL_KF _KF;
        Kibble_Finished KF;
        BE.Scrap_Secado Scrap;
        public frmScrap_Secado()
        {
            InitializeComponent();
            _KF = new BLL_KF();
            KF = new Kibble_Finished();
            Scrap = new BE.Scrap_Secado();
            Aspecto.FormatearDGV(dgvScrap_Secado);
            Aspecto.FormatearGRP(grpNuevoScrap);
        }

        private void frmScrap_Secado_Load(object sender, EventArgs e)
        {
            Refrescar();
            ToolTipiar();
        }

        private void ToolTipiar()
        {
            ToolTip tips = new ToolTip();
            tips.SetToolTip(btnBorrar, "Borrar Registro");
            tips.SetToolTip(btnEditarRegistro, "Editar Registro");
            tips.SetToolTip(btnEnviarMail, "Enviar Mail con info adicional");
            tips.SetToolTip(btnLimpiarPantalla, "Borrar Todos los Campos");
            tips.SetToolTip(btnGuardar, "Guardar Registro de Scrap");
            tips.SetToolTip(numGrandes, "Cantidad de Big Bags de Scrap Grandes");
            tips.SetToolTip(numMedianos, "Cantidad de Big Bags de Scrap Medianos");
        }

        private void Refrescar()
        {
            Cálculos.DataSourceCombo(comboTurno, Enum.GetNames(typeof(Enumerables.Turno)), "Turno");
            Cálculos.DataSourceCombo(comboEquipo, Enum.GetNames(typeof(Enumerables.Equipo)), "Equipo");
            Cálculos.DataSourceCombo(comboExtrusora, Enum.GetNames(typeof(Enumerables.Extrusora)), "Extrusora");
            Cálculos.DataSourceCombo(ComboFamilia, Enum.GetNames(typeof(Enumerables.Familia)), "Familia");
        }



        private void comboKF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboKF.SelectedIndex > -1)
            {
                txtCodigo.Text = ((Kibble_Finished)comboKF.SelectedItem).Codigo.ToString();
            }
            else
            {
                txtCodigo.Text = "";
            }
        }

        private void ComboFamilia_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ComboFamilia.SelectedValue != null)
                {
                    Cálculos.DataSourceCombo(comboKF, _KF.Listar(ComboFamilia.SelectedItem.ToString()), "Kibbles");
                }
                else
                {
                    comboKF.DataSource = null;
                }
            }
            catch { }

        }
        private void Nuevo()
        {
            KF.Codigo = ((Kibble_Finished)comboKF.SelectedItem).Codigo;
            KF.Descripción = ((Kibble_Finished)comboKF.SelectedItem).ToString();
            KF.Costo = ((Kibble_Finished)comboKF.SelectedItem).Costo;
            KF.Familia = ((Kibble_Finished)comboKF.SelectedItem).Familia;
            KF.Cantidad = _KF.CalcularCantidad(numMedianos.Value, numGrandes.Value);

            Scrap.FechaYHora = Cálculos.UnirFechas(dtpFechaScrap.Value, dtpHoraScrap.Value);
            Scrap.Turno = (Enumerables.Turno)comboTurno.SelectedItem;
            Scrap.Operador = txtOperador.Text;
            Scrap.Equipo = (Enumerables.Equipo)comboEquipo.SelectedItem;
            Scrap.Extrusora = (Enumerables.Extrusora)comboExtrusora.SelectedItem;
            Scrap.Kibble = KF;
            Scrap.Costo_Desvío = KF.CalcularCosto();
            Scrap.Comentarios = txtMotivo.Text;
            Scrap.Motivo = txtMotivo.Text;
        }

        private void btnLimpiarPantalla_Click(object sender, EventArgs e)
        {
            Cálculos.BorrarCampos(grpNuevoScrap);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Cálculos.Camposvacios(grpNuevoScrap))
            {

            }
            else { Cálculos.MsgBox("Por favor, Llene los campos obligatorios"); }
        }

        private void txtOperador_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cálculos.ValidarLetras(e);
        }
    }
}
