using System;
using System.Collections.Generic;


namespace EC
{
    public class Casa
    {
        //Atributos
        private int _Padron;
        private string _Dir;
        private DateTime _FechaC;

        //Propiedades
        public int Padron
        {
            set
            {
                if (value <= 0)
                    throw new Exception("EC: Padron invalido");
                else
                    _Padron = value;
            }
            get { return _Padron; }
        }


        public string Dir
        {
            set
            {
                if (value.Trim().Length == 0)
                    throw new Exception("EC: Direccion invalida");
                else
                    _Dir = value;
            }
            get { return _Dir; }
        }

        public DateTime FechaC
        {
            set
            {
                if (value >= DateTime.Now)
                    throw new Exception("EC: Fecha Construccion invalida");
                else
                    _FechaC = value;
            }
            get { return _FechaC; }
        }


        //Cosntructor    

        public Casa(int pPadron, string pDir, DateTime pFechaC)
        {
            _Padron = pPadron;
            _Dir = pDir;
            _FechaC = pFechaC;
        }

        //Operaciones
        public override string ToString()
        {
            return (Padron + "\t" + Dir + "\t" + FechaC);
        }

    }
}