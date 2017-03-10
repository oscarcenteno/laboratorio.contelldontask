using System;

namespace Negocio.Valoraciones.ConFunciones
{
    public static class CalculosDeLaValoracion
    {
        public static decimal GenereElMontoDeLaValoracionEnColones(
                    decimal elMontoNominal,
                    decimal elTipoDeCambio,
                    decimal elPrecioLimpio,
                    decimal elPorcentajeDeCobertura,
                    Monedas elTipoDeMoneda)
        {
            decimal elMontoSinRedondear = ObtengaElMontoSinRedondear(elMontoNominal, elTipoDeCambio, elPrecioLimpio, elPorcentajeDeCobertura, elTipoDeMoneda);

            return Redondee(elMontoSinRedondear);
        }

        private static decimal ObtengaElMontoSinRedondear(decimal elMontoNominal, decimal elTipoDeCambio, decimal elPrecioLimpio, decimal elPorcentajeDeCobertura, Monedas elTipoDeMoneda)
        {
            decimal elValorMercado = ObtengaElValorDeMercado(elMontoNominal, elTipoDeCambio, elPrecioLimpio, elTipoDeMoneda);

            return CalculeElMontoSinRedondear(elPorcentajeDeCobertura, elValorMercado);
        }

        private static decimal ObtengaElValorDeMercado(decimal elMontoNominal, decimal elTipoDeCambio, decimal elPrecioLimpio, Monedas elTipoDeMoneda)
        {
            decimal elMontoConvertido = DetermineElMontoConvertido(elMontoNominal, elTipoDeCambio, elTipoDeMoneda);

            return CalculeElValorDeMercado(elPrecioLimpio, elMontoConvertido);
        }

        private static decimal DetermineElMontoConvertido(decimal elMontoNominal, decimal elTipoDeCambio, Monedas elTipoDeMoneda)
        {
            if (elTipoDeMoneda == Monedas.Colon)
                return elMontoNominal * elTipoDeCambio;
            else
                return elMontoNominal;
        }

        private static decimal CalculeElValorDeMercado(decimal elPrecioLimpio, decimal elMontoConvertido)
        {
            return elMontoConvertido * (elPrecioLimpio / 100);
        }

        private static decimal CalculeElMontoSinRedondear(decimal elPorcentajeDeCobertura, decimal elValorMercado)
        {
            return elValorMercado * elPorcentajeDeCobertura;
        }

        private static decimal Redondee(decimal elMontoSinRedondear)
        {
            return Math.Round(elMontoSinRedondear, 4);
        }
    }
}