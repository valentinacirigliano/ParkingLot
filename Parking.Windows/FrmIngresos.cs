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
    public partial class FrmIngresos : Form
    {
        public FrmIngresos()
        {
            InitializeComponent();
        }
        private List<IngresosVehiculos> lista;
        private IngresosServicios serviciosIngresos;
        private EgresosServicios servicioEgresos;
        private LugaresServicios serviciosLugares;

        private void FrmIngresos_Load(object sender, EventArgs e)
        {
            serviciosIngresos = new IngresosServicios();
            servicioEgresos = new EgresosServicios();
            serviciosLugares= new LugaresServicios();
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                HelperGrid.LimpiarGrilla(DatosDataGridView);
                lista = serviciosIngresos.GetLista();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                ActualizarLabels();
            }
            catch (Exception ex)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }
        }

        private void ActualizarLabels()
        {
            TextoLabel.Text = "Vehículos ingresados:";
            CantidadLabel.Text = serviciosIngresos.GetCantidad().ToString();
        }

        private void DatosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count>0)
            {
                var row = DatosDataGridView.SelectedRows[0];
                IngresosVehiculos ingreso = (IngresosVehiculos)row.Tag;

                if (servicioEgresos.Existe(ingreso.IngresoId))
                {
                    BorrarIconButton.Enabled = false;
                }
                else
                {
                    BorrarIconButton.Enabled = true;
                }
            }
            

        }
        public IngresosVehiculos ingreso;
        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            var row = DatosDataGridView.SelectedRows[0];
            ingreso = (IngresosVehiculos)row.Tag;
            FrmEgresar frm = new FrmEgresar() { Text = "Egresar Vehiculo" };
            frm.SetLugar(ingreso.Lugar);
            frm.SetIngreso(ingreso);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Egreso egreso = new Egreso();
            egreso = frm.GetEgreso();

            int registors = servicioEgresos.Agregar(egreso);
            if (registors == 0)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, "No se ha podido retirar el vehículo", "Error");
            }
            else
            {
                HelperMessage.Mensaje(TipoMensaje.OK, "Vehículo retirado", "Mensaje");
                BorrarIconButton.Enabled=false; 
                RecargarGrilla();
            }
        }
        
        protected IngresosVehiculos GetIngreso()
        {
            var row = DatosDataGridView.SelectedRows[0];
            ingreso = (IngresosVehiculos)row.Tag;
            return ingreso;
        }

        private void VerEnGarage_Click(object sender, EventArgs e)
        {
            try
            {
                HelperGrid.LimpiarGrilla(DatosDataGridView);
                lista = serviciosIngresos.GetListaSinEgresar();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                TextoLabel.Text = "Vehículos sin egresar:";
                CantidadLabel.Text = serviciosLugares.GetCantidadSinEgresar().ToString();
            }
            catch (Exception ex)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }
        }

        private void RefrescarButton_Click(object sender, EventArgs e)
        {
            RecargarGrilla();

        }
        string patente = "";
        private void BuscarPatente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBuscarPatente frm = new FrmBuscarPatente() { Text = "Filtro por patente" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                patente = frm.GetPatente();


                HelperGrid.LimpiarGrilla(DatosDataGridView);
                lista = serviciosIngresos.GetListaDePatente(patente);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                TextoLabel.Text = "Ingresos de la patente:";
                CantidadLabel.Text = serviciosIngresos.GetCantidadIngresosDePatente(patente).ToString();
            }
            catch (Exception ex)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }
        }
    }
}
