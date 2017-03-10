namespace Negocio.RendimientosPorDescuento.ConTellDontAsk
{
    public class ValorTransadoBruto
    {
        decimal elValorFacial;
        decimal laTasaBruta;
        decimal losDiasAlVencimiento;

        public ValorTransadoBruto(DatosDelRendimientoPorDescuento losDatos)
        {
            elValorFacial = losDatos.ValorFacial;
            losDiasAlVencimiento = new DiasAlVencimiento(losDatos).ComoNumero();

            DatosDeLaTasaBruta losDatosDeLaTasaBruta = new DatosDeLaTasaBruta() ;
            losDatosDeLaTasaBruta.ValorFacial = losDatos.ValorFacial;
            losDatosDeLaTasaBruta.ValorTransadoNeto = losDatos.ValorTransadoNeto;
            losDatosDeLaTasaBruta.TasaDeImpuesto = losDatos.TasaDeImpuesto;
            losDatosDeLaTasaBruta.DiasAlVencimiento = losDiasAlVencimiento;
            laTasaBruta = new TasaBruta(losDatosDeLaTasaBruta).ComoNumero();
        }

        public decimal ComoNumero()
        {
            return elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimiento / 365)));
        }
    }
}