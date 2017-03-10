using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.CodigosDeReferencia.ConObjetos;

namespace Laboratorio.Negocio.UnitTests.CodigosDeReferencia.ConObjetos.AñoAjustado_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        string elResultadoEsperado;
        string elResultadoObtenido;
        DateTime laFecha;

        [TestMethod]
        public void ComoNumero_AñoEsMenorQueMil_SeAjusta()
        {
            elResultadoEsperado = "0999";

            laFecha = new DateTime(999, 11, 11);
            elResultadoObtenido = new AñoAjustado(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_AñoNoEsMenorQueMil_SeAjusta()
        {
            elResultadoEsperado = "1000";

            laFecha = new DateTime(1000, 11, 11);
            elResultadoObtenido = new AñoAjustado(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}