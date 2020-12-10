using BingoClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BingoClassLibrary
{
    public class Carton
    {

        HashSet<Bola> _bolas;
        LinkedList<HashSet<Bola>> _lineas;
        public int NumeroBolasSinTachar { get { return _bolas.Count; } }

        public int NumeroBolas
        {
            get { return _bolas.Count; }
        }

        public Carton()
        {
            _bolas = new HashSet<Bola>();
            Rellenar();
            CrearLineas();
        }

        private void Rellenar()
        {
            do
            {
                Random ramdom = new Random(DateTime.Now.Millisecond);
                Bola bola = new Bola();
                int numAleatorio = ramdom.Next(1, 91);
                bola.numero = numAleatorio;
                _bolas.Add(bola);
            }
            while (_bolas.Count < 15);
        }

        public void TacharBola(Bola bola)
         {
            _bolas.Remove(bola);
            foreach (HashSet<Bola> c in _lineas)
            {
                if (c.Contains(bola))
                    c.Remove(bola);
            }

        }



        private void CrearLineas()
        {
            _lineas = new LinkedList<HashSet<Bola>>();
           
            for (int i = 0; i < 3; i++)
            {
                HashSet<Bola> l = new HashSet<Bola>();
                for (int j = 0; j < 5; j++)
                {
                    Bola b = _bolas.ElementAt(i * 5 + j);
                    l.Add(b);
                }
                _lineas.AddLast(l);
            }
        }

        public bool EsLinea()
        {
            foreach (HashSet<Bola> c in _lineas)
            {
                if (c.Count == 0)
                    return true;
            }
            return false;
        }



    }
}