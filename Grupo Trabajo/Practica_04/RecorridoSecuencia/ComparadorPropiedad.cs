using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PSS.jefferson_max.Practica_04
{
    public class ComparadorPropiedad<T> : IComparer<T> where T : IComparable<T>
    {
        private string name;

        public ComparadorPropiedad(string name)
        {
            this.name = name;
        }



        private System.ComponentModel.PropertyDescriptor GetProperty(string name)
        {
            T item = (T)Activator.CreateInstance(typeof(T));
            PropertyDescriptor propName = null;
            foreach (PropertyDescriptor propDesc in TypeDescriptor.GetProperties(item))
            {
                if (propDesc.Name.Contains(name)) propName = propDesc;
            }
            return propName;
        }


        public int Compare(T x, T y)
        {
            PropertyDescriptor campo = GetProperty(name);
            string cadX = campo.GetValue(x).ToString();
            string cadY = campo.GetValue(y).ToString();
            return cadX.CompareTo(cadY);
        }

    }
}