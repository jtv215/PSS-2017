using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSS.jefferson_max.Practica_02;

namespace PSS.jefferson_max.Practica_02
{
    [TestClass]
    public class TestUsuarioView
    {

        [TestMethod]
        public void TestComprobarEqualsUnNull_IsFalse()
        {
            UsuarioView usuario1 = new UsuarioView(5, "Jefferson", "paso", "categoria1", true);
            UsuarioView usuario2 = null;
            Assert.IsFalse(usuario1.Equals(usuario2));

        }
     
        [TestMethod]
        public void ComprobarOperatorEqualsDosNull_IsTrue()
        {
            UsuarioView usuario1 = null;
            UsuarioView usuario2 = null;
            Assert.IsTrue(usuario1 ==usuario2);
        }

        [TestMethod]
        public void ComprobarEqualsIguales_IsTrue()
        {
            UsuarioView usuario1 = new UsuarioView(2, "jefferson", "paso", "categoria1", true);
            UsuarioView usuario2 = new UsuarioView(2, "jefferson", "paso", "categoria1", true);
            Assert.IsTrue(usuario1.Equals(usuario2));
        }

        [TestMethod]
        public void ComprobarEqualsDistintos_IsFalse()
        {
            UsuarioView usuario1 = new UsuarioView(5, "jefferson", "paso", "categoria1", true);
            UsuarioView usuario2 = new UsuarioView(2, "jefferson", "paso", "categoria1", true);
            Assert.IsFalse(usuario1.Equals(usuario2));
        }

      
        [TestMethod]
        public void TestComprobarUsuarioIgualesSobre_IsTrue()
        {
            UsuarioView usuario1 = new UsuarioView(5, "jefferson", "paso", "categoria1", true);
            UsuarioView usuario2 = new UsuarioView(5, "jj", "paso2", "tele", false);
            Assert.IsTrue(usuario1 == usuario2);
        }
        [TestMethod]
        public void TestComprobarUsuarioDistintos2Sobre_IsFalse()
        {
            UsuarioView usuario1 = new UsuarioView(5, "jefferson", "paso", "categoria1", true);
            UsuarioView usuario2 = new UsuarioView(2, "jefferson", "paso", "categoria1", true);
            Assert.IsFalse(usuario1 == usuario2);
        }

        [TestMethod]
        public void TestComprobarsobreDistintoIdDistinto_IsTrue()
        {
            UsuarioView usuario1 = new UsuarioView(1, "jefferson", "paso", "categoria1", true);
            UsuarioView usuario2 = new UsuarioView(2, "jefferson", "paso", "categoria1", true);
            Assert.IsTrue(usuario1 != usuario2);
        }
        [TestMethod]
        public void TestComprobarsobreDistintoIDIguales_IsFalse()
        {
            UsuarioView usuario1 = new UsuarioView(1, "jefferson", "paso", "categoria1", true);
            UsuarioView usuario2 = new UsuarioView(1, "jefferson", "paso", "categoria1", true);
            Assert.IsFalse(usuario1 != usuario2);
        }
        [TestMethod]
        public void TestComprobarsobreDistintoIdNull()
        {
            Object usuario1 = new UsuarioView(1, "jefferson", "paso", "categoria1", true);
            Object usuario2 = new UsuarioView(2, "jefferson", "paso", "categoria1", true);
            Assert.IsFalse(usuario1.Equals(usuario2));
        }

     
        [TestMethod]
        public void TestComprobarHasCode()
        {
            UsuarioView object1 = new UsuarioView(1, "jefferson", "paso", "categoria1", true);
            UsuarioView object2 = new UsuarioView(1, "jefferson", "paso", "categoria1", true);

            int a = object1.GetHashCode();
            int b = object2.GetHashCode();
            Assert.AreEqual(a,b);
        }
        /** #################CompareTo ################### */

        [TestMethod]
        public void CompareToElmismoUsuario_AreEqual0()
        {
            UsuarioView obj1 = new UsuarioView(1, "Jeff", "paso", "cat1", true);
            int aux = obj1.CompareTo(obj1);
            Assert.AreEqual(aux, 0);
        }

        [TestMethod]
        public void CompDosUsuarioABIguales_AreEqual()
        {
            UsuarioView obj1 = new UsuarioView(1, "Jeff", "paso", "cat1", true);
            UsuarioView obj2 = new UsuarioView(1, "Jeff", "paso", "cat1", true);
            int aux1 = obj1.CompareTo(obj2);
            int aux2 = obj2.CompareTo(obj1);
            Assert.AreEqual(aux1, aux2);
        }

