using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.RendimientosPorDescuento.ConObjetos;
using System;

namespace Negocio.UnitTests.RendimientosPorDescuento_Tests.ConObjetos_Tests_RendimientoPorDescuentoRedondeado_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private decimal elValorFacial;
        private decimal elValorTransadoNeto;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;
        private decimal laTasaDeImpuesto;
        private bool tieneTratamientoFiscal;

        [TestInitialize]
        public void Initialice()
        {
            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 8;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
        }

        [TestMethod]
        public void ComoNumero_ConTratamientoFiscal_LaFormula()
        {
            elResultadoEsperado = 21621.6216M;

            tieneTratamientoFiscal = true;
            elResultadoObtenido = new RendimientoPorDescuentoRedondeado(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SinTratamientoFiscal_LaResta()
        {
            elResultadoEsperado = 20000;

            tieneTratamientoFiscal = false;
            elResultadoObtenido = new RendimientoPorDescuentoRedondeado(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}