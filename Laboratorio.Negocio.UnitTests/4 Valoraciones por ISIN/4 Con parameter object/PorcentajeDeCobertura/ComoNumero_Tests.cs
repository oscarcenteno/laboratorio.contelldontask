using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.ValoracionesPorISIN.ConParameterObject;

namespace Negocio.UnitTests.ValoracionesPorISIN.ConParameterObject.PorcentajeDeCobertura__Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        decimal elResultadoEsperado;
        decimal elResultadoObtenido;
        private DatosDeLaValoracion losDatos;

        [TestInitialize]
        public void Inicialice()
        {
            losDatos = new DatosDeLaValoracion();
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.9M;
            losDatos.FechaActual = new DateTime(2016, 3, 3);
        }

        [TestMethod]
        public void ComoNumero_CumpleDiasMinimos_ElPorcentajeRecibido()
        {
            elResultadoEsperado = 0.9M;

            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 10, 10);
            elResultadoObtenido = new PorcentajeDeCobertura(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_NoCumpleDiasMinimos_Cero()
        {
            elResultadoEsperado = 0;

            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 3, 7); ;
            elResultadoObtenido = new PorcentajeDeCobertura(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}