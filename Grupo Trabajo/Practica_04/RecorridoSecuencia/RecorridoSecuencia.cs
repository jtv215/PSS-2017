using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.jefferson_max.Practica_04
{
    public class RecorridoSecuencia<T> : IEnumerable<T> where T : IComparable<T>
    {
        private Coleccion<T> coleccion;

        public RecorridoSecuencia(Coleccion<T> coleccion)
        {
            this.coleccion = coleccion;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return coleccion.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return coleccion.GetEnumerator();
        }

        //** Yield**//
        public IEnumerator<T> YieldAdelante()
        {
            EnumeradorAdelante<T> eAdelante = new EnumeradorAdelante<T>(coleccion);
            while (eAdelante.MoveNext())
            {
                yield return eAdelante.Current;
            }
        }
        public IEnumerator<T> YieldAtras()
        {
            EnumeradorAtras<T> eAtras = new EnumeradorAtras<T>(coleccion);
            while (eAtras.MoveNext())
            {
                yield return eAtras.Current;
            }
                      

        }

        public IEnumerator<T> YieldAscendente(string name)
        {
            EnumeradorAscendente<T> eAscendente = new EnumeradorAscendente<T>(this.coleccion, name);
            while (eAscendente.MoveNext())
            {
                yield return eAscendente.Current;
            }
        }

        public IEnumerator<T> YieldDescendente(string name)
        {
            EnumeradorDescendente<T> eDescendente = new EnumeradorDescendente<T>(this.coleccion, name);
            while (eDescendente.MoveNext())
            {
                yield return eDescendente.Current;
            }
        }




    }
}
