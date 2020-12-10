using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.jefferson_max.Practica_04
{
    public class EnumeradorDescendente<T> : IEnumerator<T> where T : IComparable<T>
    {
        private Coleccion<T> lista;
        private int posicion;
        private string nombre;

        public EnumeradorDescendente(Coleccion<T> coleccion, string name)
        {
            this.lista = coleccion;
            EnumeradorAtras<T> enumera = new EnumeradorAtras<T>(coleccion);

            while (enumera.MoveNext())
            {
                this.lista.Anadir(enumera.Current);
            }
            posicion = this.lista.Cuenta;
            this.nombre = name;
            ComparadorPropiedad<T> compara = new ComparadorPropiedad<T>(name);
            this.lista.Ordenar(compara);
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
            posicion--;
            if (posicion < 0)
                return false;
            return true;
        }

        public void Reset()
        {
            posicion = lista.Cuenta;
        }
    }
}
