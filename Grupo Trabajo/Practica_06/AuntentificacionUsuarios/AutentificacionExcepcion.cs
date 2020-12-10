using System;
using System.Runtime.Serialization;

namespace PSS.jefferson_max.Practica_06
{
    [Serializable]
    public class AutentificacionExcepcion : Exception
    {
        private object errorDatos;
        private string v;

        public AutentificacionExcepcion()
        {
        }

        public AutentificacionExcepcion(string message) : base(message)
        {
        }

        public AutentificacionExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }

        public AutentificacionExcepcion(string v, object errorDatos)
        {
            this.v = v;
            this.errorDatos = errorDatos;
        }

        protected AutentificacionExcepcion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}