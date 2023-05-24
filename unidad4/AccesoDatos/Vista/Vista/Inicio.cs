using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            tmrTemporizador.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Hide();
            tmrTemporizador.Stop();
            
        }
    }
}
