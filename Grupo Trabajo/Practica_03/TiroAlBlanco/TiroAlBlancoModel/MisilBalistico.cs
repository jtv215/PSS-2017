using System;

namespace TiroAlBlancoModel
{
    public class MisilBalistico : IMisil
    {
        private double _velocidad;
        private double _angulo;
        private double _distancia;
        private double _radio;
    

        public MisilBalistico(double Velocidad, double Angulo)
        {
            this.VelocidadInicial = Velocidad;
            this.AnguloSalida = Angulo;
             // distancia = velocidad ^ 2 * seno(2 * angulo) / gravedad
            //IMPORTANTE: la velocidad en metros /segundo
            //y el angulo en radianes
            this.Alcance = Math.Pow(VelocidadInicial * 1000 / 3600, 2) *
                    Math.Sin(2 * AnguloSalida * Math.PI / 180)
                    / 9.81; ;
            _radio = 1;
           
        }
        public double Alcance
        {
            get { return _distancia; }
            set { _distancia = value; }
        }

        public double VelocidadInicial
        {
            get
            {
                return _velocidad;
            }
            set
            {
                _velocidad = value;
            }
        }

        public double AnguloSalida
        {
            get
            {
                return _angulo;
            }
            set
            {
                _angulo = value;
            }
        }
        public double Radio
        {
            get
            {
                return _radio;
            }
            set
            {
                _radio = value;
            }
        }







    }
}