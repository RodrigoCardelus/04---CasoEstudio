using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EC;


namespace _0_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uso con Numeros
            MiGeneric<int> _coleccion = new MiGeneric<int>();

            Console.WriteLine("Cargo con Numeros");
            _coleccion.Agregar(100);
            _coleccion.Agregar(200);
            _coleccion.Agregar(300);

            Console.WriteLine("\nMuestro con Numeros - For");
            for (int i = 0; i < _coleccion.Cantidad; i++)
                Console.WriteLine("Pos: " + i + "\t" + _coleccion[i].ToString());

            Console.WriteLine("\nCantidad de elementos: " + _coleccion.Cantidad);

            Console.WriteLine("\nMuestro con Numeros - Operacion");
            Console.WriteLine(_coleccion.Listar());

            Console.ReadLine();

            Console.Clear();


            //uso con objetos
            MiGeneric<Casa> _coleccionG = new MiGeneric<Casa>();

            Console.WriteLine("Cargo con objetos Casas");
            _coleccionG.Agregar(new Casa(123456, "Primera Direccion", DateTime.Now.AddYears(-10)));
            _coleccionG.Agregar(new Casa(987654, "Segunda Direccion", DateTime.Now.AddYears(-20)));
            _coleccionG.Agregar(new Casa(456753, "Tercera Direccion", DateTime.Now.AddYears(-30)));

            Console.WriteLine("\nMuestro con Casas - For");
            for (int i = 0; i < _coleccion.Cantidad; i++)
                Console.WriteLine("Pos: " + i + "\t" + _coleccionG[i].ToString());

            Console.WriteLine("\nCantidad de elementos: " + _coleccionG.Cantidad);

            Console.WriteLine("\nMuestro con Casas - Operacion");
            Console.WriteLine(_coleccionG.Listar());

            Console.ReadLine();
 

        }
    }

    public class MiGeneric<T>
    {
        //atributos
        private List<T> _Lista;
        private int _Cantidad;

        //propiedades
        public List<T> Lista
        {
            get { return _Lista; }
        }

        public int Cantidad
        {
            get { return _Cantidad; }
        }

        public T this[int pos]
        {
            get
            {
                if (pos < 0 || pos >= _Lista.Count)
                    return (default(T));
                else
                    return (_Lista[pos]);
            }
        }


        // constructor
        public MiGeneric()
        {
            _Lista = new List<T>();
            _Cantidad = 0;
        }

        //Operaciones
        public void Agregar(T item)
        {
            _Lista.Add(item);
            _Cantidad++;
        }

        public string Listar()
        {
            string contenido = "";

            foreach (T item in _Lista)
            {
                contenido += "Elemento: " + item.ToString() + "\n";
            }

            return contenido;
        }


    }

 
}