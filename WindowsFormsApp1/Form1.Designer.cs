namespace WindowsFormsApp1
{
    partial class ventanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaPrincipal));
            this.btnSaludo = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btnDespedida = new System.Windows.Forms.Button();
            this.rbgOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbgOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbgOpcion3 = new System.Windows.Forms.RadioButton();
            this.rbOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbOpcion3 = new System.Windows.Forms.RadioButton();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnVentana = new System.Windows.Forms.Button();
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mbSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbRespuestas = new System.Windows.Forms.TextBox();
            this.mcTbrespuesta = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ingresarNumeroAletorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHerramientas = new System.Windows.Forms.ToolStrip();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbStar = new System.Windows.Forms.ToolStripButton();
            this.menuEstado = new System.Windows.Forms.StatusStrip();
            this.tssEstadogrupo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssEstadoradio = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssEstadoboton = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbCantidad = new System.Windows.Forms.TrackBar();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.clbListaChequeo = new System.Windows.Forms.CheckedListBox();
            this.cmsMenuListaCheck = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmBorrarCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.cbListaOpciones = new System.Windows.Forms.ComboBox();
            this.cmsMenuListaCombo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmBorrarCombo = new System.Windows.Forms.ToolStripMenuItem();
            this.tbAgregarElemento = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblListas = new System.Windows.Forms.Label();
            this.lblListaCheckT = new System.Windows.Forms.Label();
            this.lblListaCheckR = new System.Windows.Forms.Label();
            this.lblListaComboT = new System.Windows.Forms.Label();
            this.lblListaComboR = new System.Windows.Forms.Label();
            this.lblCajaTexto = new System.Windows.Forms.Label();
            this.gbOpciones.SuspendLayout();
            this.menuVentana.SuspendLayout();
            this.mcTbrespuesta.SuspendLayout();
            this.menuHerramientas.SuspendLayout();
            this.menuEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).BeginInit();
            this.cmsMenuListaCheck.SuspendLayout();
            this.cmsMenuListaCombo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaludo
            // 
            this.btnSaludo.Location = new System.Drawing.Point(344, 180);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(75, 23);
            this.btnSaludo.TabIndex = 0;
            this.btnSaludo.Text = "Saludo!";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(356, 329);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(46, 13);
            this.lblRespuesta.TabIndex = 1;
            this.lblRespuesta.Text = "Etiqueta";
            // 
            // btnDespedida
            // 
            this.btnDespedida.Location = new System.Drawing.Point(344, 230);
            this.btnDespedida.Name = "btnDespedida";
            this.btnDespedida.Size = new System.Drawing.Size(75, 23);
            this.btnDespedida.TabIndex = 2;
            this.btnDespedida.Text = "Despedida";
            this.btnDespedida.UseVisualStyleBackColor = true;
            this.btnDespedida.Click += new System.EventHandler(this.btnDespedida_Click);
            // 
            // rbgOpcion1
            // 
            this.rbgOpcion1.AutoSize = true;
            this.rbgOpcion1.Location = new System.Drawing.Point(6, 29);
            this.rbgOpcion1.Name = "rbgOpcion1";
            this.rbgOpcion1.Size = new System.Drawing.Size(68, 17);
            this.rbgOpcion1.TabIndex = 3;
            this.rbgOpcion1.TabStop = true;
            this.rbgOpcion1.Text = "Opción 1";
            this.rbgOpcion1.UseVisualStyleBackColor = true;
            this.rbgOpcion1.CheckedChanged += new System.EventHandler(this.rbgOpcion1_CheckedChanged);
            // 
            // rbgOpcion2
            // 
            this.rbgOpcion2.AutoSize = true;
            this.rbgOpcion2.Location = new System.Drawing.Point(6, 57);
            this.rbgOpcion2.Name = "rbgOpcion2";
            this.rbgOpcion2.Size = new System.Drawing.Size(68, 17);
            this.rbgOpcion2.TabIndex = 4;
            this.rbgOpcion2.TabStop = true;
            this.rbgOpcion2.Text = "Opción 2";
            this.rbgOpcion2.UseVisualStyleBackColor = true;
            this.rbgOpcion2.CheckedChanged += new System.EventHandler(this.rbgOpcion2_CheckedChanged);
            // 
            // rbgOpcion3
            // 
            this.rbgOpcion3.AutoSize = true;
            this.rbgOpcion3.Location = new System.Drawing.Point(6, 86);
            this.rbgOpcion3.Name = "rbgOpcion3";
            this.rbgOpcion3.Size = new System.Drawing.Size(68, 17);
            this.rbgOpcion3.TabIndex = 5;
            this.rbgOpcion3.TabStop = true;
            this.rbgOpcion3.Text = "Opción 3";
            this.rbgOpcion3.UseVisualStyleBackColor = true;
            this.rbgOpcion3.CheckedChanged += new System.EventHandler(this.rbgOpcion3_CheckedChanged);
            // 
            // rbOpcion1
            // 
            this.rbOpcion1.AutoSize = true;
            this.rbOpcion1.Location = new System.Drawing.Point(204, 209);
            this.rbOpcion1.Name = "rbOpcion1";
            this.rbOpcion1.Size = new System.Drawing.Size(68, 17);
            this.rbOpcion1.TabIndex = 6;
            this.rbOpcion1.TabStop = true;
            this.rbOpcion1.Text = "Opción 1";
            this.rbOpcion1.UseVisualStyleBackColor = true;
            this.rbOpcion1.CheckedChanged += new System.EventHandler(this.rbOpcion1_CheckedChanged);
            // 
            // rbOpcion2
            // 
            this.rbOpcion2.AutoSize = true;
            this.rbOpcion2.Location = new System.Drawing.Point(204, 237);
            this.rbOpcion2.Name = "rbOpcion2";
            this.rbOpcion2.Size = new System.Drawing.Size(68, 17);
            this.rbOpcion2.TabIndex = 7;
            this.rbOpcion2.TabStop = true;
            this.rbOpcion2.Text = "Opción 2";
            this.rbOpcion2.UseVisualStyleBackColor = true;
            this.rbOpcion2.CheckedChanged += new System.EventHandler(this.rbOpcion2_CheckedChanged);
            // 
            // rbOpcion3
            // 
            this.rbOpcion3.AutoSize = true;
            this.rbOpcion3.Location = new System.Drawing.Point(204, 266);
            this.rbOpcion3.Name = "rbOpcion3";
            this.rbOpcion3.Size = new System.Drawing.Size(68, 17);
            this.rbOpcion3.TabIndex = 8;
            this.rbOpcion3.TabStop = true;
            this.rbOpcion3.Text = "Opción 3";
            this.rbOpcion3.UseVisualStyleBackColor = true;
            this.rbOpcion3.CheckedChanged += new System.EventHandler(this.rbOpcion3_CheckedChanged);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(280, 105);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(200, 20);
            this.calendario.TabIndex = 10;
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.rbgOpcion1);
            this.gbOpciones.Controls.Add(this.rbgOpcion2);
            this.gbOpciones.Controls.Add(this.rbgOpcion3);
            this.gbOpciones.Location = new System.Drawing.Point(59, 180);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(92, 118);
            this.gbOpciones.TabIndex = 11;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Grupo";
            // 
            // btnVentana
            // 
            this.btnVentana.Location = new System.Drawing.Point(344, 279);
            this.btnVentana.Name = "btnVentana";
            this.btnVentana.Size = new System.Drawing.Size(75, 23);
            this.btnVentana.TabIndex = 12;
            this.btnVentana.Text = "Ventana";
            this.btnVentana.UseVisualStyleBackColor = true;
            this.btnVentana.Click += new System.EventHandler(this.btnVentana_Click);
            // 
            // menuVentana
            // 
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuOperaciones,
            this.menuAyuda});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(800, 24);
            this.menuVentana.TabIndex = 13;
            this.menuVentana.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbSalir});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "Archivo";
            // 
            // mbSalir
            // 
            this.mbSalir.Name = "mbSalir";
            this.mbSalir.Size = new System.Drawing.Size(96, 22);
            this.mbSalir.Text = "Salir";
            this.mbSalir.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // menuOperaciones
            // 
            this.menuOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.compilarToolStripMenuItem,
            this.depurarToolStripMenuItem,
            this.analizarToolStripMenuItem});
            this.menuOperaciones.Name = "menuOperaciones";
            this.menuOperaciones.Size = new System.Drawing.Size(85, 20);
            this.menuOperaciones.Text = "Operaciones";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.AutoToolTip = true;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // compilarToolStripMenuItem
            // 
            this.compilarToolStripMenuItem.Name = "compilarToolStripMenuItem";
            this.compilarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.compilarToolStripMenuItem.Text = "Compilar";
            // 
            // depurarToolStripMenuItem
            // 
            this.depurarToolStripMenuItem.Name = "depurarToolStripMenuItem";
            this.depurarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.depurarToolStripMenuItem.Text = "Depurar";
            // 
            // analizarToolStripMenuItem
            // 
            this.analizarToolStripMenuItem.Name = "analizarToolStripMenuItem";
            this.analizarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.analizarToolStripMenuItem.Text = "Analizar";
            // 
            // menuAyuda
            // 
            this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuAyuda.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            this.acercaDeToolStripMenuItem.ToolTipText = "Muestra informacion sobre la aplicacion";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // tbRespuestas
            // 
            this.tbRespuestas.ContextMenuStrip = this.mcTbrespuesta;
            this.tbRespuestas.Enabled = false;
            this.tbRespuestas.Location = new System.Drawing.Point(110, 105);
            this.tbRespuestas.Name = "tbRespuestas";
            this.tbRespuestas.Size = new System.Drawing.Size(125, 20);
            this.tbRespuestas.TabIndex = 14;
            // 
            // mcTbrespuesta
            // 
            this.mcTbrespuesta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNumeroAletorioToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.mcTbrespuesta.Name = "contextMenuStrip1";
            this.mcTbrespuesta.Size = new System.Drawing.Size(211, 48);
            // 
            // ingresarNumeroAletorioToolStripMenuItem
            // 
            this.ingresarNumeroAletorioToolStripMenuItem.Name = "ingresarNumeroAletorioToolStripMenuItem";
            this.ingresarNumeroAletorioToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.ingresarNumeroAletorioToolStripMenuItem.Text = "Ingresar número aleatorio";
            this.ingresarNumeroAletorioToolStripMenuItem.Click += new System.EventHandler(this.tsbStar_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // menuHerramientas
            // 
            this.menuHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPlay,
            this.tsbStop,
            this.tsbInfo,
            this.toolStripSeparator1,
            this.tsbStar});
            this.menuHerramientas.Location = new System.Drawing.Point(0, 24);
            this.menuHerramientas.Name = "menuHerramientas";
            this.menuHerramientas.Size = new System.Drawing.Size(800, 25);
            this.menuHerramientas.TabIndex = 15;
            this.menuHerramientas.Text = "toolStrip1";
            // 
            // tsbPlay
            // 
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Image = ((System.Drawing.Image)(resources.GetObject("tsbPlay.Image")));
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(23, 22);
            this.tsbPlay.Text = "toolStripButton1";
            this.tsbPlay.ToolTipText = "Habilitar area de texto";
            this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbStop.Image")));
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(23, 22);
            this.tsbStop.Text = "toolStripButton2";
            this.tsbStop.ToolTipText = "Borrar area de texto";
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // tsbInfo
            // 
            this.tsbInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbInfo.Image")));
            this.tsbInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInfo.Name = "tsbInfo";
            this.tsbInfo.Size = new System.Drawing.Size(23, 22);
            this.tsbInfo.Text = "toolStripButton3";
            this.tsbInfo.ToolTipText = "Mostrar contenido area de texto";
            this.tsbInfo.Click += new System.EventHandler(this.tsbInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbStar
            // 
            this.tsbStar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStar.Image = ((System.Drawing.Image)(resources.GetObject("tsbStar.Image")));
            this.tsbStar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStar.Name = "tsbStar";
            this.tsbStar.Size = new System.Drawing.Size(23, 22);
            this.tsbStar.Text = "toolStripButton4";
            this.tsbStar.ToolTipText = "Generar numero aleatorio";
            this.tsbStar.Click += new System.EventHandler(this.tsbStar_Click);
            // 
            // menuEstado
            // 
            this.menuEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssEstadogrupo,
            this.tssEstadoradio,
            this.tssEstadoboton});
            this.menuEstado.Location = new System.Drawing.Point(0, 426);
            this.menuEstado.Name = "menuEstado";
            this.menuEstado.Size = new System.Drawing.Size(800, 24);
            this.menuEstado.SizingGrip = false;
            this.menuEstado.TabIndex = 16;
            this.menuEstado.Text = "Barra de estado";
            // 
            // tssEstadogrupo
            // 
            this.tssEstadogrupo.AutoSize = false;
            this.tssEstadogrupo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssEstadogrupo.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tssEstadogrupo.Margin = new System.Windows.Forms.Padding(0, 3, 50, 2);
            this.tssEstadogrupo.Name = "tssEstadogrupo";
            this.tssEstadogrupo.Size = new System.Drawing.Size(130, 19);
            this.tssEstadogrupo.Text = "Opción Grupo:";
            // 
            // tssEstadoradio
            // 
            this.tssEstadoradio.AutoSize = false;
            this.tssEstadoradio.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssEstadoradio.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.tssEstadoradio.Margin = new System.Windows.Forms.Padding(0, 3, 50, 2);
            this.tssEstadoradio.Name = "tssEstadoradio";
            this.tssEstadoradio.Size = new System.Drawing.Size(90, 19);
            this.tssEstadoradio.Text = "Opción:   ";
            // 
            // tssEstadoboton
            // 
            this.tssEstadoboton.AutoSize = false;
            this.tssEstadoboton.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssEstadoboton.Margin = new System.Windows.Forms.Padding(0, 3, 50, 2);
            this.tssEstadoboton.Name = "tssEstadoboton";
            this.tssEstadoboton.Size = new System.Drawing.Size(110, 19);
            this.tssEstadoboton.Text = "Botón:         ";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbCantidad.Location = new System.Drawing.Point(520, 105);
            this.tbCantidad.Maximum = 100;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(182, 45);
            this.tbCantidad.TabIndex = 17;
            this.tbCantidad.Scroll += new System.EventHandler(this.tbCantidad_Scroll);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCantidad.Location = new System.Drawing.Point(743, 112);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(13, 13);
            this.lblCantidad.TabIndex = 18;
            this.lblCantidad.Text = "0";
            // 
            // clbListaChequeo
            // 
            this.clbListaChequeo.CheckOnClick = true;
            this.clbListaChequeo.ContextMenuStrip = this.cmsMenuListaCheck;
            this.clbListaChequeo.FormattingEnabled = true;
            this.clbListaChequeo.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4"});
            this.clbListaChequeo.Location = new System.Drawing.Point(493, 180);
            this.clbListaChequeo.Name = "clbListaChequeo";
            this.clbListaChequeo.Size = new System.Drawing.Size(120, 124);
            this.clbListaChequeo.TabIndex = 19;
            this.clbListaChequeo.SelectedIndexChanged += new System.EventHandler(this.ClbListaChequeo_SelectedIndexChanged);
            // 
            // cmsMenuListaCheck
            // 
            this.cmsMenuListaCheck.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBorrarCheck});
            this.cmsMenuListaCheck.Name = "contextMenuStrip1";
            this.cmsMenuListaCheck.Size = new System.Drawing.Size(131, 26);
            // 
            // tsmBorrarCheck
            // 
            this.tsmBorrarCheck.Name = "tsmBorrarCheck";
            this.tsmBorrarCheck.Size = new System.Drawing.Size(130, 22);
            this.tsmBorrarCheck.Text = "Borrar lista";
            this.tsmBorrarCheck.Click += new System.EventHandler(this.tsmBorrarCheck_Click);
            // 
            // cbListaOpciones
            // 
            this.cbListaOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListaOpciones.FormattingEnabled = true;
            this.cbListaOpciones.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4"});
            this.cbListaOpciones.Location = new System.Drawing.Point(635, 180);
            this.cbListaOpciones.Name = "cbListaOpciones";
            this.cbListaOpciones.Size = new System.Drawing.Size(121, 21);
            this.cbListaOpciones.TabIndex = 20;
            this.cbListaOpciones.SelectedIndexChanged += new System.EventHandler(this.CbListaOpciones_SelectedIndexChanged);
            // 
            // cmsMenuListaCombo
            // 
            this.cmsMenuListaCombo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBorrarCombo});
            this.cmsMenuListaCombo.Name = "cmsMenuListaCombo";
            this.cmsMenuListaCombo.Size = new System.Drawing.Size(131, 26);
            // 
            // tsmBorrarCombo
            // 
            this.tsmBorrarCombo.Name = "tsmBorrarCombo";
            this.tsmBorrarCombo.Size = new System.Drawing.Size(130, 22);
            this.tsmBorrarCombo.Text = "Borrar lista";
            this.tsmBorrarCombo.Click += new System.EventHandler(this.tsmBorrarCombo_Click);
            // 
            // tbAgregarElemento
            // 
            this.tbAgregarElemento.Location = new System.Drawing.Point(635, 237);
            this.tbAgregarElemento.Name = "tbAgregarElemento";
            this.tbAgregarElemento.Size = new System.Drawing.Size(121, 20);
            this.tbAgregarElemento.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(657, 281);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(654, 213);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(83, 13);
            this.lblAgregar.TabIndex = 23;
            this.lblAgregar.Text = "Añadir elemento";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(531, 329);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(207, 13);
            this.lblResultado.TabIndex = 24;
            this.lblResultado.Text = "Resultado Selección:  < Indice , Nombre >\r\n";
            // 
            // lblListas
            // 
            this.lblListas.AutoSize = true;
            this.lblListas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListas.Location = new System.Drawing.Point(570, 150);
            this.lblListas.Name = "lblListas";
            this.lblListas.Size = new System.Drawing.Size(100, 13);
            this.lblListas.TabIndex = 25;
            this.lblListas.Text = "Listas de elementos";
            // 
            // lblListaCheckT
            // 
            this.lblListaCheckT.AutoSize = true;
            this.lblListaCheckT.Location = new System.Drawing.Point(490, 358);
            this.lblListaCheckT.Name = "lblListaCheckT";
            this.lblListaCheckT.Size = new System.Drawing.Size(69, 13);
            this.lblListaCheckT.TabIndex = 26;
            this.lblListaCheckT.Text = "Lista Check: ";
            // 
            // lblListaCheckR
            // 
            this.lblListaCheckR.AutoSize = true;
            this.lblListaCheckR.Location = new System.Drawing.Point(587, 358);
            this.lblListaCheckR.Name = "lblListaCheckR";
            this.lblListaCheckR.Size = new System.Drawing.Size(83, 13);
            this.lblListaCheckR.TabIndex = 27;
            this.lblListaCheckR.Text = "< -1 , Ninguno >\r\n";
            // 
            // lblListaComboT
            // 
            this.lblListaComboT.AutoSize = true;
            this.lblListaComboT.Location = new System.Drawing.Point(490, 387);
            this.lblListaComboT.Name = "lblListaComboT";
            this.lblListaComboT.Size = new System.Drawing.Size(68, 13);
            this.lblListaComboT.TabIndex = 28;
            this.lblListaComboT.Text = "Lista Combo:";
            // 
            // lblListaComboR
            // 
            this.lblListaComboR.AutoSize = true;
            this.lblListaComboR.Location = new System.Drawing.Point(587, 387);
            this.lblListaComboR.Name = "lblListaComboR";
            this.lblListaComboR.Size = new System.Drawing.Size(83, 13);
            this.lblListaComboR.TabIndex = 29;
            this.lblListaComboR.Text = "< -1 , Ninguno >";
            // 
            // lblCajaTexto
            // 
            this.lblCajaTexto.AutoSize = true;
            this.lblCajaTexto.Location = new System.Drawing.Point(21, 108);
            this.lblCajaTexto.Name = "lblCajaTexto";
            this.lblCajaTexto.Size = new System.Drawing.Size(69, 13);
            this.lblCajaTexto.TabIndex = 30;
            this.lblCajaTexto.Text = "Caja de texto";
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCajaTexto);
            this.Controls.Add(this.lblListaComboR);
            this.Controls.Add(this.lblListaComboT);
            this.Controls.Add(this.lblListaCheckR);
            this.Controls.Add(this.lblListaCheckT);
            this.Controls.Add(this.lblListas);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbAgregarElemento);
            this.Controls.Add(this.cbListaOpciones);
            this.Controls.Add(this.clbListaChequeo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.menuEstado);
            this.Controls.Add(this.menuHerramientas);
            this.Controls.Add(this.tbRespuestas);
            this.Controls.Add(this.btnVentana);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.rbOpcion3);
            this.Controls.Add(this.rbOpcion2);
            this.Controls.Add(this.rbOpcion1);
            this.Controls.Add(this.btnDespedida);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.btnSaludo);
            this.Controls.Add(this.menuVentana);
            this.MainMenuStrip = this.menuVentana;
            this.MaximizeBox = false;
            this.Name = "ventanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación Gráfica de Prueba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.mcTbrespuesta.ResumeLayout(false);
            this.menuHerramientas.ResumeLayout(false);
            this.menuHerramientas.PerformLayout();
            this.menuEstado.ResumeLayout(false);
            this.menuEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).EndInit();
            this.cmsMenuListaCheck.ResumeLayout(false);
            this.cmsMenuListaCombo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button btnDespedida;
        private System.Windows.Forms.RadioButton rbgOpcion1;
        private System.Windows.Forms.RadioButton rbgOpcion2;
        private System.Windows.Forms.RadioButton rbgOpcion3;
        private System.Windows.Forms.RadioButton rbOpcion1;
        private System.Windows.Forms.RadioButton rbOpcion2;
        private System.Windows.Forms.RadioButton rbOpcion3;
        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnVentana;
        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mbSalir;
        private System.Windows.Forms.ToolStripMenuItem menuOperaciones;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analizarToolStripMenuItem;
        private System.Windows.Forms.TextBox tbRespuestas;
        private System.Windows.Forms.ContextMenuStrip mcTbrespuesta;
        private System.Windows.Forms.ToolStripMenuItem ingresarNumeroAletorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip menuHerramientas;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripButton tsbInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbStar;
        private System.Windows.Forms.StatusStrip menuEstado;
        private System.Windows.Forms.ToolStripStatusLabel tssEstadogrupo;
        private System.Windows.Forms.ToolStripStatusLabel tssEstadoradio;
        private System.Windows.Forms.ToolStripStatusLabel tssEstadoboton;
        private System.Windows.Forms.TrackBar tbCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.CheckedListBox clbListaChequeo;
        private System.Windows.Forms.ComboBox cbListaOpciones;
        private System.Windows.Forms.TextBox tbAgregarElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblListas;
        private System.Windows.Forms.Label lblListaCheckT;
        private System.Windows.Forms.Label lblListaCheckR;
        private System.Windows.Forms.Label lblListaComboT;
        private System.Windows.Forms.Label lblListaComboR;
        private System.Windows.Forms.Label lblCajaTexto;
        private System.Windows.Forms.ContextMenuStrip cmsMenuListaCheck;
        private System.Windows.Forms.ToolStripMenuItem tsmBorrarCheck;
        private System.Windows.Forms.ContextMenuStrip cmsMenuListaCombo;
        private System.Windows.Forms.ToolStripMenuItem tsmBorrarCombo;
    }
}

