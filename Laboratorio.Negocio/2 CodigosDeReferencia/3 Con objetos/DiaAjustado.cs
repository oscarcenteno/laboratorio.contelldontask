using System;

namespace Negocio.CodigosDeReferencia.ConObjetos
{
    public class DiaAjustado
    {
        int elDia;

        public DiaAjustado(DateTime laFecha)
        {
            elDia = laFecha.Day;
        }

        public string ComoTexto()
        {
            if (elDia < 10)
                return elDia.ToString("D2");
            else
                return elDia.ToString();
        }
    }
}