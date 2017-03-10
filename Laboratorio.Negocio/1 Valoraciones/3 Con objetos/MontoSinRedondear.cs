namespace Negocio.Valoraciones.ConObjetos
{
    public class MontoSinRedondear
    {
        decimal elPorcentajeDeCobertura;
        decimal elValorMercado;

        public MontoSinRedondear(decimal elMontoNominal, decimal elTipoDeCambio, decimal elPrecioLimpio, decimal elPorcentajeDeCobertura, Monedas elTipoDeMoneda)
        {
            elValorMercado = ObtengaElValorDeMercado(elMontoNominal, elTipoDeCambio, elPrecioLimpio, elTipoDeMoneda);
            this.elPorcentajeDeCobertura = elPorcentajeDeCobertura;
        }

        private static decimal ObtengaElValorDeMercado(decimal elMontoNominal, decimal elTipoDeCambio, decimal elPrecioLimpio, Monedas elTipoDeMoneda)
        {
            return new ValorDeMercado(elMontoNominal, elTipoDeCambio, elPrecioLimpio, elTipoDeMoneda).ComoNumero();
        }

        public decimal ComoNumero()
        {
            return elValorMercado * elPorcentajeDeCobertura;
        }
    }
}