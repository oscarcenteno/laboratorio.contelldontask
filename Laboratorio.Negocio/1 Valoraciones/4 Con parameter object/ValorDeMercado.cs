namespace Negocio.Valoraciones.ConParameterObject
{   
    public class ValorDeMercado
    {
        decimal elMontoConvertido;
        decimal elPrecioLimpio;

        public ValorDeMercado(DatosDeLaValoracionEnColones losDatos)
        {
            elMontoConvertido = DetermineElMontoConvertido(losDatos);
            elPrecioLimpio = losDatos.PrecioLimpio;
        }

        private static decimal DetermineElMontoConvertido(DatosDeLaValoracionEnColones losDatos)
        {
            // TODO: Mas de una sola operacion
            if (losDatos.TipoDeMoneda == Monedas.Colon)
                return losDatos.MontoNominal * losDatos.TipoDeCambio;
            else
                return losDatos.MontoNominal;
        }

        public decimal ComoNumero()
        {
            return elMontoConvertido * (elPrecioLimpio / 100);
        }
    }
}