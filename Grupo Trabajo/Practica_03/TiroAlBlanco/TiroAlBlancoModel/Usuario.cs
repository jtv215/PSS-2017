using System;


namespace TiroAlBlancoModel
{
   
    public class Usuario : IUsuario
    {

        private string _usuarioId;

        public Usuario()
        {
            this.UsuarioId = "Humano";
        }
        public Usuario(string UsuarioId)
        {
            this.UsuarioId = UsuarioId;
        }

        public string UsuarioId
        {
            get
            {
                return _usuarioId;
            }
            set
            {
                _usuarioId = value;
            }
        }
    }
}