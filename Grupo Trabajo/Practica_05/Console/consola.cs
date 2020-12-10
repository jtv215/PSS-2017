using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.jefferson_max.Practica_05
{
   public class Program
    {
     public static void Main(string[] args)
        {
            
            Consultas _datos = new Consultas();
            IEnumerable<vmNombre> resultado;           
            int categoriaId;
            String nombre,comienzo,ip,email;


            //**Consulta de Usuario **//

            Console.WriteLine("******Consulta de Usuarios******");
            Console.WriteLine();
            Console.WriteLine("1º) Categoria Id aconsultar: '2'");
            //categoriaId = Int32.Parse("2");
            resultado = _datos.UsuariosEnCategoria(2);
            foreach (vmNombre v in resultado)
                Console.WriteLine(v.Nombre);
            Console.WriteLine();

            Console.WriteLine("2º) Nombre de la categoria a consultar: 'Alumno'");
            nombre = "Alumno";
            resultado = _datos.UsuariosEnCategoria(nombre);
            foreach (vmNombre v in resultado)
                Console.WriteLine(v.Nombre);
            Console.WriteLine();

            Console.WriteLine("3º) Letra del usuario a consultar: 'J'");
            comienzo = "J";
            resultado = _datos.UsuariosConNombreComienza(comienzo);
            foreach (vmNombre v in resultado)
                Console.WriteLine(v.Nombre);
            Console.WriteLine();

            Console.WriteLine("4º) Letra del usuario a consultar: 'J'");
            comienzo = "J";
            Console.WriteLine("-nombre de la categoria a consultar: 'Alumno'");
            nombre = "Alumno";
            resultado = _datos.UsuariosConNombreComienzaEnCategoria(comienzo, nombre);
            foreach (vmNombre v in resultado)
                Console.WriteLine(v.Nombre);
            Console.WriteLine();


            Console.WriteLine("5º) IP de conexion del usuario a consultar: '192.168.134.23' ");
            ip = "192.168.134.23";
            resultado = _datos.UsuariosConectadosIP(ip);
            foreach (vmNombre v in resultado)
                Console.WriteLine(v.Nombre);
            Console.WriteLine();

            Console.WriteLine("6º) Nombre de la aplicacion a consultar: 'Excel' ");
            nombre = "Excel";
            Console.WriteLine("-Email del usuario a consultar: 'Juan.pss-2@ual.es'");
            email = "Juan.pss-2@ual.es";
            resultado = _datos.EncontrarUsuarioAppEmail(nombre, email);
            foreach (vmNombre v in resultado)
                Console.Write(v.Nombre);
            Console.WriteLine();

            Console.Write("Hoja 1/3: Pulse una tecla para ver la Segunda consulta...");
            Console.ReadLine();
            Console.Clear();


           // ******Consulta de Categoria *******//
            IEnumerable < vmCategoriaNombre > result;
            IEnumerable<IGrouping<string, vmCategoriaNombre>> resultado2;


            Console.WriteLine("******Consulta de Categoria******");
            Console.WriteLine();
            Console.WriteLine("1º) Nombre de la aplicacion a consultar: 'Word'");
            nombre = "Word";
            result = _datos.ListaParCategoriaUsuarioParaApp(nombre);
            foreach (vmCategoriaNombre v in result)
                Console.WriteLine(v.Categoria + "  " + v.Nombre);
            Console.WriteLine();

            Console.WriteLine("2º) Lista de usuarios ordenados por categoria:");
            resultado2 = _datos.AgrupacionUsuariosCategorias();
            foreach (IGrouping<string, vmCategoriaNombre> g in resultado2)
            {
                foreach (vmCategoriaNombre v in g)
                {
                    Console.WriteLine(v.Categoria + "  " + v.Nombre);
                }
            }
            Console.WriteLine();

            Console.WriteLine("3º) Lista de usuarios ordenados por categoria decrecientemente:");
            result = _datos.AgrupacionUsuariosCategoriasOrdenadas();
            foreach (vmCategoriaNombre v in result)
                Console.WriteLine(v.Categoria + "  " + v.Nombre);
            Console.WriteLine();

            Console.WriteLine("4º) Categoria con mayor numero de usuarios:");
            result = _datos.CategoriaMaximoNumeroUsuarios();
            foreach (vmCategoriaNombre v in result)
                Console.WriteLine(v.Categoria + "\t" + v.Nombre);
            Console.WriteLine();

            Console.WriteLine("5º) Nombre de la aplicación a constultar: 'Explorer'");
            nombre = "Explorer";
            result = _datos.TodasCategoriasApp(nombre);
            foreach (vmCategoriaNombre v in result)
                Console.WriteLine(v.Categoria + "  " + v.Nombre);
            Console.WriteLine();

            Console.WriteLine("6º) Nombre del usuario a consultar: 'Julio'");
            nombre = "Julio";
            result = _datos.CategoriasAplicacionParaUsuario(nombre);
            foreach (vmCategoriaNombre v in result)
                Console.WriteLine(v.Categoria + "  " + v.Nombre);
            Console.WriteLine();


            Console.Write("Hoja 2/3: Pulse una tecla para ver la tercera consulta...");
            Console.ReadLine();
            Console.Clear();

            //******Consulta agrupaciones *******//

            IEnumerable<vmNombreCantidad> resultadoCantidad;

            Console.WriteLine("******Consulta Agrupaciones******");
            Console.WriteLine();

            Console.WriteLine("1º) Introduce nombre de la categoria a consultar: 'Alumno'");
            nombre = "Alumno";
            resultadoCantidad = _datos.IPconMasConexionesSegunCategoria(nombre);
            foreach (vmNombreCantidad v in resultadoCantidad)
                Console.WriteLine(v.Nombre + " --> " + v.Cantidad);
            Console.WriteLine();

            Console.WriteLine("2º) Suma duracion conexiones de usuarios:");
            resultadoCantidad = _datos.UsuarioSumaDuracionConexiones();
            foreach (vmNombreCantidad v in resultadoCantidad)
                Console.WriteLine(v.Nombre + " --> " + v.Cantidad);
            Console.WriteLine();

            Console.WriteLine("3º) Usuario suma duracion conexiones nulos:");
            resultadoCantidad = _datos.UsuarioSumaDuracionConexionesNulos();
            foreach (vmNombreCantidad v in resultadoCantidad)
                Console.WriteLine(v.Nombre + " --> " + v.Cantidad);
            Console.WriteLine();

            Console.WriteLine("4º) Usuario suma total de conexiones superior a la media :");
            resultadoCantidad = _datos.UsuariosSumaDuracionMayorMedia1();
            foreach (vmNombreCantidad v in resultadoCantidad)
                Console.WriteLine(v.Nombre + " --> " + v.Cantidad);
            Console.WriteLine();

            Console.WriteLine("5º) Usuario suma total de conexiones superior a la media :");
            resultadoCantidad = _datos.UsuariosSumaDuracionMayorMedia();
            foreach (vmNombreCantidad v in resultadoCantidad)
                Console.WriteLine(v.Nombre + " --> " + v.Cantidad);
            Console.WriteLine();

            Console.WriteLine("6º) Lista con el nombre de aplicacion y suma total de duracion de conexiones :");
            resultadoCantidad = _datos.AplicacionesMasUsadas();
            foreach (vmNombreCantidad v in resultadoCantidad)
                Console.WriteLine(v.Nombre + " --> " + v.Cantidad);
            Console.WriteLine();

            Console.WriteLine("7º) Lista con el nombre de aplicacion y suma total de duracion de conexiones :");
            resultadoCantidad = _datos.AplicacionesMasUsadas();
            foreach (vmNombreCantidad v in resultadoCantidad)
                Console.WriteLine(v.Nombre + " --> " + v.Cantidad);
            Console.WriteLine();



            Console.Write("Hoja 3/3: finalizada las hojas de consultas...");

            Console.Read();






        }
    }
}
