using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.jefferson_max.Practica_04
{
    public class EnumeradorAdelante<T> : IEnumerator<T>
    {
        private Coleccion<T> lista;
        private int posicion;


        public EnumeradorAdelante(Coleccion<T> coleccion)
        {
            this.lista = coleccion;
            posicion = -1;
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
            if (posicion >= lista.Cuenta)
                return false;
            return true;
        }

        public void Reset()
        {
            posicion = -1;
        }
    }
}
