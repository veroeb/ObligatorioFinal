using Obligatorio.Models;
using Obligatorio.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio.Views
{
    public partial class LaunchScreen : Form
    {
        ManejadorDeArchivos manejadorDeArchivos = new ManejadorDeArchivos();
        NuevoInmueble nuevoInmueble = new NuevoInmueble();
        public LaunchScreen()
        {
            InitializeComponent();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            using (Home Home = new Home())
            {
                Home.ShowDialog();
            }
        }

        private void btnInmueble_Click(object sender, EventArgs e)
        {
            Hide();
            nuevoInmueble.Show();
        }

        private void LaunchScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LaunchScreen_Load(object sender, EventArgs e)
        {
            
        }
    }
}
