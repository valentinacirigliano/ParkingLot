using FontAwesome.Sharp;
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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
        private IconMenuItem menuActivo = null;
        private Form formularioActivo = null;
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            formularioActivo = formulario;

            contenedorPanel.Controls.Add(formulario);

            formulario.Show();

        }


        private void LugaresMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmLugares());
        }

        private void IngresosMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmIngresos());
        }

        private void EgresosMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmEgresos());
        }

        
        private void TarifasMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmTarifas());
        }

        
    }
}
