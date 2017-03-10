namespace Negocio.Valoraciones.ConParameterObject
{
    public class MontoSinRedondear
    {
        decimal elPorcentajeDeCobertura;
        decimal elValorMercado;

        public MontoSinRedondear(DatosDeLaValoracionEnColones losDatos)
        {
            elValorMercado = ObtengaElValorDeMercado(losDatos);
            elPorcentajeDeCobertura = losDatos.PorcentajeDeCobertura;
        }

        private static decimal ObtengaElValorDeMercado(DatosDeLaValoracionEnColones losDatos)
        {
            return new ValorDeMercado(losDatos).ComoNumero();
        }

        public decimal ComoNumero()
        {
            return elValorMercado * elPorcentajeDeCobertura;
        }
    }
}