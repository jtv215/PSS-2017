using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PSS.jefferson_max.Practica_02;

namespace Pss.jefferson_max.Practica_02
{
    [TestClass]
    public class ColeccionUsuarioView
    {

        [TestMethod]
        public void TestComprobarDoslistasiguales()
        {
            List<UsuarioView> lista = new List<UsuarioView>();
            UsuarioView usuario1 = new UsuarioView(5, "tania", "paso", "cate", true);
            UsuarioView usuario2 = new UsuarioView(5, "tania", "paso", "cate", true);
            UsuarioView usuario3 = new UsuarioView();
            UsuarioView usuario4 = new UsuarioView(5, "tania", "paso", "cate", true);
            lista.Add(usuario1);
            lista.Add(usuario2);
            lista.Add(usuario3);
            lista.Add(usuario4);
            Assert.AreEqual(lista.Count, 4);//count=numero de elementos incluidos

        }
        [TestMethod]
        public void ComprobarDiccionarioIdIguales()
        {
            //metemos dos usarios al diccionario pero con el mismo id
            Dictionary<UsuarioView, String> diccionario = new Dictionary<UsuarioView, string>();
            UsuarioView usuario1 = new UsuarioView(1, "tania", "paso", "cate", true);
            diccionario.Add(usuario1, "Es usuario1");
            UsuarioView usuario2 = new UsuarioView(1, "tania", "paso", "cate", false);

            try
            {
                diccionario.Add(usuario2, "Es usuario2");
            }
            catch (ArgumentException)
            {
            }
            Assert.AreEqual(diccionario.Count, 1);//como la clave  ya esta agregada, nos hace hace falta un catch


        }

        [TestMethod]
        public void ComprobarDiccionarioIdDistintas()
        {
            //metemos dos usarios al diccionario pero con distintos id
            Dictionary<UsuarioView, String> diccionario = new Dictionary<UsuarioView, string>();
            UsuarioView usuario1 = new UsuarioView(1, "tania", "paso", "cate", true);
            UsuarioView usuario2 = new UsuarioView(2, "tania", "paso", "cate", false);
            diccionario.Add(usuario1, "Es usuario1");
            diccionario.Add(usuario2, "Es usuario2");
            Assert.AreEqual(diccionario.Count, 2);
        }

        [TestMethod]
        public void ComprobarHashSetIdIguales()
        {
            HashSet<UsuarioView> set = new HashSet<UsuarioView>();
            UsuarioView usuario1 = new UsuarioView(1, "usuario1", "paso", "cate", true);

            Assert.IsTrue(set.Add(usuario1));
            UsuarioView usuario2 = new UsuarioView(1, "usuario1", "paso", "cate", true);
            Assert.IsFalse(set.Add(usuario2));
            Assert.AreEqual(set.Count, 1);
        }


        [TestMethod]
        public void CompruebaListContainsa()
        {
            List<UsuarioView> lista = new List<UsuarioView>();
            UsuarioView usuario1 = new UsuarioView(1, "usuario1", "paso", "cate", true);
            lista.Add(usuario1);
            Assert.IsTrue(lista.Contains(usuario1));
            UsuarioView usuario2 = new UsuarioView(1, "usuario2", "paso", "cate", false);
            Assert.IsTrue(lista.Contains(usuario2));

        }


        [TestMethod]
        public void ComprobarListIndexOf()
        {
            //ListIndexOf  tengo 3 objeto iguales y busca el que esta en la primera posicion
            UsuarioView object1 = new UsuarioView(2, "jefferson", "paso", "categoria1", true);
            UsuarioView object2 = new UsuarioView(2, "jefferson", "paso", "categoria1", true);
            UsuarioView object3 = new UsuarioView(2, "jefferson", "paso", "categoria1", true);
            List<UsuarioView> lista = new List<UsuarioView>();
            lista.Add(object1);
            lista.Add(object2);
            int aux = lista.IndexOf(object1);

            Assert.AreEqual(aux, 0);


        }

        [TestMethod]
        public void TestComprobarLastIndexOf()
        {
            //ListIndexOf busco un objeto en la lista y me devuelve la posicion ultima
            UsuarioView object1 = new UsuarioView(1, "jefferson", "paso", "categoria1", true);
            UsuarioView object2 = new UsuarioView(1, "jefferson", "paso", "categoria1", true);
            UsuarioView object3 = new UsuarioView(1, "jefferson", "paso", "categoria1", true);
            List<UsuarioView> lista = new List<UsuarioView>();
            lista.Add(object1);
            lista.Add(object2);
            lista.Add(object3);

            int aux = lista.LastIndexOf(object1);

            Assert.AreEqual(aux, 2);


        }
        [TestMethod]
        public void TestComprobarRemove()
        {
            //ListIndexOf busco un objeto en la lista y me devuelve la posicion ultima
            UsuarioView object1 = new UsuarioView(1, "jefferson", "paso", "categoria1", true);
            UsuarioView object2 = new UsuarioView(1, "jefferson", "paso", "categoria1", true);
            UsuarioView object3 = new UsuarioView(1, "jefferson", "paso", "categoria1", true);
            List<UsuarioView> lista = new List<UsuarioView>();

            lista.Add(object1);
            lista.Add(object2);
            lista.Add(object3);
            lista.Remove(object3);
            Assert.AreEqual(lista.Count, 2);


        }



        [TestMethod]
        public void Sort()
        {
            List<UsuarioView> lista = new List<UsuarioView>();
            UsuarioView usu1 = new UsuarioView(5, "usu", "rr", "cat1", true);
            UsuarioView usu2 = new UsuarioView(12, "usu", "rr", "cat1", true);
            UsuarioView usu3 = new UsuarioView(1, "usu", "rr", "cat1", false);
            lista.Add(usu1);
            lista.Add(usu2);
            lista.Add(usu3);
            lista.Sort();
            int aux1 = lista.IndexOf(usu1);
            int aux2 = lista.IndexOf(usu2);
            int aux3 = lista.IndexOf(usu3);
            Assert.AreEqual(aux3, 0);
            Assert.AreEqual(aux1, 1);
            Assert.AreEqual(aux2, 2);

        
        }


      



    }
}
