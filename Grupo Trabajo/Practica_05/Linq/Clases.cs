using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.jefferson_max.Practica_05
{

    //** Clase Aplicación*//
    public class Aplicacion
    {
        private int _id;
        private string _nombreAplicacion;
        private string _path;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string NombreAplicacion
        {
            get { return _nombreAplicacion; }
            set { _nombreAplicacion = value; }
        }
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

    }
    //** Clase Categoria*//
    public class Categoria
    {
        private int _Id;
        private string _NombreCategoria;
        private int _AplicacionId;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string NombreCategoria
        {
            get { return _NombreCategoria; }
            set { _NombreCategoria = value; }
        }

        public int AplicacionId
        {
            get { return _AplicacionId; }
            set { _AplicacionId = value; }
        }

    }

    //** Clase Conexion*//
    public class Conexion
    {
        private int _id;
        private string _ip;
        private DateTime _fechaInicio;
        private double _duracion;
        private int _usuarioCategoriaId;


       
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }

        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public double Duracion
        {
            get { return _duracion; }
            set { _duracion = value; }

        }

        public int UsuarioCategoriaId
        {
            get { return _usuarioCategoriaId; }
            set { _usuarioCategoriaId = value; }
        }

        public Conexion()
        { }


     }
    //** Clase Personal*//

    public class Personal
    {
        private int _Id;
        private int _UsuarioId;
        private int _AplicaiconId;
        private string _Password;
        private string _Email;
        private bool _EstaBloqueado;
        private DateTime _FechaAlta;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int UsuarioId
        {
            get { return _UsuarioId; }
            set { _UsuarioId = value; }
        }

        public int AplicacionId
        {
            get { return _AplicaiconId; }
            set { _AplicaiconId = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public bool EstaBloqueado
        {
            get { return _EstaBloqueado; }
            set { _EstaBloqueado = value; }
        }

        public DateTime FechaAlta
        {
            get { return _FechaAlta; }
            set { _FechaAlta = value; }
        }

    }

        //** Clase Usuario*//
        
    public class Usuario
    {
        private int _Id;
        private string _nombreUsuario;
        private bool _EsAnonimo;
        private int _AplicacionId;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string NombreUsuario
        {
            get { return _nombreUsuario;    }
            set { _nombreUsuario = value; }
        }

        public bool EsAnonimo
        {
            get { return _EsAnonimo; }
            set { _EsAnonimo = value; }
        }

        public int AplicacionId
        {
            get { return _AplicacionId; }
            set { _AplicacionId = value; }
        }
        public Usuario()
        {
            _Id = 0;
            _nombreUsuario = null;
            _EsAnonimo = false;
            _AplicacionId = 0;
        }        
    }

    //** Clase UsuarioCategoria*//

    public class UsuarioCategoria
    {
        private int _Id;
        private int _categoriaId;
        private int _usuarioId;
       
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int CategoriaId
        {
            get { return _categoriaId; }
            set { _categoriaId = value; }
        }

        public int UsuarioId
        {
            get { return _usuarioId; }
            set { _usuarioId = value; }
        }
    }

    //** Clase vmCategoriaNombre*//

    public class vmCategoriaNombre
    {

        public string Nombre { get; set; }
        public string Categoria { get; set; }

        public override bool Equals(object obj)
        {
            vmCategoriaNombre vm = obj as vmCategoriaNombre;
            if (ReferenceEquals(vm, null))
                return false;
            else
                return Categoria.Equals(vm.Categoria);
        }

        public override int GetHashCode()
        {
            return this.Categoria.GetHashCode();
        }
    }

    //** Clase vmNombre*//
    public class vmNombre : IEquatable<Object>
    {
        

        public string Nombre { get; set; }

        public override bool Equals(object obj)
        {
            vmNombre vm = obj as vmNombre;
            if (ReferenceEquals(vm, null))
                return false;
            else
                return Nombre.Equals(vm.Nombre);
        }


        public override int GetHashCode()
        {
            return this.Nombre.GetHashCode();
        }
    }


    //** Clase vmNombreCantidad*//

    public class vmNombreCantidad
    {
        public string Nombre { get; set; }       
        public double Cantidad { get; set; }


    }
}
