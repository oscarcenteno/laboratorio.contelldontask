using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.ValoracionesPorISIN.ConParameterObject;

namespace Negocio.UnitTests.ValoracionesPorISIN.ConParameterObject.DiasAlVencimiento_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        double elResultadoEsperado;
        double elResultadoObtenido;
        private DatosDeLaValoracion losDatos;

        [TestMethod]
        public void ComoNumero_CasoUnico_LaFormula()
        {
            elResultadoEsperado = 221;

            InicialiceLosDatos();
            elResultadoObtenido = new DiasAlVencimiento(losDatos).ComoNumeros();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceLosDatos()
        {
            losDatos = new DatosDeLaValoracion();
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 10, 10);
        }
    }
}