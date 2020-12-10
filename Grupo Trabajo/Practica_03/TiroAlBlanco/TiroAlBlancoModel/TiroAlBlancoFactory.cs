using System;
using usuario.TiroAlBlanco;

namespace TiroAlBlancoModel
{

    public class TiroAlBlancoFactory
    {
        public static IMisil CrearMisil(double Velocidad, double Angulo)
        {
            if (Angulo < 0 || Angulo > 90)
                throw new AnguloMisilException();
            if (Velocidad < 0 || Velocidad > 300000)
                throw new VelocidadMisilException();
            return new MisilBalistico(Velocidad, Angulo);
           
        }

        public static IObjetivo CrearObjetivoFijo(double Distancia)
        {
            if (Distancia < 0 || Distancia > 20000)
                throw new ObjetivoDistanciaException();
            return new ObjetivoFijo(Distancia);

           
        }

        public static IUsuario CrearUsuario()
        {
            return new Usuario();
        }


        public static IUsuario CrearUsuario(string nombreUsuario)
        {
            return new Usuario(nombreUsuario);
        }

        public static IPartida CrearPartida()
        {
            return new Partida();
        }

        public static IPartida CrearPartida(string nombreUsuario)
        {
            return new Partida(nombreUsuario);
        }

        public static IPartida CrearPartidaObjetivo(string nombreUsuario, string tipoObjetivo)
        {
            return new Partida(nombreUsuario, tipoObjetivo);
        }



        public static IObjetivo CrearObjetivoMovil(double Distancia)
        {
            if (Distancia < 0 || Distancia > 20000)
                throw new ObjetivoDistanciaException();
            return new ObjetivoMovil(Distancia);
        }
        
    }






}





