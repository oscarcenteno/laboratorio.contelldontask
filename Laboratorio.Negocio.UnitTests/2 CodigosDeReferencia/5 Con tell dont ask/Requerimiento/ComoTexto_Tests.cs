using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.CodigosDeReferencia.ConParameterObject;

namespace Negocio.UnitTests.CodigosDeReferencia.ConTellDontAsk.Requerimiento_Tests
{
    [TestClass()]
    public class ComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DatosDelRequerimiento losDatos;

        [TestInitialize()]
        public void Inicialice()
        {
            losDatos = new DatosDelRequerimiento();
            losDatos.Fecha = new DateTime(2000, 11, 11);
            losDatos.Cliente = 333;
            losDatos.Sistema = 22;
            losDatos.Consecutivo = "888888888888";
        }


        [TestMethod()]
        public void GenereElRequerimientoComoTexto_ClienteTieneMenosDigitos_PrecedeConCero()
        {
            elResultadoEsperado = "2000111103322888888888888";

            losDatos.Cliente = 33;
            elResultadoObtenido = new Requerimiento(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElRequerimientoComoTexto_SistemaTieneUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "2000111133302888888888888";

            losDatos.Sistema = 2;
            elResultadoObtenido = new Requerimiento(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElRequerimientoComoTexto_MesTieneUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "2000011133322888888888888";

            losDatos.Fecha = new DateTime(2000, 1, 11);
            elResultadoObtenido = new Requerimiento(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElRequerimientoComoTexto_DiaTieneUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "2000110133322888888888888";

            losDatos.Fecha = new DateTime(2000, 11, 1);
            elResultadoObtenido = new Requerimiento(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElRequerimientoComoTexto_ConsecutivoTieneMenosDigitos_PrecedeConCeros()
        {
            elResultadoEsperado = "2000111133322000000000004";

            losDatos.Consecutivo = "4";
            elResultadoObtenido = new Requerimiento(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}