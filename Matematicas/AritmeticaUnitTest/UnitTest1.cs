using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematicas;

namespace AritmeticaUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumaTestMethod()
        {
            double resultado = Aritmetica.suma(2.5, 2.5);

            Assert.AreEqual(5.0, resultado);
        }

        [TestMethod]
        public void MultiplicarTestMetod()
        {
            double resultado = Aritmetica.multiplicar(2,2);

            Assert.AreEqual(4, resultado);
        }
    }
}
