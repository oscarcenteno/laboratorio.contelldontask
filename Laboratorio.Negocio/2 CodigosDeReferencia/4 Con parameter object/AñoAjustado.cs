using System;

namespace Negocio.CodigosDeReferencia.ConParameterObject
{
    public class AñoAjustado
    {
        int elAño;

        public AñoAjustado(DatosDelRequerimiento losDatos)
        {
            // TODO: No cumple la ley de Demeter
             elAño = losDatos.Fecha.Year;
        }

        public string ComoTexto()
        {
            if (elAño < 1000)
                return elAño.ToString("D4");
            else
                return elAño.ToString();
        }
    }
}
