using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorProject.Loops.Tests
{
    [TestClass()]
    public class PrintProductTests
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            PrintProduct.CreateListProduct();
        }

        [TestMethod()]
        public void GetProductsGreaterThan30ForTest()
        {
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30For().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30For()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30For()[1].Name == "Juego");
        }

        [TestMethod()]
        public void GetProductsGreaterThan30ForEachTest()
        {
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30For().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30For()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30For()[1].Name == "Juego");
        }

        [TestMethod()]
        public void GetProductsGreaterThan30WhileTest()
        {
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30For().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30For()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30For()[1].Name == "Juego");
        }

        [TestMethod()]
        public void GetProductsGreaterThan30LinQTest()
        {
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30For().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30For()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductsGreaterThan30For()[1].Name == "Juego");
        }
    }
}