using System;

namespace Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class FechaFormateada
    {
        string elAñoAjustado;
        string elMesAjustado;
        string elDiaAjustado;

        public FechaFormateada(DatosDelRequerimiento losDatos)
        {
            elAñoAjustado = new AñoAjustado(losDatos).ComoTexto();
            elMesAjustado = new MesAjustado(losDatos).ComoTexto();
            elDiaAjustado = new DiaAjustado(losDatos).ComoTexto();
        }

        public string ComoTexto()
        {
            return elAñoAjustado + elMesAjustado + elDiaAjustado;
        }
    }
}