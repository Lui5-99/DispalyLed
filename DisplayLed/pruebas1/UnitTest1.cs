using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DisplayLed;
using System.Collections.Generic;

namespace pruebas1
{
    [TestClass]
    public class UnitTest1
    {
        Matriz mat = new Matriz();
        [TestMethod]
        public void Test_incMTZ1()
        {
            string[] array = { };
            try
            {
                mat.iniciarMatriz(array);
                Assert.Fail("No funciona con arreglos vacios");
            }
            catch (Exception ex)
            {
                StringAssert.Equals("La matriz esta vacia", ex.Message);
            }
        }
        [TestMethod]
        public void Test_incMTZ2()
        {
            string[] array = { "0XX0", "0XX0" };
            List<int> esperado = new List<int>() { 0, 1, 1, 0, 0, 1, 1, 0 };
            mat.iniciarMatriz(array);
            CollectionAssert.AreEqual(esperado, mat.matriz);
        }
        [TestMethod]
        public void Test_incMTZ3()
        {
            string[] array = { };
            List<string> ar = new List<string>();
            int[] arr = { 0, 1, 1, 0, 0 };
            List<int> esperado = new List<int>();
            int k = 0;
            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    esperado.Add(arr[k++ % arr.Length]);

                }
            }
            for (int i = 0; i < 60; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    ar.Add("0XX00");
                }
            }
            array = ar.ToArray();
            mat.iniciarMatriz(array);
            CollectionAssert.AreEqual(esperado, mat.matriz);
        }

        [TestMethod]
        public void Test_incMTZ4()
        {
            string[] array = { };
            List<string> ar = new List<string>();
            int[] arr = { 0, 1, 1, 0 };
            List<int> esperado = new List<int>();
            int k = 0;
            for (int i = 0; i < 292; i++)
            {
                for (int j = 0; j < 292; j++)
                {
                    esperado.Add(arr[k++ % arr.Length]);

                }
            }
            esperado.Add(0);
            esperado.Add(0);
            esperado.Add(0);
            esperado.Add(0);
            esperado.Add(0);
            esperado.Add(0);
            esperado.Add(0);
            esperado.Add(0);
            for (int i = 0; i < 73; i++)
            {
                for (int j = 0; j < 292; j++)
                {
                    ar.Add("0XX0");
                }
            }
            ar.Add("00000000");
            array = ar.ToArray();
            mat.iniciarMatriz(array);
            CollectionAssert.AreEqual(esperado, mat.matriz);
        }
        [TestMethod]
        public void Test_incMTZ5()
        {
            string[] array = { };
            List<string> ar = new List<string>();
            int[] arr = { 0, 1, 1, 0, 0 };
            List<int> esperado = new List<int>();
            int k = 0;
            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    esperado.Add(arr[k++ % arr.Length]);

                }
            }
            esperado.Add(0);
            for (int i = 0; i < 60; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    ar.Add("0XX00");
                }
            }
            ar.Add("0");
            array = ar.ToArray();
            mat.iniciarMatriz(array);
            CollectionAssert.AreEqual(esperado, mat.matriz);
        }
        [TestMethod]
        public void valESQSPIZQ1()
        {
            string[] array = { "000X0", "00XX0" };
            mat.colYren(array);
            mat.matriz = mat.iniciarMatriz(array);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            bool esperado = false;
            bool actual = mat.validarEsquinaInfIzq(mat.matriz);
            Assert.AreEqual(esperado, actual);

        }
        [TestMethod]
        public void valESQSPIZQ2()
        {
            string[] array = { "00XX0", "00XX0" };
            mat.colYren(array);
            mat.matriz = mat.iniciarMatriz(array);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            bool esperado = true;
            bool actual = mat.validarEsquinaInfIzq(mat.matriz);
            Assert.AreEqual(esperado, actual);
        }
        [TestMethod]
        public void valESQSPDER1()
        {
            string[] array = { "00X00", "00XX0" };
            mat.colYren(array);
            mat.matriz = mat.iniciarMatriz(array);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            bool esperado = false;
            bool actual = mat.validarEsquinaInfIzq(mat.matriz);
            Assert.AreEqual(esperado, actual);

        }
        [TestMethod]
        public void valESQSPDER2()
        {
            string[] array = { "00XX0", "00XX0" };
            mat.colYren(array);
            mat.matriz = mat.iniciarMatriz(array);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            bool esperado = true;
            bool actual = mat.validarEsquinaInfIzq(mat.matriz);
            Assert.AreEqual(esperado, actual);
        }
        [TestMethod]
        public void valESQINFDER()
        {
            string[] array = { "00XX0", "00X00" };
            mat.colYren(array);
            mat.matriz = mat.iniciarMatriz(array);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            bool esperado = false;
            bool actual = mat.validarEsquinaInfIzq(mat.matriz);
            Assert.AreEqual(esperado, actual);

        }
        [TestMethod]
        public void valESQINFDER2()
        {
            string[] array = { "00XX0", "00XX0" };
            mat.colYren(array);
            mat.matriz = mat.iniciarMatriz(array);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            bool esperado = true;
            bool actual = mat.validarEsquinaInfIzq(mat.matriz);
            Assert.AreEqual(esperado, actual);
        }
        [TestMethod]
        public void valESQINFIZQ()
        {
            string[] array = { "00XX0", "000X0" };
            mat.colYren(array);
            mat.matriz = mat.iniciarMatriz(array);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            bool resultado = mat.validarEsquinaInfDer(mat.matriz);
            bool esperado = false;
            Assert.AreEqual(esperado, resultado);

        }
        [TestMethod]
        public void valESQINFIZQ2()
        {
            string[] array = { "00XX0", "00XX0" };
            mat.colYren(array);
            mat.matriz = mat.iniciarMatriz(array);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            bool esperado = true;
            bool actual = mat.validarEsquinaInfIzq(mat.matriz);
            Assert.AreEqual(esperado, actual);
        }
        [TestMethod]
        public void agrAR1()
        {
            string[] arr = { "0XX00", "0XX00", "00000", "00XX0" };
            mat.colYren(arr);
            mat.matriz = mat.iniciarMatriz(arr);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            List<int> esperado = new List<int>() { 0, 0, 0, 0, 0, 0, 0,
                                                   0, 0, 0, 0, 0, 0, 0,
                                                   0, 0, 0, 4, 0, 0, 0,
                                                   0, 0, 0, 0, 0, 0, 0,
                                                   0, 0, 0, 0, 2, 0, 0,
                                                   0, 0, 0, 0, 0, 0, 0};
            mat.matriz = mat.agruparAreas(mat.matriz);
            CollectionAssert.AreEqual(esperado, mat.matriz);
        }
        [TestMethod]
        public void elmCer1()
        {
            string[] arr = { "0XX00", "0XX00", "00000", "00XX0" };
            mat.colYren(arr);
            mat.matriz = mat.iniciarMatriz(arr);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            mat.matriz = mat.agruparAreas(mat.matriz);
            List<int> esperado = new List<int> { 4, 2 };
            mat.matriz = mat.eliminarCeros();
            CollectionAssert.AreEqual(esperado, mat.matriz);
        }
        [TestMethod]
        public void valRec1()
        {
            string[] arr = { "XX", "XX" };
            mat.colYren(arr);
            mat.matriz = mat.iniciarMatriz(arr);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            bool esquina1 = mat.validarEsquinaInfDer(mat.matriz);
            bool esquina2 = mat.validarEsquinaInfIzq(mat.matriz);
            bool esquina3 = mat.validarEsquinaSupDer(mat.matriz);
            bool esquina4 = mat.validarEsquinaSupIzq(mat.matriz);
            bool esperado = true;
            bool actual = mat.validarRectangulos(esquina1, esquina2, esquina3, esquina4);
            Assert.AreEqual(esperado, actual);

        }
        [TestMethod]
        public void valRec2()
        {
            string[] arr = { "0X", "XX" };
            mat.colYren(arr);
            mat.matriz = mat.iniciarMatriz(arr);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            bool esquina1 = mat.validarEsquinaInfDer(mat.matriz);
            bool esquina2 = mat.validarEsquinaInfIzq(mat.matriz);
            bool esquina3 = mat.validarEsquinaSupDer(mat.matriz);
            bool esquina4 = mat.validarEsquinaSupIzq(mat.matriz);
            bool esperado = false;
            bool actual = mat.validarRectangulos(esquina1, esquina2, esquina3, esquina4);
            Assert.AreEqual(esperado, actual);
        }
        [TestMethod]
        public void valRec3()
        {
            string[] arr = { "X0", "XX" };
            mat.colYren(arr);
            mat.matriz = mat.iniciarMatriz(arr);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            bool esquina1 = mat.validarEsquinaInfDer(mat.matriz);
            bool esquina2 = mat.validarEsquinaInfIzq(mat.matriz);
            bool esquina3 = mat.validarEsquinaSupDer(mat.matriz);
            bool esquina4 = mat.validarEsquinaSupIzq(mat.matriz);
            bool esperado = false;
            bool actual = mat.validarRectangulos(esquina1, esquina2, esquina3, esquina4);
            Assert.AreEqual(esperado, actual);
        }
        [TestMethod]
        public void valRec4()
        {
            string[] arr = { "XX", "0X" };
            mat.colYren(arr);
            mat.matriz = mat.iniciarMatriz(arr);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            bool esquina1 = mat.validarEsquinaInfDer(mat.matriz);
            bool esquina2 = mat.validarEsquinaInfIzq(mat.matriz);
            bool esquina3 = mat.validarEsquinaSupDer(mat.matriz);
            bool esquina4 = mat.validarEsquinaSupIzq(mat.matriz);
            bool esperado = false;
            bool actual = mat.validarRectangulos(esquina1, esquina2, esquina3, esquina4);
            Assert.AreEqual(esperado, actual);
        }
        [TestMethod]
        public void valRec5()
        {
            string[] arr = { "XX", "X0" };
            mat.colYren(arr);
            mat.matriz = mat.iniciarMatriz(arr);
            mat.matriz = mat.bordearMatriz(mat.matriz);
            bool esquina1 = mat.validarEsquinaInfDer(mat.matriz);
            bool esquina2 = mat.validarEsquinaInfIzq(mat.matriz);
            bool esquina3 = mat.validarEsquinaSupDer(mat.matriz);
            bool esquina4 = mat.validarEsquinaSupIzq(mat.matriz);
            bool esperado = false;
            bool actual = mat.validarRectangulos(esquina1, esquina2, esquina3, esquina4);
            Assert.AreEqual(esperado, actual);
        }
    }
}
