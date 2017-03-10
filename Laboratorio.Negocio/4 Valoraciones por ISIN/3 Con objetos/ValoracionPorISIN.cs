using System;

namespace Negocio.ValoracionesPorISIN.ConObjetos
{
    public class ValoracionPorISIN
    {
        decimal elValorDeMercado;
        decimal elPorcentajeDeCoberturaRevisado;

        public ValoracionPorISIN(string elISIN, DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial, int losDiasMinimosAlVencimientoDelEmisor, decimal elPorcentajeCobertura, decimal elPrecioLimpioDelVectorDePrecios, Monedas elTipoDeMoneda, bool elSaldoEstaAnotadoEnCuenta, decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy, decimal elTipoDeCambioDeUDESDeAyer)
        {
            ISIN = elISIN;

            elValorDeMercado = ObtengaElValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
            ValorDeMercado = elValorDeMercado;

            elPorcentajeDeCoberturaRevisado = ObtengaElPorcentajeDeCobertura(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura);
            PorcentajeCobertura = elPorcentajeDeCoberturaRevisado;
        }

        public string ISIN { get; private set; }
        public decimal ValorDeMercado { get; private set; }
        public decimal PorcentajeCobertura { get; private set; }
        public decimal AporteDeGarantia => elValorDeMercado * elPorcentajeDeCoberturaRevisado;

        private static decimal ObtengaElValorDeMercado(decimal elPrecioLimpioDelVectorDePrecios, Monedas elTipoDeMoneda, bool elSaldoEstaAnotadoEnCuenta, decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy, decimal elTipoDeCambioDeUDESDeAyer)
        {
            return new ValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();
        }

        private static decimal ObtengaElPorcentajeDeCobertura(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial, int losDiasMinimosAlVencimientoDelEmisor, decimal elPorcentajeCobertura)
        {
            return new PorcentajeDeCobertura(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura).ComoNumero();
        }
    }
}