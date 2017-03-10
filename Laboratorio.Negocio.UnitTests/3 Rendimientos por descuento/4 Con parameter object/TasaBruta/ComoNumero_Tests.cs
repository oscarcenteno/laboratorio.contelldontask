using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.RendimientosPorDescuento.ConParameterObject;

namespace Negocio.UnitTests.RendimientosPorDescuento_Tests.ConParameterObject.TasaBruta_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        decimal elResultadoEsperado;
        decimal elResultadoObtenido;
        private DatosDeLaTasaBruta losDatos;

        [TestMethod]
        public void ComoNumero_CasoUnico_LaFormula()
        {
            elResultadoEsperado = 11.96799790150173781887336875M;

            InicialiceLosDatos();
            elResultadoObtenido = new TasaBruta(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceLosDatos()
        {
            losDatos = new DatosDeLaTasaBruta();
            losDatos.ValorFacial = 320000;
            losDatos.ValorTransadoNeto = 300000;
            losDatos.TasaDeImpuesto = 8;
            losDatos.DiasAlVencimiento = 221;
        }
    }
}