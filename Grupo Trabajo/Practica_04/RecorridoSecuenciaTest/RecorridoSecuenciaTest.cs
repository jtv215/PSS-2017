using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSS.jefferson_max.Practica_02;
using System.Collections.Generic;

namespace PSS.jefferson_max.Practica_04

{


    [TestClass]
    public class RecorridoSecuenciaTestAlumno
    {

        /** Coleccion**/

        [TestMethod]
        public void colecionCuenta()
        {
            Coleccion<UsuarioView> coleccion = new Coleccion<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(1, "jeff", "paso", "categoria1", true);
            UsuarioView usu2 = new UsuarioView(2, "ana", "paso", "categoria1", true);
            UsuarioView usu3 = new UsuarioView(3, "pepe", "paso", "categoria1", true);
            coleccion.Anadir(usu1);
            coleccion.Anadir(usu2);
            coleccion.Anadir(usu3);
            int cuenta = coleccion.Cuenta;
            Assert.AreEqual(cuenta, 3);

        }

        [TestMethod]
        public void ColeccionClear()
        {
            Coleccion<UsuarioView> coleccion = new Coleccion<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(1, "jeff", "paso", "categoria1", true);
            UsuarioView usu2 = new UsuarioView(2, "ana", "paso", "categoria1", true);
            UsuarioView usu3 = new UsuarioView(3, "pepe", "paso", "categoria1", true);
            coleccion.Anadir(usu1);
            coleccion.Anadir(usu2);
            coleccion.Anadir(usu3);

            coleccion.Clear();

            UsuarioView aux = new UsuarioView();
            int numero = coleccion.Cuenta;
            Assert.AreEqual(numero, 0);

        }

        /** Enumerador Adelante**/

        [TestMethod]
        public void EnumeradoAdelanteMoveNext()
        {
            Coleccion<UsuarioView> coleccion = new Coleccion<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(1, "jeff", "paso", "categoria1", true);
            UsuarioView usu2 = new UsuarioView(2, "ana", "paso", "categoria1", true);
            UsuarioView usu3 = new UsuarioView(3, "pepe", "paso", "categoria1", true);
            coleccion.Anadir(usu1);
            coleccion.Anadir(usu2);
            coleccion.Anadir(usu3);

            EnumeradorAdelante<UsuarioView> EnumeradorAdelante = new EnumeradorAdelante<UsuarioView>(coleccion);

            UsuarioView aux = new UsuarioView();
            EnumeradorAdelante.MoveNext();//empieza del -1
            EnumeradorAdelante.MoveNext();
            aux = EnumeradorAdelante.Current;
            Assert.AreEqual(aux.Nombre, "ana");

        }


        [TestMethod]
        public void EnumeradoAdelanteActual()
        {
            Coleccion<UsuarioView> coleccion = new Coleccion<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(1, "jeff", "paso", "categoria1", true);
            UsuarioView usu2 = new UsuarioView(2, "ana", "paso", "categoria1", true);
            UsuarioView usu3 = new UsuarioView(3, "pepe", "paso", "categoria1", true);
            coleccion.Anadir(usu1);
            coleccion.Anadir(usu2);
            coleccion.Anadir(usu3);

            EnumeradorAdelante<UsuarioView> EnumeradorAdelante = new EnumeradorAdelante<UsuarioView>(coleccion);

            UsuarioView aux = new UsuarioView();
            aux = EnumeradorAdelante.Current;
            Assert.IsNull(aux);

        }

        [TestMethod]
        public void EnumeradoAdelanteReset()
        {
            Coleccion<UsuarioView> coleccion = new Coleccion<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(1, "jeff", "paso", "categoria1", true);
            UsuarioView usu2 = new UsuarioView(2, "ana", "paso", "categoria1", true);
            UsuarioView usu3 = new UsuarioView(3, "pepe", "paso", "categoria1", true);
            coleccion.Anadir(usu1);
            coleccion.Anadir(usu2);
            coleccion.Anadir(usu3);

            EnumeradorAdelante<UsuarioView> EnumeradorAdelante = new EnumeradorAdelante<UsuarioView>(coleccion);

            UsuarioView aux = new UsuarioView();
            EnumeradorAdelante.MoveNext();//empieza del -1
            EnumeradorAdelante.MoveNext();
            EnumeradorAdelante.Reset();
            aux = EnumeradorAdelante.Current;
            Assert.IsNull(aux);

        }


