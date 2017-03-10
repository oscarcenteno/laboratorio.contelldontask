using System;

namespace Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class DatosDelRequerimiento
    {
        public DateTime Fecha { get; set; }
        public short Cliente { get; set; }
        public short Sistema { get; set; }
        public string Consecutivo { get; set; }
    }
}