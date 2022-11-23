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
        private IngresosServicios serviciosIngresos;
        private EgresosServicios servicioEgresos;
        private IngresosVehiculos ingreso;
        public void SetLugar(Lugar lugar)
        {
            this.lugar = lugar;
        }
        private void FrmEgresar_Load(object sender, EventArgs e)
        {
            serviciosIngresos = new IngresosServicios();
            servicioEgresos = new EgresosServicios();
            TipoVehiculoLabel.Text = ingreso.Tipo.TipoVehiculo;
            patenteLabel.Text = ingreso.Patente;
            fechaIngresoLabel.Text = ingreso.FechaIngreso.ToString();
            fechaEgreso = DateTime.Now;
            importe = servicioEgresos.GetImporte(ingreso, fechaEgreso);
            ImporteLabel.Text = "$" + importe.ToString();
            duracionLabel.Text = servicioEgresos.GetDuracionEstadia(ingreso,fechaEgreso);

        }
        public void SetIngreso(IngresosVehiculos ingreso)
        {
            this.ingreso = ingreso;
        }

        private DateTime fechaEgreso;
        private decimal importe;
        private void OKIconButton_Click(object sender, EventArgs e)
        {
            egreso = new Egreso()
            {
                IngresoId = ingreso.IngresoId,
                FechaEgreso = fechaEgreso,
                Importe = importe
            };
            egreso.Ingreso = serviciosIngresos.GetIngresoPorId(ingreso.IngresoId);
            DialogResult = DialogResult.OK;

        }
        public Egreso GetEgreso()
        {
            return egreso;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
