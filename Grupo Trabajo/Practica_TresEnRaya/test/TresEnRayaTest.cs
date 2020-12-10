using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PSS.jefferson_max.Practica_TresEnRaya
{
    [TestClass]
    public class TresEnRayaTest
    {
        [TestMethod]
        public void CrearTablero_EsNoNulo()
        {
            CrearTablero m = new CrearTablero();
            m.rellenar();
            Assert.IsNotNull(m);
        }

        [TestMethod]
        public void jugador1_EscribeX_enCasilla00_AreEqualX()
        {
            CrearTablero m = new CrearTablero();
            m.rellenar();
            m.jugador1(1);
            int aux = m.get(0, 0);
            Assert.AreEqual(aux, 'X');
        }

        [TestMethod]
        public void jugador2_EscribeO_enCasilla01_AreEqualO()
        {
            CrearTablero m = new CrearTablero();
            m.rellenar();
            m.jugador2(2);
            int aux = m.get(0, 1);
            Assert.AreEqual(aux, 'O');            
        }


        [TestMethod]
        public void Ganadorjugador1_EscribeO_AreEqualX()
        {
            CrearTablero m = new CrearTablero();
            m.rellenar();
            m.jugador1(2);
            m.jugador1(5);
            m.jugador1(8);
            string s = m.mensaje(m.ganador());
            Assert.AreEqual(s, "Felicidades!!! Ha ganado jugador 1 ");
        }

        [TestMethod]
        public void Ganadorjugador2_EscribeO_AreEqualO()
        {
            CrearTablero m = new CrearTablero();
            m.rellenar();
            m.jugador2(2);
            m.jugador2(5);
            m.jugador2(8);
            string s=m.mensaje(m.ganador());
            Assert.AreEqual(s, "Felicidades!!! Ha ganado jugador 2 ");
        }


        [TestMethod]
        public void No_haGanadoNadie_EscribeO_AreEqualO()
        {
            CrearTablero m = new CrearTablero();
            m.rellenar();
            m.jugador1(2);
            m.jugador2(5);
            m.jugador1(8);
            string s = m.mensaje(m.ganador());
            Assert.AreEqual(s, "No ha ganado nadie");
        }
    }

}
