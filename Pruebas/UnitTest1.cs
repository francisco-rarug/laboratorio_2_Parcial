using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fabrica;
using System.Collections.Generic;

namespace Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBuscarPorUsuarioYRango_UsuarioYRangoValidos_DeberiaEncontrarSupervisor()
        {
            // Arrange
            var supervisorEsperado = new Supervisor("francisco", "rojo", Rango.Supervisor, "7777", 2);
            var listaPersonal = new List<Supervisor>
            {
                supervisorEsperado,
            };

            // Act
            var resultado = Supervisor.BuscarPorUsuarioYRango("francisco", "rojo", Rango.Supervisor, listaPersonal);

            // Assert
            Assert.AreEqual(supervisorEsperado.Usuario, resultado.Usuario);
            Assert.AreEqual(supervisorEsperado.Password, resultado.Password);
            Assert.AreEqual(supervisorEsperado.Rango, resultado.Rango);
            Assert.AreEqual(supervisorEsperado.Legajo, resultado.Legajo);
            Assert.AreEqual(supervisorEsperado.Id, resultado.Id);
        }
    }
}
