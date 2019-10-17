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
        string[] array = new string[]{ "XX" , "X0" };
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
        
        public void maxYmin()
        {
            for(int i = 1; i < renglones; i++)
            {
                for (int j = 1; j < columnas; j++)
                {
                    int indice = (i * columnas) + j;
                    int indice_sp = indice - renglones;
                    int indice_iz = indice - 1;
                    int indiceDiag = indice_sp - 1;
                    
                }
            }
                   
        }
        public void buscarRenctangulos()
        {
            for (int i = 1; i < renglones; i++)
            {
                for (int j = 1; j < columnas; j++)
                {
                    int indice = (i * columnas) + j;
                    int indice_sp = indice - columnas;
                    int indice_iz = indice - 1;
                    int indiceDiag = indice_sp - 1;
                    if ((matriz[indice_iz] == 1 && matriz[indice_sp] == 1 && matriz[indice] == 0))
                    {
                        Console.WriteLine("Matriz no valida");
                    }
                }
            }
        }
        public void agregarRenglon()
        {
            
            for(int i = 0; i < columnas; i++)
            {
                matriz.Insert(0, 0);
            }
            renglones += 1;
        }
        public void agregarColumna()
        {
            
            for(int i = 0; i < renglones; i++)
            {
                
                matriz.Insert((i*columnas)+i, 0);
            }
        }
        public void imprimirMatriz()
        {
            for(int i = 0; i < matriz.Count; i++)
            {
                Console.Write(matriz[i] + " ");
            }
        }
        
    }
}
