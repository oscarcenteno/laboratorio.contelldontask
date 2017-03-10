using System;

namespace Negocio.Valoraciones.ConTellDontAsk
{
    public class MontoDeLaValoracionEnColones
    {
        decimal elMontoSinRedondear;

        public MontoDeLaValoracionEnColones(DatosDeLaValoracionEnColones losDatos)
        {
            elMontoSinRedondear = ObtengaElMontoSinRedondear(losDatos);
        }

        private static decimal ObtengaElMontoSinRedondear(DatosDeLaValoracionEnColones losDatos)
        {
            return new MontoSinRedondear(losDatos).ComoNumero();
        }

        public decimal ComoNumero()
        {
            return Math.Round(elMontoSinRedondear, 4);
        }
    }
}