using System;
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KaffeNetCore;

namespace KaffeNetCore.Test
{
    [TestClass]
    public class KaffeTest
    {
        [TestMethod]
        public void PrisLatteTest()
        {
            // Arrange
            Latte testLatte = new Latte();

            // Act
            var result = testLatte.Pris();

            // Assert
            Assert.AreEqual(40,result);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortKaffeRabatTest()
        {
            // Arrange
            SortKaffe testSortKaffe = new SortKaffe(20);
            
            // Act
            testSortKaffe.Pris();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CortadoKaffeRabatTest()
        {
            // Arrange
            Cortado testCortado = new Cortado(25);

            // Act
            testCortado.Pris();

            // Assert
            Assert.Fail();
        }
    }
}
