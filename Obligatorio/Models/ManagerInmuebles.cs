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
        public static List<Inmueble> ListaInmuebles { get; set; }
        //public static List<string> ListaFotos = new List<string>();

        static ManejadorDeArchivos manejadorDeArchivos = new ManejadorDeArchivos();
        //static ManejadorArchivosImagenes ManejadorArchivosImagenes = new ManejadorArchivosImagenes();
        static Inmueble inmueble { get; set; }

        public static string PathFotos { get; set; }

        public static void AgregarPropiedad(Inmueble InmuebleaAgregar)
        {
            ListaInmuebles.Add(InmuebleaAgregar);
            AgregarPropiedadArchivo(InmuebleaAgregar);
        }

        public static String VenderAlquilar(Inmueble inmueble, Comprador comprador)
        {
            ListaInmuebles.Remove(inmueble);
            return ("Ahora esta propiedad es de: " + comprador.Nombre);
        }

        public static void AgregarPropiedadArchivo(Inmueble i)
        {
            //foreach (Inmueble i in ListaInmuebles)
            //{
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
                    $"{Global.BooleanToString((i as Casa).Jardin)};" +
                    $"{Global.BooleanToString((i as Casa).Patio)};" +
                    $"{Global.BooleanToString(i.Parrillero)};" +
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
                    $"{Global.BooleanToString((i as Apartamento).Porteria)};" +
                    $"{Global.BooleanToString(i.Parrillero)};" +
                    $"{(i as Apartamento).CantidadPisos};" +
                    $"{(i as Apartamento).GastosComunes};" +
                    $"{i.Comentarios};" +
                    $"{ListaFotos()}");
            }
            //}
        }

        //public static void AgregarFotoLista(string path)
        //{
        //    //ListaFotos.Add(path);
        //    inmueble.Fotos.Add(path);
        //}

        //public static string ListaFotos()
        //{
        //    string combinedString = string.Join(",", inmueble.Fotos.ToArray());
        //    return combinedString;
        //}

        //public static string Algo()
        //{
        //    PathFotos = string.Join(",", inmueble.Fotos.ToArray());
        //    return PathFotos;
        //}

        public static string ListaFotos()
        {
            return VerFotos(inmueble.Fotos);
        }

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

        /* 
         * ver si poner el filtro aca
         */

        //public static void Filtro()
        //{
        //    bool filtrarPorDepartamento = true;
        //    bool filtrarPorBarrio = true;
        //    bool filtrarPorGarage = true;

        //    //List<Inmueble> listaInmuebles = new List<Inmueble>();

        //    Inmobiliaria inmobiliaria = Inmobiliaria.GetInmobiliaria();

        //    List<Inmueble> listaInmuebles = new List<Inmueble>();
        //    listaInmuebles = inmobiliaria.GetListaInmuebles();

        //    foreach (Inmueble i in listaInmuebles)
        //    {
        //        if (filtrarPorDepartamento)
        //            listaInmuebles = listaInmuebles.Where(x => x.Departamento == comboBoxDepartamento.SelectedItem.ToString()).ToList();
        //        if (filtrarPorBarrio)
        //            listaInmuebles = listaInmuebles.Where(x => x.Barrio == comboBoxBarrio.SelectedItem.ToString()).ToList();
        //        if (filtrarPorGarage)
        //            listaInmuebles = listaInmuebles.Where(x => x.Garages == Convert.ToInt32(comboBoxGarage.SelectedItem.ToString())).ToList();
        //    }
        //}
    }
}
