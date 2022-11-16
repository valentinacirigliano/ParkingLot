using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entidades
{
    public class IngresosVehiculos
    {
        public int IngresoId { get; set; }
        public int LugarId { get; set; }
        public string Patente { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int TarifaId { get; set; }
        public byte[] RowVersion { get; set; }
        public Lugar Lugar { get; set; }
        public Tarifa Tarifa { get; set; }

    }
}
