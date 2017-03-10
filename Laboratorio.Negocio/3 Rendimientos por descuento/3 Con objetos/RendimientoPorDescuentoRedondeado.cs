using System;

namespace Negocio.RendimientosPorDescuento.ConObjetos
{
    public class RendimientoPorDescuentoRedondeado
    {
        decimal elRendimiento;

        public RendimientoPorDescuentoRedondeado(decimal elValorFacial, decimal elValorTransadoNeto, decimal laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            elRendimiento = new Rendimiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal).ComoNumero();
        }

        public decimal ComoNumero()
        {
            return Math.Round(elRendimiento, 4);
        }
    }
}