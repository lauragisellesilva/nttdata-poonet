using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Tests
{
    [TestClass()] //custom attributes: son metadatos: datos que definen datos, en este caso define que es una clase de test
    public class CalculatorTests
    {
        Calculator calculator = new Calculator(); // las variables de clase no las puedo hacer var

        [TestMethod()]
        public void AddTest()
        {
            //var calculator = new Calculator(); // calculator: objeto
            // Assert es una clase de la librería MSTest
            // IsTRue como va seguido de un punto después de la case es un metodo estatico que vive durante toda la ejecucion del programa
            Assert.IsTrue(calculator.Add(2,2) == 4); //prueba de caja negra
            Assert.IsFalse(calculator.Add(2, 2) == 3); //prueba de caja negra
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Assert.IsTrue(calculator.Substract(2, 2) == 0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.IsTrue(calculator.Multiply(3, 2) == 6);
        }

        [TestMethod()]
        public void DivideTest()
        {
           Assert.IsTrue(calculator.Divide(8, 2) == 4);
        }
    }
}