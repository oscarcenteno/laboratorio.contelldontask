using System;

namespace Negocio.RendimientosPorDescuento.ConParameterObject
{
    public class DatosDelRendimientoPorDescuento
    {
        public decimal ValorFacial { get; set; }
        public decimal ValorTransadoNeto { get; set; }
        public decimal TasaDeImpuesto { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public DateTime FechaActual { get; set; }
        public bool TieneTratamientoFiscal { get; set; }
    }
}