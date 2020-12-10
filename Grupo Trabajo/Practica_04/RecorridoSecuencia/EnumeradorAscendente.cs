using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.jefferson_max.Practica_04
{
    public class EnumeradorAscendente<T> : IEnumerator<T> where T : IComparable<T>
    {
        
        private Coleccion<T> lista;
        private int posicion;
        private string nombre;


        public EnumeradorAscendente(Coleccion<T> lista, string nombre)
        {
            this.lista = lista;
            posicion = -1;
            this.nombre = nombre;
            ComparadorPropiedad<T> compara = new ComparadorPropiedad<T>(nombre);
            lista.Ordenar(compara);
        }

        public T Current
        {
            get
            {
                if (posicion >= 0 && posicion < lista.Cuenta)
               return lista.ElementAt(posicion);
                return default(T);
            }
        }

        object IEnumerator.Current
        {
            get
            {
                if (posicion >= 0 && posicion < lista.Cuenta)
                    return lista.ElementAt(posicion);
                return null;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            posicion++;
            if (posicion >= 0 && posicion < lista.Cuenta)
                return false;
            return true;
            throw new NotImplementedException();
        }

        public void Reset()
        {
            posicion= -1;
        }
    }

    
   
    
  

  

}
