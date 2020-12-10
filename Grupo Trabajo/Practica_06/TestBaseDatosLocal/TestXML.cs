using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSS.jefferson_max.Practica_06;

namespace PSS.jefferson_max.Practica_06
{
    [TestClass]
    public class TestXML
    {
        [TestMethod]
        public void ComprobarCargaFichero()
        {
            try
            {
                AutentificacionXml xml = new AutentificacionXml("C:/TFS/GINEBRA/2016-PSS-ALUMNOS/Tomala Villarreal Jefferson Max (jtv215)/Grupo Trabajo/Practica_06/AuntentificacionUsuarios/Usuarios.xml");
                Assert.IsFalse(false);
            }
            catch (AutentificacionExcepcion)
            {
                Assert.IsFalse(true);
            }
        }

        [TestMethod]
        public void ComprobarAccesoValido()
        {
            try
            {
                AutentificacionXml xml = new AutentificacionXml("C:/TFS/GINEBRA/2016-PSS-ALUMNOS/Tomala Villarreal Jefferson Max (jtv215)/Grupo Trabajo/Practica_06/AuntentificacionUsuarios/Usuarios.xml");
                CodigoAutentificacion codigo = xml.EsUsuarioAutentificado("2", "PalabraPaso_2");
                Assert.IsTrue(codigo == CodigoAutentificacion.AccesoCorrecto);
                codigo = xml.EsUsuarioAutentificado("2", "PalabraPaso_3");
                Assert.IsTrue(codigo == CodigoAutentificacion.ErrorPalabraPaso);
            }
            catch (AutentificacionExcepcion)
            {
                Assert.IsFalse(true);
            }
        }
        [TestMethod]
        public void ComprobarInsertarUsuario()
        {
            try
            {
                AutentificacionXml xml = new AutentificacionXml("C:/TFS/GINEBRA/2016-PSS-ALUMNOS/Tomala Villarreal Jefferson Max (jtv215)/Grupo Trabajo/Practica_06/AuntentificacionUsuarios/Usuarios.xml");
                IUsuarioView prueba = xml.ObtenerUsuario("10");
                Assert.IsTrue(prueba == null);
                IUsuarioView usu = new UsuarioView
                {
                    Id = "10",
                    Nombre = "Nombre_10",
                    Categoria = "Categoria_1",
                    PalabraPaso = "PalabraPaso_10",
                    EsValido = true
                };
                xml.InsertarUsuario(usu);
                prueba = xml.ObtenerUsuario("10");
                Assert.IsTrue(prueba.Nombre == "Nombre_10");
                xml.EliminarUsuario("10");
                prueba = xml.ObtenerUsuario("10");
                Assert.IsTrue(prueba == null);
            }
            catch (AutentificacionExcepcion)
            {
                Assert.IsFalse(true);
            }
        }


        [TestMethod]
        public void ComprobarInsertarUsuarioNull()
        {
            try
            {
                AutentificacionXml xml = new AutentificacionXml("C:/TFS/GINEBRA/2016-PSS-ALUMNOS/Tomala Villarreal Jefferson Max (jtv215)/Grupo Trabajo/Practica_06/AuntentificacionUsuarios/Usuarios.xml");
                IUsuarioView prueba = xml.ObtenerUsuario("10");
                Assert.IsTrue(prueba == null);
                IUsuarioView usu = new UsuarioView
                {
                    Id = null,
                    Nombre = "Nombre_10",
                    Categoria = "Categoria_1",
                    PalabraPaso = "PalabraPaso_10",
                    EsValido = true
                };
                xml.InsertarUsuario(usu);
                prueba = xml.ObtenerUsuario("10");
                Assert.IsTrue(prueba.Nombre == "Nombre_10");
                xml.EliminarUsuario("10");
                prueba = xml.ObtenerUsuario("10");
                Assert.IsTrue(prueba == null);
            }
            catch (AutentificacionExcepcion)
            {
                Assert.IsFalse(true);
            }
        }




    }
}
