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
    public partial class FrmEgresos : Form
    {
        public FrmEgresos()
        {
            InitializeComponent();
        }
        private EgresosServicios servicio;
        private List<Egreso> lista;
        private void RecargarGrilla()
        {
            try
            {
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                recaudadoLabel.Text = "$" + servicio.GetRecaudadoHoy().ToString();
            }
            catch (Exception ex)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }
        }
        private void FrmEgresos_Load(object sender, EventArgs e)
        {
            servicio = new EgresosServicios();

            RecargarGrilla();
        }
    }
}
