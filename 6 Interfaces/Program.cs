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
            //Creo conjunto de casas
            Casa[] _VectorCasas = new Casa[3];
            _VectorCasas[0] = new Casa(123456, "Primera Direccion", DateTime.Now.AddYears(-10));
            _VectorCasas[1] = new Casa(987654, "Segunda Direccion", DateTime.Now.AddYears(-20));
            _VectorCasas[2] = new Casa(456753, "Tercera Direccion", DateTime.Now.AddYears(-30));

  
            //creo una lista enumerable
            MiLista _coleccion = new MiLista(_VectorCasas);
  

            //muestro en pantalla dicha lista enumerable
            foreach (Casa unaC in _coleccion)
            {
                Console.WriteLine("\t" + unaC.ToString());
            }

            //pausa
            Console.ReadLine();
        }

    }
}

//-----------------------------------------------------Clase que implementa la interface IEnumerator---------------------
class MilistaBasica : IEnumerator
{
    //atributos
    object[] _lista;
    int _posicion;


    //propiedades
    public object Current
    {
        get { return _lista[_posicion]; }
    }


    //constructor
    public MilistaBasica(object[] plista)
    {
        _lista = plista;
        this.Reset();
    }

  
    //operaciones
    public bool MoveNext()
    {
        _posicion++;

        if (_posicion < _lista.Length)
            return true;
        else
            return false;
    }

    public void Reset()
    {
        _posicion = -1;
    }
}


//-----------------------------------------------------Clase que implementa la interface IEnumerable---------------------
class MiLista: IEnumerable
{
    //atributos
    private MilistaBasica _listainterna;


    //constructores
    public MiLista(object[] lista)
    {
        _listainterna = new MilistaBasica(lista);
    }


    //operaciones
    public IEnumerator GetEnumerator()
    {
        return _listainterna;
    }
}



