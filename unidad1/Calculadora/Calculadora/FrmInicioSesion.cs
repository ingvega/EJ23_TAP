using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
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

            //Cuando el caracter no es ninguna de las teclas 
            //pertenecientes a letra mayúscula o minúscula, se deshace
            //el ingreso de la tecla
            //int car = e.KeyChar;
            //if (!((car >= 65 && car <= 90) || (car >= 97 && car <= 122) || car==8)) {
            //    e.Handled = true;
            //}
            int car = e.KeyChar;
            if (!((car >= (int)Keys.A && car <= (int)Keys.Z) || 
                (car >= ((int)Keys.A+32) && car <= ((int)Keys.Z+32)) || car == (int)Keys.Back))
            {
                e.Handled = true;
            }
            //lblRetroUsuario.Text+=car + " ";
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            //Regex patron = new Regex("[0-9][a-z][A-Z][#%&@]");
            if(!(new Regex("[0-9]").IsMatch(txtContrasenia.Text) &&
                new Regex("[a-z]").IsMatch(txtContrasenia.Text) &&
                new Regex("[A-Z]").IsMatch(txtContrasenia.Text) &&
                new Regex("[#%&@]").IsMatch(txtContrasenia.Text))) { 
            //if (!patron.IsMatch(txtContrasenia.Text))
            //{
                epErrores.SetError(txtContrasenia, "Formato no válido");
            }
            else {
                epErrores.SetError(txtContrasenia, "");
            }
        }

        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistrar = new FrmRegistro(this);
            frmRegistrar.Visible = true;
            //OCulta el formulario actual
            //this.Visible = false;
            Hide();
            //Cierra el form actual
            //this.Close();
            //this.Dispose();

        }
    }
}
