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
            matriz.iniciarMatriz(lista);
            matriz.agregarRenglon();
            matriz.agregarColumna();
            matriz.agregarColumnaDer();
            matriz.agregarRenglonAb();
            if (matriz.validarRectangulos())
            {
                //matriz.imprimirMatriz();
                matriz.agruparAreas();
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
