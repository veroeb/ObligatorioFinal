using Obligatorio.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public static class ManagerInmuebles
    {
        public static List<Inmueble> ListaInmuebles = new List<Inmueble>();

        static ManejadorDeArchivos manejadorDeArchivos = new ManejadorDeArchivos();
        static Inmueble inmueble { get; set; }

        public static string PathFotos { get; set; }

        /// <summary>
        /// Agrega el inmueble a la lista de inmuebles
        /// </summary>
        /// <param name="InmuebleaAgregar">Se toma un inmueble como parametro</param>
        public static void AgregarPropiedad(Inmueble InmuebleaAgregar)
        {
            ListaInmuebles.Add(InmuebleaAgregar);
            AgregarPropiedadArchivo(InmuebleaAgregar);
        }

        /// <summary>
        /// Se vende o alquila el inmueble a un comprador y lo elimina de la lista de inmuebles
        /// </summary>
        /// <param name="inmueble">Se toma un inmueble</param>
        /// <param name="comprador">Se toma un comprador</param>
        /// <returns></returns>
        public static String VenderAlquilar(Inmueble inmueble, Comprador comprador)
        {
            ListaInmuebles.Remove(inmueble);
            return ("Ahora esta propiedad es de: " + comprador.Nombre);
        }

        /// <summary>
        /// Se agrega el inmueble al archivo de inmuebles
        /// </summary>
        /// <param name="i">Se toma un inmueble como parametro</param>
        public static void AgregarPropiedadArchivo(Inmueble i)
        {
            inmueble = i;
            if (i is Casa)
            {
                manejadorDeArchivos.Escribir("Listado de propiedades.txt", $"Casa;" +
                    $"{i.Precio};" +
                    $"{i.CantidadHabitaciones};" +
                    $"{i.CantidadDormitorios};" +
                    $"{i.CantidadBaños};" +
                    $"{i.AñoConstruccion};" +
                    $"{i.MetrosEdificados};" +
                    $"{i.Departamento};" +
                    $"{i.Ciudad};" +
                    $"{i.Barrio};" +
                    $"{i.Estado};" +
                    $"{i.Garages};" +
                    $"{i.Ubicacion};" +
                    $"{(i as Casa).Jardin};" +
                    $"{(i as Casa).Patio};" +
                    $"{i.Parrillero};" +
                    $"{i.GastosComunes};" +
                    $"{i.Comentarios};" +
                    $"{ListaFotos()}");
            }
            else if (i is Apartamento)
            {
                manejadorDeArchivos.Escribir("Listado de propiedades.txt", $"Apartamento;" +
                    $"{i.Precio};" +
                    $"{i.CantidadHabitaciones};" +
                    $"{i.CantidadDormitorios};" +
                    $"{i.CantidadBaños};" +
                    $"{i.AñoConstruccion};" +
                    $"{i.MetrosEdificados};" +
                    $"{i.Departamento};" +
                    $"{i.Ciudad};" +
                    $"{i.Barrio};" +
                    $"{i.Estado};" +
                    $"{i.Garages};" +
                    $"{i.Ubicacion};" +
                    $"{(i as Apartamento).NroPiso};" +
                    $"{(i as Apartamento).Porteria};" +
                    $"{i.Parrillero};" +
                    $"{(i as Apartamento).CantidadPisos};" +
                    $"{i.GastosComunes};" +
                    $"{i.Comentarios};" +
                    $"{ListaFotos()}");
            }
            
        }

        
        /// <summary>
        /// Retorna una lista de fotos de cada inmueble
        /// </summary>
        /// <returns></returns>
        public static string ListaFotos()
        {
            return VerFotos(inmueble.Fotos);
        }

        /// <summary>
        /// Se crea una lista de fotos que se separan por comas
        /// </summary>
        /// <param name="listaFotos"></param>
        /// <returns></returns>
        public static string VerFotos(List<string> listaFotos)
        {
            foreach (string s in listaFotos)
            {
                PathFotos += s + ",";
            }
            if (PathFotos != null)
                PathFotos = PathFotos.TrimEnd(',');
            return PathFotos;
        }

        public static void AgregarInmueblePropietarioArchivo (Propietario p, Inmueble i)
        {
            manejadorDeArchivos.Escribir("Inmuebles de propietarios.txt", $"Propietario con cedula: {p.CI} creo un nuevo inmueble con ubicacion: {i.Ubicacion}.");
        }

    }
}
