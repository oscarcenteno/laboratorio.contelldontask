using System;

namespace Negocio.CodigosDeReferencia.ConParameterObject
{
    public class DiaAjustado
    {
        int elDia;

        public DiaAjustado(DatosDelRequerimiento losDatos)
        {
            // TODO: No cumple la ley de Demeter
            elDia = losDatos.Fecha.Day;
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