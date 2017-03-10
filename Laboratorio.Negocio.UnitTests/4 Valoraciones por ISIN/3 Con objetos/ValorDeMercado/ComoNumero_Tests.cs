using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.ValoracionesPorISIN.ConObjetos;

namespace Negocio.UnitTests.ValoracionesPorISIN.ConObjetos.ValorDeMercado__Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        decimal elResultadoEsperado;
        decimal elResultadoObtenido;
        decimal elTipoDeCambioDeUDESDeAyer;
        decimal elTipoDeCambioDeUDESDeHoy;
        decimal elMontoNominalDelSaldo;
        bool elSaldoEstaAnotadoEnCuenta;
        Monedas elTipoDeMoneda;
        decimal elPrecioLimpioDelVectorDePrecios;

        [TestInitialize]
        public void Inicialice()
        {
        }

        [TestMethod]
        public void ComoNumero_UDESAnotadoEnCuentaYHayTipoDeCambioParaHoy_LaFormula()
        {
            elResultadoEsperado = 600000;

            elPrecioLimpioDelVectorDePrecios = 80;
            elTipoDeMoneda = Monedas.UDES;
            elSaldoEstaAnotadoEnCuenta = true;
            elMontoNominalDelSaldo = 1000;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;
            elResultadoObtenido = new ValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_UDESNoAnotadoEnCuenta_LaFormula()
        {
            elResultadoEsperado = 800;

            elPrecioLimpioDelVectorDePrecios = 80;
            elTipoDeMoneda = Monedas.UDES;
            elSaldoEstaAnotadoEnCuenta = false;
            elMontoNominalDelSaldo = 1000;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;
            elResultadoObtenido = new ValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_UDESAnotadoEnCuentaYNoHayTipoDeCambioParaHoy_LaFormula()
        {
            elResultadoEsperado = 596000;

            elPrecioLimpioDelVectorDePrecios = 80;
            elTipoDeMoneda = Monedas.UDES;
            elSaldoEstaAnotadoEnCuenta = true;
            elMontoNominalDelSaldo = 1000;
            elTipoDeCambioDeUDESDeHoy = 0;
            elTipoDeCambioDeUDESDeAyer = 745;
            elResultadoObtenido = new ValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_Colon_ElMontoNominalDelSaldo()
        {
            elResultadoEsperado = 2862400.0M;

            elPrecioLimpioDelVectorDePrecios = 80;
            elTipoDeMoneda = Monedas.Colon;
            elSaldoEstaAnotadoEnCuenta = true;
            elMontoNominalDelSaldo = 3578000;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;
            elResultadoObtenido = new ValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}