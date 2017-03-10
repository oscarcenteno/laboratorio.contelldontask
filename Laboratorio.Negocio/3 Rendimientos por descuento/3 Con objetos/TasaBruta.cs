namespace Negocio.RendimientosPorDescuento.ConObjetos
{
    public class TasaBruta
    {
        decimal laTasaDeImpuesto;
        decimal laTasaNeta;

        public TasaBruta(decimal elValorFacial, decimal elValorTransadoNeto, decimal laTasaDeImpuesto, decimal losDiasAlVencimiento)
        {
            laTasaNeta = (elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimiento / 365)) * 100;
            this.laTasaDeImpuesto = laTasaDeImpuesto;
        }

        public decimal ComoNumero()
        {
            return laTasaNeta / (1 - (laTasaDeImpuesto / 100));
        }
    }
}