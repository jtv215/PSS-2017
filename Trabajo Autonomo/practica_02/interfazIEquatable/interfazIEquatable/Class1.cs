using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; //Las expresiones regulares proporcionan un método eficaz y flexible para procesar texto. 
using System.Threading.Tasks;

namespace interfazIEquatable
{
    public class Persona: IEquatable<Person>
    {
        private string uniqueSsn;
        private string lName;

        public Persona(string lastName, string ssn)
        {
            //Determinar si el patrón de expresión regular se produce en el texto de entrada llamando al método Regex.IsMatch. Para obtener un ejemplo que utiliza el método IsMatch para validar texto, consulte Cómo: Comprobar si las cadenas tienen un formato de correo electrónico válido.
            if (Regex.IsMatch(ssn, @"\d{9}"))
                uniqueSsn = String.Format("{0}-(1}-{2}", ssn.Substring(0, 3),
                                                        ssn.Substring(3, 2),
                                                        ssn.Substring(5, 4));
            else if (Regex.IsMatch(ssn, @"\d{3}-\d{2}-\d{4}"))
                uniqueSsn = ssn;
            else

                throw new FormatException("El número de seguro social tiene un formato no válido.");
            uniqueSsn = ssn;
            this.lName = lastName;

        }

        public string SSN
        {
            get { return this.uniqueSsn; }
        }


        public string LastName
        {
            get { return this.lName; }
            set
            {
                if (String.IsNullOrEmpty(value)
                    throw new Agu
            }
        }
    }
}
