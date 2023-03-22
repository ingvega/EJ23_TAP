using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HilosCorredores
{
    public partial class Corredores : Form
    {
        public Corredores()
        {
            InitializeComponent();
        }
        static Random rng = new Random();
        private Thread t1, t2, t3;
        delegate void StringArgReturnVoidDelegate(Form frm, PictureBox pb);
       
        private void CorrerProceso(Form frm, PictureBox b)
        {
            int stp = 2;
            if (b.InvokeRequired)
            {
                while (b.Left + b.Width + 50 < frm.Width) 
                {
                    StringArgReturnVoidDelegate d = 
                        new StringArgReturnVoidDelegate(CorrerProceso);
                    this.Invoke(d, new object[] { frm,b });
                    Thread.Sleep(rng.Next(20,80));
                    
                }
            }
            else
            {
                b.Left += stp;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void buttonIniciar1_Click(object sender, EventArgs e)
        {
            CorrerHilo(out t1, picCorredor1);
        }

        private void buttonIniciar2_Click(object sender, EventArgs e)
        {
            CorrerHilo(out t2, picCorredor2);
        }

        private void buttonIniciar3_Click(object sender, EventArgs e)
        {
            CorrerHilo(out t3, picCorredor3);
        }

        private void buttonIniciarTodos_Click(object sender, EventArgs e)
        {
            CorrerHilo(out t1, picCorredor1);
            CorrerHilo(out t2, picCorredor2);
            CorrerHilo(out t3, picCorredor3);
            ThreadStart d1 = () => Multiple();
            Thread hilo = new Thread(d1);
            hilo.Start();
        }

        private void CorrerHilo(out Thread hilo ,PictureBox pb)
        {
            ThreadStart delegado = () => CorrerProceso(this, pb);
            hilo = new Thread(delegado);
            hilo.Start();
        }


        private void Multiple()
        {
            while (t1.IsAlive && t2.IsAlive && t3.IsAlive);
            int ganador;
            if (!t1.IsAlive)
            {
                ganador = 1;
            }else if (!t2.IsAlive)
            {
                ganador = 2;
            }
            else
            {
                ganador = 3;
            }
            while (t1.IsAlive || t2.IsAlive || t3.IsAlive);
            MessageBox.Show("El corredor: " + ganador + " fue el ganador");
            
        }
    }
    
}
