using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.ValoracionesPorISIN.ConObjetos;

namespace Negocio.UnitTests.ValoracionesPorISIN.ConObjetos.PorcentajeDeCobertura__Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        decimal elResultadoEsperado;
        decimal elResultadoObtenido;
        DateTime laFechaActual;
        DateTime laFechaDeVencimientoDelValorOficial;
        int losDiasMinimosAlVencimientoDelEmisor;
        decimal elPorcentajeCobertura;

        [TestInitialize]
        public void Inicialice()
        {
            losDiasMinimosAlVencimientoDelEmisor = 7;
            elPorcentajeCobertura = 0.9M;
            laFechaActual = new DateTime(2016, 3, 3);
        }

        [TestMethod]
        public void ComoNumero_CumpleDiasMinimos_ElPorcentajeRecibido()
        {
            elResultadoEsperado = 0.9M;

            laFechaDeVencimientoDelValorOficial = new DateTime(2016, 10, 10);
            elResultadoObtenido = new PorcentajeDeCobertura(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_NoCumpleDiasMinimos_Cero()
        {
            elResultadoEsperado = 0;

            laFechaDeVencimientoDelValorOficial = new DateTime(2016, 3, 7); ;
            elResultadoObtenido = new PorcentajeDeCobertura(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}