using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.CodigosDeReferencia.ConObjetos;

namespace Laboratorio.Negocio.UnitTests.CodigosDeReferencia.ConObjetos.MesAjustado_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        string elResultadoEsperado;
        string elResultadoObtenido;
        DateTime laFecha;

        [TestMethod]
        public void ComoNumero_MesEsMenorQueDiez_SeAjusta()
        {
            elResultadoEsperado = "01";

            laFecha = new DateTime(2011, 1, 11);
            elResultadoObtenido = new MesAjustado(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_MesNoEsMenorQueDiez_SeAjusta()
        {
            elResultadoEsperado = "10";

            laFecha = new DateTime(2011, 10, 11);
            elResultadoObtenido = new MesAjustado(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}