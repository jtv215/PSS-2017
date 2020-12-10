
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.ExamenJunio.Interfaces
{
    public interface IMantenimiento
    {

        bool Alta(IUsuario usuarioNew);
        bool Baja(string dni);
        IUsuario Consulta(string dni);
        bool Modificaciones(string dni, IUsuario usuarioModf);
    }
}
