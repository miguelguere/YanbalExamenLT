using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Yanbal.Examen.Orden
{
    public class Rangos
    {
        public List<int> CompletarRango(List<int> numbers)
        {
            List<int> listaResultado = new List<int>();
            var maximo = numbers.Max();
            var minimo = numbers.Min();

            listaResultado = Enumerable.Range(minimo, ((maximo + 1) - minimo)).ToList();

            listaResultado.Sort();

            return listaResultado;
        }
    }
}
