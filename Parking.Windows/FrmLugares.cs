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

        private int cantidadPaginas;
        private int registrosPorPagina = 10;
        private int paginaActual = 1;

        private Nivel nivel;
        private TipoEstacionamiento tipo;

        private void FrmLugares_Load(object sender, EventArgs e)
        {
            servicioLugares = new LugaresServicios();
            serviciosIngresos = new IngresosServicios();
            servicioEgresos = new EgresosServicios();
            
            paginaActual = 1;
            cantidadPaginas = HelperCalculos.CantidadPaginas(servicioLugares.GetCantidad(nivel, tipo), registrosPorPagina);

            RecargarGrilla();
            ManejoBotonesNavegacion();
        }
        private void ManejoBotonesNavegacion()
        {
            if (paginaActual == 1)
            {
                AnteriorIconButton.Enabled = false;
                SiguienteIconButton.Enabled = true;
            }
            else if (paginaActual == cantidadPaginas)
            {
                AnteriorIconButton.Enabled = true;
                SiguienteIconButton.Enabled = false;
            }
            else
            {
                AnteriorIconButton.Enabled = true;
                SiguienteIconButton.Enabled = true;
            }
        }

        private void RecargarGrilla()
        {
            try
            {
                lista = servicioLugares.GetListaPaginada(paginaActual, registrosPorPagina, nivel, tipo);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception ex)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }
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
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                try
                {

                    IngresosVehiculos ingreso = new IngresosVehiculos();
                    ingreso = frm.GetIngreso();
                    ingreso.LugarId = lugar.LugarId;
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

        private void PrimeroIconButton_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            RecargarGrilla();
            ManejoBotonesNavegacion();
        }

        private void AnteriorIconButton_Click(object sender, EventArgs e)
        {
            paginaActual--;
            if (paginaActual < 1)
            {
                paginaActual = 1;
            }
            RecargarGrilla();
            ManejoBotonesNavegacion();
        }

        private void SiguienteIconButton_Click(object sender, EventArgs e)
        {
            paginaActual++;
            if (paginaActual > cantidadPaginas)
            {
                paginaActual = cantidadPaginas;
            }
            RecargarGrilla();
            ManejoBotonesNavegacion();
        }

        private void UltimoIconButton_Click(object sender, EventArgs e)
        {
            paginaActual = cantidadPaginas;
            RecargarGrilla();
            ManejoBotonesNavegacion();
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
            }


        }

        private void DatosDataGridView_SelectionChanged(object sender, EventArgs e)
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
            else if(!(serviciosIngresos.LugarOcupado(lugar)))
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
}
