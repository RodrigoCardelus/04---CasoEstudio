using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using EC;


namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Manejo Coleccion comun
            System.Collections.Queue _lista = CargoDatosComun();

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
            System.Collections.Generic.Queue<Casa> _listaG = CargoDatosGeneric();

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

        //---------------------------------------------------------------Operaciones de Manejo Queue Comun------------------------
        internal static System.Collections.Queue CargoDatosComun()
        {
            System.Collections.Queue miLista = new System.Collections.Queue();

            miLista.Enqueue("Texto");
            miLista.Enqueue(null);
            miLista.Enqueue(1);
            miLista.Enqueue(2);
            miLista.Enqueue(3);

            return miLista;
        }

        internal static void MuestroComun(System.Collections.Queue miLista)
        {
            foreach (var item in miLista)
                Console.WriteLine("\t" + item);

        }

        internal static void Muestro2Pos(System.Collections.Queue miLista)
        {
            Console.WriteLine("\t" + miLista.Dequeue());
            Console.WriteLine("\t" + miLista.Dequeue());

        }


        //---------------------------------------------------------------Operaciones de Manejo Queue Generic------------------------

        internal static System.Collections.Generic.Queue<Casa> CargoDatosGeneric()
        {
            System.Collections.Generic.Queue<Casa> miLista = new System.Collections.Generic.Queue<Casa>();

            miLista.Enqueue(new Casa(123456, "Primera Direccion", DateTime.Now.AddYears(-10)));
            miLista.Enqueue(new Casa(987654, "Segunda Direccion", DateTime.Now.AddYears(-20)));
            miLista.Enqueue(new Casa(456753, "Tercera Direccion", DateTime.Now.AddYears(-30)));

            return miLista;
        }

        internal static void MuestroGeneric(System.Collections.Generic.Queue<Casa> miLista)
        {
            foreach (var item in miLista)
                Console.WriteLine("\t" + item.ToString());
        }

        internal static void MuestroGeneric1Pos(System.Collections.Generic.Queue<Casa> miLista)
        {
            Console.WriteLine("\t" + miLista.Dequeue().ToString());
        }
    }
}
