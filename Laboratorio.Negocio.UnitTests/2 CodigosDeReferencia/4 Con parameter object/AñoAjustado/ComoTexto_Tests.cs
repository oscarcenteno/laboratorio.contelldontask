using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.CodigosDeReferencia.ConParameterObject;

namespace Laboratorio.Negocio.UnitTests.CodigosDeReferencia.ConParameterObject.AñoAjustado_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        string elResultadoEsperado;
        string elResultadoObtenido;
        private DatosDelRequerimiento losDatos;

        [TestInitialize]
        public void Inicialice()
        {
            losDatos = new DatosDelRequerimiento();
        }

        [TestMethod]
        public void ComoNumero_AñoEsMenorQueMil_SeAjusta()
        {
            elResultadoEsperado = "0999";

            losDatos.Fecha = new DateTime(999, 11, 11);
            elResultadoObtenido = new AñoAjustado(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_AñoNoEsMenorQueMil_SeAjusta()
        {
            elResultadoEsperado = "1000";

            losDatos.Fecha = new DateTime(1000, 11, 11);
            elResultadoObtenido = new AñoAjustado(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}