using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesDeUsuario
{
    public enum ComportamientoVisibilidad
    {
        Click, //Click para ocultar, click para mostrar
        ClickPressed //Click para mostrar y soltar para ocultar
    }
    public partial class PasswordTextBox : UserControl
    {
        //Asignar el valor predeterminado que queremos que tenga la propiedad
        private ComportamientoVisibilidad comportamientoVisibilidad=
            ComportamientoVisibilidad.ClickPressed;

        public event EventHandler PasswordChanged;
        
        public ComportamientoVisibilidad ComportamientoVisibilidad
        {
            get { return comportamientoVisibilidad; }
            set { comportamientoVisibilidad = value; }
        }

        private String texto;

        public String Texto
        {
            get { return texto; }
            set { 
                texto = value; 
                txtPassword.Text = texto;    
            }
        }
        public PasswordTextBox()
        {
            InitializeComponent();
        }



        private void picShowHide_Click(object sender, EventArgs e)
        {
            //Solo funciona mientras que el comportamiento se haya establecido como Click
            if (ComportamientoVisibilidad == ComportamientoVisibilidad.Click)
            {
                //Cambia la vibililidad del texto a password y 
                //viceversa, sería equivalente al if de abajo
                txtPassword.UseSystemPasswordChar =
                    !txtPassword.UseSystemPasswordChar;
                //if (txtPassword.UseSystemPasswordChar)
                //{
                //    txtPassword.UseSystemPasswordChar = false;
                //}
                //else {
                //    txtPassword.UseSystemPasswordChar = true;
                //}
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            texto = txtPassword.Text;
            //Difundir la notificación de que el cambio de password está ocurriendo
            //Verificar primero que el evento ya está listo para difundirse (que no tenga null)
            //if(PasswordChanged!=null)
            //    PasswordChanged(this, e);
            PasswordChanged?.Invoke(this, e);
        }

        private void picShowHide_MouseDown(object sender, MouseEventArgs e)
        {
            if (ComportamientoVisibilidad == ComportamientoVisibilidad.ClickPressed)
            {
                txtPassword.UseSystemPasswordChar=false;
            }
        }

        private void picShowHide_MouseUp(object sender, MouseEventArgs e)
        {
            if (ComportamientoVisibilidad == ComportamientoVisibilidad.ClickPressed)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
