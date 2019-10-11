using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DisplayLed
{
    class Matriz
    {
        public List<int> matriz { get; set; }
        string[] array = new string[]{ "0X" , "0X" };
        int renglones = 2;
        int columnas = 2;
        public void iniciarMatriz()
        {
            matriz = new List<int>();
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                {
                    if(array[i][j] == 'X')
                    {
                        matriz.Add(1);
                    }
                    else
                    {
                        matriz.Add(0);
                    }
                }
            }
        }
        
        public void recorrerMatriz()
        {
            for(int i = 1; i < columnas; i++)
            {
                for (int j = 1; j < renglones; j++)
                {
                    int indice = (i * renglones) + i;
                    int indice_sp = indice - columnas;
                    int indice_iz = indice - 1;
                }
            }
                   
        }
        public void agregarRenglon()
        {
            for(int i = 0; i < columnas; i++)
            {
                matriz.Insert(0, 0);
            }

        }
        public void agregarColumna()
        {
            int indice = 0;
            for(int i = 0; i < renglones; i++)
            {
                indice = (i * columnas) + i;
                matriz.Insert(indice, 0);
            }
        }
        public void imprimirMatriz()
        {
            for(int i = 0; i < matriz.Count; i++)
            {
                Console.WriteLine(matriz[i]);
            }
        }
        
    }
}
