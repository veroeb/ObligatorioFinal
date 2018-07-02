using Obligatorio.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Obligatorio.Models
{
    public class Inmobiliaria
    {
        public static ManejadorDeArchivos manejadorDeArchivos;
        #region Singleton
        public static Inmobiliaria Instancia = null;
        public static Inmobiliaria GetInmobiliaria()
        {
            if (Instancia == null)
            {
                Instancia = new Inmobiliaria();
                manejadorDeArchivos = new ManejadorDeArchivos();
                string path = $"{AppDomain.CurrentDomain.BaseDirectory}Listado de propiedades.txt";

                if (File.Exists(path))
                {
                    ManagerInmuebles.ListaInmuebles = manejadorDeArchivos.InfoArchivo(path);
                }
            }

            return Instancia;
        }
        #endregion
        
        /// <summary>
        /// Listado de inmuebles
        /// </summary>
        /// <returns></returns>
        public List<Inmueble> GetListaInmuebles()
        {
            return ManagerInmuebles.ListaInmuebles;
        }

        /// <summary>
        /// Listado de inmuebles con filtros
        /// </summary>
        /// <returns></returns>
        public List<Inmueble> ListaInmueblesConFiltros()
        {
            return ManagerInmuebles.ListaInmuebles;
        }

        /// <summary>
        /// Lista de compradores ordenados alfabeticamente
        /// </summary>
        /// <returns></returns>
        public List<Comprador> ListaCompradoresAlfabeticamente()
        {
            return Visita.ListaCompradores.OrderBy(x => x.Nombre).ToList();
        }
    }
}
