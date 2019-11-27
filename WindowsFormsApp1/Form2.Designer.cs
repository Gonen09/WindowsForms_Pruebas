namespace WindowsFormsApp1
{
    partial class ventanaSecundaria
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnPausa;
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noChequearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkVisitanos = new System.Windows.Forms.LinkLabel();
            this.chkChequear = new System.Windows.Forms.CheckBox();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.porcentajeCarga = new System.Windows.Forms.Label();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.pgbCarga = new System.Windows.Forms.ProgressBar();
            btnPausa = new System.Windows.Forms.Button();
            this.menuVentana.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPausa
            // 
            btnPausa.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPausa.Location = new System.Drawing.Point(99, 239);
            btnPausa.Name = "btnPausa";
            btnPausa.Size = new System.Drawing.Size(22, 23);
            btnPausa.TabIndex = 8;
            btnPausa.TabStop = false;
            btnPausa.Text = "⏸";
            btnPausa.UseVisualStyleBackColor = true;
            btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(60, 51);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(200, 20);
            this.calendario.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(60, 119);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // menuVentana
            // 
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanaToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(322, 24);
            this.menuVentana.TabIndex = 2;
            this.menuVentana.Text = "menuStrip1";
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chequearToolStripMenuItem,
            this.noChequearToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // chequearToolStripMenuItem
            // 
            this.chequearToolStripMenuItem.Name = "chequearToolStripMenuItem";
            this.chequearToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.chequearToolStripMenuItem.Text = "Chequear";
            this.chequearToolStripMenuItem.Click += new System.EventHandler(this.ChequearToolStripMenuItem_Click);
            // 
            // noChequearToolStripMenuItem
            // 
            this.noChequearToolStripMenuItem.Name = "noChequearToolStripMenuItem";
            this.noChequearToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.noChequearToolStripMenuItem.Text = "No Chequear";
            this.noChequearToolStripMenuItem.Click += new System.EventHandler(this.NoChequearToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // linkVisitanos
            // 
            this.linkVisitanos.AutoSize = true;
            this.linkVisitanos.Location = new System.Drawing.Point(211, 123);
            this.linkVisitanos.Name = "linkVisitanos";
            this.linkVisitanos.Size = new System.Drawing.Size(49, 13);
            this.linkVisitanos.TabIndex = 3;
            this.linkVisitanos.TabStop = true;
            this.linkVisitanos.Text = "Visitanos";
            this.linkVisitanos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVisitanos_LinkClicked);
            // 
            // chkChequear
            // 
            this.chkChequear.AutoSize = true;
            this.chkChequear.Location = new System.Drawing.Point(134, 183);
            this.chkChequear.Name = "chkChequear";
            this.chkChequear.Size = new System.Drawing.Size(72, 17);
            this.chkChequear.TabIndex = 4;
            this.chkChequear.Text = "Chequear";
            this.chkChequear.UseVisualStyleBackColor = true;
            this.chkChequear.CheckedChanged += new System.EventHandler(this.chkChequear_CheckedChanged);
            // 
            // btnReproducir
            // 
            this.btnReproducir.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproducir.Location = new System.Drawing.Point(60, 239);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(23, 23);
            this.btnReproducir.TabIndex = 5;
            this.btnReproducir.Text = "⏵";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Location = new System.Drawing.Point(137, 239);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(23, 23);
            this.btnDetener.TabIndex = 6;
            this.btnDetener.Text = "⏹";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // porcentajeCarga
            // 
            this.porcentajeCarga.AutoSize = true;
            this.porcentajeCarga.Location = new System.Drawing.Point(213, 273);
            this.porcentajeCarga.Name = "porcentajeCarga";
            this.porcentajeCarga.Size = new System.Drawing.Size(21, 13);
            this.porcentajeCarga.TabIndex = 7;
            this.porcentajeCarga.Text = "0%";
            // 
            // temporizador
            // 
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // pgbCarga
            // 
            this.pgbCarga.Cursor = System.Windows.Forms.Cursors.Default;
            this.pgbCarga.Location = new System.Drawing.Point(191, 239);
            this.pgbCarga.Name = "pgbCarga";
            this.pgbCarga.Size = new System.Drawing.Size(69, 23);
            this.pgbCarga.TabIndex = 9;
            // 
            // ventanaSecundaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 303);
            this.Controls.Add(this.pgbCarga);
            this.Controls.Add(btnPausa);
            this.Controls.Add(this.porcentajeCarga);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.chkChequear);
            this.Controls.Add(this.linkVisitanos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.menuVentana);
            this.MainMenuStrip = this.menuVentana;
            this.MaximizeBox = false;
            this.Name = "ventanaSecundaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ventana";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.LinkLabel linkVisitanos;
        private System.Windows.Forms.CheckBox chkChequear;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chequearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noChequearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Label porcentajeCarga;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.ProgressBar pgbCarga;
    }
}