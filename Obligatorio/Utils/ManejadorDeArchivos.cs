using Obligatorio.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Obligatorio.Utils
{
    public class ManejadorDeArchivos
    {
        public List<Inmueble> Inmuebles { get; set; }

        /// <summary>
        /// Permite escribir en un archivo
        /// </summary>
        /// <param name="nomArchivo">Se toma un nombre de archivo</param>
        /// <param name="texto">Se toma un texto</param>
        public void Escribir(String nomArchivo, String texto)
        {
            StreamWriter writer = new StreamWriter(nomArchivo, true);
            writer.WriteLine(texto);
            writer.Close();
        }

        /// <summary>
        /// Se lee un archivo
        /// </summary>
        /// <param name="nomArchivo">Se toma la ruta del archivo</param>
        /// <returns></returns>
        public List<String> Leer(String nomArchivo)
        {
            StreamReader reader = new StreamReader(nomArchivo);
            List<String> lineasArchivo = new List<String>();
            while (reader.Peek() > -1)
            {
                lineasArchivo.Add(reader.ReadLine());
            }
            reader.Close();
            return lineasArchivo;
        }

        /// <summary>
        /// Se lee un archivo y se separa en strings
        /// </summary>
        /// <param name="path">Se toma una ruta de archivo</param>
        /// <returns></returns>
        public List<Inmueble> InfoArchivo(String path)
        {
            Inmuebles = new List<Inmueble>();

            List<String> lineasArchivo = Leer(path);

            String[] lineaPalabras;

            foreach (String l in lineasArchivo)
            {
                lineaPalabras = l.Split(';');

                if(lineaPalabras[0] == "Casa")
                {
                    string[] fotosAux = lineaPalabras[18].Split(',');

                    List<string> listaFotos = new List<string>();

                    foreach (string foto in fotosAux)
                    {
                        listaFotos.Add(foto);
                    }

                    Casa casa = new Casa()
                    {                        
                        Precio = float.Parse(lineaPalabras[1]),
                        CantidadHabitaciones = Convert.ToInt32(lineaPalabras[2]),
                        CantidadDormitorios = Convert.ToInt32(lineaPalabras[3]),
                        CantidadBaños = Convert.ToInt32(lineaPalabras[4]),
                        AñoConstruccion = Convert.ToInt32(lineaPalabras[5]),
                        MetrosEdificados = float.Parse(lineaPalabras[6]),
                        Departamento = lineaPalabras[7],
                        Ciudad = lineaPalabras[8],
                        Barrio = lineaPalabras[9],
                        Estado = lineaPalabras[10],
                        Garages = Convert.ToInt32(lineaPalabras[11]),
                        Ubicacion = lineaPalabras[12],
                        Jardin = Convert.ToBoolean(lineaPalabras[13]),
                        Patio = Convert.ToBoolean(lineaPalabras[14]),
                        Parrillero = Boolean.Parse(lineaPalabras[15]),
                        GastosComunes = float.Parse(lineaPalabras[16]),
                        Comentarios = lineaPalabras[17],
                        Fotos = listaFotos
                    };
                    Inmuebles.Add(casa);
                }
                else
                {
                    string[] fotosAux = lineaPalabras[19].Split(',');

                    List<string> listaFotos = new List<string>();

                    foreach (string foto in fotosAux)
                    {
                        listaFotos.Add(foto);
                    }

                    Apartamento apartamento = new Apartamento()
                    {
                        Precio = float.Parse(lineaPalabras[1]),
                        CantidadHabitaciones = Convert.ToInt32(lineaPalabras[2]),
                        CantidadDormitorios = Convert.ToInt32(lineaPalabras[3]),
                        CantidadBaños = Convert.ToInt32(lineaPalabras[4]),
                        AñoConstruccion = Convert.ToInt32(lineaPalabras[5]),
                        MetrosEdificados = float.Parse(lineaPalabras[6]),
                        Departamento = lineaPalabras[7],
                        Ciudad = lineaPalabras[8],
                        Barrio = lineaPalabras[9],
                        Estado = lineaPalabras[10],
                        Garages = Convert.ToInt32(lineaPalabras[11]),
                        Ubicacion = lineaPalabras[12],
                        NroPiso = Convert.ToInt32(lineaPalabras[13]),
                        Porteria = Convert.ToBoolean(lineaPalabras[14]),
                        Parrillero = Convert.ToBoolean(lineaPalabras[15]),
                        CantidadPisos = Convert.ToInt32(lineaPalabras[16]),
                        GastosComunes = float.Parse(lineaPalabras[17]),
                        Comentarios = lineaPalabras[18],
                        Fotos = listaFotos
                    };
                    Inmuebles.Add(apartamento);
                }
            }
            return Inmuebles;
        }

    }

}