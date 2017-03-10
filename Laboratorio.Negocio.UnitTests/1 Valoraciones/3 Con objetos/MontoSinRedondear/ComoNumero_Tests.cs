using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Valoraciones.ConObjetos;

namespace Laboratorio.Negocio.UnitTests.Valoraciones.MontoSinRedondear_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private decimal elMontoNominal;
        private decimal elTipoDeCambio;
        private decimal elPrecioLimpio;
        private decimal elPorcentajeDeCobertura;
        private Monedas elTipoDeMoneda;

        [TestMethod]
        public void ComoNumero_CasoUnico_LaFormula()
        {
            elResultadoEsperado = 6868534.95099M;

            elMontoNominal = 10000;
            elTipoDeCambio = 758.19M;
            elPrecioLimpio = 100.6569M;
            elPorcentajeDeCobertura = 0.9M;
            elTipoDeMoneda = Monedas.Colon;
            elResultadoObtenido = new MontoSinRedondear(elMontoNominal, elTipoDeCambio, elPrecioLimpio, elPorcentajeDeCobertura, elTipoDeMoneda).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
