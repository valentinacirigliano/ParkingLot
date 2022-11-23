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
    public partial class FrmBuscarPatente : Form
    {
        public FrmBuscarPatente()
        {
            InitializeComponent();
        }
        public string patente;



        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(PatenteTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(PatenteTextBox, "Debe ingresar una patente");
            }

            return valido;
        }

        internal string GetPatente()
        {
            return patente;
        }

        private void BuscarPatenteButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                patente= PatenteTextBox.Text;
            }
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
