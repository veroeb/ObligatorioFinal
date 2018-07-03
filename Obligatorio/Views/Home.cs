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
        VistaFuncionesInmobiliaria vistaFuncionesInmobiliaria = new VistaFuncionesInmobiliaria();
                
        public Home()
        {
            InitializeComponent();
            
            ///Se agrega una lista de departamentos
            List<String> listaDepartamentos = new List<String>
            {
                "Canelones", "Colonia", "Maldonado", "Montevideo" 
            };

            comboBoxDepartamento.DataSource = listaDepartamentos;

            ///Se agrega una lista de ciudades
            List<String> listaCiudades = new List<String>
            {
                "Ciudad de la Costa", "Colonia del Sacramento", "Las Piedras", "Maldonado", "Montevideo", "Pando", "Piriapolis", "Punta del Este"
            };

            comboBoxCiudad.DataSource = listaCiudades;

        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
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
                    listaInmuebles = listaInmuebles.Where(x => x.Barrio == comboBoxCiudad.SelectedItem.ToString()).ToList();
                if (filtrarPorGarage)
                    listaInmuebles = listaInmuebles.Where(x => x.Garages == Convert.ToInt32(comboBoxGarage.SelectedItem.ToString())).ToList();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarComprador_Click(object sender, EventArgs e)
        {
            ///Se agrega un comprador a la lista de compradores
            Comprador comprador = new Comprador(txtNombreComprador.Text, txtCI.Text, txtCorreo.Text, txtNumero.Text);
            CompradorActual = comprador;
            Visita.AgregarComprador(CompradorActual);
            MessageBox.Show("Comprador actual actualizado y agendado");
            lblNombreComprador.Text = CompradorActual.Nombre;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVenderAlquilar_Click(object sender, EventArgs e)
        {
            ///Se vende o alquila el inmueble, por lo tanto se elimina de la lista de inmuebles
            InmuebleActual = (gridInmuebles.SelectedRows[0].DataBoundItem as Inmueble);
            Comprador comprador = new Comprador(txtNombreComprador.Text, txtCI.Text, txtCorreo.Text, txtNumero.Text);
            CompradorActual = comprador;
            ManagerInmuebles.VenderAlquilar(InmuebleActual, CompradorActual);
            MessageBox.Show("Propiedad vendida a " + CompradorActual.Nombre);
            gridInmuebles.DataSource = ManagerInmuebles.ListaInmuebles;
        }

        private void btnAgendarVisita_Click(object sender, EventArgs e)
        {
            ///Se agenda una visita para un dia en especifico
            InmuebleActual = (gridInmuebles.SelectedRows[0].DataBoundItem as Inmueble);
            ManagerRecursos.InmuebleComprador = InmuebleActual;
            Visita.AgendarVisita(dateTimePicker1.Text, CompradorActual, InmuebleActual);
            MessageBox.Show($"Visita Agendada correctamente del inmueble {InmuebleActual.Ubicacion} con comprador {CompradorActual.Nombre}");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ///Se actualiza la lista de inmuebles
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
            ///Se muestran las fotos del inmueble
            Inmueble inmuebleSeleccionado = gridInmuebles.SelectedRows[0].DataBoundItem as Inmueble;
            if (inmuebleSeleccionado.Fotos == null || inmuebleSeleccionado.Fotos.FirstOrDefault() == "")
                MessageBox.Show("No existen imagenes para mostrar");
            else
                pbFotos.Load(inmuebleSeleccionado.Fotos[0]);
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguienteFoto_Click(object sender, EventArgs e)
        {
            ///Se muestra la foto siguiente
            Inmueble inmuebleSeleccionado = gridInmuebles.SelectedRows[0].DataBoundItem as Inmueble;
            if (inmuebleSeleccionado.Fotos == null || inmuebleSeleccionado.Fotos.FirstOrDefault() == "")
                MessageBox.Show("No existen imagenes para mostrar");
            else if (inmuebleSeleccionado.Fotos.Count() > 0)
                pbFotos.Load(inmuebleSeleccionado.Fotos[1]);
            else
                MessageBox.Show("No hay mas imagenes para mostrar");
        }

        private void btnAnteriorFoto_Click(object sender, EventArgs e)
        {
            ///Se muestra la foto anterior
            Inmueble inmuebleSeleccionado = gridInmuebles.SelectedRows[0].DataBoundItem as Inmueble;
            if (inmuebleSeleccionado.Fotos == null || inmuebleSeleccionado.Fotos.FirstOrDefault() == "")
                MessageBox.Show("No existen imagenes para mostrar");
            else
                pbFotos.Load(inmuebleSeleccionado.Fotos[0]);
        }

        private void btnInmobiliaria_Click(object sender, EventArgs e)
        {
            Hide();
            vistaFuncionesInmobiliaria.Show();
        }
    }
}
