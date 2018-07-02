using Obligatorio.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Obligatorio.Utils
{
    public class ManejadorDeArchivos
    {
        public List<Inmueble> Inmuebles { get; set; }


        public void Escribir(String nomArchivo, String texto)
        {
            StreamWriter writer = new StreamWriter(nomArchivo, true);
            writer.WriteLine(texto);
            writer.Close();
        }

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
                        Parrillero = Convert.ToBoolean(lineaPalabras[15]),
                        GastosComunes = float.Parse(lineaPalabras[16]),
                        Comentarios = lineaPalabras[17],
                        //Fotos = lineaPalabras[18]
                    };
                    Inmuebles.Add(casa);
                }
                else
                {
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
                        //Fotos = lineaPalabras[19]
                    };
                    Inmuebles.Add(apartamento);
                }
            }
            return Inmuebles;
        }

    }

}