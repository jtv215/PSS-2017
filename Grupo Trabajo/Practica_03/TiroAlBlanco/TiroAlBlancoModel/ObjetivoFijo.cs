using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiroAlBlancoModel
{
    public class ObjetivoFijo : IObjetivo
    {
        private double _distancia;
        private double _desplazamiento;

        public ObjetivoFijo(double distancia)
        {
            this.Distancia = distancia;
            this._desplazamiento = 0;
        }


        public double Distancia
        {
            get
            {
                return _distancia;
            }
            set
            {
                _distancia = value;
            }
        }

        public void Desplazar()
        {
            
        }
    }
}