namespace Negocio.ValoracionesPorISIN.ConParameterObject
{
    public class ValoracionPorISIN
    {
        decimal elValorDeMercado;
        decimal elPorcentajeDeCoberturaRevisado;

        public ValoracionPorISIN(DatosDeLaValoracion losDatos)
        {
            ISIN = losDatos.ISIN;

            elValorDeMercado = ObtengaElValorDeMercado(losDatos);
            ValorDeMercado = elValorDeMercado;

            elPorcentajeDeCoberturaRevisado = ObtengaElPorcentajeDeCobertura(losDatos);
            PorcentajeCobertura = elPorcentajeDeCoberturaRevisado;
        }

        public string ISIN { get; private set; }
        public decimal ValorDeMercado { get; private set; }
        public decimal PorcentajeCobertura { get; private set; }
        public decimal AporteDeGarantia => elValorDeMercado * elPorcentajeDeCoberturaRevisado;

        private static decimal ObtengaElValorDeMercado(DatosDeLaValoracion losDatos)
        {
            return new ValorDeMercado(losDatos).ComoNumero();
        }

        private static decimal ObtengaElPorcentajeDeCobertura(DatosDeLaValoracion losDatos)
        {
            return new PorcentajeDeCobertura(losDatos).ComoNumero();
        }
    }
}