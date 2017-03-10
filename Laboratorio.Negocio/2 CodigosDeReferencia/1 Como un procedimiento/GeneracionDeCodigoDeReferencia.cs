using System;

namespace Negocio.CodigosDeReferencia.ComoUnProcedimiento
{
    public static class GeneracionDeCodigoDeReferencia
    {
        public static string GenereElRequerimientoComoTexto(DateTime laFecha, short elCliente, short elSistema, string elConsecutivo)
        {
            int elAño = laFecha.Year;
            string elAñoAjustado;
            if (elAño < 1000)
                elAñoAjustado = elAño.ToString("D4");
            else
                elAñoAjustado = elAño.ToString();

            int elMes = laFecha.Month;
            string elMesAjustado;
            if (elMes < 10)
                elMesAjustado = elMes.ToString("D2");
            else
                elMesAjustado = elMes.ToString();

            int elDia = laFecha.Day;
            string elDiaAjustado;
            if (elDia < 10)
                elDiaAjustado = elDia.ToString("D2");
            else
                elDiaAjustado = elDia.ToString(); ;

            string laFechaFormateada = elAñoAjustado + elMesAjustado + elDiaAjustado;
            string elClienteAjustado;
            if (elCliente < 1000)
                elClienteAjustado = elCliente.ToString("D3");
            else
                elClienteAjustado = elCliente.ToString();
            string elSistemaAjustado;
            if (elSistema < 100)
                elSistemaAjustado = elSistema.ToString("D2");
            else
                elSistemaAjustado = elSistema.ToString();
            string elConsecutivoAjustado;
            if (elConsecutivo.Length < 12)
                elConsecutivoAjustado = elConsecutivo.PadLeft(12, '0');
            else
                elConsecutivoAjustado = elConsecutivo;

            return laFechaFormateada + elClienteAjustado + elSistemaAjustado + elConsecutivoAjustado;
        }
    }
}