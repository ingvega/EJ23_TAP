using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLogin
{
    public partial class Login : UserControl
    {
        private Boolean recordarmeVisible = true;
        //Definir un evento sin pasar datos
        //public event EventHandler NombreEvento;

        ////Definir un evento que difundirá datos
        //public event EventHandler<ClaseConPropiedades> NombreEventoMensaje;

        public event EventHandler<DatosLogin> ClickIniciar;

        
        /// <summary>
        /// Define la visibilidad de la casilla de verificación Recordarme
        /// </summary>
        [Description("Define la visibilidad de la casilla de verificación "), Category("Visibilidad"),ReadOnly(true)]
        public Boolean RecordarmeVisible
        {
            get {
                return recordarmeVisible; 
            }
            set { 
                recordarmeVisible = value;
                chkRecordarme.Visible = value;
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void btnInciar_Click(object sender, EventArgs e)
        {
            DatosLogin datosMensaje = new DatosLogin();
            datosMensaje.Usuario = txtUsuario.Text;
            datosMensaje.Contrasenia = txtContrasenia.Text;
            //Difundir el evento (notificación) 
            //Siempre y cuando esté listo
            //Si aún se está cargando trae NULL
            ClickIniciar?.Invoke(this,datosMensaje);
            //Evento?.Invoke(this,new EventArgs());
        }
    }
}
