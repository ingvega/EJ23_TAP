using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoDeControlesPropios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Opción no recomentada, la dejamos como última opción
            foreach (Control control in passwordTextBox1.Controls)
            {
                if (control is TextBox) {
                    MessageBox.Show("El password es " + control.Text);
                    return;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Opción viable solo que quiera exponer muchas propiedades y eventos
            //de la caja de texto o no me interese como el programador
            //manipule la caja de texto
            MessageBox.Show("El password es " +
                passwordTextBox1.txtPassword.Text);
        }
    }
}
