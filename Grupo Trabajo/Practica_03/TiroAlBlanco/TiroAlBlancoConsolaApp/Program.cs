using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TiroAlBlancoModel;
using usuario.TiroAlBlanco;

namespace TiroAlBlancoConsolaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nombre, cadena, tipoObjetivo;
            IPartida partida;
            double velocidad, angulo;
            IMisil misil;
            string idioma;
            do
            {
                Console.Write("Que idioma quieres (1-español, 2-ingles): ");
                idioma = Console.ReadLine();
            } while (idioma != "1" && idioma != "2");
            if (idioma == "1")
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            else
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");






            Console.Write(TiroAlBlanco.inputName);
            
            nombre = Console.ReadLine();
            
            do
            {
                Console.Write(TiroAlBlanco.tiypeObjetive);
                tipoObjetivo = Console.ReadLine();
            } while (tipoObjetivo != "1" && tipoObjetivo != "2");

            partida = TiroAlBlancoFactory.CrearPartidaObjetivo(nombre, tipoObjetivo);

            Console.WriteLine();
            Console.WriteLine(TiroAlBlanco.welcome + partida.Usuario.UsuarioId);
            while (!partida.ObjetivoAlcanzado)
            {
                try
                {
                    Console.WriteLine(TiroAlBlanco.TargetDistance + partida.Objetivo.Distancia + " m");
                    Console.Write(TiroAlBlanco.degrees);
                    cadena = Console.ReadLine();
                    angulo = Double.Parse(cadena);
                    Console.Write(TiroAlBlanco.velocity);
                    cadena = Console.ReadLine();
                    velocidad = Double.Parse(cadena);
                    misil = TiroAlBlancoFactory.CrearMisil(velocidad, angulo);
                    partida.DispararMisil(misil);
                    Console.Write(partida.NumDisparos + "º"+TiroAlBlanco.PlayerLaunch +
                        partida.Usuario.UsuarioId + ": ");
                    if (partida.ObjetivoAlcanzado)
                    {
                        Console.WriteLine(TiroAlBlanco.missileLess);
                        Console.WriteLine(TiroAlBlanco.destroyed + partida.NumDisparos + TiroAlBlanco.Attempts);
                    }
                    else
                    {
                        Console.WriteLine("Misil cae a " + partida.DistanciaRelativaImpacto + " m");
                        //Console.WriteLine("Misil {0} cae a {1} m", 4, 5);
                    }
                }
                catch (VelocidadMisilException)
                {
                    Console.WriteLine(TiroAlBlanco.mistake1);
                }
                catch (AnguloMisilException)
                {
                    Console.WriteLine(TiroAlBlanco.mistake2);
                }
            }

            Console.ReadLine();

        }
    }
}