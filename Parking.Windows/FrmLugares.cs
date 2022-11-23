using Parking.Datos.Repositorios;
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
    public partial class FrmLugares : Form
    {
        public FrmLugares()
        {
            InitializeComponent();
        }

        private LugaresServicios servicioLugares;
        private List<Lugar> lista;
        private IngresosServicios serviciosIngresos;
        private EgresosServicios servicioEgresos;
        

        private void FrmLugares_Load(object sender, EventArgs e)
        {
            servicioLugares = new LugaresServicios();
            serviciosIngresos = new IngresosServicios();
            servicioEgresos = new EgresosServicios();
            
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            HelperGrid.LimpiarGrilla(DatosDataGridView);
            try
            {
                lista = servicioLugares.GetLista();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                ActualizarCantidad();
            }
            catch (Exception ex)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }
        }

        private void ActualizarCantidad()
        {
            TextoLabel.Text = "Ubicaciones del estacionamiento:";
            cantidadLabel.Text = servicioLugares.GetCantidad().ToString();
        }

        private void IngresarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var row = DatosDataGridView.SelectedRows[0];
            Lugar lugar = (Lugar)row.Tag;
            if (!serviciosIngresos.LugarOcupado(lugar))
            {
                FrmIngresarVehiculo frm = new FrmIngresarVehiculo() { Text = "Ingresar Vehiculo" };
                frm.SetLugar(lugar);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                try
                {

                    IngresosVehiculos ingreso = new IngresosVehiculos();
                    ingreso = frm.GetIngreso();
                    
                    if (serviciosIngresos.ExisteEnGarage(ingreso))
                    {
                        HelperMessage.Mensaje(TipoMensaje.Error, "Vehículo previamente ingresado", "ERROR");
                    }
                    else
                    {
                        int registors = serviciosIngresos.Agregar(ingreso);
                        if (registors == 0)
                        {
                            HelperMessage.Mensaje(TipoMensaje.Error, "Vehículo no ingresado", "Error");
                        }
                        else
                        {
                            HelperMessage.Mensaje(TipoMensaje.OK, "Vehículo ingresado", "Mensaje");
                            IngresarIconButton.Enabled = false;
                            ActualizarCantidad();
                        }
                        
                        
                    }

                }
                catch (Exception ex)
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, ex.Message, "Error");
                }
            }
            else
            {
                HelperMessage.Mensaje(TipoMensaje.Error, "El lugar se encuentra ocupado", "ERROR");
            }
            
        }
        
        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var row = DatosDataGridView.SelectedRows[0];
            Lugar lugar = (Lugar)row.Tag;

            FrmEgresar frm = new FrmEgresar() { Text = "Egresar Vehiculo" };
            frm.SetLugar(lugar);
            frm.SetIngreso(serviciosIngresos.GetIngresoPorLugar(lugar));
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
                RecargarGrilla();
            }


        }

        private void DatosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count > 0)
            {
                var row = DatosDataGridView.SelectedRows[0];
                Lugar lugar = (Lugar)row.Tag;

                if (serviciosIngresos.LugarOcupado(lugar))
                {
                    IngresosVehiculos ingreso = new IngresosVehiculos();
                    ingreso = serviciosIngresos.GetIngresoPorLugar(lugar);
                    if (servicioEgresos.Existe(ingreso.IngresoId))
                    {
                        IngresarIconButton.Enabled = true;
                        BorrarIconButton.Enabled = false;
                    }
                    else
                    {
                        IngresarIconButton.Enabled = false;
                        BorrarIconButton.Enabled = true;
                    }

                }
                else if (!(serviciosIngresos.LugarOcupado(lugar)))
                {
                    IngresarIconButton.Enabled = true;
                    BorrarIconButton.Enabled = false;
                }
                else
                {
                    IngresarIconButton.Enabled = false;
                    BorrarIconButton.Enabled = false;
                }
            }
        }

        private void VerEnGarage_Click(object sender, EventArgs e)
        {
            try
            {
                HelperGrid.LimpiarGrilla(DatosDataGridView);
                lista = servicioLugares.GetListaSinEgresar();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                TextoLabel.Text = "Ubicaciones ocupadas:";
                cantidadLabel.Text = servicioLugares.GetCantidadSinEgresar().ToString();
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

        private void LugaresLibresButton_Click(object sender, EventArgs e)
        {
            try
            {
                HelperGrid.LimpiarGrilla(DatosDataGridView);
                lista = servicioLugares.GetListaLibres();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                TextoLabel.Text = "Ubicaciones libres:";
                cantidadLabel.Text = (servicioLugares.GetCantidad() - servicioLugares.GetCantidadSinEgresar()).ToString();
            }
            catch (Exception ex)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }
        }
    }
}
