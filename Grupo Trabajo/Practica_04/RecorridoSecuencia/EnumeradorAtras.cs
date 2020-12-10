using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.jefferson_max.Practica_04
{
   public class EnumeradorAtras<T> : IEnumerator<T>
    {
        private Coleccion<T> coleccion;
        private int posicion;

        public EnumeradorAtras(Coleccion<T> coleccion)
        {
            this.coleccion = coleccion;
            posicion = this.coleccion.Cuenta;
        }
        public T Current
        {
            get
            {
                if (posicion >= 0 && posicion < coleccion.Cuenta)
                    return coleccion.ElementAt(posicion);
                return default(T);
            }
        }

        object IEnumerator.Current
        {
            get
            {
                if (posicion >= 0 && posicion < coleccion.Cuenta)
                    return coleccion.ElementAt(posicion);
                return default(T);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            posicion--;
            if (posicion < 0)
                return false;
            return true;
        }

        public void Reset()
        {
            posicion = coleccion.Cuenta;
        }
    }
}
