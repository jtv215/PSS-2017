using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PSS.jefferson_max.Practica_06
{
   public class AutentificacionXml : IAutentificacion
    {
        private String _xmlFilename = "claves.xml";
        private XDocument _xmlDocument = null;
        IUsuarioView _usuarioAutentificado;

        /// <summary>
        /// Constructor en el que se especifica: nombre del archivo Xml que contiene los Usuario.
        /// </summary>
        /// <param name="xmlFile">nombre del archivo de Xml</param>

        public AutentificacionXml(string xmlFile)
        {
            _xmlFilename = xmlFile;

            if ((_xmlFilename != null) && File.Exists(_xmlFilename))
            {
                try
                {
                    _xmlDocument = XDocument.Load(_xmlFilename);
                }
                catch
                {
                    throw new AutentificacionExcepcion("Error al acceder al archivo Xml", CodigoAutentificacion.ErrorDatos);
                }
            }
            else throw new AutentificacionExcepcion("El fichero " + xmlFile + " no existe.", CodigoAutentificacion.ErrorDatos);
        }

        
        public bool EliminarUsuario(string id)
        {
            var resultado = (from usu in _xmlDocument.Elements("Usuarios").Elements("Usuario")
                             where usu.Attribute("Id").Value.Equals(id)
                             select usu).SingleOrDefault();

            if (resultado == null)
                return false;
            resultado.Remove();
            GuardarDatos();
            return true;
        }

        public CodigoAutentificacion EsUsuarioAutentificado(string id, string PalabraPaso)
        {
            if (_xmlDocument == null)
                return CodigoAutentificacion.ErrorDatos;
            IUsuarioView usuario = ObtenerUsuario(id);
            if (usuario == null)
                return CodigoAutentificacion.ErrorIdUsuario;
            if (usuario.PalabraPaso != PalabraPaso)
            {
                if (usuario.EsValido)
                    return CodigoAutentificacion.ErrorPalabraPaso;
                return CodigoAutentificacion.ErrorPalabraPaso | CodigoAutentificacion.AccesoInvalido;
            }
            if (usuario.EsValido)
                return CodigoAutentificacion.AccesoCorrecto;
            return CodigoAutentificacion.AccesoInvalido;
        }

        public void GuardarDatos()
        {
            try
            {
                _xmlDocument.Save(_xmlFilename);
            }
            catch
            {
                throw new AutentificacionExcepcion("El fichero " + _xmlFilename + " da error al escribir.",
                                    CodigoAutentificacion.ErrorDatos);
            }
        }

        public bool InsertarUsuario(IUsuarioView user)
        {
            if (user.Id == null)
            {
                int id = (from usu in _xmlDocument.Elements("Usuarios").Elements("Usuario")
                          orderby Convert.ToInt16(usu.Attribute("Id").Value)
                          select Convert.ToInt16(usu.Attribute("Id").Value)).Max();
                user.Id = Convert.ToString(id + 1);
            }
            else
            {
                if (ObtenerUsuario(user.Id) != null)
                    return false;
            }
            XElement ele = new XElement("Usuario",
                                        new XAttribute("Id", user.Id),
                                        new XElement("Nombre", user.Nombre),
                                        new XElement("Categoria", user.Categoria),
                                        new XElement("PalabraPaso", user.PalabraPaso),
                                        new XElement("EsValido", user.EsValido.ToString()));
            var usuarios = (from u in _xmlDocument.Elements("Usuarios")
                            select u).SingleOrDefault();
            usuarios.Add(ele);
            GuardarDatos();
            return true;
        }

        public bool ModificarUsuario(string id, IUsuarioView user)
        {
            var resultado = (from usuario in _xmlDocument.Elements("Usuarios").Elements("Usuario")
                             where usuario.Attribute("Id").Value.Equals(id)
                             select usuario).SingleOrDefault();
            if (resultado == null)
                return false;
            resultado.SetElementValue("Nombre", user.Nombre);
            resultado.SetElementValue("PalabraPaso", user.PalabraPaso);
            resultado.SetElementValue("Categoria", user.Categoria);
            resultado.SetElementValue("EsValido", user.EsValido);
            GuardarDatos();
            return true;
        }

        public IUsuarioView ObtenerUsuario(string id)
        {
            var resultado = (from usuario in _xmlDocument.Elements("Usuarios").Elements("Usuario")
                             where usuario.Attribute("Id").Value.Equals(id)
                             select new UsuarioView
                             {
                                 Id = usuario.Attribute("Id").Value,
                                 Nombre = usuario.Element("Nombre").Value,
                                 PalabraPaso = usuario.Element("PalabraPaso").Value,
                                 Categoria = usuario.Element("Categoria").Value,
                                 EsValido = Convert.ToBoolean(usuario.Element("EsValido").Value)
                             }).SingleOrDefault();
            return resultado;
        }
    }
}
