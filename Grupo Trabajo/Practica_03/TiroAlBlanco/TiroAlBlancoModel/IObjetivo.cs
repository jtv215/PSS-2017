using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiroAlBlancoModel
{
    public interface IObjetivo
    {
        double Distancia { get; set; }
        void Desplazar();
    }
}