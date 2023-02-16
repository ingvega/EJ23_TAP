using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmLugares : Form
    {
        public FrmLugares()
        {
            InitializeComponent();
            String resumen = "";
            //Por cada control que se encuentre en la colección Controls del form
            //foreach (Control control in this.Controls)
            //{
            //    if(control is Button)
            //        resumen+= control.Name  + " - " + control.GetType().Name 
            //        + "\n";
            //}
            //MessageBox.Show(resumen);

            foreach (Button btn in panel1.Controls)
            {
                btn.Click += new EventHandler(eventoBoton);
                btn.KeyPress += new KeyPressEventHandler(eventoTecla); 
                
            }
        }

        private void eventoBoton(Object boton, EventArgs e)
        {
            Button btn = (Button)boton;
            if (txtNombre.Text.Trim().Length >= 2)
            {
                btn.BackgroundImage =
                GUI.Properties.Resources.pcOcupada;
                btn.Tag=txtNombre.Text.Trim();
            }
            else
            {
                MessageBox.Show("Se debe ingresar el nombre del ocupante (al menos 2 caracteres)",
                    "Reservar equipo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eventoTecla(Object boton, KeyPressEventArgs e)
        {
            //KeyPressEventArgs argumentos = (KeyPressEventArgs)e;
            //if (e.KeyChar != (int)Keys.D && e.KeyChar != (int)Keys.D+32) return;

            //if (e.KeyChar != 'D' && e.KeyChar != 'd') return;
            if (e.KeyChar == 'D' || e.KeyChar == 'd')
            {
                

                Button btn = (Button)boton;
                if (btn.Tag != null)
                {
                    DialogResult respuesta = MessageBox.Show("Este esquipo lo tiene reservado " + btn.Tag + ", ¿Estás seguro que deseas liberarlo?", "Eliminar reserva de equipo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        btn.BackgroundImage =
                        GUI.Properties.Resources.pcLibre;
                        btn.Tag = null;
                    }
                }
                else
                {
                    MessageBox.Show("Este equipo ya estaba disponible",
                        "Reservar equipo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
