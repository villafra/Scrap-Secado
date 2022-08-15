namespace Scrap_Secado
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ListaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.btnScrap_Secado = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.PanelTiempo = new System.Windows.Forms.Panel();
            this.lblTransacción = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPxWx = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.PanelTiempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.btnSalir);
            this.PanelMenu.Controls.Add(this.btnScrap_Secado);
            this.PanelMenu.Controls.Add(this.picMenu);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(233, 653);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.ImageIndex = 1;
            this.btnSalir.ImageList = this.ListaImagenes;
            this.btnSalir.Location = new System.Drawing.Point(12, 577);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(208, 50);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ListaImagenes
            // 
            this.ListaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaImagenes.ImageStream")));
            this.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaImagenes.Images.SetKeyName(0, "Scrap Secado.png");
            this.ListaImagenes.Images.SetKeyName(1, "logout.png");
            // 
            // btnScrap_Secado
            // 
            this.btnScrap_Secado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScrap_Secado.ImageIndex = 0;
            this.btnScrap_Secado.ImageList = this.ListaImagenes;
            this.btnScrap_Secado.Location = new System.Drawing.Point(12, 206);
            this.btnScrap_Secado.Name = "btnScrap_Secado";
            this.btnScrap_Secado.Size = new System.Drawing.Size(208, 50);
            this.btnScrap_Secado.TabIndex = 1;
            this.btnScrap_Secado.Text = "Scrap Secado";
            this.btnScrap_Secado.UseVisualStyleBackColor = true;
            this.btnScrap_Secado.Click += new System.EventHandler(this.btnScrap_Secado_Click);
            // 
            // picMenu
            // 
            this.picMenu.Image = global::Scrap_Secado.Properties.Resources.Mars_Petcare;
            this.picMenu.Location = new System.Drawing.Point(-7, -30);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(249, 127);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu.TabIndex = 0;
            this.picMenu.TabStop = false;
            // 
            // PanelTiempo
            // 
            this.PanelTiempo.Controls.Add(this.lblTransacción);
            this.PanelTiempo.Controls.Add(this.lblUsuario);
            this.PanelTiempo.Controls.Add(this.lblFecha);
            this.PanelTiempo.Controls.Add(this.lblPxWx);
            this.PanelTiempo.Controls.Add(this.lblHora);
            this.PanelTiempo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTiempo.Location = new System.Drawing.Point(233, 0);
            this.PanelTiempo.Name = "PanelTiempo";
            this.PanelTiempo.Size = new System.Drawing.Size(883, 34);
            this.PanelTiempo.TabIndex = 2;
            // 
            // lblTransacción
            // 
            this.lblTransacción.AutoSize = true;
            this.lblTransacción.Location = new System.Drawing.Point(249, 9);
            this.lblTransacción.Name = "lblTransacción";
            this.lblTransacción.Size = new System.Drawing.Size(0, 16);
            this.lblTransacción.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(6, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(11, 16);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "-";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(524, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(11, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "-";
            // 
            // lblPxWx
            // 
            this.lblPxWx.AutoSize = true;
            this.lblPxWx.Location = new System.Drawing.Point(664, 9);
            this.lblPxWx.Name = "lblPxWx";
            this.lblPxWx.Size = new System.Drawing.Size(11, 16);
            this.lblPxWx.TabIndex = 1;
            this.lblPxWx.Text = "-";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(788, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(11, 16);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "-";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 653);
            this.Controls.Add(this.PanelTiempo);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.PanelTiempo.ResumeLayout(false);
            this.PanelTiempo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Panel PanelTiempo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPxWx;
        private System.Windows.Forms.Button btnScrap_Secado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTransacción;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ImageList ListaImagenes;
    }
}

