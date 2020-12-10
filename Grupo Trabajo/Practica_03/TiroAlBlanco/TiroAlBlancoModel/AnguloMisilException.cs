using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace usuario.TiroAlBlanco
{
    public class AnguloMisilException : Exception
    {
        public AnguloMisilException() : base("Angulo fuera de rango")
        { }
    }
}
