using System;

namespace PSS.jefferson_max.Practica_TresEnRaya
{
    public class CrearTablero
    {

        public Char[,] matriz = new Char[3, 3];



        public void rellenar()
        {
            char aux = '1';

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = aux++;
                }
            }
        }

        public void dibujar()
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j < 2)
                    {

                        Console.Write(" " + matriz[i, j] + " |");
                    }
                    else
                    {
                        Console.Write(" " + matriz[i, j] + "  |");
                    }

                }
                if (i < 2)
                {
                    Console.Write("\n-------------\n");
                }

            }

            Console.WriteLine("\n");
        }




        public string jugador1(int n)
        {
            int i, j;

            switch (n)
            {
                case 1:

                    i = 0;
                    j = 0;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'X';
                    }

                    break;

                case 2:

                    i = 0;
                    j = 1;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {


                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'X';
                    }


                    break;
                case 3:

                    i = 0;
                    j = 2;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'X';
                    }

                    break;
                case 4:

                    i = 1;
                    j = 0;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'X';
                    }

                    break;
                case 5:

                    i = 1;
                    j = 1;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'X';
                    }

                    break;
                case 6:

                    i = 1;
                    j = 2;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'X';
                    }

                    break;
                case 7:

                    i = 2;
                    j = 0;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'X';
                    }

                    break;
                case 8:

                    i = 2;
                    j = 1;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'X';
                    }

                    break;
                case 9:

                    i = 2;
                    j = 2;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'X';
                    }

                    break;
            }


            return null;
        }



        public string jugador2(int n)
        {
            int i, j;
            string s = "";
            switch (n)
            {
                case 1:

                    i = 0;
                    j = 0;
                    if (matriz[i, j].Equals('X') || matriz[i, j] == 'O')
                    {

                        s = "Casilla Ocupada";
                        System.Console.WriteLine(s);
                        
                    }
                    else
                    {
                        matriz[i, j] = 'O';
                    }

                    break;

                case 2:

                    i = 0;
                    j = 1;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {


                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'O';
                    }


                    break;
                case 3:

                    i = 0;
                    j = 2;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'O';
                    }

                    break;
                case 4:

                    i = 1;
                    j = 0;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'O';
                    }

                    break;
                case 5:

                    i = 1;
                    j = 1;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'O';
                    }

                    break;
                case 6:

                    i = 1;
                    j = 2;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'O';
                    }

                    break;
                case 7:

                    i = 2;
                    j = 0;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'O';
                    }

                    break;
                case 8:

                    i = 2;
                    j = 1;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'O';
                    }

                    break;
                case 9:

                    i = 2;
                    j = 2;
                    if (matriz[i, j] == 'X' || matriz[i, j] == 'O')
                    {

                        return "Casilla Ocupada";
                    }
                    else
                    {
                        matriz[i, j] = 'O';
                    }

                    break;
            }


            return null;
        }



        public int ganador()
        {

            if (matriz[0, 0] == 'X' || matriz[0, 0] == 'O')//caso 1 en el 1 
            {
                if (matriz[0, 0] == matriz[0, 1] && matriz[0, 0] == matriz[0, 2])//horizontal
                {
                    if (matriz[0, 0] == 'X')
                    {
                        return 0;//he ganado
                    }
                    else
                    {
                        return 1;//he perdido
                    }
                }
                if (matriz[0, 0] == matriz[1, 0] && matriz[0, 0] == matriz[2, 0])//vertical
                {
                    if (matriz[0, 0] == 'X')
                    {
                        return 0;//he ganado
                    }
                    else
                    {
                        return 1;//he perdido
                    }

                }


            }

            if (matriz[1, 1] == 'X' || matriz[1, 1] == 'O')//caso 2 en el centro
            {
                if (matriz[1,1] == matriz[2, 2] && matriz[1,1] == matriz[0, 0])//diagonal
                {
                    if (matriz[1, 1] == 'X')
                    {
                        return 0;//he ganado
                    }
                    else
                    {
                        return 1;//he perdido
                    }
                }
                if (matriz[1, 1] == matriz[1, 0] && matriz[1, 1] == matriz[1, 2])//horizontal
                {
                    if (matriz[1, 1] == 'X')
                    {
                        return 0;//he ganado
                    }
                    else
                    {
                        return 1;//he perdido
                    }

                }
                if (matriz[1, 1] == matriz[2, 0] && matriz[1, 1] == matriz[0, 2])//diagonal izquierda
                {
                    if (matriz[1, 1] == 'X')
                    {
                        return 0;//he ganado
                    }
                    else
                    {
                        return 1;//he perdido
                    }

                }
                if (matriz[1, 1] == matriz[0, 1] && matriz[1, 1] == matriz[2, 1])//horizontal
                {
                    if (matriz[1, 1] == 'X')
                    {
                        return 0;//he ganado
                    }
                    else
                    {
                        return 1;//he perdido
                    }

                }
            }

            if (matriz[2, 2] == 'X' || matriz[2, 2] == 'O')//caso 3
            {
                if (matriz[2, 2] == matriz[2, 0] && matriz[2, 2] == matriz[2, 1])//horizontal
                {
                    if (matriz[0, 0] == 'X')
                    {
                        return 0;//he ganado
                    }
                    else
                    {
                        return 1;//he perdido
                    }
                }
                if (matriz[2, 2] == matriz[1, 2] && matriz[2, 2] == matriz[0, 2])//vertical
                {
                    if (matriz[0, 0] == 'X')
                    {
                        return 0;//he ganado
                    }
                    else
                    {
                        return 1;//he perdido
                    }
                }
            }

                //2 si no ocurre nada

            return 2;

        }

        public String mensaje(int j)
        {
            if (j == 0)
            {
                Console.WriteLine("Felicidades!!! Ha ganado jugador 1 ");
                return "Felicidades!!! Ha ganado jugador 1 ";


            }
            else if(j == 1)
            {
                Console.WriteLine("Felicidades!!! Ha ganado jugador 2 ");
                return "Felicidades!!! Ha ganado jugador 2 ";
            }
            else
            {
                Console.WriteLine("No ha ganado nadie");
                return "No ha ganado nadie";

            }
        }


        public int  get(int i, int j )
        {
            
            return matriz[i, j];
             
        }


    }
}