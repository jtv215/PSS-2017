using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.jefferson_max.Practica_06
{
    
        /// <summary>
        /// Interface IAutentificacion describe el contrato que debe cumplir las clases que implementen la autentificación.
        /// </summary>
        public interface IAutentificacion
        {
            /// <summary>
            /// Su finalidad es comprobar que el usuario está autentificado.
            /// </summary>
            /// <param name="id"> Clave primaria = id</param>
            /// <param name="passWord"> Palabra de paso </param>
            /// <returns> Devuelve el código de autentificación </returns>
            CodigoAutentificacion EsUsuarioAutentificado(string id, string PalabraPaso);
            /// <summary>
            /// Su finalidad es modificar un usuario que debe de estar autentificado.
            /// </summary>
            /// <param name="id"> Clave primaria = id</param>
            /// <param name="user"> Nuevos datos del usuario </param>
            /// <returns> Devuelve si se ha efectuado la modificación adecuadamente </returns>
            bool ModificarUsuario(string id, IUsuarioView user);
            /// <summary>
            /// Su finalidad es Insertar un nuevo usuario que no debe de existir.
            /// </summary>
            /// <param name="user"> Nuevos datos del usuario </param>
            /// <returns> Devuelve si se ha efectuado la insercción adecuadamente </returns>
            bool InsertarUsuario(IUsuarioView user);
            /// <summary>
            /// Su finalidad es eliminar un usuario que debe de existir.
            /// </summary>
            /// <param name="id"> Clave primaria = id</param>
            /// <returns> Devuelve si se ha efectuado la eliminación adecuadamente </returns>
            bool EliminarUsuario(string id);
            /// <summary>
            /// Su finalidad es obtener la información de un usuario.
            /// </summary>
            /// <param name="id"> Clave primaria = id</param>
            /// <returns> Devuelve el Usuario o null en caso de que no exista </returns>
            IUsuarioView ObtenerUsuario(string id);
            /// <summary>
            /// Su finalidad es guardar la información en el origen de datos (si procede).
            /// </summary>
            void GuardarDatos();
        }

        /// <summary>
        /// Tipo enumerado con Flags para representar los posibles errores codificados de autentificación que se pueden dar conjuntamente
        /// </summary>
        [FlagsAttribute]
        public enum CodigoAutentificacion
        {
            /// El identificador de usuario y la palabra de paso coinciden con la que está almacenada en el origen de dato
            AccesoCorrecto = 0,
            /// Error en el acceso a la fuente de datos (por ej. error en la apertura del fichero de Usuarios, conexión a la base de datos ...)
            ErrorDatos = 1,
            /// El identificador de usuario existe, pero además es un usuario no válido (no le está permitido acceder al sistema). Es acumulativo con ErrorPalabrapaso.
            AccesoInvalido = 2,
            /// La clave primaria (UsuarioId) no se encuentra en el origen de datos
            ErrorIdUsuario = 4,
            /// La palabra de paso del usuario encontrado no coincide con la que está almacenada en el origen de dato
            ErrorPalabraPaso = 8
        }



 }

