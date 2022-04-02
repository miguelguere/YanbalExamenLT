using System;
using System.Collections.Generic;

namespace Yanbal.Examen.Orden
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Usuario> list = new List<Usuario>();

            list.Add(new Usuario { Nombre = "Esther", Apellido = "Rodriguez" });
            list.Add(new Usuario { Nombre = "Andrés", Apellido = "Yraes" });
            list.Add(new Usuario { Nombre = "Cristian", Apellido = "Zegarra" });
            list.Add(new Usuario { Nombre = "Cristian", Apellido = "Andares" });
            list.Add(new Usuario { Nombre = "Zoila", Apellido = "Vaca" });
            list.Add(new Usuario { Nombre = "Zoila", Apellido = "Lumbares" });
            list.Add(new Usuario { Nombre = "Zoila" });
            list.Add(new Usuario { Nombre = "Manuel", Apellido = "Chamaco" });

            OrdenarLista obj = new OrdenarLista();
            //var resultado = obj.OrdenarPorNombre(list);
            var resultado = obj.OrdenarPorNombreApellido(list);


            foreach (var item in resultado)
            {
                Console.WriteLine("Usuario: " + item.Nombre + " " + item.Apellido);
            }

            Console.ReadLine();
        }

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");

        //    //List<int> list = new List<int> { 2, 1, 4, 5 };

        //    //List<int> list = new List<int> { 100, 96, 101, 102, 105 };
        //    List<int> list = new List<int> { 22, 25};

        //    Rangos obj = new Rangos();
            
        //    var resultado = obj.CompletarRango(list);


        //    foreach (var item in resultado)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.ReadLine();
        //}

    }
}
