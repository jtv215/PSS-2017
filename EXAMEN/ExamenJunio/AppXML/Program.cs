using PSS.ExamenJunio.Mantenimiento;
using PSS.ExamenJunio.Procesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppXML
{
   public class Program
    {
        static void Main(string[] args)
        {
            string ruta = (@"C:/TFS/GINEBRA/2016-PSS-ALUMNOS/Tomala Villarreal Jefferson Max (jtv215)/EXAMEN/ExamenJunio/AppXML/usuario.xml");
            
            
            System.Console.WriteLine("\n1)El nombre del archivo de entrada es: usario.xml ");
            System.Console.WriteLine("\n2)El listado del archivo XMl:\n");
            MantenimientoXML m= new MantenimientoXML(ruta);
            m.ListaUsuarios();

            System.Console.WriteLine("\n3)Obtener la edad media de los usuarios: "+m.EdadMedia());
            System.Console.WriteLine("\n4)Número total de usuarios: " + m.NumeroTotalUsuarios());
            System.Console.WriteLine("\n5)Número de usuarios menores de edad: " + m.MenoresEdad());


            Console.Read();

        }
    }
}
