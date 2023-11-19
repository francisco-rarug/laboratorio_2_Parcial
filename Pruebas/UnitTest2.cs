using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fabrica;
using System.Collections.Generic;

namespace Pruebas
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestBuscarPorUsuarioYRango_UsuarioYRangoValidos_DeberiaEncontrarOperario()
        {
            // Arrange
            var operarioEsperado = new Operario("ricardo", "hoy", Rango.Operario, "fort", 11);
            var listaPersonal = new List<Operario>
            {
                operarioEsperado,
            };

            // Act
            var resultado = Operario.BuscarPorUsuarioYRango("ricardo", "hoy", Rango.Operario, listaPersonal);

            // Assert
            Assert.AreEqual(operarioEsperado.Usuario, resultado.Usuario);
            Assert.AreEqual(operarioEsperado.Password, resultado.Password);
            Assert.AreEqual(operarioEsperado.Rango, resultado.Rango);
            Assert.AreEqual(operarioEsperado.Apellido, resultado.Apellido);
            Assert.AreEqual(operarioEsperado.Id, resultado.Id);

        }


    }
}

