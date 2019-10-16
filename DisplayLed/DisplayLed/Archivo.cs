using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace DisplayLed
{
    class Archivo
    {
        public void ValidarExtension(string ruta)
        {
            string extension = System.IO.Path.GetExtension(ruta); //Devuelve la extensión de la ruta especificada
            try
            {
                if (extension.Equals(".txt"))
                    EsVacio(ruta);
                else
                    Console.WriteLine("La extensión del archivo es incorrecta");
            }
            catch
            {
                Console.WriteLine("Verifique que la extensión sea correcta");
            }

        }

        public void EsVacio(string ruta)
        {
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    if (sr.Peek() > 0)
                        LeerArchivo(ruta);
                    else
                        Console.WriteLine("El archivo está vacío");
                }
            }
            catch
            {
                Console.WriteLine("Verifique que el archivo seleccionado sea el correcto");
            }

        }

        public void LeerArchivo(string ruta)
        {
            List<string> ledsLista = new List<string>();
            //string[] ledsMatriz = new string[0];
            Regex simbolosValidos = new Regex("^[0-X]{1,300}$");

            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (simbolosValidos.IsMatch(linea))
                            ledsLista.Add(linea);
                        else
                            Console.WriteLine("Hay simbolos no válidos en el archivo");
                    }
                    string[] ledsArreglo = ledsLista.ToArray();
                    Console.WriteLine(ledsArreglo[0]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("El archivo no pudo ser leído");
                Console.WriteLine(e.Message);
            }
        }

    }
}
