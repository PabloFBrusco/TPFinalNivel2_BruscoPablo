namespace Presentacion
{
    partial class frmArticulos
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
            this.gpbArticulos = new System.Windows.Forms.GroupBox();
            this.LblRCategoria = new System.Windows.Forms.Label();
            this.LblRMarca = new System.Windows.Forms.Label();
            this.LblRPrecio = new System.Windows.Forms.Label();
            this.LblRNombre = new System.Windows.Forms.Label();
            this.LblRCodigo = new System.Windows.Forms.Label();
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtLinkFoto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.txtFDescripcion = new System.Windows.Forms.TextBox();
            this.cboFDescripcion = new System.Windows.Forms.ComboBox();
            this.txtFCategoria = new System.Windows.Forms.TextBox();
            this.cboFCategoria = new System.Windows.Forms.ComboBox();
            this.txtFMarca = new System.Windows.Forms.TextBox();
            this.cboFMarca = new System.Windows.Forms.ComboBox();
            this.txtFPrecio = new System.Windows.Forms.TextBox();
            this.cboFPrecio = new System.Windows.Forms.ComboBox();
            this.txtFNombre = new System.Windows.Forms.TextBox();
            this.cboFNombre = new System.Windows.Forms.ComboBox();
            this.chkCategoria = new System.Windows.Forms.CheckBox();
            this.chkDescripcion = new System.Windows.Forms.CheckBox();
            this.chkPrecio = new System.Windows.Forms.CheckBox();
            this.chkMarca = new System.Windows.Forms.CheckBox();
            this.chkNombre = new System.Windows.Forms.CheckBox();
            this.txtFCodigo = new System.Windows.Forms.TextBox();
            this.cboFCodigo = new System.Windows.Forms.ComboBox();
            this.chkCodigo = new System.Windows.Forms.CheckBox();
            this.gpbBotones = new System.Windows.Forms.GroupBox();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.gpbArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.gpbFiltro.SuspendLayout();
            this.gpbBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(203, 33);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(763, 261);
            this.dgvArticulos.TabIndex = 2;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // gpbArticulos
            // 
            this.gpbArticulos.Controls.Add(this.LblRCategoria);
            this.gpbArticulos.Controls.Add(this.LblRMarca);
            this.gpbArticulos.Controls.Add(this.LblRPrecio);
            this.gpbArticulos.Controls.Add(this.LblRNombre);
            this.gpbArticulos.Controls.Add(this.LblRCodigo);
            this.gpbArticulos.Controls.Add(this.btnMarca);
            this.gpbArticulos.Controls.Add(this.btnCategoria);
            this.gpbArticulos.Controls.Add(this.btnCancelar);
            this.gpbArticulos.Controls.Add(this.btnAceptar);
            this.gpbArticulos.Controls.Add(this.btnLink);
            this.gpbArticulos.Controls.Add(this.cboMarca);
            this.gpbArticulos.Controls.Add(this.cboCategoria);
            this.gpbArticulos.Controls.Add(this.txtLinkFoto);
            this.gpbArticulos.Controls.Add(this.txtNombre);
            this.gpbArticulos.Controls.Add(this.txtDescripcion);
            this.gpbArticulos.Controls.Add(this.txtPrecio);
            this.gpbArticulos.Controls.Add(this.txtCodigo);
            this.gpbArticulos.Controls.Add(this.ptbFoto);
            this.gpbArticulos.Controls.Add(this.lblNombre);
            this.gpbArticulos.Controls.Add(this.lblDescripcion);
            this.gpbArticulos.Controls.Add(this.lblPrecio);
            this.gpbArticulos.Controls.Add(this.lblImagen);
            this.gpbArticulos.Controls.Add(this.lblCategoria);
            this.gpbArticulos.Controls.Add(this.lblMarca);
            this.gpbArticulos.Controls.Add(this.lblCodigo);
            this.gpbArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbArticulos.Location = new System.Drawing.Point(203, 306);
            this.gpbArticulos.Name = "gpbArticulos";
            this.gpbArticulos.Size = new System.Drawing.Size(763, 221);
            this.gpbArticulos.TabIndex = 1;
            this.gpbArticulos.TabStop = false;
            this.gpbArticulos.Text = "Artículo Seleccionado:";
            // 
            // LblRCategoria
            // 
            this.LblRCategoria.Location = new System.Drawing.Point(269, 160);
            this.LblRCategoria.Name = "LblRCategoria";
            this.LblRCategoria.Size = new System.Drawing.Size(17, 15);
            this.LblRCategoria.TabIndex = 25;
            this.LblRCategoria.Text = "*";
            // 
            // LblRMarca
            // 
            this.LblRMarca.Location = new System.Drawing.Point(269, 191);
            this.LblRMarca.Name = "LblRMarca";
            this.LblRMarca.Size = new System.Drawing.Size(17, 15);
            this.LblRMarca.TabIndex = 24;
            this.LblRMarca.Text = "*";
            // 
            // LblRPrecio
            // 
            this.LblRPrecio.Location = new System.Drawing.Point(249, 102);
            this.LblRPrecio.Name = "LblRPrecio";
            this.LblRPrecio.Size = new System.Drawing.Size(17, 15);
            this.LblRPrecio.TabIndex = 23;
            this.LblRPrecio.Text = "*";
            // 
            // LblRNombre
            // 
            this.LblRNombre.Location = new System.Drawing.Point(404, 50);
            this.LblRNombre.Name = "LblRNombre";
            this.LblRNombre.Size = new System.Drawing.Size(17, 15);
            this.LblRNombre.TabIndex = 22;
            this.LblRNombre.Text = "*";
            // 
            // LblRCodigo
            // 
            this.LblRCodigo.Location = new System.Drawing.Point(247, 24);
            this.LblRCodigo.Name = "LblRCodigo";
            this.LblRCodigo.Size = new System.Drawing.Size(17, 15);
            this.LblRCodigo.TabIndex = 21;
            this.LblRCodigo.Text = "*";
            // 
            // btnMarca
            // 
            this.btnMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarca.Location = new System.Drawing.Point(246, 186);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(20, 20);
            this.btnMarca.TabIndex = 20;
            this.btnMarca.Text = "+";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(246, 159);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(21, 19);
            this.btnCategoria.TabIndex = 19;
            this.btnCategoria.Text = "+";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(649, 185);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(649, 151);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 28);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Ace&ptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLink
            // 
            this.btnLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink.Location = new System.Drawing.Point(400, 128);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(20, 20);
            this.btnLink.TabIndex = 16;
            this.btnLink.Text = "+";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(97, 185);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(146, 23);
            this.cboMarca.TabIndex = 6;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(98, 156);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(144, 23);
            this.cboCategoria.TabIndex = 5;
            // 
            // txtLinkFoto
            // 
            this.txtLinkFoto.Location = new System.Drawing.Point(97, 127);
            this.txtLinkFoto.MaxLength = 500;
            this.txtLinkFoto.Name = "txtLinkFoto";
            this.txtLinkFoto.Size = new System.Drawing.Size(301, 21);
            this.txtLinkFoto.TabIndex = 4;
            this.txtLinkFoto.Leave += new System.EventHandler(this.txtLinkFoto_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 47);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(301, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(97, 73);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(301, 21);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(97, 99);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(146, 21);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(97, 21);
            this.txtCodigo.MaxLength = 15;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(146, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // ptbFoto
            // 
            this.ptbFoto.Location = new System.Drawing.Point(432, 20);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(211, 194);
            this.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFoto.TabIndex = 8;
            this.ptbFoto.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 49);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 15);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(8, 76);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(3);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 15);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(9, 100);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(3);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 15);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(8, 130);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(3);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(70, 15);
            this.lblImagen.TabIndex = 4;
            this.lblImagen.Text = "Link Foto:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(8, 160);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(3);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(73, 15);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(8, 188);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(3);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 15);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(8, 23);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(3);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Location = new System.Drawing.Point(198, 9);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(69, 13);
            this.lblFiltroRapido.TabIndex = 2;
            this.lblFiltroRapido.Text = "Filtro Rápido:";
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Location = new System.Drawing.Point(272, 6);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(236, 20);
            this.txtFiltroRapido.TabIndex = 1;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.txtFiltroRapido_TextChanged);
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.btnLimpiar);
            this.gpbFiltro.Controls.Add(this.btnfiltrar);
            this.gpbFiltro.Controls.Add(this.txtFDescripcion);
            this.gpbFiltro.Controls.Add(this.cboFDescripcion);
            this.gpbFiltro.Controls.Add(this.txtFCategoria);
            this.gpbFiltro.Controls.Add(this.cboFCategoria);
            this.gpbFiltro.Controls.Add(this.txtFMarca);
            this.gpbFiltro.Controls.Add(this.cboFMarca);
            this.gpbFiltro.Controls.Add(this.txtFPrecio);
            this.gpbFiltro.Controls.Add(this.cboFPrecio);
            this.gpbFiltro.Controls.Add(this.txtFNombre);
            this.gpbFiltro.Controls.Add(this.cboFNombre);
            this.gpbFiltro.Controls.Add(this.chkCategoria);
            this.gpbFiltro.Controls.Add(this.chkDescripcion);
            this.gpbFiltro.Controls.Add(this.chkPrecio);
            this.gpbFiltro.Controls.Add(this.chkMarca);
            this.gpbFiltro.Controls.Add(this.chkNombre);
            this.gpbFiltro.Controls.Add(this.txtFCodigo);
            this.gpbFiltro.Controls.Add(this.cboFCodigo);
            this.gpbFiltro.Controls.Add(this.chkCodigo);
            this.gpbFiltro.Location = new System.Drawing.Point(970, 33);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(377, 261);
            this.gpbFiltro.TabIndex = 4;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtrar Grilla:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(225, 205);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(143, 34);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar Filtros";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(10, 205);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(143, 34);
            this.btnfiltrar.TabIndex = 18;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // txtFDescripcion
            // 
            this.txtFDescripcion.Location = new System.Drawing.Point(214, 72);
            this.txtFDescripcion.Name = "txtFDescripcion";
            this.txtFDescripcion.Size = new System.Drawing.Size(154, 20);
            this.txtFDescripcion.TabIndex = 17;
            // 
            // cboFDescripcion
            // 
            this.cboFDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFDescripcion.FormattingEnabled = true;
            this.cboFDescripcion.Location = new System.Drawing.Point(90, 71);
            this.cboFDescripcion.Name = "cboFDescripcion";
            this.cboFDescripcion.Size = new System.Drawing.Size(118, 21);
            this.cboFDescripcion.TabIndex = 16;
            // 
            // txtFCategoria
            // 
            this.txtFCategoria.Location = new System.Drawing.Point(214, 151);
            this.txtFCategoria.Name = "txtFCategoria";
            this.txtFCategoria.Size = new System.Drawing.Size(154, 20);
            this.txtFCategoria.TabIndex = 15;
            // 
            // cboFCategoria
            // 
            this.cboFCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFCategoria.FormattingEnabled = true;
            this.cboFCategoria.Location = new System.Drawing.Point(90, 150);
            this.cboFCategoria.Name = "cboFCategoria";
            this.cboFCategoria.Size = new System.Drawing.Size(118, 21);
            this.cboFCategoria.TabIndex = 14;
            // 
            // txtFMarca
            // 
            this.txtFMarca.Location = new System.Drawing.Point(214, 125);
            this.txtFMarca.Name = "txtFMarca";
            this.txtFMarca.Size = new System.Drawing.Size(154, 20);
            this.txtFMarca.TabIndex = 13;
            // 
            // cboFMarca
            // 
            this.cboFMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFMarca.FormattingEnabled = true;
            this.cboFMarca.Location = new System.Drawing.Point(90, 124);
            this.cboFMarca.Name = "cboFMarca";
            this.cboFMarca.Size = new System.Drawing.Size(118, 21);
            this.cboFMarca.TabIndex = 12;
            // 
            // txtFPrecio
            // 
            this.txtFPrecio.Location = new System.Drawing.Point(214, 99);
            this.txtFPrecio.Name = "txtFPrecio";
            this.txtFPrecio.Size = new System.Drawing.Size(154, 20);
            this.txtFPrecio.TabIndex = 11;
            // 
            // cboFPrecio
            // 
            this.cboFPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFPrecio.FormattingEnabled = true;
            this.cboFPrecio.Location = new System.Drawing.Point(90, 98);
            this.cboFPrecio.Name = "cboFPrecio";
            this.cboFPrecio.Size = new System.Drawing.Size(118, 21);
            this.cboFPrecio.TabIndex = 10;
            // 
            // txtFNombre
            // 
            this.txtFNombre.Location = new System.Drawing.Point(214, 46);
            this.txtFNombre.Name = "txtFNombre";
            this.txtFNombre.Size = new System.Drawing.Size(154, 20);
            this.txtFNombre.TabIndex = 9;
            // 
            // cboFNombre
            // 
            this.cboFNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFNombre.FormattingEnabled = true;
            this.cboFNombre.Location = new System.Drawing.Point(90, 45);
            this.cboFNombre.Name = "cboFNombre";
            this.cboFNombre.Size = new System.Drawing.Size(118, 21);
            this.cboFNombre.TabIndex = 8;
            // 
            // chkCategoria
            // 
            this.chkCategoria.AutoSize = true;
            this.chkCategoria.Location = new System.Drawing.Point(10, 152);
            this.chkCategoria.Name = "chkCategoria";
            this.chkCategoria.Size = new System.Drawing.Size(73, 17);
            this.chkCategoria.TabIndex = 7;
            this.chkCategoria.Text = "Categoría";
            this.chkCategoria.UseVisualStyleBackColor = true;
            this.chkCategoria.CheckedChanged += new System.EventHandler(this.chkCategoria_CheckedChanged);
            // 
            // chkDescripcion
            // 
            this.chkDescripcion.AutoSize = true;
            this.chkDescripcion.Location = new System.Drawing.Point(10, 73);
            this.chkDescripcion.Name = "chkDescripcion";
            this.chkDescripcion.Size = new System.Drawing.Size(82, 17);
            this.chkDescripcion.TabIndex = 6;
            this.chkDescripcion.Text = "Descripción";
            this.chkDescripcion.UseVisualStyleBackColor = true;
            this.chkDescripcion.CheckedChanged += new System.EventHandler(this.chkDescripcion_CheckedChanged);
            // 
            // chkPrecio
            // 
            this.chkPrecio.AutoSize = true;
            this.chkPrecio.Location = new System.Drawing.Point(10, 100);
            this.chkPrecio.Name = "chkPrecio";
            this.chkPrecio.Size = new System.Drawing.Size(56, 17);
            this.chkPrecio.TabIndex = 5;
            this.chkPrecio.Text = "Precio";
            this.chkPrecio.UseVisualStyleBackColor = true;
            this.chkPrecio.CheckedChanged += new System.EventHandler(this.chkPrecio_CheckedChanged);
            // 
            // chkMarca
            // 
            this.chkMarca.AutoSize = true;
            this.chkMarca.Location = new System.Drawing.Point(10, 127);
            this.chkMarca.Name = "chkMarca";
            this.chkMarca.Size = new System.Drawing.Size(56, 17);
            this.chkMarca.TabIndex = 4;
            this.chkMarca.Text = "Marca";
            this.chkMarca.UseVisualStyleBackColor = true;
            this.chkMarca.CheckedChanged += new System.EventHandler(this.chkMarca_CheckedChanged);
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Location = new System.Drawing.Point(10, 47);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(63, 17);
            this.chkNombre.TabIndex = 3;
            this.chkNombre.Text = "Nombre";
            this.chkNombre.UseVisualStyleBackColor = true;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // txtFCodigo
            // 
            this.txtFCodigo.Location = new System.Drawing.Point(214, 20);
            this.txtFCodigo.Name = "txtFCodigo";
            this.txtFCodigo.Size = new System.Drawing.Size(154, 20);
            this.txtFCodigo.TabIndex = 2;
            // 
            // cboFCodigo
            // 
            this.cboFCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFCodigo.FormattingEnabled = true;
            this.cboFCodigo.Location = new System.Drawing.Point(90, 19);
            this.cboFCodigo.Name = "cboFCodigo";
            this.cboFCodigo.Size = new System.Drawing.Size(118, 21);
            this.cboFCodigo.TabIndex = 1;
            // 
            // chkCodigo
            // 
            this.chkCodigo.AutoSize = true;
            this.chkCodigo.Location = new System.Drawing.Point(10, 21);
            this.chkCodigo.Name = "chkCodigo";
            this.chkCodigo.Size = new System.Drawing.Size(59, 17);
            this.chkCodigo.TabIndex = 0;
            this.chkCodigo.Text = "Codigo";
            this.chkCodigo.UseVisualStyleBackColor = true;
            this.chkCodigo.CheckedChanged += new System.EventHandler(this.chkCodigo_CheckedChanged);
            // 
            // gpbBotones
            // 
            this.gpbBotones.BackColor = System.Drawing.Color.SteelBlue;
            this.gpbBotones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gpbBotones.Controls.Add(this.ptbLogo);
            this.gpbBotones.Controls.Add(this.btnModificar);
            this.gpbBotones.Controls.Add(this.btnEliminar);
            this.gpbBotones.Controls.Add(this.btnAgregar);
            this.gpbBotones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbBotones.Location = new System.Drawing.Point(0, -8);
            this.gpbBotones.Margin = new System.Windows.Forms.Padding(0);
            this.gpbBotones.Name = "gpbBotones";
            this.gpbBotones.Size = new System.Drawing.Size(197, 552);
            this.gpbBotones.TabIndex = 0;
            this.gpbBotones.TabStop = false;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Location = new System.Drawing.Point(2, 9);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(195, 188);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 11;
            this.ptbLogo.TabStop = false;
            this.ptbLogo.DoubleClick += new System.EventHandler(this.ptbLogo_DoubleClick);
            this.ptbLogo.MouseEnter += new System.EventHandler(this.ptbLogo_MouseEnter);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(4, 406);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(189, 63);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(4, 472);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(189, 63);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(4, 340);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(189, 63);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1351, 530);
            this.Controls.Add(this.gpbBotones);
            this.Controls.Add(this.gpbFiltro);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.gpbArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Artículos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.gpbArticulos.ResumeLayout(false);
            this.gpbArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.gpbBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.GroupBox gpbArticulos;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtLinkFoto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.GroupBox gpbBotones;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.TextBox txtFDescripcion;
        private System.Windows.Forms.ComboBox cboFDescripcion;
        private System.Windows.Forms.TextBox txtFCategoria;
        private System.Windows.Forms.ComboBox cboFCategoria;
        private System.Windows.Forms.TextBox txtFMarca;
        private System.Windows.Forms.ComboBox cboFMarca;
        private System.Windows.Forms.TextBox txtFPrecio;
        private System.Windows.Forms.ComboBox cboFPrecio;
        private System.Windows.Forms.TextBox txtFNombre;
        private System.Windows.Forms.ComboBox cboFNombre;
        private System.Windows.Forms.CheckBox chkCategoria;
        private System.Windows.Forms.CheckBox chkDescripcion;
        private System.Windows.Forms.CheckBox chkPrecio;
        private System.Windows.Forms.CheckBox chkMarca;
        private System.Windows.Forms.CheckBox chkNombre;
        private System.Windows.Forms.TextBox txtFCodigo;
        private System.Windows.Forms.ComboBox cboFCodigo;
        private System.Windows.Forms.CheckBox chkCodigo;
        private System.Windows.Forms.Label LblRCategoria;
        private System.Windows.Forms.Label LblRMarca;
        private System.Windows.Forms.Label LblRPrecio;
        private System.Windows.Forms.Label LblRNombre;
        private System.Windows.Forms.Label LblRCodigo;
    }
}