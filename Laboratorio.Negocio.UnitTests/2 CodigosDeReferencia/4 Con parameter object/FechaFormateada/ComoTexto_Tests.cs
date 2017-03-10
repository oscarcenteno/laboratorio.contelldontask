using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.CodigosDeReferencia.ConParameterObject;

namespace Laboratorio.Negocio.UnitTests.CodigosDeReferencia.ConParameterObject.FechaFormateada_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        string elResultadoEsperado;
        string elResultadoObtenido;
        private DatosDelRequerimiento losDatos;

        [TestMethod]
        public void ComoNumero_DiaEsMenorQueDiez_SeAjusta()
        {
            elResultadoEsperado = "20111101";

            losDatos = new DatosDelRequerimiento();
            losDatos.Fecha = new DateTime(2011, 11, 1);
            elResultadoObtenido = new FechaFormateada(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}