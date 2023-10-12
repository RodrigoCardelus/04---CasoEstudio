using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using EC;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manejo Coleccion comun
            System.Collections.SortedList _lista = CargoDatosComun();

            Console.WriteLine("Como queda carga - se recorre contenido");
            MuestroComun(_lista);
            Console.WriteLine("\n");

            Console.WriteLine("Cantidad de elementos: " + _lista.Count + "\n");

            Console.WriteLine("Elimino valores");
            EliminoComun(_lista);
            Console.WriteLine("\n");

            Console.WriteLine("Contenido despues de eliminar dos valores");
            MuestroComun(_lista);
            Console.WriteLine("\n");

            Console.WriteLine("Cantidad de elementos: " + _lista.Count + "\n");

            Console.WriteLine("Existe el valor 4 de clave en la coleccion? " + _lista.ContainsKey(4) + "\n");
            Console.WriteLine("Existe el valor 'cinco' de valor en la coleccion? -- Case Sensitive " + _lista.ContainsValue("cinco") + "\n");

            Console.ReadLine();



            // liimpio pantalla
            Console.Clear();



            //Manejo Coleccion Generic
            System.Collections.Generic.SortedList<int,Casa> _listaG = CargoDatosGeneric();

            Console.WriteLine("Como queda carga - se recorre contenido");
            MuestroGeneric(_listaG);
            Console.WriteLine("\n");

            Console.WriteLine("Cantidad de elementos: " + _listaG.Count + "\n");

            Console.WriteLine("Obtengo el valor de una clave");
            MuestroGeneric1Pos(_listaG);
            Console.WriteLine("\n");

            Console.WriteLine("Elimino valores");
            EliminoGeneric(_listaG);
            Console.WriteLine("\n");

            Console.WriteLine("Contenido despues de eliminar valores");
            MuestroGeneric(_listaG);
            Console.WriteLine("\n");

            Console.WriteLine("Cantidad de elementos: " + _listaG.Count + "\n");

            Console.WriteLine("Existe el valor 100 de clave en la coleccion? " + _listaG.ContainsKey(100) + "\n");

            Console.ReadLine();

        }

        //---------------------------------------------------------------Operaciones de Manejo SortedList Comun------------------------
        internal static System.Collections.SortedList CargoDatosComun()
        {
            System.Collections.SortedList miLista = new System.Collections.SortedList();

            miLista.Add(5, "Cinco");
            miLista.Add(1, null);
            miLista.Add(2, "Dos");
            miLista.Add(4, "Cuatro");
            miLista.Add(3, "tres");

            return miLista;
        }

        internal static void MuestroComun(System.Collections.SortedList miLista)
        {
            for (int i = 0; i < miLista.Count; i++)
            {
                Console.WriteLine("Clave: " + miLista.GetKey(i) + "\tValor: " + miLista.GetByIndex(i));
            }

        }

        internal static void EliminoComun(System.Collections.SortedList miLista)
        {
            miLista.Remove(1); //--> Elimino por clave
            miLista.RemoveAt(0); // --> Elimino por posicion

        }


        //---------------------------------------------------------------Operaciones de Manejo SortedList Generic------------------------

        internal static System.Collections.Generic.SortedList<int, Casa> CargoDatosGeneric()
        {
            System.Collections.Generic.SortedList<int, Casa> miLista = new System.Collections.Generic.SortedList<int, Casa>();

            miLista.Add(123456,new Casa(123456, "Primera Direccion", DateTime.Now.AddYears(-10)));
            miLista.Add(987654,new Casa(987654, "Segunda Direccion", DateTime.Now.AddYears(-20)));
            miLista.Add(456753, new Casa(456753, "Tercera Direccion", DateTime.Now.AddYears(-30)));

            return miLista;
        }

        internal static void MuestroGeneric(System.Collections.Generic.SortedList<int, Casa> miLista)
        {
            for (int i = 0; i < miLista.Count; i++)
            {
                Console.WriteLine("Clave: " + miLista.Keys[i] +  "\tValor: " + miLista.Values[i]);
            }
        }

        internal static void MuestroGeneric1Pos(System.Collections.Generic.SortedList<int, Casa> miLista)
        {
            Console.WriteLine("\t" + miLista[987654].ToString());
        }

        internal static void EliminoGeneric(System.Collections.Generic.SortedList<int, Casa> miLista)
        {
            miLista.Remove(987654); //--> Elimino por clave
            miLista.RemoveAt(0); // --> Elimino por posicion

        }

    }
}
