using System;

namespace Negocio.RendimientosPorDescuento.ConTellDontAsk
{
    public class RendimientoPorDescuentoRedondeado
    {
        decimal elRendimiento;

        public RendimientoPorDescuentoRedondeado(DatosDelRendimientoPorDescuento losDatos)
        {
            elRendimiento = new Rendimiento(losDatos).ComoNumero();
        }

        public decimal ComoNumero()
        {
            return Math.Round(elRendimiento, 4);
        }
    }
}