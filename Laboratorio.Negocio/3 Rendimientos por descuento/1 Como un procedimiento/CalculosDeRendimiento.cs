using System;

namespace Negocio.RendimientosPorDescuento.ComoUnProcedimiento
{
    public static class CalculosDeRendimiento
    {
        public static decimal GenereElRendimientoPorDescuentoRedondeado(decimal elValorFacial,
                decimal elValorTransadoNeto,
                decimal laTasaDeImpuesto,
                DateTime laFechaDeVencimiento,
                DateTime laFechaActual,
                bool tieneTratamientoFiscal)
        {
            decimal elValorTransadoBruto;
            if (tieneTratamientoFiscal)
            {
                TimeSpan elTiempoAlVencimiento;
                elTiempoAlVencimiento = (laFechaDeVencimiento - laFechaActual);
                decimal losDiasAlVencimiento;
                losDiasAlVencimiento = elTiempoAlVencimiento.Days;

                decimal laTasaNeta;
                laTasaNeta = (elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimiento / 365)) * 100;
                decimal laTasaBruta;
                laTasaBruta = laTasaNeta / (1 - (laTasaDeImpuesto / 100));
                elValorTransadoBruto = elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimiento / 365)));
            }
            else
            {
                elValorTransadoBruto = elValorTransadoNeto;
            }

            decimal elRendimiento = elValorFacial - elValorTransadoBruto;
            return Math.Round(elRendimiento, 4);
        }
    }
}