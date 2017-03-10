using System;

namespace Negocio.RendimientosPorDescuento.ConParameterObject
{
    public class DiasAlVencimiento
    {
        TimeSpan elTiempoAlVencimiento;

        public DiasAlVencimiento(DatosDelRendimientoPorDescuento losDatos)
        {
            // TODO: Mas de una sola operacion
            elTiempoAlVencimiento = losDatos.FechaDeVencimiento - losDatos.FechaActual;
        }

        public decimal ComoNumero()
        {
            return elTiempoAlVencimiento.Days;
        }
    }
}