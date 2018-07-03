 using Obligatorio.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public class Visita
    {
        public static string Comentario { get; set; }
        public static Comprador Comprador { get; set; }    
        public static Inmueble Inmueble { get; set; }
        public static List<Comprador> ListaCompradores = new List<Comprador>();
        public static ManejadorDeArchivos manejadorDeArchivos = new ManejadorDeArchivos();

        /// <summary>
        /// Se agrega un comprador a la lista de compradores
        /// </summary>
        /// <param name="comprador">Se toma un comprador</param>
        public static void AgregarComprador(Comprador comprador)
        {
            ListaCompradores.Add(comprador);
            ListaCompradores.OrderBy(x => x.Nombre).ToList();
            AgregarCompradorArchivo();
        }

        /// <summary>
        /// Se agregan los compradores a un archivo
        /// </summary>
        public static void AgregarCompradorArchivo()
        {
            foreach (Comprador c in ListaCompradores)
            {
                manejadorDeArchivos.Escribir("Lista de compradores.txt", $"{DateTime.Now.ToString()} -" +
                    //$" Inmueble: {ManagerRecursos.InmuebleComprador.Ubicacion.ToString()}," +
                    $" Nombre: {c.Nombre}," +
                    $" CI: {c.CI}," +
                    $" Correo: {c.Correo}," +
                    $" Telefono: {c.Telefono}");
                    //$" Comentarios: {Comentario}.");
            }
        }

        /// <summary>
        /// Se agenda una visita con un comprador, un inmueble, y una fecha que el comprador decida
        /// </summary>
        /// <param name="fecha">Se toma una fecha</param>
        /// <param name="c">Se toma un comprador</param>
        /// <param name="i">Se toma un inmueble</param>
        public static void AgendarVisita(string fecha, Comprador c, Inmueble i)
        {
            manejadorDeArchivos.Escribir("Visitas agendadas.txt", $"{fecha} - Comprador con cedula: {c.CI} agendó una visita al inmueble: {i.Ubicacion}.");
        }
    }
}