        [TestMethod]
        public void ComparaTresUusariosABCIguales()
        {
            UsuarioView obj1 = new UsuarioView(1, "Jeff", "paso", "cat1", true);
            UsuarioView obj2 = new UsuarioView(1, "Jeff", "paso", "cat1", true);
            UsuarioView obj3 = new UsuarioView(1, "Jeff", "paso", "cat1", true);
            int aux1 = obj1.CompareTo(obj2);
            int aux2 = obj2.CompareTo(obj3);
            Assert.AreEqual(aux1, aux2);
        }

        [TestMethod]
        public void ComparaDosUsuarioDistintosA_BsonDistintos()
        {
            UsuarioView obj1 = new UsuarioView(1, "Jeff", "paso", "cat1", true);
            UsuarioView obj2 = new UsuarioView(2, "Jeff", "paso", "cat1", true);            
            int aux1 = obj1.CompareTo(obj2);
            int aux2 = obj2.CompareTo(obj1);
            Assert.AreNotEqual(aux1, aux2);

        }

        [TestMethod]
        public void CompA_B_Cson_Iguales()
        {
            UsuarioView obj1 = new UsuarioView(1, "Jeff", "paso", "cat1", true);
            UsuarioView obj2 = new UsuarioView(2, "Jeff", "paso", "cat1", true);
            UsuarioView obj3 = new UsuarioView(3, "Jeff", "paso", "cat1", true);
            int aux1 = obj1.CompareTo(obj2);
            int aux2 = obj2.CompareTo(obj3);
            int aux3 = obj1.CompareTo(obj3);
          
            Assert.AreEqual(aux1, aux2);
            Assert.AreEqual(aux2,aux3);

        }
        /** #sobreEscritura de Operadores# */

        [TestMethod]
        // método CompareTo. Objetos iguales.
        public void CompareToSameObjectTest()
        {

            UsuarioView userA = new UsuarioView(1, "jeff", "paso_", "categoria", true);
            UsuarioView userB = userA;

            int expected = 0;
            int actual = userA.CompareTo(userB);
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        // método CompareTo. Objetos iguales.
        public void CompareToesNull()
        {

            UsuarioView userA = new UsuarioView(1, "jeff", "paso_", "categoria", true);
            UsuarioView userB = null;

            int expected = 1;
            int actual = userA.CompareTo(userB);
            Assert.AreEqual(expected, actual);

        }


        [TestMethod()]
        //sobre-escritura del operador >= . Objetos iguales.
        public void OperatorMayorIgualMismoUsuario()
        {

            UsuarioView userA = new UsuarioView(1, "jeff", "paso_", "categoria", true);
            UsuarioView userB = userA;

            bool expected = true;
            bool actual = userA >= userB;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        //sobre-escritura del operador > . Objetos iguales.
        public void OperatorMayorMismoUsuario()
        {
            UsuarioView userA = new UsuarioView(1, "jeff", "paso_", "categoria", true);
            UsuarioView userB = userA;

            bool expected = false;
            bool actual = userA > userB;
            Assert.AreEqual(expected, actual);

        }


        [TestMethod()]
        //sobre-escritura del operador < . Objetos iguales.
        public void OperatorMenorMismoUsuario()
        {
            UsuarioView userA = new UsuarioView(1, "jeff", "paso_", "categoria", true);
            UsuarioView userB = new UsuarioView(1, "jeff", "paso_", "categoria", true);

            bool expected = false;
            bool actual = userA < userB;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        //sobre-escritura del operador <= . Objetos iguales.
        public void OperatorMenorIgualMismoUsuario()
        {
            UsuarioView userA = new UsuarioView(1, "jeff", "paso_", "categoria", true);
            UsuarioView userB = userA;

            bool expected = true;
            bool actual = userA <= userB;
            Assert.AreEqual(expected, actual);

        }


        //ICOMPARER

        [TestMethod()]
        public void Compare_WhithCategoria_IsUno()
        {
            UsuarioView usu1 = new UsuarioView(1, "Jeff", "paso", "cat1", true);
            UsuarioView usu2 = new UsuarioView(1, "Jeff", "paso", "cat2", true);

            ComparadorPropiedad<UsuarioView> comparer = new ComparadorPropiedad<UsuarioView>("Categoria");
            Assert.AreEqual(comparer.Comparer(usu2, usu1), 1);
            
        }

        [TestMethod()]
        public void Compare_WhithEsValid_IsZero()
        {
            UsuarioView usu1 = new UsuarioView(1, "Jeff", "paso", "cat1", false);
            UsuarioView usu2 = new UsuarioView(1, "Jeff", "paso", "cat1", false);

            ComparadorPropiedad<UsuarioView> comparer = new ComparadorPropiedad<UsuarioView>("EsValido");
            Assert.AreEqual(comparer.Comparer(usu2, usu1), 0);
        }

    }
}
