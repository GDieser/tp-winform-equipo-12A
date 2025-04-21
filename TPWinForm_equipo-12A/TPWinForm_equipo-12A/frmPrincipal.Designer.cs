namespace TPWinForm_equipo_12A
{
    partial class frmPrincipal
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbImagenes = new System.Windows.Forms.PictureBox();
            this.btnImagenPrevia = new System.Windows.Forms.Button();
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleTS = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboCat = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarMarca = new System.Windows.Forms.Button();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.btnAgregarAvanzado = new System.Windows.Forms.Button();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToOrderColumns = true;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(220)))));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(220)))));
            this.dgvArticulos.Location = new System.Drawing.Point(9, 78);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(481, 385);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellDoubleClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbImagenes
            // 
            this.pbImagenes.Location = new System.Drawing.Point(557, 43);
            this.pbImagenes.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pbImagenes.Name = "pbImagenes";
            this.pbImagenes.Size = new System.Drawing.Size(315, 282);
            this.pbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenes.TabIndex = 1;
            this.pbImagenes.TabStop = false;
            // 
            // btnImagenPrevia
            // 
            this.btnImagenPrevia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnImagenPrevia.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnImagenPrevia.Location = new System.Drawing.Point(557, 342);
            this.btnImagenPrevia.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnImagenPrevia.Name = "btnImagenPrevia";
            this.btnImagenPrevia.Size = new System.Drawing.Size(105, 28);
            this.btnImagenPrevia.TabIndex = 4;
            this.btnImagenPrevia.Text = "Anterior";
            this.btnImagenPrevia.UseVisualStyleBackColor = false;
            this.btnImagenPrevia.Click += new System.EventHandler(this.btnImagenPrevia_Click);
            // 
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnImagenSiguiente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnImagenSiguiente.Location = new System.Drawing.Point(767, 343);
            this.btnImagenSiguiente.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(105, 27);
            this.btnImagenSiguiente.TabIndex = 5;
            this.btnImagenSiguiente.Text = "Siguiente";
            this.btnImagenSiguiente.UseVisualStyleBackColor = false;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(220)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.categoriasToolStripMenuItem,
            this.marcasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(887, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.toolStripMenuItem2,
            this.eliminarToolStripMenuItem2,
            this.detalleTS});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItem1.Text = "Articulos";
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(165, 26);
            this.agregarToolStripMenuItem2.Text = "Agregar";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 26);
            this.toolStripMenuItem2.Text = "Modificar";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // eliminarToolStripMenuItem2
            // 
            this.eliminarToolStripMenuItem2.Name = "eliminarToolStripMenuItem2";
            this.eliminarToolStripMenuItem2.Size = new System.Drawing.Size(165, 26);
            this.eliminarToolStripMenuItem2.Text = "Eliminar";
            this.eliminarToolStripMenuItem2.Click += new System.EventHandler(this.eliminarToolStripMenuItem2_Click);
            // 
            // detalleTS
            // 
            this.detalleTS.Name = "detalleTS";
            this.detalleTS.Size = new System.Drawing.Size(165, 26);
            this.detalleTS.Text = "Ver Detalle";
            this.detalleTS.Click += new System.EventHandler(this.detalleTS_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.tsmModificarCategoria});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // tsmModificarCategoria
            // 
            this.tsmModificarCategoria.Name = "tsmModificarCategoria";
            this.tsmModificarCategoria.Size = new System.Drawing.Size(156, 26);
            this.tsmModificarCategoria.Text = "Modificar";
            this.tsmModificarCategoria.Click += new System.EventHandler(this.tsmModificarCategoria_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.tsmModificarMarca});
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // tsmModificarMarca
            // 
            this.tsmModificarMarca.Name = "tsmModificarMarca";
            this.tsmModificarMarca.Size = new System.Drawing.Size(156, 26);
            this.tsmModificarMarca.Text = "Modificar";
            this.tsmModificarMarca.Click += new System.EventHandler(this.tsmModificarMarca_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBuscar.Location = new System.Drawing.Point(15, 528);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(52, 16);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxBuscar.Location = new System.Drawing.Point(76, 526);
            this.txtBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(173, 22);
            this.txtBoxBuscar.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(5, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(191, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Categ:";
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(64, 39);
            this.comboMarca.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(120, 24);
            this.comboMarca.TabIndex = 1;
            this.comboMarca.SelectedIndexChanged += new System.EventHandler(this.comboMarca_SelectedIndexChanged);
            // 
            // comboCat
            // 
            this.comboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Location = new System.Drawing.Point(247, 39);
            this.comboCat.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(128, 24);
            this.comboCat.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Location = new System.Drawing.Point(737, 405);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 43);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(737, 476);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 43);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(142)))), ((int)(((byte)(121)))));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(557, 405);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 43);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnBuscarMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarMarca.Location = new System.Drawing.Point(381, 38);
            this.btnBuscarMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(105, 26);
            this.btnBuscarMarca.TabIndex = 3;
            this.btnBuscarMarca.Text = "Buscar";
            this.btnBuscarMarca.UseVisualStyleBackColor = false;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnBuscarMarca_Click);
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnVerDetalles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerDetalles.Location = new System.Drawing.Point(557, 476);
            this.btnVerDetalles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(135, 43);
            this.btnVerDetalles.TabIndex = 8;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = false;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // btnAgregarAvanzado
            // 
            this.btnAgregarAvanzado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnAgregarAvanzado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarAvanzado.Location = new System.Drawing.Point(271, 519);
            this.btnAgregarAvanzado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarAvanzado.Name = "btnAgregarAvanzado";
            this.btnAgregarAvanzado.Size = new System.Drawing.Size(115, 34);
            this.btnAgregarAvanzado.TabIndex = 13;
            this.btnAgregarAvanzado.Text = "Buscar";
            this.btnAgregarAvanzado.UseVisualStyleBackColor = false;
            this.btnAgregarAvanzado.Click += new System.EventHandler(this.btnAgregarAvanzado_Click);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(328, 486);
            this.cbxCriterio.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(161, 24);
            this.cbxCriterio.TabIndex = 11;
            // 
            // cbxCampo
            // 
            this.cbxCampo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(76, 486);
            this.cbxCampo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(163, 24);
            this.cbxCampo.TabIndex = 10;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCriterio.Location = new System.Drawing.Point(267, 490);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(52, 16);
            this.lblCriterio.TabIndex = 21;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCampo.Location = new System.Drawing.Point(17, 490);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(54, 16);
            this.lblCampo.TabIndex = 20;
            this.lblCampo.Text = "Campo:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(115)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(887, 565);
            this.Controls.Add(this.cbxCriterio);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnAgregarAvanzado);
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.btnBuscarMarca);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.comboCat);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnImagenSiguiente);
            this.Controls.Add(this.btnImagenPrevia);
            this.Controls.Add(this.pbImagenes);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(905, 612);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(905, 612);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImagenes;
        private System.Windows.Forms.Button btnImagenPrevia;
        private System.Windows.Forms.Button btnImagenSiguiente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.ComboBox comboCat;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ToolStripMenuItem detalleTS;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscarMarca;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarMarca;
        private System.Windows.Forms.Button btnAgregarAvanzado;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
    }
}