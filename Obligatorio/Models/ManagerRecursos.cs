﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public static class ManagerRecursos
    {
        /// <summary>
        /// Clase que permite guardar las propiedades 
        /// </summary>

        #region Inmueble
        public static float precio;
        public static string departamento;
        public static string ciudad;
        public static string barrio;
        public static string direccionInmueble;
        public static string estado;
        public static int año;
        public static float superficie;
        public static int habitaciones;
        public static int dormitorios;
        public static int baños;
        public static int garages;
        public static bool parrillero;
        public static bool jardin;
        public static float gastosComunes;
        public static int nroPiso;
        public static int pisos;
        public static bool portero;
        public static string comentarios;
        public static List<string> fotos;
        public static string titulo;
        #endregion

        #region Propietario
        public static string NombrePropietario;
        public static string CIPropietario;
        public static string DireccionPropietario;
        public static string CorreoPropietario;
        public static string TelefonoPropietario;
        #endregion

        #region Comprador
        public static string NombreComprador;
        public static string CIComprador;
        public static string CorreoComprador;
        public static string TelefonoComprador;
        public static Inmueble InmuebleComprador = new Inmueble();
        #endregion
    }
}
