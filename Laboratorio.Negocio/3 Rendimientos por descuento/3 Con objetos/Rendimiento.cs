using System;

namespace Negocio.RendimientosPorDescuento.ConObjetos
{
    public class Rendimiento
    {
        decimal elValorFacial;
        decimal elValorTransadoBruto;

        public Rendimiento(decimal elValorFacial, decimal elValorTransadoNeto, decimal laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            this.elValorFacial = elValorFacial;
            elValorTransadoBruto = DetermineElValorTransadorBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal);
        }

        private static decimal DetermineElValorTransadorBruto(decimal elValorFacial, decimal elValorTransadoNeto, decimal laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            if (tieneTratamientoFiscal)
                return ObtengaElValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);
            else
                return elValorTransadoNeto;
        }

        private static decimal ObtengaElValorTransadoBruto(decimal elValorFacial, decimal elValorTransadoNeto, decimal laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return new ValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).ComoNumero();
        }

        public decimal ComoNumero()
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}