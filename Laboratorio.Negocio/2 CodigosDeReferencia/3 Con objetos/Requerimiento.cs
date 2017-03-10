using System;

namespace Negocio.CodigosDeReferencia.ConObjetos
{
    public class Requerimiento
    {
        string laFechaFormateada;
        string elClienteAjustado;
        string elSistemaAjustado;
        string elConsecutivoAjustado;

        public Requerimiento(DateTime laFecha, short elCliente, short elSistema, string elConsecutivo)
        {
            laFechaFormateada = ObtengaLaFechaFormateada(laFecha);
            elClienteAjustado = AjusteElCliente(elCliente);
            elSistemaAjustado = AjusteElSistema(elSistema);
            elConsecutivoAjustado = AjusteElConsecutivo(elConsecutivo);
        }

        private static string ObtengaLaFechaFormateada(DateTime laFecha)
        {
            return new FechaFormateada(laFecha).ComoTexto();
        }

        private static string AjusteElCliente(short elCliente)
        {
            if (elCliente < 1000)
                return elCliente.ToString("D3");
            else
                return elCliente.ToString();
        }

        private static string AjusteElSistema(short elSistema)
        {
            if (elSistema < 100)
                return elSistema.ToString("D2");
            else
                return elSistema.ToString();
        }

        private static string AjusteElConsecutivo(string elConsecutivo)
        {
            if (elConsecutivo.Length < 12)
                return elConsecutivo.PadLeft(12, '0');
            else
                return elConsecutivo;
        }
        
        public string ComoTexto() 
        {
            return laFechaFormateada + elClienteAjustado + elSistemaAjustado + elConsecutivoAjustado;
        }
    }
}