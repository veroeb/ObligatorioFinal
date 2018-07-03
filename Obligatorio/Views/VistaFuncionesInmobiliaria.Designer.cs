namespace Obligatorio.Views
{
    partial class VistaFuncionesInmobiliaria
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.lbFiltros = new System.Windows.Forms.ListBox();
            this.gridInmuebles = new System.Windows.Forms.DataGridView();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.btnInmuebles = new System.Windows.Forms.Button();
            this.lbCompradores = new System.Windows.Forms.ListBox();
            this.btnCompradores = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridInmuebles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(68, -21);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(96, 21);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Ir atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // lbFiltros
            // 
            this.lbFiltros.FormattingEnabled = true;
            this.lbFiltros.Location = new System.Drawing.Point(65, 407);
            this.lbFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.lbFiltros.Name = "lbFiltros";
            this.lbFiltros.Size = new System.Drawing.Size(664, 108);
            this.lbFiltros.TabIndex = 10;
            // 
            // gridInmuebles
            // 
            this.gridInmuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInmuebles.Location = new System.Drawing.Point(65, 129);
            this.gridInmuebles.Margin = new System.Windows.Forms.Padding(2);
            this.gridInmuebles.Name = "gridInmuebles";
            this.gridInmuebles.RowTemplate.Height = 33;
            this.gridInmuebles.Size = new System.Drawing.Size(662, 189);
            this.gridInmuebles.TabIndex = 9;
            // 
            // btnFiltros
            // 
            this.btnFiltros.Location = new System.Drawing.Point(65, 356);
            this.btnFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(96, 31);
            this.btnFiltros.TabIndex = 8;
            this.btnFiltros.Text = "Ver lista de filtros";
            this.btnFiltros.UseVisualStyleBackColor = true;
            this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            // 
            // btnInmuebles
            // 
            this.btnInmuebles.Location = new System.Drawing.Point(65, 72);
            this.btnInmuebles.Margin = new System.Windows.Forms.Padding(2);
            this.btnInmuebles.Name = "btnInmuebles";
            this.btnInmuebles.Size = new System.Drawing.Size(96, 31);
            this.btnInmuebles.TabIndex = 7;
            this.btnInmuebles.Text = "Ver Inmuebles";
            this.btnInmuebles.UseVisualStyleBackColor = true;
            this.btnInmuebles.Click += new System.EventHandler(this.btnInmuebles_Click);
            // 
            // lbCompradores
            // 
            this.lbCompradores.FormattingEnabled = true;
            this.lbCompradores.Location = new System.Drawing.Point(65, 611);
            this.lbCompradores.Margin = new System.Windows.Forms.Padding(2);
            this.lbCompradores.Name = "lbCompradores";
            this.lbCompradores.Size = new System.Drawing.Size(664, 108);
            this.lbCompradores.TabIndex = 13;
            // 
            // btnCompradores
            // 
            this.btnCompradores.Location = new System.Drawing.Point(65, 557);
            this.btnCompradores.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompradores.Name = "btnCompradores";
            this.btnCompradores.Size = new System.Drawing.Size(152, 31);
            this.btnCompradores.TabIndex = 12;
            this.btnCompradores.Text = "Ver compradores ordenados alfabeticamente";
            this.btnCompradores.UseVisualStyleBackColor = true;
            this.btnCompradores.Click += new System.EventHandler(this.btnCompradores_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 21);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ir atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VistaFuncionesInmobiliaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbCompradores);
            this.Controls.Add(this.btnCompradores);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lbFiltros);
            this.Controls.Add(this.gridInmuebles);
            this.Controls.Add(this.btnFiltros);
            this.Controls.Add(this.btnInmuebles);
            this.Name = "VistaFuncionesInmobiliaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaFuncionesInmobiliaria";
            ((System.ComponentModel.ISupportInitialize)(this.gridInmuebles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ListBox lbFiltros;
        private System.Windows.Forms.DataGridView gridInmuebles;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.Button btnInmuebles;
        private System.Windows.Forms.ListBox lbCompradores;
        private System.Windows.Forms.Button btnCompradores;
        private System.Windows.Forms.Button button1;
    }
}