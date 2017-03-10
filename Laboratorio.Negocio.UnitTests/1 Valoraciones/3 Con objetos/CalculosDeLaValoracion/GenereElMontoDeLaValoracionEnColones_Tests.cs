using Negocio.Valoraciones.ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Negocio.UnitTests.Valoraciones.ConObjetos.MontoDeLaValoracionEnColones_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elMontoNominal;
        private decimal elPorcentajeDeCobertura;
        private decimal elPrecioLimpio;
        private decimal elTipoDeCambio;
        private Monedas elTipoDeMoneda;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_NoEsColon_UsaElMontoConvertido()
        {
            decimal elResultadoEsperado = 9049.9860M;

            decimal elMontoNominal = 10000M;
            decimal elPrecioLimpio = 100.5554M;
            decimal elPorcentajeDeCobertura = 0.9M;
            Monedas elTipoDeMoneda = Monedas.UDEs;
            decimal elResultadoObtenido = new MontoDeLaValoracionEnColones(elMontoNominal, elTipoDeCambio, elPrecioLimpio, elPorcentajeDeCobertura, elTipoDeMoneda).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_EsColon_UsaElMontoNominal()
        {
            elResultadoEsperado = 6868534.9510M;

            elTipoDeCambio = 758.19M;
            elMontoNominal = 10000M;
            elPrecioLimpio = 100.6569M;
            elPorcentajeDeCobertura = 0.9M;
            elTipoDeMoneda = Monedas.Colon;
            elResultadoObtenido = new MontoDeLaValoracionEnColones(elMontoNominal, elTipoDeCambio, elPrecioLimpio, elPorcentajeDeCobertura, elTipoDeMoneda).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}