using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.CodigosDeReferencia.ConParameterObject;

namespace Laboratorio.Negocio.UnitTests.CodigosDeReferencia.ConParameterObject.MesAjustado_Tests
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
        public void ComoNumero_MesEsMenorQueDiez_SeAjusta()
        {
            elResultadoEsperado = "01";

            losDatos.Fecha = new DateTime(2011, 1, 11);
            elResultadoObtenido = new MesAjustado(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_MesNoEsMenorQueDiez_SeAjusta()
        {
            elResultadoEsperado = "10";

            losDatos.Fecha = new DateTime(2011, 10, 11);
            elResultadoObtenido = new MesAjustado(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}