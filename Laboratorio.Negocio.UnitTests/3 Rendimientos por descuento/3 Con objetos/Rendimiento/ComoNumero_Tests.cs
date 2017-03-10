using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.RendimientosPorDescuento.ConObjetos;

namespace Negocio.UnitTests.RendimientosPorDescuento_Tests.ConObjetos.Rendimiento_Tests
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
        public void ComoNumero_ConTratamientoFiscal_UsaValorTransadoBrutoCalculado()
        {
            elResultadoEsperado = 21621.62162162162162162162163M;

            tieneTratamientoFiscal = true;
            elResultadoObtenido = new Rendimiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SinTratamientoFiscal_UsaValorTransadoNeto()
        {
            elResultadoEsperado = 20000;

            tieneTratamientoFiscal = false;
            elResultadoObtenido = new Rendimiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}