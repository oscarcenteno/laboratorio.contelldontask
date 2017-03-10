using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.CodigosDeReferencia.ConParameterObject;

namespace Laboratorio.Negocio.UnitTests.CodigosDeReferencia.ConParameterObject.DiaAjustado_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        string elResultadoEsperado;
        string elResultadoObtenido;
        DatosDelRequerimiento losDatos;

        [TestInitialize]
        public void Inicialice()
        {
            losDatos = new DatosDelRequerimiento();
        }

        [TestMethod]
        public void ComoNumero_DiaEsMenorQueDiez_SeAjusta()
        {
            elResultadoEsperado = "01";

            losDatos.Fecha = new DateTime(2011, 11, 1);
            elResultadoObtenido = new DiaAjustado(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_DiaNoEsMenorQueDiez_SeAjusta()
        {
            elResultadoEsperado = "10";

            losDatos.Fecha = new DateTime(2011, 11, 10);
            elResultadoObtenido = new DiaAjustado(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}