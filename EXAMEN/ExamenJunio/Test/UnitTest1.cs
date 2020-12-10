using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSS.ExamenJunio.Mantenimiento;
using PSS.ExamenJunio.Interfaces;
using System.Xml.Linq;
using System.Linq;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComprobarCargaFichero()
        {
            try
            {
                string ruta = (@"C:/TFS/GINEBRA/2016-PSS-ALUMNOS/Tomala Villarreal Jefferson Max (jtv215)/EXAMEN/ExamenJunio/AppXML/usuario.xml");
                MantenimientoXML xml = new MantenimientoXML(ruta);
                Assert.IsFalse(false);
            }
            catch
            {
                Assert.IsFalse(true);
            }
        }


        //Doy de alta a un usuario nuevo si es asi me devuelve true 
        [TestMethod]
        public void ComprobarAlta()
        {
            string ruta = (@"C:/TFS/GINEBRA/2016-PSS-ALUMNOS/Tomala Villarreal Jefferson Max (jtv215)/EXAMEN/ExamenJunio/AppXML/usuario.xml");
            MantenimientoXML m = new MantenimientoXML(ruta);
            Usuario usuarioNew = new Usuario("5", "Juan", "25");
            Boolean aux;
            if (m.Alta(usuarioNew))
            {
                aux = true;
            }
            else
            {
                aux = false;
            }
            Assert.AreEqual(aux, true);


        }

        //Compruebo la edad de martin que tiene 5 años.
        [TestMethod]
        public void consultaComprueboEdadMartin()
        {
            string ruta = (@"C:/TFS/GINEBRA/2016-PSS-ALUMNOS/Tomala Villarreal Jefferson Max (jtv215)/EXAMEN/ExamenJunio/AppXML/usuario.xml");
            MantenimientoXML m = new MantenimientoXML(ruta);    
            string edad = m.Consulta("1").Edad;            
            string salida = "5";
            System.Console.Write(m.Consulta("1").Edad);
            Assert.AreEqual(edad,salida);
        }

        //El usuario 1 se va a llamar adriana y con edad 40, compruebo si la edad coincide al modificarlo
        [TestMethod]
        public void consultaModificaciones()
        {
            string ruta = (@"C:/TFS/GINEBRA/2016-PSS-ALUMNOS/Tomala Villarreal Jefferson Max (jtv215)/EXAMEN/ExamenJunio/AppXML/usuario.xml");
            MantenimientoXML m = new MantenimientoXML(ruta);
            Usuario usuarioNew = new Usuario("1", "Adriana", "40");
            m.Modificaciones("1", usuarioNew);

            string edad = m.Consulta("1").Edad;
            string salida = "40";
            
            System.Console.Write(m.Consulta("1").Edad);
            Assert.AreEqual(edad, salida);
        }


    }
}
