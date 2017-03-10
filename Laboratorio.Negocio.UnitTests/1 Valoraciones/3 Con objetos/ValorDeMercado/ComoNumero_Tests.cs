using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Valoraciones.ConObjetos;

namespace Laboratorio.Negocio.UnitTests.Valoraciones.ValorDeMercado_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private decimal elMontoNominal;
        private decimal elTipoDeCambio;
        private decimal elPrecioLimpio;
        private Monedas elTipoDeMoneda;

        [TestMethod]
        public void ComoNumero_NoEsColon_UsaElMontoConvertido()
        {
            elResultadoEsperado = 10065.69M;

            elMontoNominal = 10000;
            elTipoDeCambio = 758.19M;
            elPrecioLimpio = 100.6569M;
            elTipoDeMoneda = Monedas.USDolar;
            elResultadoObtenido = new ValorDeMercado(elMontoNominal, elTipoDeCambio, elPrecioLimpio, elTipoDeMoneda).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_EsColon_UsaElMontoNominal()
        {
            elResultadoEsperado = 7631705.5011M;

            elMontoNominal = 10000;
            elTipoDeCambio = 758.19M;
            elPrecioLimpio = 100.6569M;
            elTipoDeMoneda = Monedas.Colon;
            elResultadoObtenido = new ValorDeMercado(elMontoNominal, elTipoDeCambio, elPrecioLimpio, elTipoDeMoneda).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
