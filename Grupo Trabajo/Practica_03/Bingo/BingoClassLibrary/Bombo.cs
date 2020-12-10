using System;
using BingoClassLibrary;
using System.Collections.Generic;

namespace BingoClassLibrary
{
    public class Bombo
    {
        HashSet<Bola> _bolas = new HashSet<Bola>();
        //private int _numeroBolas;
   
        public int NumeroBolas { get { return _bolas.Count; } }

       

        public void MeterBola(Bola bola)
        {
            _bolas.Add(bola); 
          
        }

        public bool EstaBola(Bola bola)
        {
            return _bolas.Contains(bola);
        }

        public void SacarBola(Bola bola)
        {
            if (_bolas.Contains(bola))
                _bolas.Remove(bola);
            else
                throw new ArgumentOutOfRangeException();
        }

        public Bola ElegirBola()
        {
            if (NumeroBolas <= 0) throw new ArgumentOutOfRangeException();
            Random ramdom = new Random(DateTime.Now.Millisecond);
            Bola bola = new Bola();
            do
            {
                int numAleatorio = ramdom.Next(1, 91);
                bola.numero = numAleatorio;
            }
            while (!EstaBola(bola));
            return bola;
        }


        public HashSet<Bola> Bolas
        {
            get { return _bolas; }
        }

        public void Rellenar()
        {
            for (int i = 1; i <= 90; i++)
            {
                Bola bola = new Bola();
                bola.numero = i;
                MeterBola(bola);
            }
        }
    }
}