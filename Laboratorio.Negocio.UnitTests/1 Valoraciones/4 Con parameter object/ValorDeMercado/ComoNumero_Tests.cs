using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Valoraciones.ConParameterObject;

namespace Laboratorio.Negocio.UnitTests.Valoraciones.ConParameterObject.ValorDeMercado_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DatosDeLaValoracionEnColones losDatos;

        [TestInitialize]
        public void Inicialice()
        {
            losDatos = new DatosDeLaValoracionEnColones();
            losDatos.MontoNominal = 10000;
            losDatos.TipoDeCambio = 758.19M;
            losDatos.PrecioLimpio = 100.6569M;
        }

        [TestMethod]
        public void ComoNumero_NoEsColon_UsaElMontoConvertido()
        {
            elResultadoEsperado = 10065.69M;

            losDatos.TipoDeMoneda = Monedas.USDolar;
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_EsColon_UsaElMontoNominal()
        {
            elResultadoEsperado = 7631705.5011M;

            losDatos.TipoDeMoneda = Monedas.Colon;
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}