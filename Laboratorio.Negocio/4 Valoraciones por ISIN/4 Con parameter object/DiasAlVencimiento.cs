using System;

namespace Negocio.ValoracionesPorISIN.ConParameterObject
{
    public class DiasAlVencimiento
    {
        TimeSpan laDiferenciaEntreLasFechas;

        public DiasAlVencimiento(DatosDeLaValoracion losDatos)
        {
            // TODO: Mas de una sola operacion
            laDiferenciaEntreLasFechas = losDatos.FechaDeVencimientoDelValorOficial.Subtract(losDatos.FechaActual);
        }

        public double ComoNumeros()
        {
            return laDiferenciaEntreLasFechas.TotalDays;
        }

    }
}
