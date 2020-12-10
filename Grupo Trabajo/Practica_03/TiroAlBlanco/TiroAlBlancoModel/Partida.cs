using System;

namespace TiroAlBlancoModel
{
    public class Partida : IPartida
    {
        private IUsuario _usuario;
        private int _numDisparos;
        private double _distancia;
        private IObjetivo _objetivo;
        private IMisil _misil;
        private bool _alcanzado;

        public Partida()
        {
            this.Usuario = TiroAlBlancoFactory.CrearUsuario();
            this.NumDisparos = 0;
            Random random = new Random();
            int distanciaObjetivo = random.Next(20001);
            this.Objetivo = TiroAlBlancoFactory.CrearObjetivoFijo(distanciaObjetivo);
            this.DistanciaRelativaImpacto = distanciaObjetivo;
            _misil = null;
        }

        public Partida(string nombreUsuario)
        {
            this.Usuario = TiroAlBlancoFactory.CrearUsuario(nombreUsuario);
            this.NumDisparos = 0;
            Random random = new Random();
            int distanciaObjetivo = random.Next(20001);
            this.Objetivo = TiroAlBlancoFactory.CrearObjetivoFijo(distanciaObjetivo);
            this.DistanciaRelativaImpacto = distanciaObjetivo;
            _misil = null;
        }

        public Partida(string nombreUsuario, string tipoObjetivo)
        {
            if (nombreUsuario == "")
                this.Usuario = TiroAlBlancoFactory.CrearUsuario();
            else
                this.Usuario = TiroAlBlancoFactory.CrearUsuario(nombreUsuario);
            this.NumDisparos = 0;
            Random random = new Random();
            int distanciaObjetivo = random.Next(20001);
            if (tipoObjetivo == "1")
                this.Objetivo = TiroAlBlancoFactory.CrearObjetivoFijo(distanciaObjetivo);
            else
                this.Objetivo = TiroAlBlancoFactory.CrearObjetivoMovil(distanciaObjetivo);
            this.DistanciaRelativaImpacto = distanciaObjetivo;
            _misil = null;
        }

        public IUsuario Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }

        public IObjetivo Objetivo
        {
            get { return _objetivo; }
            set { _objetivo = value; }
        }

        public int NumDisparos
        {
            get
            {
                return _numDisparos;
            }
            set
            {
                _numDisparos = value;
            }
        }

        public double DistanciaRelativaImpacto
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

        public void DispararMisil(IMisil misil)
        {
            //si no llego al objetivo, la distancia relativa de impacto es negativa
            //y si me paso, es positiva
            DistanciaRelativaImpacto = misil.Alcance - _objetivo.Distancia;
            NumDisparos++;
            _objetivo.Desplazar();
            _misil = misil;
        }

        public bool ObjetivoAlcanzado
        {
            get
            {
                if (Math.Abs(DistanciaRelativaImpacto) <=1)
                    return true;
                return false;
            }
            set { }
        }
        }
}
