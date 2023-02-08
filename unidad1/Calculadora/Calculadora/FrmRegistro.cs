using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            cboEstado.Items.Add("Guanajuato");
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length >= 1)
            {
                epErrores.SetError(txtNombre, "");
            }
            else {
                epErrores.SetError(txtNombre, "El nombre es obligatorio y debería de tener al menos un caracter");
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Length >= 5)
            {
                epErrores.SetError(txtUsuario, "");
            }
            else
            {
                epErrores.SetError(txtUsuario, "El usuario es obligatorio y debería de tener al menos cinco caracteres");
            }
        }

        private void txtContrasenia1_TextChanged(object sender, EventArgs e)
        {
            String mensajes = "";
            if (txtContrasenia1.Text.Trim().Length < 8)
            {
                mensajes = "La contraseña es obligatoria y debería de tener al menos ocho caracteres";
            }

            epErrores.SetError(txtContrasenia1, mensajes);
        }

        private void txtContrasenia2_TextChanged(object sender, EventArgs e)
        {
            String mensajes = "";
            if (txtContrasenia2.Text.Trim().Length < 8)
            {
                mensajes += "La contraseña es obligatoria y debería de tener al menos ocho caracteres";
            }

            if (!txtContrasenia2.Text.Trim().Equals(txtContrasenia2.Text.Trim()))
            {
                mensajes += "\nLas contraseñas no coinciden";
            }

            epErrores.SetError(txtContrasenia2, mensajes);
        }
    }
}
