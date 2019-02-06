namespace BlocNotas
{
    partial class FormBlocNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBlocNotas));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.msArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.msArchivoNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.msArchivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.msArchivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.msArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.msEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.msEdicionCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.msEdicionCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.msEdicionPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.msEdicionBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.msEdicionFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.msEdicionColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsBtnAbrir = new System.Windows.Forms.ToolStripButton();
            this.tsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnCortar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCopiar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPegar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnFuente = new System.Windows.Forms.ToolStripButton();
            this.tsBtnColor = new System.Windows.Forms.ToolStripButton();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsIndicadorLinea = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msArchivo,
            this.msEdicion});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            // 
            // msArchivo
            // 
            this.msArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msArchivoNuevo,
            this.msArchivoAbrir,
            this.msArchivoGuardar,
            this.msArchivoSalir});
            this.msArchivo.Name = "msArchivo";
            this.msArchivo.Size = new System.Drawing.Size(71, 24);
            this.msArchivo.Text = "Archivo";
            // 
            // msArchivoNuevo
            // 
            this.msArchivoNuevo.Name = "msArchivoNuevo";
            this.msArchivoNuevo.Size = new System.Drawing.Size(137, 26);
            this.msArchivoNuevo.Text = "Nuevo";
            this.msArchivoNuevo.Click += new System.EventHandler(this.msArchivoNuevo_Click);
            // 
            // msArchivoAbrir
            // 
            this.msArchivoAbrir.Name = "msArchivoAbrir";
            this.msArchivoAbrir.Size = new System.Drawing.Size(137, 26);
            this.msArchivoAbrir.Text = "Abrir";
            this.msArchivoAbrir.Click += new System.EventHandler(this.msArchivoAbrir_Click);
            // 
            // msArchivoGuardar
            // 
            this.msArchivoGuardar.Name = "msArchivoGuardar";
            this.msArchivoGuardar.Size = new System.Drawing.Size(137, 26);
            this.msArchivoGuardar.Text = "Guardar";
            this.msArchivoGuardar.Click += new System.EventHandler(this.msArchivoGuardar_Click);
            // 
            // msArchivoSalir
            // 
            this.msArchivoSalir.Name = "msArchivoSalir";
            this.msArchivoSalir.Size = new System.Drawing.Size(137, 26);
            this.msArchivoSalir.Text = "Salir";
            this.msArchivoSalir.Click += new System.EventHandler(this.msArchivoSalir_Click);
            // 
            // msEdicion
            // 
            this.msEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msEdicionCortar,
            this.msEdicionCopiar,
            this.msEdicionPegar,
            this.msEdicionBuscar,
            this.msEdicionFuente,
            this.msEdicionColor});
            this.msEdicion.Name = "msEdicion";
            this.msEdicion.Size = new System.Drawing.Size(70, 24);
            this.msEdicion.Text = "Edición";
            // 
            // msEdicionCortar
            // 
            this.msEdicionCortar.Name = "msEdicionCortar";
            this.msEdicionCortar.Size = new System.Drawing.Size(128, 26);
            this.msEdicionCortar.Text = "Cortar";
            this.msEdicionCortar.Click += new System.EventHandler(this.msEdicionCortar_Click);
            // 
            // msEdicionCopiar
            // 
            this.msEdicionCopiar.Name = "msEdicionCopiar";
            this.msEdicionCopiar.Size = new System.Drawing.Size(128, 26);
            this.msEdicionCopiar.Text = "Copiar";
            this.msEdicionCopiar.Click += new System.EventHandler(this.msEdicionCopiar_Click);
            // 
            // msEdicionPegar
            // 
            this.msEdicionPegar.Name = "msEdicionPegar";
            this.msEdicionPegar.Size = new System.Drawing.Size(128, 26);
            this.msEdicionPegar.Text = "Pegar";
            this.msEdicionPegar.Click += new System.EventHandler(this.msEdicionPegar_Click);
            // 
            // msEdicionBuscar
            // 
            this.msEdicionBuscar.Name = "msEdicionBuscar";
            this.msEdicionBuscar.Size = new System.Drawing.Size(128, 26);
            this.msEdicionBuscar.Text = "Buscar";
            this.msEdicionBuscar.Click += new System.EventHandler(this.msEdicionBuscar_Click);
            // 
            // msEdicionFuente
            // 
            this.msEdicionFuente.Name = "msEdicionFuente";
            this.msEdicionFuente.Size = new System.Drawing.Size(128, 26);
            this.msEdicionFuente.Text = "Fuente";
            this.msEdicionFuente.Click += new System.EventHandler(this.msEdicionFuente_Click);
            // 
            // msEdicionColor
            // 
            this.msEdicionColor.Name = "msEdicionColor";
            this.msEdicionColor.Size = new System.Drawing.Size(128, 26);
            this.msEdicionColor.Text = "Color";
            this.msEdicionColor.Click += new System.EventHandler(this.msEdicionColor_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnNuevo,
            this.tsBtnAbrir,
            this.tsBtnGuardar,
            this.toolStripSeparator1,
            this.tsBtnCortar,
            this.tsBtnCopiar,
            this.tsBtnPegar,
            this.tsBtnBuscar,
            this.tsBtnFuente,
            this.tsBtnColor});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 27);
            this.toolStrip.TabIndex = 1;
            // 
            // tsBtnNuevo
            // 
            this.tsBtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNuevo.Image")));
            this.tsBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNuevo.Name = "tsBtnNuevo";
            this.tsBtnNuevo.Size = new System.Drawing.Size(24, 24);
            this.tsBtnNuevo.Text = "Nuevo";
            this.tsBtnNuevo.Click += new System.EventHandler(this.tsBtnNuevo_Click);
            // 
            // tsBtnAbrir
            // 
            this.tsBtnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAbrir.Image")));
            this.tsBtnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAbrir.Name = "tsBtnAbrir";
            this.tsBtnAbrir.Size = new System.Drawing.Size(24, 24);
            this.tsBtnAbrir.Text = "Abrir";
            this.tsBtnAbrir.Click += new System.EventHandler(this.tsBtnAbrir_Click);
            // 
            // tsBtnGuardar
            // 
            this.tsBtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnGuardar.Image")));
            this.tsBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGuardar.Name = "tsBtnGuardar";
            this.tsBtnGuardar.Size = new System.Drawing.Size(24, 24);
            this.tsBtnGuardar.Text = "Guardar";
            this.tsBtnGuardar.Click += new System.EventHandler(this.tsBtnGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsBtnCortar
            // 
            this.tsBtnCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCortar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCortar.Image")));
            this.tsBtnCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCortar.Name = "tsBtnCortar";
            this.tsBtnCortar.Size = new System.Drawing.Size(24, 24);
            this.tsBtnCortar.Text = "Cortar";
            this.tsBtnCortar.Click += new System.EventHandler(this.tsBtnCortar_Click);
            // 
            // tsBtnCopiar
            // 
            this.tsBtnCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCopiar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCopiar.Image")));
            this.tsBtnCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCopiar.Name = "tsBtnCopiar";
            this.tsBtnCopiar.Size = new System.Drawing.Size(24, 24);
            this.tsBtnCopiar.Text = "Copiar";
            this.tsBtnCopiar.Click += new System.EventHandler(this.tsBtnCopiar_Click);
            // 
            // tsBtnPegar
            // 
            this.tsBtnPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPegar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPegar.Image")));
            this.tsBtnPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPegar.Name = "tsBtnPegar";
            this.tsBtnPegar.Size = new System.Drawing.Size(24, 24);
            this.tsBtnPegar.Text = "Pegar";
            this.tsBtnPegar.Click += new System.EventHandler(this.tsBtnPegar_Click);
            // 
            // tsBtnBuscar
            // 
            this.tsBtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBuscar.Image")));
            this.tsBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBuscar.Name = "tsBtnBuscar";
            this.tsBtnBuscar.Size = new System.Drawing.Size(24, 24);
            this.tsBtnBuscar.Text = "Buscar";
            this.tsBtnBuscar.Click += new System.EventHandler(this.tsBtnBuscar_Click);
            // 
            // tsBtnFuente
            // 
            this.tsBtnFuente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFuente.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFuente.Image")));
            this.tsBtnFuente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFuente.Name = "tsBtnFuente";
            this.tsBtnFuente.Size = new System.Drawing.Size(24, 24);
            this.tsBtnFuente.Text = "Fuente";
            this.tsBtnFuente.Click += new System.EventHandler(this.tsBtnFuente_Click);
            // 
            // tsBtnColor
            // 
            this.tsBtnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnColor.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnColor.Image")));
            this.tsBtnColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnColor.Name = "tsBtnColor";
            this.tsBtnColor.Size = new System.Drawing.Size(24, 24);
            this.tsBtnColor.Text = "Color";
            this.tsBtnColor.Click += new System.EventHandler(this.tsBtnColor_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.ContextMenuStrip = this.contextMenuStrip;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 55);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(800, 395);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            this.richTextBox.SelectionChanged += new System.EventHandler(this.richTextBox_SelectionChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsIndicadorLinea,
            this.tsStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // tsIndicadorLinea
            // 
            this.tsIndicadorLinea.Name = "tsIndicadorLinea";
            this.tsIndicadorLinea.Size = new System.Drawing.Size(0, 17);
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.fuenteToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(123, 148);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // FormBlocNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormBlocNotas";
            this.Text = "Bloc de Notas";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem msArchivo;
        private System.Windows.Forms.ToolStripMenuItem msEdicion;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsIndicadorLinea;
        private System.Windows.Forms.ToolStripMenuItem msArchivoNuevo;
        private System.Windows.Forms.ToolStripMenuItem msArchivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem msArchivoGuardar;
        private System.Windows.Forms.ToolStripMenuItem msArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem msEdicionCortar;
        private System.Windows.Forms.ToolStripMenuItem msEdicionCopiar;
        private System.Windows.Forms.ToolStripMenuItem msEdicionPegar;
        private System.Windows.Forms.ToolStripMenuItem msEdicionBuscar;
        private System.Windows.Forms.ToolStripMenuItem msEdicionFuente;
        private System.Windows.Forms.ToolStripMenuItem msEdicionColor;
        private System.Windows.Forms.ToolStripButton tsBtnNuevo;
        private System.Windows.Forms.ToolStripButton tsBtnAbrir;
        private System.Windows.Forms.ToolStripButton tsBtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnCortar;
        private System.Windows.Forms.ToolStripButton tsBtnCopiar;
        private System.Windows.Forms.ToolStripButton tsBtnPegar;
        private System.Windows.Forms.ToolStripButton tsBtnBuscar;
        private System.Windows.Forms.ToolStripButton tsBtnFuente;
        private System.Windows.Forms.ToolStripButton tsBtnColor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
    }
}

