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
    public partial class InputDialog : Form
    {
        public String Valor { get; set; }
        public String Titulo { get; set; }
        public String Texto { get; set; }
        public InputDialog()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Valor=txtValor.Text;
            this.Close();
        }
    }
}
