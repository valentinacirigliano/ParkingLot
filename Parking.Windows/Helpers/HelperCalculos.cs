using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Windows.Helpers
{
    public class HelperCalculos
    {
        public static int CantidadPaginas(int totalRegistros, int cantidadPorPagina)
        {
            if (totalRegistros < cantidadPorPagina)
            {
                return 1;
            }
            else if (totalRegistros % cantidadPorPagina == 0)
            {
                return totalRegistros / cantidadPorPagina;
            }
            else
            {
                return totalRegistros / cantidadPorPagina + 1;
            }
        }
    }
}
