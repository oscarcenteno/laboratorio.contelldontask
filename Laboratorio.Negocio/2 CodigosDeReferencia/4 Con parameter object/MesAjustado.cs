namespace Negocio.CodigosDeReferencia.ConParameterObject
{
    public class MesAjustado
    {
        int elMes;

        public MesAjustado(DatosDelRequerimiento losDatos)
        {
            // TODO: No cumple la ley de Demeter
             elMes = losDatos.Fecha.Month;
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