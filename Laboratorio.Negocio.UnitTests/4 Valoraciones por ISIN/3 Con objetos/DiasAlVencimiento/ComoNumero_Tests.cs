using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.ValoracionesPorISIN.ConObjetos;

namespace Negocio.UnitTests.ValoracionesPorISIN.ConObjetos.DiasAlVencimiento_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        double elResultadoEsperado;
        double elResultadoObtenido;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimientoDelValorOficial;

        [TestMethod]
        public void ComoNumero_CasoUnico_LaFormula()
        {
            elResultadoEsperado = 221;

            laFechaActual = new DateTime(2016, 3, 3);
            laFechaDeVencimientoDelValorOficial = new DateTime(2016, 10, 10);
            elResultadoObtenido = new DiasAlVencimiento(laFechaActual, laFechaDeVencimientoDelValorOficial).ComoNumeros();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}