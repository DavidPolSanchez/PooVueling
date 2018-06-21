using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        ICalculadora iCalculadora = new Calculadora();

        [DataRow(4, 2, 2)]
        [DataRow(9, 3, 3)]
        [DataTestMethod()]
        public void Divisiontest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) ==resultado);
        }

        [DataRow(4, 2, 8)]
        [DataRow(6, 3, 18)]
        [DataTestMethod()]
        public void Multiplicaciontest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(num1, num2) == resultado);
        }

        [DataRow(4, 2, 2)]
        [DataRow(8, 3, 5)]
        [DataTestMethod()]
        public void Restatest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Resta(num1, num2) == resultado);
        }

        [DataRow(2, 2, 4)]
        [DataRow(5, 3, 8)]
        [DataTestMethod()]
        public void Sumatest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Suma(num1, num2) == resultado);
        }
    }
}