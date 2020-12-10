using System;
using System.Collections.Generic;
using System.IO;

namespace PSS.jefferson_max.Practica_06
{

    class AutentificacionTextFile : IAutentificacion
    {
        
        private string _finCampo;
        private FormatoRegistro _formatoRegistro;
        private string _textFile;
        private Dictionary<string, IUsuarioView> _diccionarioUsuarios;

        /// <summary>
        /// Constructor sobre cargado, en el que se especifica: nombre del archivo que contiene las 
        ///lineas de texto querepresentan a cada Usuario,
        /// el orden de los campos que constituye la información del usuario, y la cadena separadora.
        /// </summary>
        /// <param name="textFile">nombre del archivo de texto</param>
        /// <param name="formatoRegistro">Descripcion del formato del registro (orden de los campos en cada linea del archivo de texto)</param>
        /// <param name="finCampo">cadena que determina la separación entre campos</param>
        public AutentificacionTextFile(string textFile, FormatoRegistro formatoRegistro, string finCampo)
        {
                                    
            this._textFile = textFile;
            this._formatoRegistro = formatoRegistro;
            this._finCampo = finCampo;
            this._diccionarioUsuarios = new Dictionary<string, IUsuarioView>();

            if ((_textFile != null) && File.Exists(_textFile))
            {
                using (var fs = File.OpenRead(textFile))
                {
                    StreamReader _srTextFile = new StreamReader(fs);
                    string reg = null;

                    while ((reg = _srTextFile.ReadLine()) != null)
                    {

                        IUsuarioView user = Decodificar(reg);
                        try
                        {
                            _diccionarioUsuarios.Add(user.Id, user);
                        }
                        catch
                        {
                            throw new AutentificacionExcepcion("Id " + user.Id + " ya existe.",
                                    CodigoAutentificacion.ErrorDatos);
                        }
                    }
                }
            }
            else
                throw new AutentificacionExcepcion("El fichero " + textFile + " no existe.",
                    CodigoAutentificacion.ErrorDatos);
        }

        private IUsuarioView Decodificar(string reg)
        {
            throw new NotImplementedException();
        }

        public bool EliminarUsuario(string id)
        {
            if (!_diccionarioUsuarios.ContainsKey(id))
                return false;
            _diccionarioUsuarios.Remove(id);
           GuardarDatos();
            return true;
        }

       

        public CodigoAutentificacion EsUsuarioAutentificado(string id, string PalabraPaso)
        {
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

        void IAutentificacion.GuardarDatos()
        {
            throw new NotImplementedException();
        }

        public bool InsertarUsuario(IUsuarioView user)
        {
            if (_diccionarioUsuarios.ContainsKey(user.Id))
                return false;
            _diccionarioUsuarios.Add(user.Id, user);
            GuardarDatos();//más abajo
            return true;
        }

       public bool ModificarUsuario(string id, IUsuarioView user)
        {
            if (_diccionarioUsuarios == null)
                return false;
            if (_diccionarioUsuarios.ContainsKey(id))
            {
                //el usuario si existe
                _diccionarioUsuarios[id] = user;
                GuardarDatos();
                return true;
            }
            else
                return false;
        }



        ////////////
        public void GuardarDatos()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_textFile))
                {
                    foreach (KeyValuePair<string, IUsuarioView> usu in _diccionarioUsuarios)
                    {
                        string cadena = Codificar(usu.Value);
                        sw.WriteLine(cadena);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
      
       ///////////////
        
        public IUsuarioView ObtenerUsuario(string id)
        {
            if (_diccionarioUsuarios.ContainsKey(id))
                return _diccionarioUsuarios[id];
            return null;
        }
    
        /////////
      
        private string Codificar(IUsuarioView user)
        {
            string cadena;

            cadena = "";
            for (int j = 0; j < _formatoRegistro.CamposRegistro.Length; j++)
            {
                switch (_formatoRegistro.CamposRegistro[j])
                {
                    case CamposRegistro.Id: cadena = cadena + user.Id; break;
                    case CamposRegistro.Nombre: cadena = cadena + user.Nombre; break;
                    case CamposRegistro.PalabraPaso: cadena = cadena + user.PalabraPaso; break;
                    case CamposRegistro.Categoria: cadena = cadena + user.Categoria; break;
                    case CamposRegistro.EsValido: cadena = cadena + user.EsValido; break;
                }
                if (j < _formatoRegistro.CamposRegistro.Length - 1)
                    cadena = cadena + _finCampo;
            }
            return cadena;
        }

    }
}
