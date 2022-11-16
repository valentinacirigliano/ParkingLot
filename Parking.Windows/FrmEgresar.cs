using Parking.Datos;
using Parking.Datos.Repositorios;
using Parking.Entidades;
using Parking.Servicios.Servicios;
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
    public partial class FrmEgresar : Form
    {
        public FrmEgresar()
        {
            InitializeComponent();
        }
        public Egreso egreso;
        public Lugar lugar;
        private LugaresServicios servicioLugares;
        private TarifasServicios serviciosTarifas;
        private IngresosServicios serviciosIngresos;
        private EgresosServicios servicioEgresos;
        private IngresosVehiculos ingreso;
        public void SetLugar(Lugar lugar)
        {
            this.lugar = lugar;
        }
        private void FrmEgresar_Load(object sender, EventArgs e)
        {
            servicioLugares = new LugaresServicios();
            serviciosTarifas = new TarifasServicios();
            serviciosIngresos=new IngresosServicios();
            servicioEgresos = new EgresosServicios();
            
            
            if (ingreso!=null)
            {

                patenteLabel.Text = ingreso.Patente;
                TarifaTiempoLabel.Text = ingreso.Tarifa.NombreTarifa;
                fechaIngresoLabel.Text = ingreso.FechaIngreso.ToShortTimeString();
                TarifaPrecioLabel.Text = ingreso.Tarifa.Precio.ToString();
            }
            else
            {
                ingreso = new IngresosVehiculos();
            }
        }
        public void SetIngreso(IngresosVehiculos ingreso)
        {
            this.ingreso = ingreso;
        }

        
        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                decimal importe = int.Parse(cantidadNumeric.Value.ToString()) *
                ingreso.Tarifa.Precio;      

                egreso = new Egreso()
                {
                    IngresoId = ingreso.IngresoId,
                    FechaEgreso = DateTime.Now,
                    TarifaId = ingreso.TarifaId,
                    Importe = importe
                };
                egreso.Ingreso = serviciosIngresos.GetIngresoPorId(ingreso.IngresoId);
                egreso.Tarifa = serviciosTarifas.GetTarifaPorId(ingreso.TarifaId);
                DialogResult = DialogResult.OK;
            }
            
        }
        public Egreso GetEgreso()
        {
            return egreso;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (!int.TryParse(cantidadNumeric.Value.ToString(), out int cant) )
            {

                valido = false;
                errorProvider1.SetError(cantidadNumeric, "La cantidad es requerida");
            }
            else
            {
                if (cant == 0)
                {
                    valido = false;
                    errorProvider1.SetError(cantidadNumeric, "La cantidad debe ser mayor a 0");
                }
            }

            return valido;
        }
    }
}
