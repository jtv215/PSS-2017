using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("¿input your name ...? ");
            string nombre = System.Console.ReadLine();
            System.Console.Write("¿enter your surname  ?");
            string apellidos = System.Console.ReadLine();
            string nombreCompuesto = nombre + " " + apellidos;
            string mensaje = "Hola " + nombreCompuesto;
            System.Console.WriteLine(mensaje);
            System.Console.ReadLine();
         }
    }
}
