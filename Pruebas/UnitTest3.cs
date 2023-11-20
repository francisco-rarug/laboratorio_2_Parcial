using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fabrica;

namespace TusPruebas
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestHayStockSuficiente_DeberiaRetornarTrueCuandoHayStockSuficiente()
        {
            // Arrange
            Produccion.Materiales["vegano"] = 10;
            Produccion.Materiales["2x2"] = 5;

            // Act
            bool resultado = Produccion.HayStockSuficiente("vegano", "2x2", 10, 5);

            // Assert
            Assert.IsTrue(resultado, "Se esperaba que hubiera stock suficiente.");
        }
    }
}





