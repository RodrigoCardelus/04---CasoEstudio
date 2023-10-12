using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using EC;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.Dictionary<int, Casa> _listaG = CargoDatosGeneric();

            Console.WriteLine("Como queda carga - se recorre contenido Basico");
            MuestroGeneric(_listaG);
            Console.WriteLine("\n");

            Console.WriteLine("Se recorre contenido por claves");
            MuestroGenericPorValor(_listaG);
            Console.WriteLine("\n");

  
            Console.WriteLine("Cantidad de elementos: " + _listaG.Count + "\n");

            Console.WriteLine("Obtengo el valor de la posicion 1");
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

        //---------------------------------------------------------------Operaciones de Manejo Dictionary Generic------------------------

        internal static System.Collections.Generic.Dictionary<int, Casa> CargoDatosGeneric()
        {
            System.Collections.Generic.Dictionary<int, Casa> miLista = new System.Collections.Generic.Dictionary<int, Casa>();

            miLista.Add(123456, new Casa(123456, "Primera Direccion", DateTime.Now.AddYears(-10)));
            miLista.Add(987654, new Casa(987654, "Segunda Direccion", DateTime.Now.AddYears(-20)));
            miLista.Add(456753, new Casa(456753, "Tercera Direccion", DateTime.Now.AddYears(-30)));

            return miLista;
        }

        internal static void MuestroGeneric(System.Collections.Generic.Dictionary<int, Casa> miLista)
        {
            foreach (KeyValuePair<int, Casa> item in miLista)
            {
                Console.WriteLine("Clave: " + item.Key + "\tValor: " + item.Value.ToString());
            }
        }

        internal static void MuestroGeneric1Pos(System.Collections.Generic.Dictionary<int, Casa> miLista)
        {
            KeyValuePair<int, Casa> elemento = miLista.ElementAt(1);
            Console.WriteLine("\t" + elemento.Value.ToString());
        }

        internal static void EliminoGeneric(System.Collections.Generic.Dictionary<int, Casa> miLista)
        {
            miLista.Remove(987654); //--> Elimino por clave
        }

        internal static void MuestroGenericPorValor(System.Collections.Generic.Dictionary<int, Casa> miLista)
        {
            foreach (int item in miLista.Keys)
            {
                Console.WriteLine("Clave: " + item);
            }
        }

    }
}



