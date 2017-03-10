namespace Negocio.ValoracionesPorISIN.ConParameterObject
{
    public class PorcentajeDeCobertura
    {
        double losDiasAlVencimiento;
        int losDiasMinimosAlVencimientoDelEmisor;
        decimal elPorcentajeCobertura;

        public PorcentajeDeCobertura(DatosDeLaValoracion losDatos)
        {
            losDiasAlVencimiento = new DiasAlVencimiento(losDatos).ComoNumeros();
            losDiasMinimosAlVencimientoDelEmisor = losDatos.DiasMinimosAlVencimientoDelEmisor;
            elPorcentajeCobertura = losDatos.PorcentajeCobertura;
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