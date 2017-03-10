using System;

namespace Negocio.CodigosDeReferencia.ConObjetos
{
    public class FechaFormateada
    {
        string elAñoAjustado;
        string elMesAjustado;
        string elDiaAjustado;

        public FechaFormateada(DateTime laFecha)
        {
            elAñoAjustado = new AñoAjustado(laFecha).ComoTexto();
            elMesAjustado = new MesAjustado(laFecha).ComoTexto();
            elDiaAjustado = new DiaAjustado(laFecha).ComoTexto();
        }

        public string ComoTexto()
        {
            return elAñoAjustado + elMesAjustado + elDiaAjustado;
        }
    }
}