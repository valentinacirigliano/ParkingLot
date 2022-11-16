using Parking.Entidades;
using Parking.Servicios.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking.Windows.Helpers
{
    public class HelperGrid
    {
        public static void LimpiarGrilla(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

        }
        public static DataGridViewRow ConstruirFila(DataGridView dataGrid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGrid);
            return r;
        }

        public static void AgregarFila(DataGridView dataGrid, DataGridViewRow r)
        {
            dataGrid.Rows.Add(r);
        }

        public static void SetearFila(DataGridViewRow r, Object obj)
        {
            IngresosServicios servicio = new IngresosServicios();
            switch (obj)
            {
                case Lugar lugar:
                    r.Cells[0].Value = lugar.Nombre;
                    r.Cells[1].Value = lugar.Nivel.Descripcion;
                    r.Cells[2].Value = lugar.TipoEstacionamiento.Descripcion;
                    break;
                case IngresosVehiculos ingreso:
                    r.Cells[0].Value = ingreso.Lugar.Nombre;
                    r.Cells[1].Value = ingreso.Patente;
                    r.Cells[2].Value = ingreso.FechaIngreso;
                    r.Cells[3].Value = ingreso.Tarifa.NombreTarifa;
                    break;
                case Egreso egreso:
                    r.Cells[0].Value = egreso.Ingreso.Patente;
                    r.Cells[1].Value = egreso.FechaEgreso;
                    r.Cells[2].Value = egreso.Importe;
                    break;
                case Tarifa tarifa:
                    r.Cells[0].Value = tarifa.Tiempo.Nombre;
                    r.Cells[1].Value = tarifa.TipoVehiculo.TipoVehiculo;
                    r.Cells[2].Value = tarifa.Precio;
                    break;
            }

            r.Tag = obj;

        }

        public static void BorrarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }
    }
}
