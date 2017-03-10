using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.RendimientosPorDescuento.ConObjetos;

namespace Negocio.UnitTests.RendimientosPorDescuento_Tests.ConObjetos.TasaBruta_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        decimal elResultadoEsperado;
        decimal elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_CasoUnico_LaFormula()
        {
            elResultadoEsperado = 11.96799790150173781887336875M;

            elResultadoObtenido = new TasaBruta(320000, 300000, 8, 221).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}