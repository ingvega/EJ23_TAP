using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProgramacionConcurrente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Mostrar el loader
            picLoader.Image = Properties.Resources.loading_loader;

            Thread hilo = new Thread(
                new ThreadStart(ejecutarOperaciones));
            hilo.Start();
            
            
        }

        private void ejecutarOperaciones() {
            //Simular un proceso largo (tardado)
            for (int i = 0; i < 3000000; i++)
            {
                Console.WriteLine("Subactividad" + i);
            }
            //Quitar el loader
            picLoader.Image = null;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            //MessageBox.Show("Se presionó el botón");
        }
    }
}
