﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking.Windows.Helpers
{
    public static class HelperMessage
    {
        public static void Mensaje(TipoMensaje tipoMensaje, string mensaje, string titulo)
        {
            switch (tipoMensaje)
            {
                case TipoMensaje.OK:
                    MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case TipoMensaje.Warning:
                    MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    break;
                case TipoMensaje.Exclamation:
                    MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    break;
                case TipoMensaje.Error:
                    MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoMensaje), tipoMensaje, null);
            }

        }

        public static DialogResult Mensaje(string mensaje, string titulo)
        {
            return MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
        }
    }
}
