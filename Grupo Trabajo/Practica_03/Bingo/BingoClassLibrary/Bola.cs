using System;
using System.Collections.Generic;

namespace BingoClassLibrary
{
    public class Bola : IEqualityComparer<Bola>, IEquatable<Bola>
    {

        private int _numero;
        public Bola()
        {

        }

        public int numero
        {
            get { return _numero; }
            set
            {
                if (value < 1 || value > 90) throw new ArgumentOutOfRangeException();
                else _numero = value;
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Bola);
        }
        public override int GetHashCode()
        {

            return this.numero.GetHashCode();
        }
        public bool Equals(Bola x, Bola y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null)) return false;
            else return (x.numero == y.numero);
        }
        public int GetHashCode(Bola obj)
        {
            return obj.numero.GetHashCode();
        }
        public bool Equals(Bola other)
        {
            return Equals(this, other);
        }
        public static bool operator ==(Bola a, Bola b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Bola a, Bola b)
        {
            return !a.Equals(b);
        }



    }
}