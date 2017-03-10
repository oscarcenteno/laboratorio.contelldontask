namespace Negocio.CodigosDeReferencia.ConParameterObject
{
    public class Requerimiento
    {
        string laFechaFormateada;
        string elClienteAjustado;
        string elSistemaAjustado;
        string elConsecutivoAjustado;

        public Requerimiento(DatosDelRequerimiento losDatos)
        {
            laFechaFormateada = ObtengaLaFechaFormateada(losDatos);
            elClienteAjustado = AjusteElCliente(losDatos);
            elSistemaAjustado = AjusteElSistema(losDatos);
            elConsecutivoAjustado = AjusteElConsecutivo(losDatos);
        }

        private static string ObtengaLaFechaFormateada(DatosDelRequerimiento losDatos)
        {
            return new FechaFormateada(losDatos).ComoTexto();
        }

        private static string AjusteElCliente(DatosDelRequerimiento losDatos)
        {
            // TODO: Mas de una sola operacion
            if (losDatos.Cliente < 1000)
                return losDatos.Cliente.ToString("D3");
            else
                return losDatos.Cliente.ToString();
        }

        private static string AjusteElSistema(DatosDelRequerimiento losDatos)
        {
            // TODO: Mas de una sola operacion
            if (losDatos.Sistema < 100)
                return losDatos.Sistema.ToString("D2");
            else
                return losDatos.Sistema.ToString();
        }

        private static string AjusteElConsecutivo(DatosDelRequerimiento losDatos)
        {
            // TODO: Mas de una sola operacion
            if (losDatos.Consecutivo.Length < 12)
                return losDatos.Consecutivo.PadLeft(12, '0');
            else
                return losDatos.Consecutivo;
        }
        
        public string ComoTexto() 
        {
            return laFechaFormateada + elClienteAjustado + elSistemaAjustado + elConsecutivoAjustado;
        }
    }
}