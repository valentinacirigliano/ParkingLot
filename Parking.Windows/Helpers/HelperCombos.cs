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
    public static class HelperCombos
    {
        


        public static void CargarDatosComboTipoVehiculo(ref ComboBox combo)
        {
            TipoVehiculosServicios servicio = new TipoVehiculosServicios();
            var lista = servicio.GetLista();
            var defaultTipo = new TipoDeVehiculo()
            {
                TipoDeVehiculoId = 0,
                TipoVehiculo = "Seleccione Tipo"
            };
            lista.Insert(0, defaultTipo);
            combo.DataSource = lista;
            combo.DisplayMember = "TipoVehiculo";
            combo.ValueMember = "TipoVehiculo";
            combo.SelectedIndex = 0;
        }
        public static void CargarDatosComboTarifas(ref ComboBox combo, TipoDeVehiculo tipo)
        {
            TarifasServicios servicio = new TarifasServicios();
            var lista = servicio.GetLista(tipo);
            var defaultTarifa = new Tarifa()
            {
                TarifaId = 0,
                NombreTarifa = "Seleccione Tarifa"
            };
            lista.Insert(0, defaultTarifa);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreTarifa";
            combo.ValueMember = "TarifaId";
            combo.SelectedIndex = 0;
        }

    }
}
