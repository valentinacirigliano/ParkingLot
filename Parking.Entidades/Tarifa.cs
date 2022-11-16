using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entidades
{
    public class Tarifa:ICloneable
    {
        public int TarifaId { get; set; }
        public string NombreTarifa { get; set; }
        public int TiempoId { get; set; }
        public int TipoVehiculoId { get; set; }
        public decimal Precio { get; set; }
        public byte[] RowVersion { get; set; }
        public TiempoEstadia Tiempo { get; set; }
        public TipoDeVehiculo TipoVehiculo { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
