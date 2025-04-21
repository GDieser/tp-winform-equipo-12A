namespace TPWinForm_equipo_12A
{
    partial class frmDetalleArticulo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblImagenes = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.pbImagenes = new System.Windows.Forms.PictureBox();
            this.btnImagPrevia = new System.Windows.Forms.Button();
            this.btnImagSig = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImagenes = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(128, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMarca.Location = new System.Drawing.Point(140, 82);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 20);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCategoria.Location = new System.Drawing.Point(114, 135);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(82, 20);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescripcion.Location = new System.Drawing.Point(100, 186);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigo.Location = new System.Drawing.Point(134, 275);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código:";
            // 
            // lblImagenes
            // 
            this.lblImagenes.AutoSize = true;
            this.lblImagenes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblImagenes.Location = new System.Drawing.Point(34, 349);
            this.lblImagenes.Name = "lblImagenes";
            this.lblImagenes.Size = new System.Drawing.Size(161, 20);
            this.lblImagenes.TabIndex = 5;
            this.lblImagenes.Text = "Galeria de Imagenes:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecio.Location = new System.Drawing.Point(134, 315);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbNombre.Location = new System.Drawing.Point(249, 31);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(277, 26);
            this.tbNombre.TabIndex = 7;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbDescripcion.Location = new System.Drawing.Point(249, 183);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(277, 73);
            this.tbDescripcion.TabIndex = 8;
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbCodigo.Location = new System.Drawing.Point(249, 272);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(277, 26);
            this.tbCodigo.TabIndex = 9;
            // 
            // tbPrecio
            // 
            this.tbPrecio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbPrecio.Location = new System.Drawing.Point(249, 312);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(277, 26);
            this.tbPrecio.TabIndex = 10;
            // 
            // pbImagenes
            // 
            this.pbImagenes.Location = new System.Drawing.Point(249, 352);
            this.pbImagenes.Name = "pbImagenes";
            this.pbImagenes.Size = new System.Drawing.Size(278, 302);
            this.pbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenes.TabIndex = 11;
            this.pbImagenes.TabStop = false;
            // 
            // btnImagPrevia
            // 
            this.btnImagPrevia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnImagPrevia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImagPrevia.Location = new System.Drawing.Point(212, 352);
            this.btnImagPrevia.Name = "btnImagPrevia";
            this.btnImagPrevia.Size = new System.Drawing.Size(32, 302);
            this.btnImagPrevia.TabIndex = 12;
            this.btnImagPrevia.Text = "<";
            this.btnImagPrevia.UseVisualStyleBackColor = false;
            this.btnImagPrevia.Click += new System.EventHandler(this.btnImagPrevia_Click);
            // 
            // btnImagSig
            // 
            this.btnImagSig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnImagSig.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImagSig.Location = new System.Drawing.Point(532, 352);
            this.btnImagSig.Name = "btnImagSig";
            this.btnImagSig.Size = new System.Drawing.Size(32, 302);
            this.btnImagSig.TabIndex = 13;
            this.btnImagSig.Text = ">";
            this.btnImagSig.UseVisualStyleBackColor = false;
            this.btnImagSig.Click += new System.EventHandler(this.btnImagSig_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(249, 78);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(277, 28);
            this.cbMarca.TabIndex = 14;
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(249, 132);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(277, 28);
            this.cbCategoria.TabIndex = 15;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(39, 492);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(152, 49);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(142)))), ((int)(((byte)(121)))));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptar.Location = new System.Drawing.Point(39, 548);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(152, 49);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(76)))), ((int)(((byte)(87)))));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(39, 605);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 49);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImagenes
            // 
            this.btnImagenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnImagenes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImagenes.Location = new System.Drawing.Point(39, 435);
            this.btnImagenes.Name = "btnImagenes";
            this.btnImagenes.Size = new System.Drawing.Size(152, 49);
            this.btnImagenes.TabIndex = 19;
            this.btnImagenes.Text = "Imagenes";
            this.btnImagenes.UseVisualStyleBackColor = false;
            this.btnImagenes.Click += new System.EventHandler(this.btnImagenes_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.Location = new System.Drawing.Point(231, 695);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(220, 49);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(115)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(616, 749);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnImagenes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.btnImagSig);
            this.Controls.Add(this.btnImagPrevia);
            this.Controls.Add(this.pbImagenes);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblImagenes);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(638, 805);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(638, 758);
            this.Name = "frmDetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Articulo";
            this.Load += new System.EventHandler(this.frmDetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblImagenes;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.PictureBox pbImagenes;
        private System.Windows.Forms.Button btnImagPrevia;
        private System.Windows.Forms.Button btnImagSig;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImagenes;
        private System.Windows.Forms.Button btnCerrar;
    }
}