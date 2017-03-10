using System;

namespace Negocio.RendimientosPorDescuento.ConObjetos
{
    public class ValorTransadoBruto
    {
        decimal elValorFacial;
        decimal laTasaBruta;
        decimal losDiasAlVencimiento;

        public ValorTransadoBruto(decimal elValorFacial, decimal elValorTransadoNeto, decimal laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            this.elValorFacial = elValorFacial;
            losDiasAlVencimiento = new DiasAlVencimiento(laFechaDeVencimiento, laFechaActual).ComoNumero();
            laTasaBruta = new TasaBruta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, losDiasAlVencimiento).ComoNumero();
        }

        public decimal ComoNumero()
        {
            return elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimiento / 365)));
        }
    }
}