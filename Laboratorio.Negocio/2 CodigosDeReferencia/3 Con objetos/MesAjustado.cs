using System;

namespace Negocio.CodigosDeReferencia.ConObjetos
{
    public class MesAjustado
    {
        int elMes;

        public MesAjustado(DateTime laFecha)
        {
             elMes = laFecha.Month;
        }

        public string ComoTexto()
        {
            if (elMes < 10)
                return elMes.ToString("D2");
            else
                return elMes.ToString();
        }
    }
}