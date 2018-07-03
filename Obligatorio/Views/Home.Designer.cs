namespace Obligatorio.Views
{
    partial class Home
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
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarComprador = new System.Windows.Forms.Button();
            this.txtNombreComprador = new System.Windows.Forms.TextBox();
            this.btnVenderAlquilar = new System.Windows.Forms.Button();
            this.btnAgendarVisita = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.comboBoxGarage = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCasa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApartamento = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gridInmuebles = new System.Windows.Forms.DataGridView();
            this.pbFotos = new System.Windows.Forms.PictureBox();
            this.btnSiguienteFoto = new System.Windows.Forms.Button();
            this.btnAnteriorFoto = new System.Windows.Forms.Button();
            this.btnMostrarFoto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnInmobiliaria = new System.Windows.Forms.Button();
            this.lblNombreComprador = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInmuebles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(176, 150);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(163, 20);
            this.txtCI.TabIndex = 25;
            this.txtCI.Text = "Ci";
            this.txtCI.Click += new System.EventHandler(this.txtCI_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(176, 176);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(163, 20);
            this.txtCorreo.TabIndex = 24;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.Click += new System.EventHandler(this.txtCorreo_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(176, 200);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(163, 20);
            this.txtNumero.TabIndex = 23;
            this.txtNumero.Text = "Numero";
            this.txtNumero.Click += new System.EventHandler(this.txtNumero_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Iniciar sesion ";
            // 
            // btnAgregarComprador
            // 
            this.btnAgregarComprador.Location = new System.Drawing.Point(215, 226);
            this.btnAgregarComprador.Name = "btnAgregarComprador";
            this.btnAgregarComprador.Size = new System.Drawing.Size(83, 23);
            this.btnAgregarComprador.TabIndex = 21;
            this.btnAgregarComprador.Text = "Agregar";
            this.btnAgregarComprador.UseVisualStyleBackColor = true;
            this.btnAgregarComprador.Click += new System.EventHandler(this.btnAgregarComprador_Click);
            // 
            // txtNombreComprador
            // 
            this.txtNombreComprador.Location = new System.Drawing.Point(176, 124);
            this.txtNombreComprador.Name = "txtNombreComprador";
            this.txtNombreComprador.Size = new System.Drawing.Size(163, 20);
            this.txtNombreComprador.TabIndex = 20;
            this.txtNombreComprador.Text = "Nombre";
            this.txtNombreComprador.Click += new System.EventHandler(this.txtNombreComprador_Click);
            // 
            // btnVenderAlquilar
            // 
            this.btnVenderAlquilar.Location = new System.Drawing.Point(761, 17);
            this.btnVenderAlquilar.Name = "btnVenderAlquilar";
            this.btnVenderAlquilar.Size = new System.Drawing.Size(136, 40);
            this.btnVenderAlquilar.TabIndex = 19;
            this.btnVenderAlquilar.Text = "Vender o alquilar $";
            this.btnVenderAlquilar.UseVisualStyleBackColor = true;
            this.btnVenderAlquilar.Click += new System.EventHandler(this.btnVenderAlquilar_Click);
            // 
            // btnAgendarVisita
            // 
            this.btnAgendarVisita.Location = new System.Drawing.Point(761, 166);
            this.btnAgendarVisita.Name = "btnAgendarVisita";
            this.btnAgendarVisita.Size = new System.Drawing.Size(136, 40);
            this.btnAgendarVisita.TabIndex = 18;
            this.btnAgendarVisita.Text = "Agendar visita";
            this.btnAgendarVisita.UseVisualStyleBackColor = true;
            this.btnAgendarVisita.Click += new System.EventHandler(this.btnAgendarVisita_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(761, 63);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(136, 40);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar ๑";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(170, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 89);
            this.panel3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "POP 3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Obligatorio.Properties.Resources.realEstateWhite;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(170, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 12);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.lblNombreComprador);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.comboBoxGarage);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.comboBoxCiudad);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBoxDepartamento);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnCasa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnApartamento);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 488);
            this.panel1.TabIndex = 13;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(37, 26);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "<-- Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // comboBoxGarage
            // 
            this.comboBoxGarage.FormattingEnabled = true;
            this.comboBoxGarage.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.comboBoxGarage.Location = new System.Drawing.Point(66, 444);
            this.comboBoxGarage.Name = "comboBoxGarage";
            this.comboBoxGarage.Size = new System.Drawing.Size(92, 21);
            this.comboBoxGarage.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(-54, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 33);
            this.button3.TabIndex = 15;
            this.button3.Text = "Garage";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.Location = new System.Drawing.Point(66, 400);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(92, 21);
            this.comboBoxCiudad.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(-54, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ciudad";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxDepartamento
            // 
            this.comboBoxDepartamento.FormattingEnabled = true;
            this.comboBoxDepartamento.Location = new System.Drawing.Point(39, 353);
            this.comboBoxDepartamento.Name = "comboBoxDepartamento";
            this.comboBoxDepartamento.Size = new System.Drawing.Size(92, 21);
            this.comboBoxDepartamento.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(-3, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Departamento";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(58, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Otros";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.panel7.Location = new System.Drawing.Point(-2, 287);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(172, 32);
            this.panel7.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(33, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comprador";
            // 
            // btnCasa
            // 
            this.btnCasa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCasa.Location = new System.Drawing.Point(-6, 237);
            this.btnCasa.Name = "btnCasa";
            this.btnCasa.Size = new System.Drawing.Size(176, 33);
            this.btnCasa.TabIndex = 7;
            this.btnCasa.Text = "Casas";
            this.btnCasa.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(41, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inmueble";
            // 
            // btnApartamento
            // 
            this.btnApartamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnApartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApartamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnApartamento.Location = new System.Drawing.Point(-6, 198);
            this.btnApartamento.Name = "btnApartamento";
            this.btnApartamento.Size = new System.Drawing.Size(176, 33);
            this.btnApartamento.TabIndex = 6;
            this.btnApartamento.Text = "Apartamentos";
            this.btnApartamento.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 32);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.panel5.Location = new System.Drawing.Point(-1, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(176, 32);
            this.panel5.TabIndex = 4;
            // 
            // gridInmuebles
            // 
            this.gridInmuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInmuebles.GridColor = System.Drawing.SystemColors.Control;
            this.gridInmuebles.Location = new System.Drawing.Point(344, 17);
            this.gridInmuebles.Margin = new System.Windows.Forms.Padding(2);
            this.gridInmuebles.Name = "gridInmuebles";
            this.gridInmuebles.RowTemplate.Height = 33;
            this.gridInmuebles.Size = new System.Drawing.Size(388, 232);
            this.gridInmuebles.TabIndex = 26;
            // 
            // pbFotos
            // 
            this.pbFotos.Location = new System.Drawing.Point(440, 277);
            this.pbFotos.Name = "pbFotos";
            this.pbFotos.Size = new System.Drawing.Size(194, 194);
            this.pbFotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotos.TabIndex = 27;
            this.pbFotos.TabStop = false;
            // 
            // btnSiguienteFoto
            // 
            this.btnSiguienteFoto.Location = new System.Drawing.Point(657, 362);
            this.btnSiguienteFoto.Name = "btnSiguienteFoto";
            this.btnSiguienteFoto.Size = new System.Drawing.Size(92, 23);
            this.btnSiguienteFoto.TabIndex = 28;
            this.btnSiguienteFoto.Text = "Siguiente foto";
            this.btnSiguienteFoto.UseVisualStyleBackColor = true;
            this.btnSiguienteFoto.Click += new System.EventHandler(this.btnSiguienteFoto_Click);
            // 
            // btnAnteriorFoto
            // 
            this.btnAnteriorFoto.Location = new System.Drawing.Point(321, 362);
            this.btnAnteriorFoto.Name = "btnAnteriorFoto";
            this.btnAnteriorFoto.Size = new System.Drawing.Size(92, 23);
            this.btnAnteriorFoto.TabIndex = 29;
            this.btnAnteriorFoto.Text = "Anterior foto";
            this.btnAnteriorFoto.UseVisualStyleBackColor = true;
            this.btnAnteriorFoto.Click += new System.EventHandler(this.btnAnteriorFoto_Click);
            // 
            // btnMostrarFoto
            // 
            this.btnMostrarFoto.Location = new System.Drawing.Point(761, 211);
            this.btnMostrarFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarFoto.Name = "btnMostrarFoto";
            this.btnMostrarFoto.Size = new System.Drawing.Size(136, 40);
            this.btnMostrarFoto.TabIndex = 30;
            this.btnMostrarFoto.Text = "Mostrar foto";
            this.btnMostrarFoto.UseVisualStyleBackColor = true;
            this.btnMostrarFoto.Click += new System.EventHandler(this.btnMostrarFoto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(736, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Para agendar una visita ingrese una fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(737, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // btnInmobiliaria
            // 
            this.btnInmobiliaria.Location = new System.Drawing.Point(734, 435);
            this.btnInmobiliaria.Margin = new System.Windows.Forms.Padding(2);
            this.btnInmobiliaria.Name = "btnInmobiliaria";
            this.btnInmobiliaria.Size = new System.Drawing.Size(163, 36);
            this.btnInmobiliaria.TabIndex = 36;
            this.btnInmobiliaria.Text = "Ingresar a datos de la inmobiliaria";
            this.btnInmobiliaria.UseVisualStyleBackColor = true;
            this.btnInmobiliaria.Click += new System.EventHandler(this.btnInmobiliaria_Click);
            // 
            // lblNombreComprador
            // 
            this.lblNombreComprador.AutoSize = true;
            this.lblNombreComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreComprador.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreComprador.Location = new System.Drawing.Point(23, 101);
            this.lblNombreComprador.Name = "lblNombreComprador";
            this.lblNombreComprador.Size = new System.Drawing.Size(0, 20);
            this.lblNombreComprador.TabIndex = 37;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 488);
            this.Controls.Add(this.btnInmobiliaria);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMostrarFoto);
            this.Controls.Add(this.btnAnteriorFoto);
            this.Controls.Add(this.btnSiguienteFoto);
            this.Controls.Add(this.pbFotos);
            this.Controls.Add(this.gridInmuebles);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarComprador);
            this.Controls.Add(this.txtNombreComprador);
            this.Controls.Add(this.btnVenderAlquilar);
            this.Controls.Add(this.btnAgendarVisita);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POP3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInmuebles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarComprador;
        private System.Windows.Forms.TextBox txtNombreComprador;
        private System.Windows.Forms.Button btnVenderAlquilar;
        private System.Windows.Forms.Button btnAgendarVisita;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ComboBox comboBoxGarage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxCiudad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxDepartamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCasa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApartamento;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView gridInmuebles;
        private System.Windows.Forms.PictureBox pbFotos;
        private System.Windows.Forms.Button btnSiguienteFoto;
        private System.Windows.Forms.Button btnAnteriorFoto;
        private System.Windows.Forms.Button btnMostrarFoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnInmobiliaria;
        private System.Windows.Forms.Label lblNombreComprador;
    }
}