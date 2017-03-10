namespace Negocio.ValoracionesPorISIN.ConObjetos
{
    public class ValorDeMercado
    {
        decimal elMontoConvertido;
        decimal elPrecioLimpioDelVectorDePrecios;

        public ValorDeMercado(decimal elPrecioLimpioDelVectorDePrecios, Monedas elTipoDeMoneda, bool elSaldoEstaAnotadoEnCuenta, decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy, decimal elTipoDeCambioDeUDESDeAyer)
        {
            elMontoConvertido = DetermineElMontoConvertido(elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
            this.elPrecioLimpioDelVectorDePrecios = elPrecioLimpioDelVectorDePrecios;
        }

        private static decimal DetermineElMontoConvertido(Monedas elTipoDeMoneda, bool elSaldoEstaAnotadoEnCuenta, decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy, decimal elTipoDeCambioDeUDESDeAyer)
        {
            // Solamente se convierten los UDES que están anotados en cuenta. Los que no están anotados ya están colonizados.
            if (elTipoDeMoneda == Monedas.UDES & elSaldoEstaAnotadoEnCuenta)
                return DetermineElMontoConvertidoEnUDESAnotadoEnCuenta(elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
            else
                return elMontoNominalDelSaldo;
        }

        private static decimal DetermineElMontoConvertidoEnUDESAnotadoEnCuenta(decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy, decimal elTipoDeCambioDeUDESDeAyer)
        {
            // Los saldos en UDES se colonizan según el tipo de cambio de hoy, si no, el de ayer.
            if (elTipoDeCambioDeUDESDeHoy > 0)
                return elMontoNominalDelSaldo * elTipoDeCambioDeUDESDeHoy;
            else
                return elMontoNominalDelSaldo * elTipoDeCambioDeUDESDeAyer;
        }

        public decimal ComoNumero()
        {
            return elMontoConvertido * (elPrecioLimpioDelVectorDePrecios / 100);
        }
    }
}