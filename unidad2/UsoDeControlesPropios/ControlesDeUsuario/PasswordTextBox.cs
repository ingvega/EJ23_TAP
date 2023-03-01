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
    public enum Behavior
    {
        Click, //Click para ocultar, click para mostrar
        ClickPressed //Click para mostrar y soltar para ocultar
    }
    public partial class PasswordTextBox : UserControl
    {
        private Behavior behavior;

        public event EventHandler PasswordChanged;
        
        public Behavior Behavior
        {
            get { return behavior; }
            set { behavior = value; }
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
    }
}
