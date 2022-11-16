using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entidades
{
    public class Lugar
    {
        public int LugarId { get; set; }
        public string Nombre { get; set; }
        public int NivelId { get; set; }
        public string TipoEstacionamientoId { get; set; }
        public bool Disponible { get; set; } 
        public Nivel Nivel { get; set; }
        public TipoEstacionamiento TipoEstacionamiento { get; set; }
    }
}
