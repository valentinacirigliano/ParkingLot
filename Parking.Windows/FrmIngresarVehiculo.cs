using Parking.Entidades;
using Parking.Servicios.Servicios;
using Parking.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking.Windows
{
    public partial class FrmIngresarVehiculo : Form
    {
        public FrmIngresarVehiculo()
        {
            InitializeComponent();
        }
        private IngresosVehiculos ingreso;
        public TipoDeVehiculo tipo;
        public IngresosVehiculos GetIngreso()
        {
            return ingreso;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombos.CargarDatosComboTipoVehiculo(ref VehiculoCB);
            if (tipo != null)
            {
                VehiculoCB.SelectedValue = tipo.TipoDeVehiculoId;
            }
            if (ingreso != null)
            {
                VehiculoCB.SelectedValue = ingreso.Tarifa.TipoVehiculoId;
                HelperCombos.CargarDatosComboTarifas(ref TarifaCB, ingreso.Tarifa.TipoVehiculo);
                PatenteTextBox.Text = ingreso.Patente;
            }
        }
        
        private void AgregarVehiculo_Click(object sender, EventArgs e)
        {
            
            if (ValidarDatos())
            {
                if (ingreso == null)
                {
                    ingreso = new IngresosVehiculos();
                }
                ingreso.Tarifa = (Tarifa)TarifaCB.SelectedItem;
                ingreso.TarifaId = ((Tarifa)TarifaCB.SelectedItem).TarifaId;
                ingreso.Patente = PatenteTextBox.Text;
                ingreso.FechaIngreso = DateTime.Now;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (VehiculoCB.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(VehiculoCB, "Debe seleccionar un tipo");

            }
            if (TarifaCB.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(TarifaCB, "Debe seleccionar una tarifa");

            }
            if (string.IsNullOrEmpty(PatenteTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(PatenteTextBox, "La patente es requerida");
            }

            return valido;
        }

        private void VehiculoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VehiculoCB.SelectedIndex > 0)
            {
                tipo = (TipoDeVehiculo)VehiculoCB.SelectedItem;
                HelperCombos.CargarDatosComboTarifas(ref TarifaCB, tipo);
            }
            else
            {
                TarifaCB.DataSource = null;
            }
        }
        

        
    }
}
