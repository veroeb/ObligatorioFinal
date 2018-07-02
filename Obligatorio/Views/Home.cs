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
    public partial class Home : Form
    {
        Comprador CompradorActual;
        Inmueble InmuebleActual;
        Inmobiliaria inmobiliaria = Inmobiliaria.GetInmobiliaria();
        LaunchScreen launchScreen = new LaunchScreen();
        ManejadorDeArchivos manejadorDeArchivos = new ManejadorDeArchivos();


        //ManejadorDeArchivos manejadorDeArchivos = new ManejadorDeArchivos();
        //List<Inmueble> ListaInmuebles { get; set; }

        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Hide();
            //NuevoInmueble nuevoInmueble = new NuevoInmueble();
            //nuevoInmueble.Show();
        }

        public void Filtro()
        {
            bool filtrarPorDepartamento = true;
            bool filtrarPorBarrio = true;
            bool filtrarPorGarage = true;

            //List<Inmueble> listaInmuebles = new List<Inmueble>();

            Inmobiliaria inmobiliaria = Inmobiliaria.GetInmobiliaria();

            List<Inmueble> listaInmuebles = new List<Inmueble>();
            listaInmuebles = inmobiliaria.GetListaInmuebles();

            foreach (Inmueble i in listaInmuebles)
            {
                if (filtrarPorDepartamento)
                    listaInmuebles = listaInmuebles.Where(x => x.Departamento == comboBoxDepartamento.SelectedItem.ToString()).ToList();
                if (filtrarPorBarrio)
                    listaInmuebles = listaInmuebles.Where(x => x.Barrio == comboBoxBarrio.SelectedItem.ToString()).ToList();
                if (filtrarPorGarage)
                    listaInmuebles = listaInmuebles.Where(x => x.Garages == Convert.ToInt32(comboBoxGarage.SelectedItem.ToString())).ToList();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //inmobiliaria.GetListaInmuebles();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Inmobiliaria.GetInmobiliaria().VenderAlquilar(InmuebleActual, CompradorActual);
            //ManagerInmuebles.VenderAlquilar(InmuebleActual, CompradorActual);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //ManagerInmuebles.
        }

        private void btnAgregarComprador_Click(object sender, EventArgs e)
        {
            Comprador comprador = new Comprador(txtNombreComprador.Text, txtCI.Text, txtCorreo.Text, txtNumero.Text);
            CompradorActual = comprador;
            Visita.AgregarComprador(CompradorActual);
            MessageBox.Show("Comprador actual actualizado y agendado");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVenderAlquilar_Click(object sender, EventArgs e)
        {
            InmuebleActual = (gridInmuebles.SelectedRows[0].DataBoundItem as Inmueble);
            Comprador comprador = new Comprador(txtNombreComprador.Text, txtCI.Text, txtCorreo.Text, txtNumero.Text);
            CompradorActual = comprador;
            ManagerInmuebles.VenderAlquilar(InmuebleActual, CompradorActual);
            MessageBox.Show("Propiedad vendida a " + CompradorActual.Nombre);
            gridInmuebles.DataSource = ManagerInmuebles.ListaInmuebles;
        }

        private void btnAgendarVisita_Click(object sender, EventArgs e)
        {
            InmuebleActual = (gridInmuebles.SelectedRows[0].DataBoundItem as Inmueble);
            ManagerRecursos.InmuebleComprador = InmuebleActual;
            Visita.AgendarVisita(CompradorActual, InmuebleActual);
            MessageBox.Show($"Visita Agendada correctamente del inmueble {InmuebleActual.Ubicacion} con comprador {CompradorActual.Nombre}");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            gridInmuebles.DataSource = null;
            List<Inmueble> inmuebles = inmobiliaria.GetListaInmuebles();
            gridInmuebles.DataSource = inmuebles;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Hide();
            launchScreen.Show();
        }

        private void txtNombreComprador_MouseEnter(object sender, EventArgs e)
        {
        }

        private void txtNombreComprador_Click(object sender, EventArgs e)
        {
            txtNombreComprador.Text = "";
        }

        private void txtCI_Click(object sender, EventArgs e)
        {
            txtCI.Text = "";
        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {
            txtCorreo.Text = "";
        }

        private void txtNumero_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMostrarFoto_Click(object sender, EventArgs e)
        {
            Inmueble seleccionado = gridInmuebles.SelectedRows[0].DataBoundItem as Inmueble;
            if (seleccionado.Fotos == null)
                MessageBox.Show("No existen imagenes para mostrar");
            else
                pbFotos.Load(seleccionado.Fotos[0]);
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            manejadorDeArchivos = new ManejadorDeArchivos();
            string path = $"{AppDomain.CurrentDomain.BaseDirectory}Listado de propiedades.txt";

            if (File.Exists(path))
            {
                ManagerInmuebles.ListaInmuebles = manejadorDeArchivos.InfoArchivo(path);
            }
        }
    }
}
