using System;

namespace Negocio.ValoracionesPorISIN.ConObjetos
{
    public class PorcentajeDeCobertura
    {
        double losDiasAlVencimiento;
        int losDiasMinimosAlVencimientoDelEmisor;
        decimal elPorcentajeCobertura;

        public PorcentajeDeCobertura(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial, int losDiasMinimosAlVencimientoDelEmisor, decimal elPorcentajeCobertura)
        {
            losDiasAlVencimiento = new DiasAlVencimiento(laFechaActual, laFechaDeVencimientoDelValorOficial).ComoNumeros();
            this.losDiasMinimosAlVencimientoDelEmisor = losDiasMinimosAlVencimientoDelEmisor;
            this.elPorcentajeCobertura = elPorcentajeCobertura;
        }

        public decimal ComoNumero()
        {
            // Si no cumple los días mínimos, el porcentaje de cobertura es cero
            if (losDiasAlVencimiento < losDiasMinimosAlVencimientoDelEmisor)
                return 0;
            else
                return elPorcentajeCobertura;
        }
    }
}