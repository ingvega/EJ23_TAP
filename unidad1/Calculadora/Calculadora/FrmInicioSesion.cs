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
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length < 5)
            {
                epErrores.SetError(txtUsuario, "El usuario debe tener mínimo 5 caracteres");
            }
            else if (txtUsuario.Text.Length > 15)
            {
                epErrores.SetError(txtUsuario, "El usuario debe tener máximo 15 caracteres");
            }
            else
            {
                epErrores.SetError(txtUsuario, "");
            }

            /*if (txtUsuario.Text.Length < 5)
            {
                lblRetroUsuario.Text = "El usuario debe tener mínimo 5 caracteres";
            }
            else if (txtUsuario.Text.Length > 15)
            {
                lblRetroUsuario.Text = "El usuario debe tener máximo 15 caracteres";
            }
            else
            {
                lblRetroUsuario.Text = "";
            }
            */
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int car = e.KeyChar;
            //Cuando el caracter no es ninguna de las teclas 
            //pertenecientes a letra mayúscula o minúscula, se deshace
            //el ingreso de la tecla
            if (!((car >= 65 && car <= 90) || (car >= 97 && car <= 122))) {
                e.Handled = true;
            }
            //lblRetroUsuario.Text+=car + " ";
        }
    }
}
