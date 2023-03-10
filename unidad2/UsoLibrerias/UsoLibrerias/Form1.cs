using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoLibrerias
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double metros = double.Parse(txtDatos.Text);
            double pies = Conversiones.ConversionesMedida.MetrosAPies(metros);
            MessageBox.Show(metros + "m equivalen a " + pies + "ft");
        }
    }
}
