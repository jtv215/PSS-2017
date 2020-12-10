using System;

namespace TiroAlBlancoModel
{
    public class ObjetivoDistanciaException: Exception
    {
        public ObjetivoDistanciaException() : base("Distancia objetivo fuera de rango")
        { }
    }
}