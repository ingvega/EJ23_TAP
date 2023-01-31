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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (Double.TryParse(txtNum1.Text, out num1) && Double.TryParse(txtNum2.Text, out num2)) { 
                lblResultado.Text = num1 + num2 + "";
            }else{
                MessageBox.Show("Valores no válidos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
