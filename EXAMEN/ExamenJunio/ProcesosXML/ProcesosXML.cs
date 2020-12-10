using PSS.ExamenJunio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PSS.ExamenJunio.Procesos
{
    public class ProcesosXML : IProcesos
    {




        public double EdadMedia(string ruta)
        {
            XDocument _xmlDoc = XDocument.Load(ruta);
            double x = 0;
            int n = 0;

            _xmlDoc.Descendants("Usuario").Select(p => new
            {
                dni = p.Attribute("DNI").Value,
                Nombre = p.Element("Nombre").Value,
                edad = p.Element("Edad").Value
            }).ToList().ForEach(p =>
            {
                x = x + Int32.Parse(p.edad);
                n++;
            });
            x = x / n;
           return x;
        }

        public int MenoresEdad(string ruta)
        {
            XDocument _xmlDoc = XDocument.Load(ruta);
            int n = 0;
            _xmlDoc.Descendants("Usuario").Where(p =>
            Convert.ToInt32(p.Attribute("Edad").Value) > 18).Select(p => new
            {
                DNI = p.Attribute("DNI").Value,
                Nombre = p.Element("Nombre").Value,
                Edad = p.Element("Edad").Value
            }).ToList().ForEach(p =>
            {
                n++;

            });
            return n;
        }

        



        public int NumeroTotalUsuarios(string ruta)
        {
            XDocument _xmlDoc = XDocument.Load(ruta);
            int n = 0;
            _xmlDoc.Descendants("Usuario").Select(p => new
            {
                dni = p.Attribute("DNI").Value,
                Nombre = p.Element("Nombre").Value,
                edad = p.Element("Edad").Value
            }).ToList().ForEach(p =>
            {
                n++;
            });
            return n;
        }

       

    }
 }

