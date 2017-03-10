using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.RendimientosPorDescuento.ConParameterObject;

namespace Negocio.UnitTests.RendimientosPorDescuento_Tests.ConParameterObject.Rendimiento_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        decimal elResultadoEsperado;
        decimal elResultadoObtenido;
        private DatosDelRendimientoPorDescuento losDatos;

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
        public void ComoNumero_ConTratamientoFiscal_UsaValorTransadoBrutoCalculado()
        {
            elResultadoEsperado = 21621.62162162162162162162163M;

            losDatos.TieneTratamientoFiscal = true;
            elResultadoObtenido = new Rendimiento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SinTratamientoFiscal_UsaValorTransadoNeto()
        {
            elResultadoEsperado = 20000;

            losDatos.TieneTratamientoFiscal = false;
            elResultadoObtenido = new Rendimiento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}