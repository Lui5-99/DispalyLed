using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayLed
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz matriz = new Matriz();
            Archivo archivo = new Archivo();
            archivo.leerArchivo();
            string[] lista = archivo.enviar();
            matriz.colYren(lista);
            List<int> iniciar = matriz.iniciarMatriz(lista);
            List<int> mat = matriz.bordearMatriz(iniciar);
            bool esquina1 = matriz.validarEsquinaInfDer(mat);
            bool esquina2 = matriz.validarEsquinaInfIzq(mat);
            bool esquina3 = matriz.validarEsquinaSupDer(mat);
            bool esquina4 = matriz.validarEsquinaSupIzq(mat);
            if (matriz.validarRectangulos(esquina1, esquina2, esquina3, esquina4))
            {
                matriz.agruparAreas(mat);
                //matriz.imprimirMatriz();
                matriz.eliminarCeros();
                //matriz.imprimirMatriz();
                Console.WriteLine(matriz.max());
                Console.WriteLine(matriz.min());
            }
            else
            {
                Console.WriteLine("Matriz no valida");
            }
            Console.ReadKey();
        }
    }
}
