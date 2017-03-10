using Negocio.Valoraciones.ConParameterObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laboratorio.Negocio.UnitTests.Valoraciones.ConParameterObject.MontoDeLaValoracionEnColones_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DatosDeLaValoracionEnColones losDatos;

        [TestMethod]
        public void ComoNumero_NoEsColon_UsaElMontoConvertido()
        {
            elResultadoEsperado = 9049.9860M;

            InicialiceLosDatosEnUDES();
            elResultadoObtenido = new MontoDeLaValoracionEnColones(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceLosDatosEnUDES()
        {
            losDatos = new DatosDeLaValoracionEnColones();
            losDatos.MontoNominal = 10000M;
            losDatos.PrecioLimpio = 100.5554M;
            losDatos.PorcentajeDeCobertura = 0.9M;
            losDatos.TipoDeMoneda = Monedas.UDEs;
        }

        [TestMethod]
        public void ComoNumero_EsColon_UsaElMontoNominal()
        {
            elResultadoEsperado = 6868534.9510M;

            InicialiceLosDatosEnColones();
            elResultadoObtenido = new MontoDeLaValoracionEnColones(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceLosDatosEnColones()
        {
            losDatos = new DatosDeLaValoracionEnColones();
            losDatos.TipoDeCambio = 758.19M;
            losDatos.MontoNominal = 10000M;
            losDatos.PrecioLimpio = 100.6569M;
            losDatos.PorcentajeDeCobertura = 0.9M;
            losDatos.TipoDeMoneda = Monedas.Colon;
        }
    }
}