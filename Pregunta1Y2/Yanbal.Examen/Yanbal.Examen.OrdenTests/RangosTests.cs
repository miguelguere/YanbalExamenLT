using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yanbal.Examen.Orden;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Yanbal.Examen.Orden.Tests
{
    [TestClass()]
    public class RangosTests
    {
        [TestMethod()]
        public void CompletarRangoTest()
        {
            Rangos rangos = new Rangos();

            /*Entrada 1*/
            List<int> listaResultado = rangos.CompletarRango(new List<int>() { 2, 1, 4, 5 });
            List<int> listaordenada = new List<int>() { 1, 2, 3, 4, 5 };
            
            Assert.AreEqual(true, listaordenada.SequenceEqual(listaResultado));

            /*Entrada 2*/
            listaResultado = rangos.CompletarRango(new List<int>() { 100, 96, 101, 102, 105 });
            listaordenada = new List<int>() { 96, 97, 98, 99, 100, 101, 102, 103, 104, 105 };
            
            Assert.AreEqual(true, listaordenada.SequenceEqual(listaResultado));

            /*Entrada 3*/
            listaResultado = rangos.CompletarRango(new List<int>() { 22, 25 });
            listaordenada = new List<int>() { 22, 23, 24, 25};

            Assert.AreEqual(true, listaordenada.SequenceEqual(listaResultado));
        }
    }
}