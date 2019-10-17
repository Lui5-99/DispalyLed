using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DisplayLed
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz matriz = new Matriz();
            matriz.iniciarMatriz();
            //matriz.agregarRenglon();
            matriz.agregarColumna();
            matriz.buscarRenctangulos();
            matriz.imprimirMatriz();
            Console.ReadKey();
        }
    }
}
