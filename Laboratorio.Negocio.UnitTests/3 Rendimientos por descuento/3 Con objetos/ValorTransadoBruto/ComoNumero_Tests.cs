using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.RendimientosPorDescuento.ConObjetos;

namespace Negocio.UnitTests.RendimientosPorDescuento_Tests.ConObjetos.ValorTransadoBruto_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        decimal elResultadoEsperado;
        decimal elResultadoObtenido;
        private decimal elValorFacial;
        private decimal elValorTransadoNeto;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;
        private decimal laTasaDeImpuesto;

        [TestMethod]
        public void ComoNumero_CasoUnico_LaFormula()
        {
            elResultadoEsperado = 298378.37837837837837837837837M;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 8;
            laFechaDeVencimiento = new DateTime(2016, 3, 3);
            laFechaActual = new DateTime(2016, 10, 10);
            elResultadoObtenido = new ValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}