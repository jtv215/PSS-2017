using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiroAlBlancoModel
{
    public class ObjetivoMovil : IObjetivo
    {
        private double _distancia;
        private double _desplazamiento;

        public ObjetivoMovil(double distancia)
        {
            this.Distancia = distancia;
            this._desplazamiento = distancia * 0.01;
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
            Distancia = Distancia + _desplazamiento;
        }
    }
}
