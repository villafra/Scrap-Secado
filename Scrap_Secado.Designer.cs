namespace Scrap_Secado
{
    partial class frmScrap_Secado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvScrap_Secado = new System.Windows.Forms.DataGridView();
            this.grpNuevoScrap = new System.Windows.Forms.GroupBox();
            this.lblBolsones = new System.Windows.Forms.Label();
            this.lblGrandes = new System.Windows.Forms.Label();
            this.numGrandes = new System.Windows.Forms.NumericUpDown();
            this.numMedianos = new System.Windows.Forms.NumericUpDown();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblMedianos = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblExtrusora = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblKF = new System.Windows.Forms.Label();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.comboKF = new System.Windows.Forms.ComboBox();
            this.ComboFamilia = new System.Windows.Forms.ComboBox();
            this.comboExtrusora = new System.Windows.Forms.ComboBox();
            this.dtpHoraScrap = new System.Windows.Forms.DateTimePicker();
            this.comboEquipo = new System.Windows.Forms.ComboBox();
            this.comboTurno = new System.Windows.Forms.ComboBox();
            this.dtpFechaScrap = new System.Windows.Forms.DateTimePicker();
            this.btnEnviarMail = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditarRegistro = new System.Windows.Forms.Button();
            this.btnLimpiarPantalla = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.bgwSecado = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScrap_Secado)).BeginInit();
            this.grpNuevoScrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGrandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedianos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScrap_Secado
            // 
            this.dgvScrap_Secado.AllowUserToAddRows = false;
            this.dgvScrap_Secado.AllowUserToDeleteRows = false;
            this.dgvScrap_Secado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScrap_Secado.Location = new System.Drawing.Point(9, 29);
            this.dgvScrap_Secado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvScrap_Secado.Name = "dgvScrap_Secado";
            this.dgvScrap_Secado.ReadOnly = true;
            this.dgvScrap_Secado.RowHeadersWidth = 51;
            this.dgvScrap_Secado.RowTemplate.Height = 24;
            this.dgvScrap_Secado.Size = new System.Drawing.Size(627, 194);
            this.dgvScrap_Secado.TabIndex = 0;
            // 
            // grpNuevoScrap
            // 
            this.grpNuevoScrap.Controls.Add(this.lblBolsones);
            this.grpNuevoScrap.Controls.Add(this.lblGrandes);
            this.grpNuevoScrap.Controls.Add(this.numGrandes);
            this.grpNuevoScrap.Controls.Add(this.numMedianos);
            this.grpNuevoScrap.Controls.Add(this.lblComentarios);
            this.grpNuevoScrap.Controls.Add(this.txtComentarios);
            this.grpNuevoScrap.Controls.Add(this.lblCodigo);
            this.grpNuevoScrap.Controls.Add(this.txtCodigo);
            this.grpNuevoScrap.Controls.Add(this.lblOperador);
            this.grpNuevoScrap.Controls.Add(this.lblMedianos);
            this.grpNuevoScrap.Controls.Add(this.lblMotivo);
            this.grpNuevoScrap.Controls.Add(this.lblExtrusora);
            this.grpNuevoScrap.Controls.Add(this.lblEquipo);
            this.grpNuevoScrap.Controls.Add(this.lblTurno);
            this.grpNuevoScrap.Controls.Add(this.lblKF);
            this.grpNuevoScrap.Controls.Add(this.lblFamilia);
            this.grpNuevoScrap.Controls.Add(this.lblHora);
            this.grpNuevoScrap.Controls.Add(this.lblFecha);
            this.grpNuevoScrap.Controls.Add(this.txtMotivo);
            this.grpNuevoScrap.Controls.Add(this.txtOperador);
            this.grpNuevoScrap.Controls.Add(this.comboKF);
            this.grpNuevoScrap.Controls.Add(this.ComboFamilia);
            this.grpNuevoScrap.Controls.Add(this.comboExtrusora);
            this.grpNuevoScrap.Controls.Add(this.dtpHoraScrap);
            this.grpNuevoScrap.Controls.Add(this.comboEquipo);
            this.grpNuevoScrap.Controls.Add(this.comboTurno);
            this.grpNuevoScrap.Controls.Add(this.dtpFechaScrap);
            this.grpNuevoScrap.Location = new System.Drawing.Point(11, 228);
            this.grpNuevoScrap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpNuevoScrap.Name = "grpNuevoScrap";
            this.grpNuevoScrap.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpNuevoScrap.Size = new System.Drawing.Size(625, 222);
            this.grpNuevoScrap.TabIndex = 0;
            this.grpNuevoScrap.TabStop = false;
            this.grpNuevoScrap.Text = "Registrar Scrap";
            // 
            // lblBolsones
            // 
            this.lblBolsones.AutoSize = true;
            this.lblBolsones.Location = new System.Drawing.Point(317, 72);
            this.lblBolsones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBolsones.Name = "lblBolsones";
            this.lblBolsones.Size = new System.Drawing.Size(52, 13);
            this.lblBolsones.TabIndex = 0;
            this.lblBolsones.Text = "Big Bags:";
            // 
            // lblGrandes
            // 
            this.lblGrandes.AutoSize = true;
            this.lblGrandes.Location = new System.Drawing.Point(523, 72);
            this.lblGrandes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrandes.Name = "lblGrandes";
            this.lblGrandes.Size = new System.Drawing.Size(47, 13);
            this.lblGrandes.TabIndex = 0;
            this.lblGrandes.Text = "Grandes";
            // 
            // numGrandes
            // 
            this.numGrandes.Location = new System.Drawing.Point(525, 93);
            this.numGrandes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numGrandes.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numGrandes.Name = "numGrandes";
            this.numGrandes.Size = new System.Drawing.Size(60, 20);
            this.numGrandes.TabIndex = 9;
            this.numGrandes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numMedianos
            // 
            this.numMedianos.Location = new System.Drawing.Point(420, 93);
            this.numMedianos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numMedianos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numMedianos.Name = "numMedianos";
            this.numMedianos.Size = new System.Drawing.Size(60, 20);
            this.numMedianos.TabIndex = 8;
            this.numMedianos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(317, 118);
            this.lblComentarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(65, 13);
            this.lblComentarios.TabIndex = 0;
            this.lblComentarios.Text = "Comentarios";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(310, 138);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(302, 67);
            this.txtComentarios.TabIndex = 12;
            this.txtComentarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(11, 165);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(14, 184);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(92, 20);
            this.txtCodigo.TabIndex = 20;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(434, 22);
            this.lblOperador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(51, 13);
            this.lblOperador.TabIndex = 0;
            this.lblOperador.Text = "Operador";
            // 
            // lblMedianos
            // 
            this.lblMedianos.AutoSize = true;
            this.lblMedianos.Location = new System.Drawing.Point(413, 72);
            this.lblMedianos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedianos.Name = "lblMedianos";
            this.lblMedianos.Size = new System.Drawing.Size(53, 13);
            this.lblMedianos.TabIndex = 0;
            this.lblMedianos.Text = "Medianos";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(145, 165);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(39, 13);
            this.lblMotivo.TabIndex = 0;
            this.lblMotivo.Text = "Motivo";
            // 
            // lblExtrusora
            // 
            this.lblExtrusora.AutoSize = true;
            this.lblExtrusora.Location = new System.Drawing.Point(11, 72);
            this.lblExtrusora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrusora.Name = "lblExtrusora";
            this.lblExtrusora.Size = new System.Drawing.Size(51, 13);
            this.lblExtrusora.TabIndex = 0;
            this.lblExtrusora.Text = "Extrusora";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(317, 22);
            this.lblEquipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(40, 13);
            this.lblEquipo.TabIndex = 0;
            this.lblEquipo.Text = "Equipo";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(203, 22);
            this.lblTurno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 0;
            this.lblTurno.Text = "Turno";
            // 
            // lblKF
            // 
            this.lblKF.AutoSize = true;
            this.lblKF.Location = new System.Drawing.Point(11, 118);
            this.lblKF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKF.Name = "lblKF";
            this.lblKF.Size = new System.Drawing.Size(20, 13);
            this.lblKF.TabIndex = 0;
            this.lblKF.Text = "KF";
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Location = new System.Drawing.Point(142, 72);
            this.lblFamilia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(39, 13);
            this.lblFamilia.TabIndex = 0;
            this.lblFamilia.Text = "Familia";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(118, 22);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(11, 22);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(145, 186);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(150, 20);
            this.txtMotivo.TabIndex = 11;
            this.txtMotivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOperador
            // 
            this.txtOperador.Location = new System.Drawing.Point(436, 42);
            this.txtOperador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(176, 20);
            this.txtOperador.TabIndex = 5;
            this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOperador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOperador_KeyPress);
            // 
            // comboKF
            // 
            this.comboKF.FormattingEnabled = true;
            this.comboKF.Location = new System.Drawing.Point(14, 138);
            this.comboKF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboKF.Name = "comboKF";
            this.comboKF.Size = new System.Drawing.Size(282, 21);
            this.comboKF.TabIndex = 10;
            this.comboKF.SelectedIndexChanged += new System.EventHandler(this.comboKF_SelectedIndexChanged);
            // 
            // ComboFamilia
            // 
            this.ComboFamilia.FormattingEnabled = true;
            this.ComboFamilia.Location = new System.Drawing.Point(144, 93);
            this.ComboFamilia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboFamilia.Name = "ComboFamilia";
            this.ComboFamilia.Size = new System.Drawing.Size(151, 21);
            this.ComboFamilia.TabIndex = 7;
            this.ComboFamilia.SelectedValueChanged += new System.EventHandler(this.ComboFamilia_SelectedValueChanged);
            // 
            // comboExtrusora
            // 
            this.comboExtrusora.DisplayMember = "EnumMember";
            this.comboExtrusora.FormattingEnabled = true;
            this.comboExtrusora.Location = new System.Drawing.Point(14, 93);
            this.comboExtrusora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboExtrusora.Name = "comboExtrusora";
            this.comboExtrusora.Size = new System.Drawing.Size(98, 21);
            this.comboExtrusora.TabIndex = 6;
            this.comboExtrusora.ValueMember = "EnumMember";
            // 
            // dtpHoraScrap
            // 
            this.dtpHoraScrap.CustomFormat = "HH:mm";
            this.dtpHoraScrap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraScrap.Location = new System.Drawing.Point(120, 42);
            this.dtpHoraScrap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHoraScrap.Name = "dtpHoraScrap";
            this.dtpHoraScrap.ShowUpDown = true;
            this.dtpHoraScrap.Size = new System.Drawing.Size(61, 20);
            this.dtpHoraScrap.TabIndex = 2;
            this.dtpHoraScrap.Value = new System.DateTime(2022, 8, 15, 11, 30, 47, 0);
            // 
            // comboEquipo
            // 
            this.comboEquipo.FormattingEnabled = true;
            this.comboEquipo.Location = new System.Drawing.Point(320, 42);
            this.comboEquipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboEquipo.Name = "comboEquipo";
            this.comboEquipo.Size = new System.Drawing.Size(92, 21);
            this.comboEquipo.TabIndex = 4;
            // 
            // comboTurno
            // 
            this.comboTurno.FormattingEnabled = true;
            this.comboTurno.Location = new System.Drawing.Point(203, 42);
            this.comboTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboTurno.Name = "comboTurno";
            this.comboTurno.Size = new System.Drawing.Size(92, 21);
            this.comboTurno.TabIndex = 3;
            // 
            // dtpFechaScrap
            // 
            this.dtpFechaScrap.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaScrap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaScrap.Location = new System.Drawing.Point(14, 41);
            this.dtpFechaScrap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaScrap.Name = "dtpFechaScrap";
            this.dtpFechaScrap.Size = new System.Drawing.Size(98, 20);
            this.dtpFechaScrap.TabIndex = 1;
            this.dtpFechaScrap.Value = new System.DateTime(2022, 8, 15, 11, 30, 47, 0);
            // 
            // btnEnviarMail
            // 
            this.btnEnviarMail.BackgroundImage = global::Scrap_Secado.Properties.Resources.Email;
            this.btnEnviarMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnviarMail.FlatAppearance.BorderSize = 0;
            this.btnEnviarMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarMail.Location = new System.Drawing.Point(11, 455);
            this.btnEnviarMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviarMail.Name = "btnEnviarMail";
            this.btnEnviarMail.Size = new System.Drawing.Size(40, 39);
            this.btnEnviarMail.TabIndex = 5;
            this.btnEnviarMail.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::Scrap_Secado.Properties.Resources.borrar1;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(369, 455);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(40, 39);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditarRegistro
            // 
            this.btnEditarRegistro.BackgroundImage = global::Scrap_Secado.Properties.Resources.editar_codigo;
            this.btnEditarRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarRegistro.FlatAppearance.BorderSize = 0;
            this.btnEditarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRegistro.Location = new System.Drawing.Point(236, 455);
            this.btnEditarRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarRegistro.Name = "btnEditarRegistro";
            this.btnEditarRegistro.Size = new System.Drawing.Size(40, 39);
            this.btnEditarRegistro.TabIndex = 3;
            this.btnEditarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarPantalla
            // 
            this.btnLimpiarPantalla.BackgroundImage = global::Scrap_Secado.Properties.Resources.dispositivos;
            this.btnLimpiarPantalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiarPantalla.FlatAppearance.BorderSize = 0;
            this.btnLimpiarPantalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarPantalla.Location = new System.Drawing.Point(596, 455);
            this.btnLimpiarPantalla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarPantalla.Name = "btnLimpiarPantalla";
            this.btnLimpiarPantalla.Size = new System.Drawing.Size(40, 39);
            this.btnLimpiarPantalla.TabIndex = 2;
            this.btnLimpiarPantalla.UseVisualStyleBackColor = true;
            this.btnLimpiarPantalla.Click += new System.EventHandler(this.btnLimpiarPantalla_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Scrap_Secado.Properties.Resources.diskette;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(302, 455);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(40, 39);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // bgwSecado
            // 
            this.bgwSecado.WorkerReportsProgress = true;
            this.bgwSecado.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSecado_DoWork);
            this.bgwSecado.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSecado_ProgressChanged);
            this.bgwSecado.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSecado_RunWorkerCompleted);
            // 
            // frmScrap_Secado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 504);
            this.Controls.Add(this.btnEnviarMail);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditarRegistro);
            this.Controls.Add(this.btnLimpiarPantalla);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpNuevoScrap);
            this.Controls.Add(this.dgvScrap_Secado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmScrap_Secado";
            this.Text = "Scrap_Secado";
            this.Load += new System.EventHandler(this.frmScrap_Secado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScrap_Secado)).EndInit();
            this.grpNuevoScrap.ResumeLayout(false);
            this.grpNuevoScrap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGrandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedianos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScrap_Secado;
        private System.Windows.Forms.GroupBox grpNuevoScrap;
        private System.Windows.Forms.ComboBox comboTurno;
        private System.Windows.Forms.DateTimePicker dtpFechaScrap;
        private System.Windows.Forms.ComboBox comboEquipo;
        private System.Windows.Forms.DateTimePicker dtpHoraScrap;
        private System.Windows.Forms.ComboBox comboKF;
        private System.Windows.Forms.ComboBox ComboFamilia;
        private System.Windows.Forms.ComboBox comboExtrusora;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblMedianos;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblExtrusora;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblKF;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label lblGrandes;
        private System.Windows.Forms.NumericUpDown numGrandes;
        private System.Windows.Forms.NumericUpDown numMedianos;
        private System.Windows.Forms.Label lblBolsones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiarPantalla;
        private System.Windows.Forms.Button btnEditarRegistro;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEnviarMail;
        private System.ComponentModel.BackgroundWorker bgwSecado;
    }
}