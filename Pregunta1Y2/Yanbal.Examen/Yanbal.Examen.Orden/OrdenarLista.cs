using System;
using System.Collections.Generic;
using System.Text;

namespace Yanbal.Examen.Orden
{

    public class OrdenarLista
    {                

        public List<Usuario> OrdenarPorNombre(List<Usuario> listaEntrada)
        {
            listaEntrada.Sort(delegate(Usuario x, Usuario y) {
                return x.Nombre.CompareTo(y.Nombre);
            });

            return listaEntrada;
        }

        public List<Usuario> OrdenarPorNombreApellido(List<Usuario> listaEntrada)
        {
            listaEntrada.Sort(delegate (Usuario x, Usuario y)
            {
                return (string.Concat(x.Nombre, x.Apellido)).CompareTo(string.Concat(y.Nombre, y.Apellido));
            });

            return listaEntrada;
        }
    }
}
