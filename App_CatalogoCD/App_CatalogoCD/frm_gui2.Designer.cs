namespace App_CatalogoCD
{
    partial class frm_gui2
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
            this.btnOpcion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbxDVD = new System.Windows.Forms.ListBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCompania = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.tbxArtista = new System.Windows.Forms.TextBox();
            this.tbxPais = new System.Windows.Forms.TextBox();
            this.tbxCompania = new System.Windows.Forms.TextBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.tbxAnio = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lbxCatalogo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOpcion
            // 
            this.btnOpcion.Location = new System.Drawing.Point(235, 12);
            this.btnOpcion.Name = "btnOpcion";
            this.btnOpcion.Size = new System.Drawing.Size(81, 47);
            this.btnOpcion.TabIndex = 5;
            this.btnOpcion.Text = "Seleccionar opción";
            this.btnOpcion.UseVisualStyleBackColor = true;
            this.btnOpcion.Click += new System.EventHandler(this.btnOpcion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(235, 65);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 42);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lbxDVD
            // 
            this.lbxDVD.FormattingEnabled = true;
            this.lbxDVD.Items.AddRange(new object[] {
            "1 - Mostrar los DVD",
            "2 - Mostrar los DVD en XML",
            "3 - Insertar un DVD con datos al azar",
            "4 - Eliminar un DVD",
            "5 - Modificar un DVD",
            "6 - Volcar XML a fichero",
            "7 - Listar DVD por país"});
            this.lbxDVD.Location = new System.Drawing.Point(12, 12);
            this.lbxDVD.Name = "lbxDVD";
            this.lbxDVD.Size = new System.Drawing.Size(217, 95);
            this.lbxDVD.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 127);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 154);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Título";
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Location = new System.Drawing.Point(12, 181);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(36, 13);
            this.lblArtista.TabIndex = 8;
            this.lblArtista.Text = "Artista";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(12, 208);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 9;
            this.lblPais.Text = "País";
            // 
            // lblCompania
            // 
            this.lblCompania.AutoSize = true;
            this.lblCompania.Location = new System.Drawing.Point(12, 235);
            this.lblCompania.Name = "lblCompania";
            this.lblCompania.Size = new System.Drawing.Size(56, 13);
            this.lblCompania.TabIndex = 10;
            this.lblCompania.Text = "Compañía";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 262);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(12, 289);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 12;
            this.lblAnio.Text = "Año";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(79, 120);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(227, 20);
            this.tbxCodigo.TabIndex = 13;
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(79, 148);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(227, 20);
            this.tbxTitulo.TabIndex = 14;
            // 
            // tbxArtista
            // 
            this.tbxArtista.Location = new System.Drawing.Point(79, 176);
            this.tbxArtista.Name = "tbxArtista";
            this.tbxArtista.Size = new System.Drawing.Size(227, 20);
            this.tbxArtista.TabIndex = 15;
            // 
            // tbxPais
            // 
            this.tbxPais.Location = new System.Drawing.Point(79, 204);
            this.tbxPais.Name = "tbxPais";
            this.tbxPais.Size = new System.Drawing.Size(227, 20);
            this.tbxPais.TabIndex = 16;
            // 
            // tbxCompania
            // 
            this.tbxCompania.Location = new System.Drawing.Point(79, 232);
            this.tbxCompania.Name = "tbxCompania";
            this.tbxCompania.Size = new System.Drawing.Size(227, 20);
            this.tbxCompania.TabIndex = 17;
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Location = new System.Drawing.Point(79, 260);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(227, 20);
            this.tbxPrecio.TabIndex = 18;
            // 
            // tbxAnio
            // 
            this.tbxAnio.Location = new System.Drawing.Point(79, 288);
            this.tbxAnio.Name = "tbxAnio";
            this.tbxAnio.Size = new System.Drawing.Size(227, 20);
            this.tbxAnio.TabIndex = 19;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoEllipsis = true;
            this.lblMensaje.Location = new System.Drawing.Point(12, 313);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(190, 45);
            this.lblMensaje.TabIndex = 20;
            this.lblMensaje.Text = "Mensaje de ayuda";
            this.lblMensaje.Visible = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(208, 313);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(98, 42);
            this.btnGenerar.TabIndex = 21;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Visible = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lbxCatalogo
            // 
            this.lbxCatalogo.FormattingEnabled = true;
            this.lbxCatalogo.Location = new System.Drawing.Point(337, 12);
            this.lbxCatalogo.Name = "lbxCatalogo";
            this.lbxCatalogo.Size = new System.Drawing.Size(165, 342);
            this.lbxCatalogo.TabIndex = 22;
            this.lbxCatalogo.Visible = false;
            this.lbxCatalogo.SelectedIndexChanged += new System.EventHandler(this.lbxCatalogo_SelectedIndexChanged);
            // 
            // frm_gui2
            // 
            this.AcceptButton = this.btnOpcion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(523, 367);
            this.Controls.Add(this.lbxCatalogo);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.tbxAnio);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.tbxCompania);
            this.Controls.Add(this.tbxPais);
            this.Controls.Add(this.tbxArtista);
            this.Controls.Add(this.tbxTitulo);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCompania);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnOpcion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbxDVD);
            this.Name = "frm_gui2";
            this.Text = "Catálogo de DVD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpcion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lbxDVD;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCompania;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.TextBox tbxArtista;
        private System.Windows.Forms.TextBox tbxPais;
        private System.Windows.Forms.TextBox tbxCompania;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.TextBox tbxAnio;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListBox lbxCatalogo;
    }
}