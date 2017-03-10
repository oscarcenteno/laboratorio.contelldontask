namespace Negocio.ValoracionesPorISIN.ConParameterObject
{
    public class ValorDeMercado
    {
        decimal elMontoConvertido;
        decimal elPrecioLimpioDelVectorDePrecios;

        public ValorDeMercado(DatosDeLaValoracion losDatos)
        {
            elMontoConvertido = DetermineElMontoConvertido(losDatos);
            elPrecioLimpioDelVectorDePrecios = losDatos.PrecioLimpioDelVectorDePrecios;
        }

        private static decimal DetermineElMontoConvertido(DatosDeLaValoracion losDatos)
        {
            // TODO: Mas de una sola operacion
            // Solamente se convierten los UDES que están anotados en cuenta. Los que no están anotados ya están colonizados.
            if (losDatos.TipoDeMoneda == Monedas.UDES & losDatos.SaldoEstaAnotadoEnCuenta)
                return DetermineElMontoConvertidoEnUDESAnotadoEnCuenta(losDatos);
            else
                return losDatos.MontoNominalDelSaldo;
        }

        private static decimal DetermineElMontoConvertidoEnUDESAnotadoEnCuenta(DatosDeLaValoracion losDatos)
        {
            // TODO: Mas de una sola operacion
            // Los saldos en UDES se colonizan según el tipo de cambio de hoy, si no, el de ayer.
            if (losDatos.TipoDeCambioDeUDESDeHoy > 0)
                return losDatos.MontoNominalDelSaldo * losDatos.TipoDeCambioDeUDESDeHoy;
            else
                return losDatos.MontoNominalDelSaldo * losDatos.TipoDeCambioDeUDESDeAyer;
        }

        public decimal ComoNumero()
        {
            return elMontoConvertido * (elPrecioLimpioDelVectorDePrecios / 100);
        }
    }
}