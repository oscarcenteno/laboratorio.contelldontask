using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.RendimientosPorDescuento.ConParameterObject;
using System;

namespace Negocio.UnitTests.RendimientosPorDescuento_Tests.ConParameterObject.RendimientoPorDescuentoRedondeado_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        DatosDelRendimientoPorDescuento losDatos;

        [TestInitialize]
        public void Initialice()
        {
            losDatos = new DatosDelRendimientoPorDescuento();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 8;
            losDatos.FechaDeVencimiento = new DateTime(2016, 10, 10);
            losDatos.FechaActual = new DateTime(2016, 3, 3);
        }

        [TestMethod]
        public void ComoNumero_ConTratamientoFiscal_LaFormula()
        {
            elResultadoEsperado = 21621.6216M;

            losDatos.TieneTratamientoFiscal = true;
            elResultadoObtenido = new RendimientoPorDescuentoRedondeado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SinTratamientoFiscal_LaResta()
        {
            elResultadoEsperado = 20000;

            losDatos.TieneTratamientoFiscal = false;
            elResultadoObtenido = new RendimientoPorDescuentoRedondeado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}