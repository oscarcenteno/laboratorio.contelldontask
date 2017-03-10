using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.CodigosDeReferencia.ConObjetos;

namespace Laboratorio.Negocio.UnitTests.CodigosDeReferencia.ConObjetos.FechaFormateada_Tests
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
            elResultadoEsperado = "20111101";

            laFecha = new DateTime(2011, 11, 1);
            elResultadoObtenido = new FechaFormateada(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}