using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.RendimientosPorDescuento.ComoUnProcedimiento;
using System;

namespace Negocio.UnitTests.RendimientosPorDescuento_Tests.ComoUnProcedimiento_Tests
{
    [TestClass]
    public class GenereElRendimientoPorDescuentoRedondeado_Tests
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
        public void GenereElRendimientoPorDescuento_ConTratamientoFiscal_LaFormula()
        {
            elResultadoEsperado = 21621.6216M;

            tieneTratamientoFiscal = true;
            elResultadoObtenido = CalculosDeRendimiento.GenereElRendimientoPorDescuentoRedondeado(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElRendimientoPorDescuento_SinTratamientoFiscal_LaResta()
        {
            elResultadoEsperado = 20000;

            tieneTratamientoFiscal = false;
            elResultadoObtenido = CalculosDeRendimiento.GenereElRendimientoPorDescuentoRedondeado(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}