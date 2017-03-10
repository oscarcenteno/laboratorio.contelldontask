using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Valoraciones.ConParameterObject;

namespace Laboratorio.Negocio.UnitTests.Valoraciones.ConParameterObject.MontoSinRedondear_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DatosDeLaValoracionEnColones losDatos;

        [TestMethod]
        public void ComoNumero_CasoUnico_LaFormula()
        {
            elResultadoEsperado = 6868534.95099M;

            InicialiceLosDatos();
            elResultadoObtenido = new MontoSinRedondear(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceLosDatos()
        {
            losDatos = new DatosDeLaValoracionEnColones();
            losDatos.MontoNominal = 10000;
            losDatos.TipoDeCambio = 758.19M;
            losDatos.PrecioLimpio = 100.6569M;
            losDatos.PorcentajeDeCobertura = 0.9M;
            losDatos.TipoDeMoneda = Monedas.Colon;
        }
    }
}
