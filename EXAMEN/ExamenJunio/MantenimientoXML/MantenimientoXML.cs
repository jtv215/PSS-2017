using PSS.ExamenJunio.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PSS.ExamenJunio.Mantenimiento
{
    public class MantenimientoXML : IMantenimiento
    {
        private String _xmlFilename;
        private XDocument _xmlDoc = null;
        public MantenimientoXML(string dir)
        {

            this._xmlFilename = dir;

            if ((_xmlFilename != null) && File.Exists(_xmlFilename))
            {
                try
                {
                    _xmlDoc = XDocument.Load(_xmlFilename);

                }
                catch
                {
                    throw new Exception("al acceder al archivo Xml");
                }
            }
            else throw new Exception("El fichero " + dir + " no existe.");
        }
        public bool Alta(IUsuario usuarioNew)
        {
            if (usuarioNew.DNI == null)
            {
                int id = (from usu in _xmlDoc.Elements("Usuarios").Elements("Usuario")
                          orderby Convert.ToInt16(usu.Attribute("DNI").Value)
                          select Convert.ToInt16(usu.Attribute("DNI").Value)).Max();
                usuarioNew.DNI = Convert.ToString(id + 1);
            }

            XElement ele = new XElement("Usuario",
                                        new XAttribute("DNI", usuarioNew.DNI),
                                        new XElement("Nombre", usuarioNew.Nombre),
                                        new XElement("Edad", usuarioNew.Edad));

            var usuarios = (from u in _xmlDoc.Elements("Usuarios")
                            select u).SingleOrDefault();
            usuarios.Add(ele);
            GuardarDatos();
            return true;
        }

        private void GuardarDatos()
        {
            try
            {                
                _xmlDoc.Save(_xmlFilename);
            }
            catch
            {
                throw new Exception("El fichero " + _xmlFilename + " da error al escribir.");
            }
        }

        public bool Baja(string dni)
        {
            var resultado = (from usu in _xmlDoc.Elements("Usuarios").Elements("Usuario")
                             where usu.Attribute("DNI").Value.Equals(dni)
                             select usu).SingleOrDefault();

            if (resultado == null)
                return false;
            resultado.Remove();
            GuardarDatos();
            return true;
        }

        public IUsuario Consulta(string dni)
        {
            var resultado = (from usuario in _xmlDoc.Elements("Usuarios").Elements("Usuario")
                             where usuario.Attribute("DNI").Value.Equals(dni)
                             select new Usuario
                             {
                                 DNI = usuario.Attribute("DNI").Value,
                                 Nombre = usuario.Element("Nombre").Value,
                                 Edad = usuario.Element("Edad").Value,

                             }).SingleOrDefault();
            return resultado;
        }

        public bool Modificaciones(string dni, IUsuario usuarioModf)
        {
            var resultado = (from usuario in _xmlDoc.Elements("Usuarios").Elements("Usuario")
                             where usuario.Attribute("DNI").Value.Equals(dni)
                             select usuario).SingleOrDefault();
            if (resultado == null)
                return false;
            resultado.SetElementValue("DNI", usuarioModf.DNI);
            resultado.SetElementValue("Nombre", usuarioModf.Nombre);
            resultado.SetElementValue("Edad", usuarioModf.Edad);

            GuardarDatos();
            return true;
        }

        public void ListaUsuarios()
        {
            _xmlDoc.Descendants("Usuario").Select(p => new
            {
                Id = p.Attribute("DNI").Value,
                Nombre = p.Element("Nombre").Value,
                Contraseña = p.Element("Edad").Value
            }).ToList().ForEach(p =>
            {
                Console.WriteLine("Dni: " + p.Id + " Nombre: " + p.Nombre + " Edad: " + p.Contraseña);

            });
        }

        public double EdadMedia()
        {

            double x = 0;
            int n = 0;

            _xmlDoc.Descendants("Usuario").Select(p => new
            {
                dni = p.Attribute("DNI").Value,
                Nombre = p.Element("Nombre").Value,
                edad = p.Element("Edad").Value
            }).ToList().ForEach(p =>
            {
                x = x + Int32.Parse(p.edad);
                n++;
            });
            x = x / n;
            return x;
        }

        public int NumeroTotalUsuarios()
        {
            int n = 0;
            _xmlDoc.Descendants("Usuario").Select(p => new
            {
                dni = p.Attribute("DNI").Value,
                Nombre = p.Element("Nombre").Value,
                edad = p.Element("Edad").Value
            }).ToList().ForEach(p =>
            {
                n++;
            });
            return n;
        }
                
        public int MenoresEdad()
        {
           
            int n = 0;
            _xmlDoc.Descendants("Usuario").Where(p => Convert.ToInt32(p.Element("Edad").Value) < 18).Select(p => new
            {
                dni = p.Attribute("DNI").Value,
                Nombre = p.Element("Nombre").Value,
                edad = p.Element("Edad").Value
            }).ToList().ForEach(p =>
            {
                n++;
            });
            return n;
        }


    }
}
