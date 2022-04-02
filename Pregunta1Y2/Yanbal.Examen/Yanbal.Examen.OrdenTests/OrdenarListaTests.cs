using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yanbal.Examen.Orden;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Yanbal.Examen.Orden.Tests
{
    [TestClass()]
    public class OrdenarListaTests
    {
        class UsuarioComparer : IEqualityComparer<Usuario>
        {
            // override object.Equals
            public bool Equals(Usuario x, Usuario y)
            {
                if (x.Nombre.ToLower() == y.Nombre.ToLower() && x.Apellido.ToLower() == y.Apellido.ToLower())
                    return true;
                
                return false;
            }

            public int GetHashCode(Usuario obj)
            {
                return obj.GetHashCode();
            }
        }

        [TestMethod()]
        public void OrdenarPorNombreApellidoTest()
        {
            List<Usuario> listaEntrada = new List<Usuario>();
            List<Usuario> listaordenada = new List<Usuario>();
            OrdenarLista ordenLista = new OrdenarLista();

            /*LISTA DESORDENADA*/
            listaEntrada.Add(new Usuario { Nombre = "Carlos", Apellido = "Alcantara" });
            listaEntrada.Add(new Usuario { Nombre = "Luis", Apellido = "Reyes" });
            listaEntrada.Add(new Usuario { Nombre = "Marcos", Apellido = "Pinillos" });
            listaEntrada.Add(new Usuario { Nombre = "Marcos", Apellido = "Buis" });
            listaEntrada.Add(new Usuario { Nombre = "Alberto", Apellido = "Coronel" });

            /*LISTA ORDENADA*/
            listaordenada.Add(new Usuario { Nombre = "Alberto", Apellido = "Coronel" });
            listaordenada.Add(new Usuario { Nombre = "Carlos", Apellido = "Alcantara" });
            listaordenada.Add(new Usuario { Nombre = "Luis", Apellido = "Reyes" });
            listaordenada.Add(new Usuario { Nombre = "Marcos", Apellido = "Buis" });
            listaordenada.Add(new Usuario { Nombre = "Marcos", Apellido = "Pinillos" });                       

            var listarespuesta = ordenLista.OrdenarPorNombreApellido(listaEntrada);
                        
            Assert.AreEqual(true, listaordenada.SequenceEqual(listarespuesta, new UsuarioComparer()));
        }

        [TestMethod()]
        public void OrdenarPorNombreTest()
        {
            List<Usuario> listaEntrada = new List<Usuario>();
            List<Usuario> listaordenada = new List<Usuario>();
            OrdenarLista ordenLista = new OrdenarLista();
                        
            /*LISTA DESORDENADA*/
            listaEntrada.Add(new Usuario { Nombre = "Carlos", Apellido = "Alcantara" });
            listaEntrada.Add(new Usuario { Nombre = "Luis", Apellido = "Reyes" });
            listaEntrada.Add(new Usuario { Nombre = "Marcos", Apellido = "Pinillos" });
            listaEntrada.Add(new Usuario { Nombre = "Marcos", Apellido = "Buis" });
            listaEntrada.Add(new Usuario { Nombre = "Alberto", Apellido = "Coronel" });

            /*LISTA ORDENADA*/
            listaordenada.Add(new Usuario { Nombre = "Alberto", Apellido = "Coronel" });
            listaordenada.Add(new Usuario { Nombre = "Carlos", Apellido = "Alcantara" });
            listaordenada.Add(new Usuario { Nombre = "Luis", Apellido = "Reyes" });            
            listaordenada.Add(new Usuario { Nombre = "Marcos", Apellido = "Pinillos" });
            listaordenada.Add(new Usuario { Nombre = "Marcos", Apellido = "Buis" });

            var listarespuesta = ordenLista.OrdenarPorNombre(listaEntrada);
                        

            Assert.AreEqual(true, listaordenada.SequenceEqual(listarespuesta, new UsuarioComparer()));
        }
    }
}