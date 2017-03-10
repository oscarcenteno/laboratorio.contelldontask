namespace Negocio.RendimientosPorDescuento.ConParameterObject
{
    public class TasaBruta
    {
        decimal laTasaDeImpuesto;
        decimal laTasaNeta;

        public TasaBruta(DatosDeLaTasaBruta losDatos)
        {
            // TODO: Mas de una sola operacion
            laTasaNeta = (losDatos.ValorFacial - losDatos.ValorTransadoNeto) / (losDatos.ValorTransadoNeto * (losDatos.DiasAlVencimiento / 365)) * 100;
            laTasaDeImpuesto = losDatos.TasaDeImpuesto;
        }

        public decimal ComoNumero()
        {
            return laTasaNeta / (1 - (laTasaDeImpuesto / 100));
        }
    }
}