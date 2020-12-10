using PSS.jefferson_max.Practica_04;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PSS.jefferson_max.Practica_04
{
    public class Coleccion<T> :List<T>,  IEnumerable<T>
    {
        public Coleccion() : base()
        { }


        public Coleccion(IEnumerable<T> enu) : base(enu)
        { }
          
        public void Anadir(T item)
        {
            base.Add(item);
        }

        public bool Eliminar(T item)
        {
            return base.Remove(item);
        }
        public bool Contiene(T item)
        {
            return base.Contains(item);
        }

        public void Limpiar()  
        {
            base.Clear();
        }

       

        public int Cuenta
        {
            get { return base.Count; }
        }


      
        public void Ordenar(IComparer<T> comparador)
        {
            base.Sort(comparador);
        }

   
       
        public new T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.Cuenta)
                    return this.ElementAt(index);
                return default(T);
            }
            set
            { }
        }



        public IEnumerator<T> GetEnumerator()
        {
            return base.GetEnumerator();

        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        //
    }
}