using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using EC;


namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manejo Coleccion comun
            System.Collections.Stack _lista = CargoDatosComun();

            Console.WriteLine("Como queda carga - se recorre contenido, no se quitan los elementos");
            MuestroComun(_lista);
            Console.WriteLine("\n");

            Console.WriteLine("Cantidad de elementos: " + _lista.Count + "\n");

            Console.WriteLine("Obtengo dos valores - Ver que posicion obtiene");
            Muestro2Pos(_lista);
            Console.WriteLine("\n");

            Console.WriteLine("Contenido despues de obtener dos valores");
            MuestroComun(_lista);
            Console.WriteLine("\n");

            Console.WriteLine("Cantidad de elementos: " + _lista.Count + "\n");

            Console.WriteLine("Existe el valor 25 en la coleccion? " + _lista.Contains(25) + "\n");

            Console.ReadLine();



            // liimpio pantalla
            Console.Clear();



            //Manejo Coleccion Generic
            System.Collections.Generic.Stack<Casa> _listaG = CargoDatosGeneric();

            Console.WriteLine("Como queda carga - se recorre contenido, no se quitan los elementos");
            MuestroGeneric(_listaG);
            Console.WriteLine("\n");

            Console.WriteLine("Cantidad de elementos: " + _listaG.Count + "\n");

            Console.WriteLine("Obtengo 1 valor - Ver que posicion obtiene");
            MuestroGeneric1Pos(_listaG);
            Console.WriteLine("\n");

            Console.WriteLine("Contenido despues de obtener un valor");
            MuestroGeneric(_listaG);
            Console.WriteLine("\n");

            Console.WriteLine("Cantidad de elementos: " + _listaG.Count + "\n");

            Console.ReadLine();

        }

        //---------------------------------------------------------------Operaciones de Manejo Stack Comun------------------------
        internal static System.Collections.Stack CargoDatosComun()
        {
            System.Collections.Stack miLista = new System.Collections.Stack();

            miLista.Push("Texto");
            miLista.Push(null);
            miLista.Push(1);
            miLista.Push(2);
            miLista.Push(3);
  
            return miLista;
        }

        internal static void MuestroComun(System.Collections.Stack miLista)
        {
            //no se toca el contenido; simplemente consulto valores en cada pos.
            foreach (var item in miLista)
                Console.WriteLine("\t" + item);

        }

        internal static void Muestro2Pos(System.Collections.Stack miLista)
        {
            Console.WriteLine("\t" + miLista.Pop());
            Console.WriteLine("\t" + miLista.Pop());
            //despues el largo del stack queda en 3 - porque consulte y quite elementos
        }


        //---------------------------------------------------------------Operaciones de Manejo Stack Generic------------------------

        internal static System.Collections.Generic.Stack<Casa> CargoDatosGeneric()
        {
            System.Collections.Generic.Stack<Casa> miLista = new System.Collections.Generic.Stack<Casa>();

            miLista.Push(new Casa(123456, "Primera Direccion", DateTime.Now.AddYears(-10)));
            miLista.Push(new Casa(987654, "Segunda Direccion", DateTime.Now.AddYears(-20)));
            miLista.Push(new Casa(456753, "Tercera Direccion", DateTime.Now.AddYears(-30)));

            return miLista;
        }

        internal static void MuestroGeneric(System.Collections.Generic.Stack<Casa> miLista)
        {
            foreach (var item in miLista)
                Console.WriteLine("\t" + item.ToString());
        }

        internal static void MuestroGeneric1Pos(System.Collections.Generic.Stack<Casa> miLista)
        {
            Console.WriteLine("\t" + miLista.Pop().ToString());
        }

    }
}
