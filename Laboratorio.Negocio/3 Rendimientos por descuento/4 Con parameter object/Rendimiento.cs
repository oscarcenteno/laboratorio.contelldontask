namespace Negocio.RendimientosPorDescuento.ConParameterObject
{
    public class Rendimiento
    {
        decimal elValorFacial;
        decimal elValorTransadoBruto;

        public Rendimiento(DatosDelRendimientoPorDescuento losDatos)
        {
            elValorFacial = losDatos.ValorFacial;
            elValorTransadoBruto = DetermineElValorTransadorBruto(losDatos);
        }

        private static decimal DetermineElValorTransadorBruto(DatosDelRendimientoPorDescuento losDatos)
        {
            if (losDatos.TieneTratamientoFiscal)
                return ObtengaElValorTransadoBruto(losDatos);
            else
                return losDatos.ValorTransadoNeto;
        }

        private static decimal ObtengaElValorTransadoBruto(DatosDelRendimientoPorDescuento losDatos)
        {
            return new ValorTransadoBruto(losDatos).ComoNumero();
        }

        public decimal ComoNumero()
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}