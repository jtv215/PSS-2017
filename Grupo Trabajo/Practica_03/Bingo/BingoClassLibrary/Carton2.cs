using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoClassLibrary
{
 public class Carton2
    {

        HashSet<Bola> _bolas;
        public HashSet<Bola> Bolas
        {
            get { return _bolas; }
            set { _bolas = value; }
        }


        public Carton2()
        {
            _bolas = new HashSet<Bola>();
            Rellenar();
        }

        private void Rellenar()
        {
            Random ramdom = new Random(DateTime.Now.Millisecond);
            do
            {
                Bola bola = new Bola();
                int numAleatorio = ramdom.Next(1, 91);
                bola.numero = numAleatorio;
                _bolas.Add(bola);
            }
            while (_bolas.Count < 15);
        }



        public int NumeroBolasSinTachar(Bombo bombo)
        {
            return bombo.Bolas.Intersect(this._bolas).Count();
        }
    }






}
