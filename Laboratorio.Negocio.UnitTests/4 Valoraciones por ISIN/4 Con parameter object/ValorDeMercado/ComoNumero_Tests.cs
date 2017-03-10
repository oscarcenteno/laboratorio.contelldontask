using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.ValoracionesPorISIN.ConParameterObject;

namespace Negocio.UnitTests.ValoracionesPorISIN.ConParameterObject.ValorDeMercado__Tests
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
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;
        }

        [TestMethod]
        public void ComoNumero_UDESAnotadoEnCuentaYHayTipoDeCambioParaHoy_LaFormula()
        {
            elResultadoEsperado = 600000;

            InicialiceUDESAnotadoEnCuentaYHayTipoDeCambioParaHoy();
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceUDESAnotadoEnCuentaYHayTipoDeCambioParaHoy()
        {
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.SaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
        }

        [TestMethod]
        public void ComoNumero_UDESNoAnotadoEnCuenta_LaFormula()
        {
            elResultadoEsperado = 800;

            InicialiceDatosEnUDESAnotado();
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceDatosEnUDESAnotado()
        {
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.SaldoEstaAnotadoEnCuenta = false;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
        }

        [TestMethod]
        public void ComoNumero_UDESAnotadoEnCuentaYNoHayTipoDeCambioParaHoy_LaFormula()
        {
            elResultadoEsperado = 596000;

            InicialiceDatosEnUDESAnotadoYNoHayTipoDeCambioParaHoy();
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceDatosEnUDESAnotadoYNoHayTipoDeCambioParaHoy()
        {
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.SaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 0;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;
        }

        [TestMethod]
        public void ComoNumero_Colon_ElMontoNominalDelSaldo()
        {
            elResultadoEsperado = 2862400.0M;

            InicialiceDatosEnColones();
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceDatosEnColones()
        {
            losDatos.TipoDeMoneda = Monedas.Colon;
            losDatos.SaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 3578000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
        }
    }
}