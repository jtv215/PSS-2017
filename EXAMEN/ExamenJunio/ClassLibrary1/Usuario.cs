using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.ExamenJunio.Interfaces
{
    public class Usuario : IUsuario
    {
        public string DNI
        {
            get;
            set;          
        }

        public string Edad
        {
            get;
            set;            
        }

        public string Nombre
        {
            get;
            set;           
        }

        public Usuario(string dni, string nombre, string edad)
        {
            DNI = dni;
            Nombre = nombre;
            Edad = edad;

        }

        public Usuario()
        {
            this.DNI = null;
            this.Nombre = null;
            this.Edad = "0";
        }



    }
}
