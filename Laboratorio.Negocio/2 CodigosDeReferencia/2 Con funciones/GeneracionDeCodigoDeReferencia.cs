using System;

namespace Negocio.CodigosDeReferencia.ConFunciones
{
    public static class GeneracionDeCodigoDeReferencia
    {
        public static string GenereElRequerimientoComoTexto(DateTime laFecha, short elCliente, short elSistema, string elConsecutivo)
        {
            string laFechaFormateada = ObtengaLaFechaFormateada(laFecha);
            string elClienteAjustado = AjusteElCliente(elCliente);
            string elSistemaAjustado = AjusteElSistema(elSistema);
            string elConsecutivoAjustado = AjusteElConsecutivo(elConsecutivo);

            return FormateeElRequerimiento(laFechaFormateada, elClienteAjustado, elSistemaAjustado, elConsecutivoAjustado);
        }

        private static string ObtengaLaFechaFormateada(DateTime laFecha)
        {
            string elAñoAjustado = ObtengaElAñoAjustado(laFecha);
            string elMesAjustado = OtengaElMesAjustado(laFecha);
            string elDiaAjustado = ObtengaElDiaAjustado(laFecha);

            return FormateeLaFecha(elAñoAjustado, elMesAjustado, elDiaAjustado);
        }

        private static string ObtengaElAñoAjustado(DateTime laFecha)
        {
            int elAño = ExtraigaElAño(laFecha);

            return AjusteElAño(elAño);
        }

        private static int ExtraigaElAño(DateTime laFecha)
        {
            return laFecha.Year;
        }

        private static string AjusteElAño(int elAño)
        {
            if (elAño < 1000)
                return elAño.ToString("D4");
            else
                return elAño.ToString();
        }

        private static string OtengaElMesAjustado(DateTime laFecha)
        {
            int elMes = ExtraigaElMes(laFecha);

            return AjusteElMes(elMes);
        }

        private static int ExtraigaElMes(DateTime laFecha)
        {
            return laFecha.Month;
        }

        private static string AjusteElMes(int elMes)
        {
            if (elMes < 10)
                return elMes.ToString("D2");
            else
                return elMes.ToString();
        }

        private static string ObtengaElDiaAjustado(DateTime laFecha)
        {
            int elDia = ExtraigaElDia(laFecha);

            return AjusteElDia(elDia);
        }

        private static int ExtraigaElDia(DateTime laFecha)
        {
            return laFecha.Day;
        }

        private static string AjusteElDia(int elDia)
        {
            if (elDia < 10)
                return elDia.ToString("D2");
            else
                return elDia.ToString();
        }

        private static string FormateeLaFecha(string elAñoAjustado, string elMesAjustado, string elDiaAjustado)
        {
            return elAñoAjustado + elMesAjustado + elDiaAjustado;
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

        private static string FormateeElRequerimiento(string laFechaFormateada, string elClienteAjustado, string elSistemaAjustado, string elConsecutivoAjustado)
        {
            return laFechaFormateada + elClienteAjustado + elSistemaAjustado + elConsecutivoAjustado;
        }
    }
}