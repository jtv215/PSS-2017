
using System;

namespace usuario.TiroAlBlanco
{
    public class VelocidadMisilException : Exception
    {
        public VelocidadMisilException() : base("Velocidad fuera de rango")
        { }
    }
}