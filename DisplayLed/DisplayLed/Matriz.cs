using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayLed
{
    public class Matriz
    {
        public List<int> matriz = new List<int>();
        int columnas = 0;
        int renglones = 0;
        public void colYren(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    columnas = array[i].Length;
                }
                renglones = (array.Length);
            }

        }
        public void iniciarMatriz(string[] array)
        {
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        if (array[i][j] == 'X')
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
            else
            {
                throw new Exception("Matriz Vacia");
            }
        }
        public void agruparAreas()
        {
            int suma = 0;
            for (int i = 1; i < renglones; i++)
            {
                for (int j = 1; j < columnas; j++)
                {
                    int indice = (i * columnas) + j;
                    int indice_sp = indice - columnas;
                    int indice_ab = indice + columnas;
                    int indice_iz = indice - 1;
                    int indice_Der = indice + 1;
                    int indiceDiagSpIz = indice_sp - 1;
                    int indiceDiagSpDer = indice_sp + 1;
                    int indiceDiagAbDer = indice_ab + 1;
                    int indiceDiagAbIz = indice_ab - 1;
                    if (matriz[indice] > 0)
                    {
                        suma = matriz[indice] + matriz[indice_iz] + matriz[indice_sp];
                        matriz[indice] = suma;
                        matriz[indice_iz] = 0;
                        matriz[indice_sp] = 0;
                    }

                }
            }
        }
        public void eliminarCeros()
        {
            for (int i = matriz.Count - 1; i >= 0; i--)
            {
                if (matriz[i] == 0)
                {
                    matriz.RemoveAt(i);
                }
            }
        }
        public int max()
        {
            int max = matriz.Max();
            return max;
        }
        public int min()
        {
            int min = 0;
            if (matriz.Count > 1)
            {
                min = matriz.Min();
            }
            else
            {
                min = 0;
            }
            return min;
        }
        public bool validarRectangulos()
        {
            bool estado = true;
            if (validarEsquinaInfDer() && validarEsquinaInfIzq() &&
                validarEsquinaSupDer() && validarEsquinaSupIzq())
            {
                estado = true;
            }
            else if (linea())
            {
                estado = true;
            }
            else
            {
                estado = false;
            }
            return estado;
        }
        public void agregarRenglon()
        {

            for (int i = 0; i < columnas; i++)
            {
                matriz.Insert(0, 0);
            }
            renglones += 1;
        }
        public void agregarColumnaDer()
        {
            for (int i = 0; i < renglones; i++)
            {
                int indice = (i * columnas) + columnas + i;
                matriz.Insert(indice, 0);
            }
            columnas += 1;
        }
        public void agregarRenglonAb()
        {
            for (int i = 0; i < columnas; i++)
            {
                matriz.Add(0);
            }
            renglones += 1;
        }
        public void agregarColumna()
        {

            for (int i = 0; i < renglones; i++)
            {

                matriz.Insert((i * columnas) + i, 0);
            }
            columnas += 1;
        }
        public void imprimirMatriz()
        {
            for (int i = 0; i < matriz.Count; i++)
            {
                Console.Write(matriz[i] + " ");
            }
            Console.WriteLine("");
        }
        public bool validarEsquinaInfDer()
        {
            bool estado = false;
            for (int i = 1; i < renglones; i++)
            {
                for (int j = 1; j < columnas; j++)
                {
                    int indice = (i * columnas) + j;
                    int indice_sp = indice - columnas;
                    int indice_iz = indice - 1;
                    int indiceDiagIzqSp = indice_sp - 1;
                    if (matriz[indice_iz] == 1 && matriz[indice_sp] == 1 && matriz[indiceDiagIzqSp] == 1 && matriz[indice] == 0)
                    {
                        estado = false;
                    }
                    else if (matriz[indice_iz] == 1 && matriz[indice_sp] == 1 && matriz[indiceDiagIzqSp] == 1 && matriz[indice] == 1)
                    {
                        estado = true;
                    }
                }
            }
            return estado;
        }
        public bool validarEsquinaInfIzq()
        {
            bool estado = false;
            for (int i = 1; i < renglones; i++)
            {
                for (int j = 1; j < (columnas - 1); j++)
                {
                    int indice = (i * columnas) + j;
                    int indice_sp = indice - columnas;
                    int indice_iz = indice - 1;
                    int indice_der = indice + 1;
                    int indiceDiagDerSp = indice_sp + 1;
                    if (matriz[indice_der] == 1 && matriz[indice_sp] == 1 && matriz[indiceDiagDerSp] == 1 && matriz[indice] == 0)
                    {
                        estado = false;
                    }
                    else if (matriz[indice_der] == 1 && matriz[indice_sp] == 1 && matriz[indiceDiagDerSp] == 1 && matriz[indice] == 1)
                    {
                        estado = true;
                    }
                }
            }
            return estado;
        }
        public bool validarEsquinaSupDer()
        {
            bool estado = false;
            for (int i = 1; i < renglones - 1; i++)
            {
                for (int j = 1; j < (columnas - 1); j++)
                {
                    int indice = (i * columnas) + j;
                    int indice_sp = indice - columnas;
                    int indice_iz = indice - 1;
                    int indice_der = indice + 1;
                    int indice_ab = indice + columnas;
                    int indiceDiagIzAb = indice_ab - 1;
                    if (matriz[indice_iz] == 1 && matriz[indice_ab] == 1 && matriz[indiceDiagIzAb] == 1 && matriz[indice] == 0)
                    {
                        estado = false;
                    }
                    if (matriz[indice_iz] == 1 && matriz[indice_ab] == 1 && matriz[indiceDiagIzAb] == 1 && matriz[indice] == 1)
                    {
                        estado = true;
                    }
                }
            }
            return estado;
        }
        public bool validarEsquinaSupIzq()
        {
            bool estado = false;
            for (int i = 1; i < renglones - 1; i++)
            {
                for (int j = 1; j < (columnas - 1); j++)
                {
                    int indice = (i * columnas) + j;
                    int indice_sp = indice - columnas;
                    int indice_iz = indice - 1;
                    int indice_der = indice + 1;
                    int indice_ab = indice + columnas;
                    int indiceDiagDerAb = indice_ab + 1;
                    if (matriz[indice_der] == 1 && matriz[indice_ab] == 1 && matriz[indiceDiagDerAb] == 1 && matriz[indice] == 0)
                    {
                        estado = false;
                    }
                    else if (matriz[indice_der] == 1 && matriz[indice_ab] == 1 && matriz[indiceDiagDerAb] == 1 && matriz[indice] == 1)
                    {
                        estado = true;
                    }
                }
            }
            return estado;
        }
        public bool linea()
        {
            bool estado = true;
            for (int i = 1; i < renglones; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    int indice = (i * columnas) + j;
                    int indice_iz = indice - 1;
                    int indice_der = indice + 1;
                    if (matriz[indice] == 1 && (matriz[indice_iz] == 1 || matriz[indice_der] == 1))
                    {
                        estado = true;
                    }
                    else
                    {
                        estado = false;
                    }
                }
            }
            return estado;
        }
    }
}