        /** Enumerador atras**/


        [TestMethod]
        public void EnumeradorAtras()
        {
            Coleccion<UsuarioView> coleccion = new Coleccion<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(1, "jeff", "paso", "categoria1", true);
            UsuarioView usu2 = new UsuarioView(2, "ana", "paso", "categoria1", true);
            UsuarioView usu3 = new UsuarioView(3, "pepe", "paso", "categoria1", true);
            coleccion.Anadir(usu1);
            coleccion.Anadir(usu2);
            coleccion.Anadir(usu3);

            EnumeradorAtras<UsuarioView> EnumeradorAtras = new EnumeradorAtras<UsuarioView>(coleccion);

            UsuarioView aux = new UsuarioView();
            EnumeradorAtras.MoveNext();//empieza desde atrás
            EnumeradorAtras.MoveNext();
            aux = EnumeradorAtras.Current;
            Assert.AreEqual(aux.Nombre, "ana");

        }

        /** Enumerador Ascendente**/

        [TestMethod]
        public void EnumeradorAscendenteConNombre()
        {
            Coleccion<UsuarioView> coleccion = new Coleccion<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(10, "jeff", "paso", "categoria1", true);
            UsuarioView usu2 = new UsuarioView(9, "ana", "paso", "categoria1", true);
            UsuarioView usu3 = new UsuarioView(8, "pepe", "paso", "categoria1", true);
            UsuarioView usu4 = new UsuarioView(7, "a", "paso", "categoria1", true);
            coleccion.Anadir(usu1);
            coleccion.Anadir(usu2);
            coleccion.Anadir(usu3);
            coleccion.Anadir(usu4);

            EnumeradorAscendente<UsuarioView> EnumeradorAdelante = new EnumeradorAscendente<UsuarioView>(coleccion, "Nombre");
            UsuarioView aux = new UsuarioView();

            EnumeradorAdelante.MoveNext();
            aux = EnumeradorAdelante.Current;
            Assert.AreEqual(aux.Nombre, "a");

        }
        [TestMethod]
        public void EnumeradorAscendenteConId()
        {
            Coleccion<UsuarioView> coleccion = new Coleccion<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(10, "jeff", "paso", "categoria1", true);
            UsuarioView usu2 = new UsuarioView(11, "ana", "paso", "categoria1", true);
            UsuarioView usu3 = new UsuarioView(6, "pepe", "paso", "categoria1", true);
            UsuarioView usu4 = new UsuarioView(7, "a", "paso", "categoria1", true);
            coleccion.Anadir(usu1);
            coleccion.Anadir(usu2);
            coleccion.Anadir(usu3);
            coleccion.Anadir(usu4);

            EnumeradorAscendente<UsuarioView> EnumeradorAdelante = new EnumeradorAscendente<UsuarioView>(coleccion, "Id");

            UsuarioView aux = new UsuarioView();

            EnumeradorAdelante.MoveNext();
            aux = EnumeradorAdelante.Current;
            Assert.AreEqual(aux.Nombre, "pepe");

        }

        /** Enumerador Descendente**/

        [TestMethod]
        public void EnumeradorDescendenteConNombre()
        {
            Coleccion<UsuarioView> coleccion = new Coleccion<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(10, "jeff", "paso", "categoria1", true);
            UsuarioView usu2 = new UsuarioView(9, "ana", "paso", "categoria1", true);
            UsuarioView usu3 = new UsuarioView(8, "xavi", "paso", "categoria1", true);
            UsuarioView usu4 = new UsuarioView(7, "zidane", "paso", "categoria1", true);
            coleccion.Anadir(usu1);
            coleccion.Anadir(usu2);
            coleccion.Anadir(usu3);
            coleccion.Anadir(usu4);

            EnumeradorDescendente<UsuarioView> EnumeradorAdelante = new EnumeradorDescendente<UsuarioView>(coleccion, "Nombre");
            UsuarioView aux = new UsuarioView();

            EnumeradorAdelante.MoveNext();
            aux = EnumeradorAdelante.Current;
            Assert.AreEqual(aux.Nombre, "zidane");

        }


