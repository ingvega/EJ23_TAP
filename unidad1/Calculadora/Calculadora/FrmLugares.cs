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
            foreach (Button btn in panel1.Controls)
            {
                btn.Click += new EventHandler(eventoBoton);
            }
        }

        private void eventoBoton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtNombre.Text.Trim().Length >= 2)
            {
                btn.BackgroundImage =
                GUI.Properties.Resources.pcOcupada;
            }
            else
            {
                MessageBox.Show("Se debe ingresar el nombre del ocupante (al menos 2 caracteres)",
                    "Reservar equipo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
