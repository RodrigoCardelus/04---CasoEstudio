using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;



using EC;


namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manejo Coleccion comun
            System.Collections.Hashtable _lista = CargoDatosComun();

            Console.WriteLine("Como queda carga - se recorre contenido");
            MuestroComun(_lista);
            Console.WriteLine("\n");

            Console.WriteLine("Cantidad de elementos: " + _lista.Count + "\n");

            Console.WriteLine("Obtengo el valor de una clave - 3");
            Muestro1Pos(_lista);
            Console.WriteLine("\n");

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
	}
 

    //---------------------------------------------------------------Operaciones de Manejo HashTable Comun------------------------
    internal static System.Collections.Hashtable CargoDatosComun()
    {
        System.Collections.Hashtable miLista = new System.Collections.Hashtable();

        miLista.Add(5, "Cinco");
        miLista.Add(1, null);
        miLista.Add(2, "Dos");
        miLista.Add(4, "Cuatro");
        miLista.Add(3, "tres");

        return miLista;
    }

    internal static void MuestroComun(System.Collections.Hashtable miLista)
    {
        foreach (DictionaryEntry DE in miLista)
        {
            Console.WriteLine("Clave: " + DE.Key + "\tValor: " + DE.Value);
        }

    }

    internal static void Muestro1Pos(System.Collections.Hashtable miLista)
    {
        Console.WriteLine("\t" + miLista[3].ToString());
    }

    internal static void EliminoComun(System.Collections.Hashtable miLista)
    {
        miLista.Remove(1); //--> Elimino por clave solamente
    }


    




        
    }
}
