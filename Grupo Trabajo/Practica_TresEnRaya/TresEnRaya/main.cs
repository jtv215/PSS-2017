using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSS.jefferson_max.Practica_TresEnRaya;


namespace PSS.jefferson_max.Practica_TresEnRaya
{
    public class main
    {
        public static void Main(string[] args)
        {
            
            CrearTablero matriz = new CrearTablero();
            matriz.rellenar();
            Console.WriteLine("------Comienza partida Tres en raya------");
            Console.WriteLine("Jugador 1: ficha X");
            Console.WriteLine("Jugador 2: ficha O");
            matriz.dibujar();
            
            int i = 0;
            int j;

            do
            {


                if (i % 2 == 0)
                {
                    Console.WriteLine("------Empieza jugador 1------");
                    Console.WriteLine("Selecciona la ubicación:");
                    string ubicacion = Console.ReadLine();
                    int rango = Int32.Parse(ubicacion);
                    if (rango < 1 || rango > 9)
                    {

                        while (rango < 1 || rango > 9)
                        {
                            Console.WriteLine("vuelve a introduce número:");
                            ubicacion = Console.ReadLine();
                            rango = Int32.Parse(ubicacion);
                        }
                    }
                    else
                    {
                        matriz.jugador1(rango);
                    }
                    Console.Clear();
                    i++;
                    matriz.dibujar();
                }
                else
                {
                    Console.WriteLine("------Empieza jugador 2------");
                    Console.WriteLine("Selecciona la ubicación:");
                    string ubicacion = Console.ReadLine();
                    int rango = Int32.Parse(ubicacion);
                    if (rango < 1 || rango > 9)
                    {
                        while (rango < 1 || rango > 9)
                        {
                            Console.WriteLine("Vuelve a introduce número");
                            ubicacion = Console.ReadLine();
                            rango = Int32.Parse(ubicacion);
                        }
                    }
                    else
                    {
                        matriz.jugador2(rango);
                    }
                    Console.Clear();
                    i++;
                    matriz.dibujar();

                }
                j = matriz.ganador();

            } while (i < 9 && j == 2);

            matriz.mensaje(j);
            

            Console.Read();

        }
        

    }
}
