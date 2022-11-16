using Parking.Entidades;
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
    public partial class FrmTarifasAE : Form
    {
        public FrmTarifasAE()
        {
            InitializeComponent();
        }

        private Tarifa tarifa;

        private void FrmTarifasAE_Load(object sender, EventArgs e)
        {
            if (tarifa != null)
            {
                PrecioTextBox.Text = tarifa.Precio.ToString();
            }
        }
        public void SetTarifa(Tarifa tarifa)
        {
            this.tarifa = tarifa;
        }

        public Tarifa GetTarifa()
        {
            return tarifa;
        }
        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                
                tarifa.Precio = decimal.Parse(PrecioTextBox.Text);

                DialogResult = DialogResult.OK;
            }
        }
        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(PrecioTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(PrecioTextBox, "El precio es requerido");
            }

            return valido;
        }
    }
}
