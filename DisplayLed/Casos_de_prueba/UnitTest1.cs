using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DisplayLed;
using System.Collections.Generic;

namespace Casos_de_prueba
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
            mat.iniciarMatriz(array);
            bool resultado = mat.validarEsquinaSupIzq();
            bool esperado = false;
            Assert.AreEqual(esperado, resultado);

        }
        [TestMethod]
        public void valESQSPIZQ2()
        {
            string[] array = { "00XX0", "00XX0" };
            mat.iniciarMatriz(array);
            mat.agregarColumna();
            mat.agregarColumnaDer();
            mat.agregarRenglonAb();
            List<int> arr = mat.matriz;
            bool esperado = false;
            Assert.AreEqual(esperado, mat.validarEsquinaSupIzq());
        }
        [TestMethod]
        public void valESQSPDER1()
        {
            string[] array = { "00X00", "00XX0" };
            mat.iniciarMatriz(array);
            bool resultado = mat.validarEsquinaSupDer();
            bool esperado = false;
            Assert.AreEqual(esperado, resultado);

        }
        [TestMethod]
        public void valESQSPDER2()
        {
            string[] array = { "00XX0", "00XX0" };
            mat.iniciarMatriz(array);
            mat.agregarColumna();
            mat.agregarColumnaDer();
            mat.agregarRenglonAb();
            List<int> arr = mat.matriz;
            bool esperado = false;
            Assert.AreEqual(esperado, mat.validarEsquinaSupDer());
        }
        [TestMethod]
        public void valESQINFDER()
        {
            string[] array = { "00XX0", "00X00" };
            mat.iniciarMatriz(array);
            bool resultado = mat.validarEsquinaInfDer();
            bool esperado = false;
            Assert.AreEqual(esperado, resultado);

        }
        [TestMethod]
        public void valESQINFDER2()
        {
            string[] array = { "00XX0", "00XX0" };
            mat.iniciarMatriz(array);
            mat.agregarColumna();
            mat.agregarColumnaDer();
            mat.agregarRenglonAb();
            List<int> arr = mat.matriz;
            bool esperado = false;
            Assert.AreEqual(esperado, mat.validarEsquinaInfDer());
        }
        [TestMethod]
        public void valESQINFIZQ()
        {
            string[] array = { "00XX0", "000X0" };
            mat.iniciarMatriz(array);
            bool resultado = mat.validarEsquinaInfDer();
            bool esperado = false;
            Assert.AreEqual(esperado, resultado);

        }
        [TestMethod]
        public void valESQINFIZQ2()
        {
            string[] array = { "00XX0", "00XX0" };
            mat.iniciarMatriz(array);
            mat.agregarColumna();
            mat.agregarColumnaDer();
            mat.agregarRenglonAb();
            List<int> arr = mat.matriz;
            bool esperado = false;
            Assert.AreEqual(esperado, mat.validarEsquinaInfDer());
        }
    }
}


