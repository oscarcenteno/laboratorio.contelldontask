using Negocio.ValoracionesPorISIN.ConParameterObject;
using System;

namespace Negocio.UnitTests.ValoracionesPorISIN.ConParameterObject
{
    public class Escenarios
    {
        private DatosDeLaValoracion losDatos;

        public ValoracionPorISIN UnaValoracionEnColonesYCumpleLosDiasMinimos()
        {
            losDatos = new DatosDeLaValoracion();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.Colon;
            losDatos.SaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 3578000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN InicialiceUnaValoracionEnColonesYNoCumpleLosDiasMinimos()
        {
            losDatos = new DatosDeLaValoracion();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.Colon;
            losDatos.SaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 3578000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoNoEstaAnotadoEnCuenta()
        {
            losDatos = new DatosDeLaValoracion();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.SaldoEstaAnotadoEnCuenta = false;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuenta()
        {
            losDatos = new DatosDeLaValoracion();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.SaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 750;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy()
        {
            losDatos = new DatosDeLaValoracion();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.SaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioDeUDESDeHoy = 0;
            losDatos.TipoDeCambioDeUDESDeAyer = 745;

            return new ValoracionPorISIN(losDatos);
        }
    }
}