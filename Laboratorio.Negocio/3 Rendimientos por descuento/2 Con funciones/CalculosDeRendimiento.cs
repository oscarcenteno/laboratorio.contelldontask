using System;

namespace Negocio.RendimientosPorDescuento.ConFunciones
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
            decimal elRendimiento = ObtengaElRendimiento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal);

            return RedondeeElRendimiento(elRendimiento);
        }

        private static decimal ObtengaElRendimiento(decimal elValorFacial, decimal elValorTransadoNeto, decimal laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            decimal elValorTransadoBruto = DetermineElValorTransadorBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal);

            return CalculeElRendimiento(elValorFacial, elValorTransadoBruto);
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
            decimal losDiasAlVencimiento = ObtengaLosDiasAlVencimiento(laFechaDeVencimiento, laFechaActual);
            decimal laTasaBruta = ObtengaLaTasaBruta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, losDiasAlVencimiento);

            return CalculeElValorTransadoBruto(elValorFacial, losDiasAlVencimiento, laTasaBruta);
        }

        private static decimal ObtengaLosDiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            TimeSpan elTiempoAlVencimiento = CalculeElTiempoAlVencimiento(laFechaDeVencimiento, laFechaActual);

            return ExtraigaLosDias(elTiempoAlVencimiento);
        }

        private static TimeSpan CalculeElTiempoAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return laFechaDeVencimiento - laFechaActual;
        }

        private static decimal ExtraigaLosDias(TimeSpan elTiempoAlVencimiento)
        {
            return elTiempoAlVencimiento.Days;
        }

        private static decimal ObtengaLaTasaBruta(decimal elValorFacial, decimal elValorTransadoNeto, decimal laTasaDeImpuesto, decimal losDiasAlVencimiento)
        {
            decimal laTasaNeta = CalculeLaTasaNeta(elValorFacial, elValorTransadoNeto, losDiasAlVencimiento);

            return CalculeLaTasaBruta(laTasaDeImpuesto, laTasaNeta);
        }

        private static decimal CalculeLaTasaNeta(decimal elValorFacial, decimal elValorTransadoNeto, decimal losDiasAlVencimiento)
        {
            return (elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimiento / 365)) * 100;
        }

        private static decimal CalculeLaTasaBruta(decimal laTasaDeImpuesto, decimal laTasaNeta)
        {
            return laTasaNeta / (1 - (laTasaDeImpuesto / 100));
        }

        private static decimal CalculeElValorTransadoBruto(decimal elValorFacial, decimal losDiasAlVencimiento, decimal laTasaBruta)
        {
            return elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimiento / 365)));
        }

        private static decimal CalculeElRendimiento(decimal elValorFacial, decimal elValorTransadoBruto)
        {
            return elValorFacial - elValorTransadoBruto;
        }

        private static decimal RedondeeElRendimiento(decimal elRendimiento)
        {
            return Math.Round(elRendimiento, 4);
        }
    }
}