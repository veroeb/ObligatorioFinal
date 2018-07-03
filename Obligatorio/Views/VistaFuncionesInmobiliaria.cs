using Obligatorio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio.Views
{
    public partial class VistaFuncionesInmobiliaria : Form
    {
        Inmobiliaria inmobiliaria = Inmobiliaria.GetInmobiliaria();

        public VistaFuncionesInmobiliaria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            home.Show();
        }

        private void btnInmuebles_Click(object sender, EventArgs e)
        {
            ///Se listan los inmuebles
            gridInmuebles.DataSource = null;
            List<Inmueble> inmuebles = inmobiliaria.GetListaInmuebles();
            gridInmuebles.DataSource = inmuebles;
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {

        }

        private void btnCompradores_Click(object sender, EventArgs e)
        {
            ///Se listan los compradores creados alfabeticamente
            List<Comprador> compradores = inmobiliaria.ListaCompradoresAlfabeticamente();
            foreach (Comprador c in compradores)
            {
                lbCompradores.Items.Add(c.Nombre);
            }
        }
    }
}
