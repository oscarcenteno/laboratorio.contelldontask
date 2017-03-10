using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.RendimientosPorDescuento.ConParameterObject;

namespace Negocio.UnitTests.RendimientosPorDescuento_Tests.ConParameterObject.ValorTransadoBruto_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        decimal elResultadoEsperado;
        decimal elResultadoObtenido;
        private DatosDelRendimientoPorDescuento losDatos;

        [TestMethod]
        public void ComoNumero_CasoUnico_LaFormula()
        {
            elResultadoEsperado = 298378.37837837837837837837837M;

            InicialiceLosDatos();
            elResultadoObtenido = new ValorTransadoBruto(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceLosDatos()
        {
            losDatos = new DatosDelRendimientoPorDescuento();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 8;
            losDatos.FechaDeVencimiento = new DateTime(2016, 3, 3);
            losDatos.FechaActual = new DateTime(2016, 10, 10);
        }
    }
}