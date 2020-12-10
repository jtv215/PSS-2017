using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.jefferson_max.Practica_06
{
    /// <summary>
    /// Clase AutentificacionSqlServerFile que implementa el interface IAutentificacion mediante una cadena de conexion a base de datos(parámetro del constructor) a una base de datos SqlServer(*.mdf)
    /// </summary>
    class AutentificacionSqlServerFile: IAutentificacion
    {

        /// <summary>
        /// Constructor de la clase que tiene como parámetro la cadena de conexion a la base de datos.
        /// Generar una excepción ErrorDatos si la conexion no es accesible.
        /// </summary>
        /// <param name="conexion"> cadena de conexion:
        /// ejemplo de cadena de conexion = @"data source=(LocalDB)\v11.0; AttachDbFilename=|DataDirectory|\AutentificacionDB.mdf;Integrated Security = True";
        ///</param>
        public AutentificacionSqlServerFile(string cadenaConexion)
        {





        }

        public bool EliminarUsuario(string id)
        {
            throw new NotImplementedException();
        }

        public CodigoAutentificacion EsUsuarioAutentificado(string id, string PalabraPaso)
        {
            throw new NotImplementedException();
        }

        public void GuardarDatos()
        {
            throw new NotImplementedException();
        }

        public bool InsertarUsuario(IUsuarioView user)
        {
            throw new NotImplementedException();
        }

        public bool ModificarUsuario(string id, IUsuarioView user)
        {
            throw new NotImplementedException();
        }

        public IUsuarioView ObtenerUsuario(string id)
        {
            throw new NotImplementedException();
        }
    }
}
