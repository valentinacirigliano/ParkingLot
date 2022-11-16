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
    public partial class FrmTarifas : Form
    {
        public FrmTarifas()
        {
            InitializeComponent();
        }
        private TarifasServicios servicio;
        private List<Tarifa> lista;
        private void FrmTarifas_Load(object sender, EventArgs e)
        {
            servicio = new TarifasServicios();

            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception ex)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }
        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Tarifa tarifa = (Tarifa)r.Tag;
            Tarifa tarifaAux = (Tarifa)tarifa.Clone();
            try
            {
                FrmTarifasAE frm = new FrmTarifasAE() { Text = "Editar tarifa" };
                frm.SetTarifa(tarifa);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                tarifa = frm.GetTarifa();
                int registrosAfectados = servicio.Editar(tarifa);
                if (registrosAfectados == 0)
                {
                    MessageBox.Show("No se editaron registros","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    RecargarGrilla();

                }
                else
                {
                    HelperGrid.SetearFila(r, tarifa);
                    MessageBox.Show("Registro modificado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r, tarifaAux);
                MessageBox.Show(exception.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        
    }
}
