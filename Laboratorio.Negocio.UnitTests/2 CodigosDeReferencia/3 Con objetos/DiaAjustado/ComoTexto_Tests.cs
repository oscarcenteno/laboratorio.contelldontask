using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.CodigosDeReferencia.ConObjetos;

namespace Laboratorio.Negocio.UnitTests.CodigosDeReferencia.ConObjetos.DiaAjustado_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        string elResultadoEsperado;
        string elResultadoObtenido;
        DateTime laFecha;

        [TestMethod]
        public void ComoNumero_DiaEsMenorQueDiez_SeAjusta()
        {
            elResultadoEsperado = "01";

            laFecha = new DateTime(2011, 11, 1);
            elResultadoObtenido = new DiaAjustado(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_DiaNoEsMenorQueDiez_SeAjusta()
        {
            elResultadoEsperado = "10";

            laFecha = new DateTime(2011, 11, 10);
            elResultadoObtenido = new DiaAjustado(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}