        [TestMethod]
        public void EnumeradorDescendenteConId()
        {
            Coleccion<UsuarioView> coleccion = new Coleccion<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(10, "jeff", "paso", "categoria1", true);
            UsuarioView usu2 = new UsuarioView(9, "ana", "paso", "categoria1", true);
            UsuarioView usu3 = new UsuarioView(8, "xavi", "paso", "categoria1", true);
            UsuarioView usu4 = new UsuarioView(7, "zidane", "paso", "categoria1", true);
            coleccion.Anadir(usu1);
            coleccion.Anadir(usu2);
            coleccion.Anadir(usu3);
            coleccion.Anadir(usu4);

            EnumeradorDescendente<UsuarioView> EnumeradorAdelante = new EnumeradorDescendente<UsuarioView>(coleccion, "Id");
            UsuarioView aux = new UsuarioView();

            EnumeradorAdelante.MoveNext();
            aux = EnumeradorAdelante.Current;
            Assert.AreEqual(aux.Nombre, "jeff");

        }



        [TestMethod]
        public void YieldAdelante()
        {
            Coleccion<UsuarioView> coleccion = new Coleccion<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(1, "jeff", "paso", "categoria1", true);
            UsuarioView usu2 = new UsuarioView(2, "ana", "paso", "categoria1", true);
            UsuarioView usu3 = new UsuarioView(3, "pepe", "paso", "categoria1", true);
            coleccion.Anadir(usu1);
            coleccion.Anadir(usu2);
            coleccion.Anadir(usu3);

            RecorridoSecuencia<UsuarioView> r = new RecorridoSecuencia<UsuarioView>(coleccion);
            IEnumerator<UsuarioView> e = r.YieldAdelante();

            UsuarioView aux = new UsuarioView();
            e.MoveNext();
            aux = e.Current;
            System.Console.WriteLine(aux.Nombre);
            Assert.AreEqual(aux.Nombre, "jeff");

        }



        [TestMethod]
        public void YieldAtras()
        {
            Coleccion<UsuarioView> coleccion = new Coleccion<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(1, "jeff", "paso", "categoria1", true);
            UsuarioView usu2 = new UsuarioView(2, "ana", "paso", "categoria1", true);
            UsuarioView usu3 = new UsuarioView(3, "pepe", "paso", "categoria1", true);
            coleccion.Anadir(usu1);
            coleccion.Anadir(usu2);
            coleccion.Anadir(usu3);

            RecorridoSecuencia<UsuarioView> r = new RecorridoSecuencia<UsuarioView>(coleccion);
            IEnumerator<UsuarioView> e = r.YieldAtras();
            //la coleccion empieza null-> pepe> ana-> jeff
            UsuarioView aux = new UsuarioView();
            e.MoveNext();
            aux = e.Current;
            System.Console.WriteLine(aux.Nombre);
            Assert.AreEqual(aux.Nombre, "pepe");

        }


        [TestMethod]
        public void YieldAscendente()
        {
            Coleccion<UsuarioView> coleccion = new Coleccion<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(1, "jeff", "paso", "categoria1", true);
            UsuarioView usu2 = new UsuarioView(2, "ana", "paso", "categoria1", true);
            UsuarioView usu3 = new UsuarioView(3, "pepe", "paso", "categoria1", true);
            coleccion.Anadir(usu1);
            coleccion.Anadir(usu2);
            coleccion.Anadir(usu3);

            RecorridoSecuencia<UsuarioView> r = new RecorridoSecuencia<UsuarioView>(coleccion);
            IEnumerator<UsuarioView> e = r.YieldAdelante();
            r.YieldAscendente("Id");
            UsuarioView aux = new UsuarioView();
            e.MoveNext();                            
            aux = e.Current;                
            Assert.AreEqual(aux.Nombre,"jeff");

        }
        [TestMethod]
        public void YieldDescendente()
        {
            Coleccion<UsuarioView> coleccion = new Coleccion<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(1, "jeff", "paso", "categoria1", true);
            UsuarioView usu2 = new UsuarioView(2, "ana", "paso", "categoria1", true);
            UsuarioView usu3 = new UsuarioView(3, "pepe", "paso", "categoria1", true);
            coleccion.Anadir(usu1);
            coleccion.Anadir(usu2);
            coleccion.Anadir(usu3);


            RecorridoSecuencia<UsuarioView> r = new RecorridoSecuencia<UsuarioView>(coleccion);
            IEnumerator<UsuarioView> e = r.YieldDescendente("Id");
       
            UsuarioView aux = new UsuarioView();
            e.MoveNext();
            aux = e.Current;           
            Assert.AreEqual(aux.Nombre, "pepe");

        }

    }

}
