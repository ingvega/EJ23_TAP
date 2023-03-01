using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ocurrió el click");
        }

        private void login1_ClickIniciar(object sender, ControlLogin.DatosLogin e)
        {
            MessageBox.Show(e.Usuario + " - " + e.Contrasenia);
        }
    }
}
