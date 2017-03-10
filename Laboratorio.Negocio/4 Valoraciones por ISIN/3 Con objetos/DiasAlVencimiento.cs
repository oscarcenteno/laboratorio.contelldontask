using System;

namespace Negocio.ValoracionesPorISIN.ConObjetos
{
    public class DiasAlVencimiento
    {
        TimeSpan laDiferenciaEntreLasFechas;

        public DiasAlVencimiento(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial)
        {
            laDiferenciaEntreLasFechas = laFechaDeVencimientoDelValorOficial.Subtract(laFechaActual);
        }

        public double ComoNumeros()
        {
            return laDiferenciaEntreLasFechas.TotalDays;
        }

    }
}
