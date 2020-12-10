using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.ExamenJunio.Interfaces
{
    public interface IProcesos
    {
        double EdadMedia(string ruta);
        int NumeroTotalUsuarios(string ruta);
        int MenoresEdad(string ruta);

    }
}
