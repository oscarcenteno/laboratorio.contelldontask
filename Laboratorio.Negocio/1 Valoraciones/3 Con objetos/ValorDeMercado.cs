namespace Negocio.Valoraciones.ConObjetos
{   
    public class ValorDeMercado
    {
        decimal elMontoConvertido;
        decimal elPrecioLimpio;

        public ValorDeMercado(decimal elMontoNominal, decimal elTipoDeCambio, decimal elPrecioLimpio, Monedas elTipoDeMoneda)
        {
            elMontoConvertido = DetermineElMontoConvertido(elMontoNominal, elTipoDeCambio, elTipoDeMoneda);
            this.elPrecioLimpio = elPrecioLimpio;
        }

        private static decimal DetermineElMontoConvertido(decimal elMontoNominal, decimal elTipoDeCambio, Monedas elTipoDeMoneda)
        {
            if (elTipoDeMoneda == Monedas.Colon)
                return elMontoNominal * elTipoDeCambio;
            else
                return elMontoNominal;
        }

        public decimal ComoNumero()
        {
            return elMontoConvertido * (elPrecioLimpio / 100);
        }
    }
}