using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entidades
{
    public class Egreso
    {
        public int IngresoId;
        public DateTime FechaEgreso;
        public int TarifaId;
        public decimal Importe;
        public IngresosVehiculos Ingreso;
        public Tarifa Tarifa;
    }
}
