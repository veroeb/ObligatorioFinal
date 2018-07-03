namespace Obligatorio.Views
{
    partial class NuevaCasa
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
            this.lbl = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDireccionPropietario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblApartamento = new System.Windows.Forms.Label();
            this.cbJardin = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cbParrillero = new System.Windows.Forms.ComboBox();
            this.cbGarages = new System.Windows.Forms.ComboBox();
            this.cbBaños = new System.Windows.Forms.ComboBox();
            this.cbDormitorios = new System.Windows.Forms.ComboBox();
            this.cbHabitaciones = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnAgregarFotos = new System.Windows.Forms.Button();
            this.pbFoto1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtGastos = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAñoConstruccion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ImagesFile = new System.Windows.Forms.OpenFileDialog();
            this.lbFotos = new System.Windows.Forms.ListBox();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(92, 508);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(75, 25);
            this.lbl.TabIndex = 89;
            this.lbl.Text = "Barrio:";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.Location = new System.Drawing.Point(56, 35);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(192, 44);
            this.btnHome.TabIndex = 85;
            this.btnHome.Text = "< Ir a Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Items.AddRange(new object[] {
            "Ciudad de la Costa",
            "Colonia del Sacramento",
            "Las Piedras",
            "Maldonado",
            "Montevideo",
            "Pando",
            "Piriapolis",
            "Punta del Este"});
            this.cbCiudad.Location = new System.Drawing.Point(316, 444);
            this.cbCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(198, 33);
            this.cbCiudad.TabIndex = 3;
            this.cbCiudad.SelectedIndexChanged += new System.EventHandler(this.cbCiudad_SelectedIndexChanged);
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Items.AddRange(new object[] {
            "Canelones",
            "Colonia",
            "Maldonado",
            "Montevideo"});
            this.cbDepartamento.Location = new System.Drawing.Point(316, 385);
            this.cbDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(198, 33);
            this.cbDepartamento.TabIndex = 2;
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbDepartamento_SelectedIndexChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(928, 627);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(198, 31);
            this.txtTelefono.TabIndex = 20;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(754, 629);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 81;
            this.label10.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(928, 567);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(198, 31);
            this.txtCorreo.TabIndex = 19;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(754, 569);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 25);
            this.label11.TabIndex = 79;
            this.label11.Text = "Correo:";
            // 
            // txtDireccionPropietario
            // 
            this.txtDireccionPropietario.Location = new System.Drawing.Point(928, 504);
            this.txtDireccionPropietario.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionPropietario.Name = "txtDireccionPropietario";
            this.txtDireccionPropietario.Size = new System.Drawing.Size(198, 31);
            this.txtDireccionPropietario.TabIndex = 18;
            this.txtDireccionPropietario.TextChanged += new System.EventHandler(this.txtDireccionPropietario_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(754, 508);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "Direccion:";
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(928, 444);
            this.txtCI.Margin = new System.Windows.Forms.Padding(4);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(198, 31);
            this.txtCI.TabIndex = 17;
            this.txtCI.TextChanged += new System.EventHandler(this.txtCI_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(754, 448);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 25);
            this.label7.TabIndex = 75;
            this.label7.Text = "CI:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(928, 385);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 31);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(754, 388);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 73;
            this.label8.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(750, 302);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(394, 42);
            this.label9.TabIndex = 72;
            this.label9.Text = "Datos del propietario:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(316, 569);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(198, 31);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 573);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 70;
            this.label5.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 448);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "Ciudad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 388);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(88, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 42);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ubicacion del inmueble:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(314, 198);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(198, 31);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Precio U$S:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPrecio.Location = new System.Drawing.Point(88, 115);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(130, 42);
            this.lblPrecio.TabIndex = 64;
            this.lblPrecio.Text = "Precio";
            // 
            // lblApartamento
            // 
            this.lblApartamento.AutoSize = true;
            this.lblApartamento.Location = new System.Drawing.Point(936, 48);
            this.lblApartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApartamento.Name = "lblApartamento";
            this.lblApartamento.Size = new System.Drawing.Size(173, 25);
            this.lblApartamento.TabIndex = 63;
            this.lblApartamento.Text = "Inmueble > Casa";
            // 
            // cbJardin
            // 
            this.cbJardin.FormattingEnabled = true;
            this.cbJardin.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbJardin.Location = new System.Drawing.Point(314, 1304);
            this.cbJardin.Margin = new System.Windows.Forms.Padding(4);
            this.cbJardin.Name = "cbJardin";
            this.cbJardin.Size = new System.Drawing.Size(198, 33);
            this.cbJardin.TabIndex = 14;
            this.cbJardin.SelectedIndexChanged += new System.EventHandler(this.cbJardin_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(98, 1308);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 25);
            this.label25.TabIndex = 118;
            this.label25.Text = "Jardín:";
            // 
            // cbParrillero
            // 
            this.cbParrillero.FormattingEnabled = true;
            this.cbParrillero.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbParrillero.Location = new System.Drawing.Point(314, 1244);
            this.cbParrillero.Margin = new System.Windows.Forms.Padding(4);
            this.cbParrillero.Name = "cbParrillero";
            this.cbParrillero.Size = new System.Drawing.Size(198, 33);
            this.cbParrillero.TabIndex = 13;
            this.cbParrillero.SelectedIndexChanged += new System.EventHandler(this.cbParrillero_SelectedIndexChanged);
            // 
            // cbGarages
            // 
            this.cbGarages.FormattingEnabled = true;
            this.cbGarages.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbGarages.Location = new System.Drawing.Point(314, 1185);
            this.cbGarages.Margin = new System.Windows.Forms.Padding(4);
            this.cbGarages.Name = "cbGarages";
            this.cbGarages.Size = new System.Drawing.Size(198, 33);
            this.cbGarages.TabIndex = 12;
            this.cbGarages.SelectedIndexChanged += new System.EventHandler(this.cbGarages_SelectedIndexChanged);
            // 
            // cbBaños
            // 
            this.cbBaños.FormattingEnabled = true;
            this.cbBaños.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbBaños.Location = new System.Drawing.Point(314, 1125);
            this.cbBaños.Margin = new System.Windows.Forms.Padding(4);
            this.cbBaños.Name = "cbBaños";
            this.cbBaños.Size = new System.Drawing.Size(198, 33);
            this.cbBaños.TabIndex = 11;
            this.cbBaños.SelectedIndexChanged += new System.EventHandler(this.cbBaños_SelectedIndexChanged);
            // 
            // cbDormitorios
            // 
            this.cbDormitorios.FormattingEnabled = true;
            this.cbDormitorios.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbDormitorios.Location = new System.Drawing.Point(314, 1063);
            this.cbDormitorios.Margin = new System.Windows.Forms.Padding(4);
            this.cbDormitorios.Name = "cbDormitorios";
            this.cbDormitorios.Size = new System.Drawing.Size(198, 33);
            this.cbDormitorios.TabIndex = 10;
            this.cbDormitorios.SelectedIndexChanged += new System.EventHandler(this.cbDormitorios_SelectedIndexChanged);
            // 
            // cbHabitaciones
            // 
            this.cbHabitaciones.FormattingEnabled = true;
            this.cbHabitaciones.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbHabitaciones.Location = new System.Drawing.Point(316, 1004);
            this.cbHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.cbHabitaciones.Name = "cbHabitaciones";
            this.cbHabitaciones.Size = new System.Drawing.Size(198, 33);
            this.cbHabitaciones.TabIndex = 9;
            this.cbHabitaciones.SelectedIndexChanged += new System.EventHandler(this.cbHabitaciones_SelectedIndexChanged);
            // 
            // cbEstado
            // 
            this.cbEstado.Items.AddRange(new object[] {
            "A estrenar",
            "Buen estado",
            "Mal estado",
            "Reciclado"});
            this.cbEstado.Location = new System.Drawing.Point(316, 821);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(198, 33);
            this.cbEstado.TabIndex = 6;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnContinuar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContinuar.Location = new System.Drawing.Point(512, 1437);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(220, 63);
            this.btnContinuar.TabIndex = 23;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnAgregarFotos
            // 
            this.btnAgregarFotos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarFotos.Location = new System.Drawing.Point(960, 1304);
            this.btnAgregarFotos.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarFotos.Name = "btnAgregarFotos";
            this.btnAgregarFotos.Size = new System.Drawing.Size(166, 44);
            this.btnAgregarFotos.TabIndex = 22;
            this.btnAgregarFotos.Text = "Agregar fotos";
            this.btnAgregarFotos.UseVisualStyleBackColor = true;
            this.btnAgregarFotos.Click += new System.EventHandler(this.btnAgregarFotos_Click);
            // 
            // pbFoto1
            // 
            this.pbFoto1.Location = new System.Drawing.Point(760, 1240);
            this.pbFoto1.Margin = new System.Windows.Forms.Padding(4);
            this.pbFoto1.Name = "pbFoto1";
            this.pbFoto1.Size = new System.Drawing.Size(166, 154);
            this.pbFoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto1.TabIndex = 108;
            this.pbFoto1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(754, 1065);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 25);
            this.label18.TabIndex = 107;
            this.label18.Text = "Fotos:";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(760, 862);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(4);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(368, 169);
            this.txtComentarios.TabIndex = 21;
            this.txtComentarios.TextChanged += new System.EventHandler(this.txtComentarios_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(754, 821);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(139, 25);
            this.label26.TabIndex = 105;
            this.label26.Text = "Comentarios:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.SteelBlue;
            this.label27.Location = new System.Drawing.Point(750, 738);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(141, 42);
            this.label27.TabIndex = 104;
            this.label27.Text = "Extras:";
            // 
            // txtGastos
            // 
            this.txtGastos.Location = new System.Drawing.Point(316, 1363);
            this.txtGastos.Margin = new System.Windows.Forms.Padding(4);
            this.txtGastos.Name = "txtGastos";
            this.txtGastos.Size = new System.Drawing.Size(198, 31);
            this.txtGastos.TabIndex = 15;
            this.txtGastos.TextChanged += new System.EventHandler(this.txtGastos_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(100, 1369);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(197, 25);
            this.label19.TabIndex = 102;
            this.label19.Text = "Gastos comunes $:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(98, 1248);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 25);
            this.label20.TabIndex = 101;
            this.label20.Text = "Parrillero:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(98, 1188);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 25);
            this.label21.TabIndex = 100;
            this.label21.Text = "Garages:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(98, 1131);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 25);
            this.label22.TabIndex = 99;
            this.label22.Text = "Baños:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 1065);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 25);
            this.label12.TabIndex = 98;
            this.label12.Text = "Dormitorios:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(96, 1006);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 25);
            this.label13.TabIndex = 97;
            this.label13.Text = "Habitaciones:";
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Location = new System.Drawing.Point(316, 940);
            this.txtSuperficie.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(198, 31);
            this.txtSuperficie.TabIndex = 8;
            this.txtSuperficie.TextChanged += new System.EventHandler(this.txtSuperficie_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(96, 944);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 25);
            this.label14.TabIndex = 95;
            this.label14.Text = "Superficie m:";
            // 
            // txtAñoConstruccion
            // 
            this.txtAñoConstruccion.Location = new System.Drawing.Point(316, 881);
            this.txtAñoConstruccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtAñoConstruccion.Name = "txtAñoConstruccion";
            this.txtAñoConstruccion.Size = new System.Drawing.Size(198, 31);
            this.txtAñoConstruccion.TabIndex = 7;
            this.txtAñoConstruccion.TextChanged += new System.EventHandler(this.txtAñoConstruccion_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(96, 885);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(214, 25);
            this.label15.TabIndex = 93;
            this.label15.Text = "Año de construccion:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(96, 825);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 25);
            this.label16.TabIndex = 92;
            this.label16.Text = "Estado fisico:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.SteelBlue;
            this.label17.Location = new System.Drawing.Point(92, 738);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(470, 42);
            this.label17.TabIndex = 91;
            this.label17.Text = "Descripcion del inmueble:";
            // 
            // ImagesFile
            // 
            this.ImagesFile.FileName = "ImagesFile";
            this.ImagesFile.Filter = "Image Files(*.PNG;*.BMP;*.JPG;*.GIF)|*.PNG;*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // lbFotos
            // 
            this.lbFotos.FormattingEnabled = true;
            this.lbFotos.ItemHeight = 25;
            this.lbFotos.Location = new System.Drawing.Point(760, 1113);
            this.lbFotos.Margin = new System.Windows.Forms.Padding(4);
            this.lbFotos.Name = "lbFotos";
            this.lbFotos.Size = new System.Drawing.Size(368, 104);
            this.lbFotos.TabIndex = 120;
            this.lbFotos.SelectedIndexChanged += new System.EventHandler(this.lbFotos_SelectedIndexChanged);
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(316, 504);
            this.txtBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(198, 31);
            this.txtBarrio.TabIndex = 4;
            this.txtBarrio.TextChanged += new System.EventHandler(this.txtBarrio_TextChanged);
            // 
            // NuevaCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1256, 748);
            this.Controls.Add(this.txtBarrio);
            this.Controls.Add(this.lbFotos);
            this.Controls.Add(this.cbJardin);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cbParrillero);
            this.Controls.Add(this.cbGarages);
            this.Controls.Add(this.cbBaños);
            this.Controls.Add(this.cbDormitorios);
            this.Controls.Add(this.cbHabitaciones);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnAgregarFotos);
            this.Controls.Add(this.pbFoto1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtGastos);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtAñoConstruccion);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDireccionPropietario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblApartamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "NuevaCasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POP3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NuevaCasa_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDireccionPropietario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblApartamento;
        private System.Windows.Forms.ComboBox cbJardin;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbParrillero;
        private System.Windows.Forms.ComboBox cbGarages;
        private System.Windows.Forms.ComboBox cbBaños;
        private System.Windows.Forms.ComboBox cbDormitorios;
        private System.Windows.Forms.ComboBox cbHabitaciones;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnAgregarFotos;
        private System.Windows.Forms.PictureBox pbFoto1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtGastos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAñoConstruccion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.OpenFileDialog ImagesFile;
        private System.Windows.Forms.ListBox lbFotos;
        private System.Windows.Forms.TextBox txtBarrio;
    }
}