using System;
using System.IO;
using System.Collections;
using Entidades;
using System.Collections.Generic;

namespace DAO
{
    public class Utils
    {
        public List<Animal> ReadFileAnimales(string ruta)
        {
            StreamReader objReader = new StreamReader(ruta);
            string linea = "";
            List<Animal> lAnimales = new List<Animal>();

            try
            {
                while (linea != null)
                {
                    linea = objReader.ReadLine();

                    if (linea != null)
                    {
                        lAnimales.Add(new Animal()
                        {
                            propNombre = linea
                        });
                    }
                }
                Console.WriteLine("Ejecuto ReadFileAnimales");
                return lAnimales;
            }

            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
                return null;
            }
            finally
            {
                objReader.Close();
            }
        }

        public void GenerarArchivo(List<Animal> lAnimales, string rutaDestinoArchivo)
        {
            StreamWriter swArchivo = new StreamWriter(rutaDestinoArchivo);
            try
            {
                foreach (var item in lAnimales)
                {
                    swArchivo.WriteLine(item.propNombre);
                }
                Console.WriteLine("Ejecuto GenerarArchivo.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                swArchivo.Close();
            }
        }
    }
}
