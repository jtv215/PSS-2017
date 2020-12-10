using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.jefferson_max.Practica_02
{

    public class UsuarioView : IUsuarioView, IEquatable<UsuarioView>, IComparable<UsuarioView>
    {
        //Atributos

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string PalabraPaso { get; set; }
        public string Categoria { get; set; }
        public bool EsValido { get; set; }

        //Constructor
        public UsuarioView() { }

        //Contructor  por parámetros
        public UsuarioView(int id, string nombre, string palabraPaso, string categoria, bool esValido)
        {
           
            Id= anadirceros(id,4);
            Nombre = nombre;
            PalabraPaso = palabraPaso;
            Categoria = categoria;
            EsValido = esValido;
        }
        private string anadirceros(int id, int max)
        {
            String result = "";
            String valor = id.ToString();


            if (valor.Length > max) throw new ArgumentException();

            for(int i = valor.Length; i < max; i++)//añadir 0, para el sort
            {
                result += "0";
            }

            return result+=valor;
        }

        /** ################# Equals ################### */
        public bool Equals(UsuarioView other)
        {

            if (ReferenceEquals(this, other))
                return true;
            if (ReferenceEquals(other, null))
                return false;
            return Id.Equals(other.Id);
        }
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (this.Id.Equals((obj as UsuarioView).Id))
                {
                    return true;
                }
            }
            return false;
        }



        public static bool operator ==(UsuarioView usu, UsuarioView other)
        {

            return Equals(usu, other);
        }

        public static bool operator !=(UsuarioView usu, UsuarioView other)
        {

            return !(usu == other);
        }

        public override int GetHashCode()
        {
            if (Id == null)
                return "".GetHashCode(); //para devolver un GetHashCode de una cadena vacia
            return Id.GetHashCode();
        }


        /** #################CompareTo ################### */
        public int CompareTo(UsuarioView other)
        {

            if (ReferenceEquals(other, null))
                return 1;
            if (ReferenceEquals(this, other))
                return 0;
            return this.Id.CompareTo(other.Id);
        }


        public static bool operator >=(UsuarioView usu1, UsuarioView usu2)
        {
            if (ReferenceEquals(usu1, null) && ReferenceEquals(usu2, null))
                return true;
            if (ReferenceEquals(usu1, null))
                return false;
            if (ReferenceEquals(usu2, null))
                return true;
            return usu1.Id.CompareTo(usu2.Id) >= 0;
        }

        public static bool operator <=(UsuarioView usu1, UsuarioView usu2)
        {
            if (ReferenceEquals(usu1, null) && ReferenceEquals(usu2, null))
                return true;
            if (ReferenceEquals(usu1, null))
                return true;
            if (ReferenceEquals(usu2, null))
                return false;
            return usu1.Id.CompareTo(usu2.Id) <= 0;
        }

        public static bool operator >(UsuarioView usu1, UsuarioView usu2)
        {
            if (ReferenceEquals(usu1, null) && ReferenceEquals(usu2, null))
                return false;
            if (ReferenceEquals(usu1, null))
                return false;
            if (ReferenceEquals(usu2, null))
                return true;
            return usu1.Id.CompareTo(usu2.Id) > 0;
        }

        public static bool operator <(UsuarioView usu1, UsuarioView usu2)
        {
            if (ReferenceEquals(usu1, null) && ReferenceEquals(usu2, null))
                return false;
            if (ReferenceEquals(usu1, null))
                return true;
            if (ReferenceEquals(usu2, null))
                return false;
            return usu1.Id.CompareTo(usu2.Id) < 0;
        }





    }

    //** ####interfaz ####**/

    public interface IUsuarioView
    {
        string Id { get; set; }  //representa el identificador único del objeto
        string Nombre { get; set; }
        string PalabraPaso { get; set; }
        string Categoria { get; set; }
        bool EsValido { get; set; }
    }


    //** #### Icomparer ####**/

    public interface IComparer<in T>
    {
        int Comparer(T X, T y);
    }

    public class ComparadorPropiedad<T> : IComparer<T>
    {
        private PropertyDescriptor GetProperty(string name)
        {
            T item = (T)Activator.CreateInstance(typeof(T));
            PropertyDescriptor propName = null;
            foreach (PropertyDescriptor propDesc in TypeDescriptor.GetProperties(item))
            {
                if (propDesc.Name.Contains(name)) propName = propDesc;
            }
            return propName;
        }
        private PropertyDescriptor _property;
        private bool _esAscendente;


        private int comparaPropiedades(T x, T y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (x == null) return -1;
            object valueX = _property.GetValue(x);
            object valueY = _property.GetValue(y);
            return ((valueX as IComparable).CompareTo(valueY));
        }


        public ComparadorPropiedad(string nombrePropiedad) : this(nombrePropiedad, true)
        {

        }


        public ComparadorPropiedad(string nombrePropiedad, bool esAscendente)
        {
            _esAscendente = esAscendente;
            _property = GetProperty(nombrePropiedad);
            if (_property == null) throw new MissingFieldException();

        }



        public int Comparer(T x, T y)
        {
            if (_esAscendente) return comparaPropiedades(x, y);
            else return -comparaPropiedades(x, y);

        }


    }




}
