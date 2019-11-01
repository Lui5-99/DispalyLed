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
        public string[] matriz;
        public List<string> mat = new List<string>();
        StreamReader archivo = new StreamReader("C:\\Users\\Lenovo\\Desktop\\Escritorio\\Ingenieria en software\\7o\\Lenguajes y Automatas\\Tarea Doc\\prueba.txt");
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
                        leerArchivo();
                    else
                        Console.WriteLine("El archivo está vacío");
                }
            }
            catch
            {
                Console.WriteLine("Verifique que el archivo seleccionado sea el correcto");
            }

        }

        public void leerArchivo()
        {
            Regex validar = new Regex("^[0X]{1,300}$");
            Regex invalido = new Regex("^[0X]{ 0, 0 }$");
            while (!archivo.EndOfStream)
            {
                string linea = archivo.ReadLine();
                if (validar.IsMatch(linea))
                {
                    mat.Add(linea);
                }
                else if (invalido.IsMatch(linea))
                {
                    Console.WriteLine("Mátriz invalida");
                }
                matriz = mat.ToArray();
            }

        }
        public string[] enviar()
        {
            return matriz;
        }

    }
}
