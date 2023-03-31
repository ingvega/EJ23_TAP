using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HilosCorredores
{
    public partial class CorredoresTareas : Form
    {
        public CorredoresTareas()
        {
            InitializeComponent();
        }
        static Random rng = new Random();
        //private Thread t1, t2, t3;
        private Task[] tareas=new Task[3];
        delegate void StringArgReturnVoidDelegate(Form frm, PictureBox pb);
       
        private void CorrerProceso(Form frm, PictureBox b)
        {

            int stp = 5;
            if (b.InvokeRequired)
            {
                try
                {
                    while (b.Left + b.Width + 50 < frm.Width)
                    {
                        StringArgReturnVoidDelegate d =
                            new StringArgReturnVoidDelegate(CorrerProceso);
                        this.Invoke(d, new object[] { frm, b });
                        Thread.Sleep(rng.Next(20, 50));

                    }
                }
                catch (Exception){}
            }
            else
            {
                b.Left += stp;
            }
        }

        private void buttonIniciar1_Click(object sender, EventArgs e)
        {
            CorrerTarea(out tareas[0], picCorredor1);
        }

        private void buttonIniciar2_Click(object sender, EventArgs e)
        {
            CorrerTarea(out tareas[1], picCorredor2);
        }

        private void buttonIniciar3_Click(object sender, EventArgs e)
        {
            CorrerTarea(out tareas[2], picCorredor3);
        }

        private void buttonIniciarTodos_Click(object sender, EventArgs e)
        {
            
            
            for (int i = 0; i < tareas.Length; i++)
            {
                CorrerTarea(out tareas[i], (PictureBox) this.Controls["picCorredor" + (i+1)]);
            }

            //No recomendable porque pausa el hilo principal
            //Task.WaitAny(tareas); 
            Task.Factory.StartNew(() => {
                int tarea=Task.WaitAny(tareas);
                MessageBox.Show("Ya terminó la carrera"+
                    " ganó el corredor " + (tarea + 1) );
            });
            
            //Task.Factory.StartNew(() => Multiple());
        }

        private void CorrerTarea(out Task tarea ,PictureBox pb)
        {
            tarea = Task.Factory.StartNew(() => CorrerProceso(this, pb));
        }
        private void Multiple()
        {
            while (!tareas[0].IsCompleted && !tareas[1].IsCompleted && !tareas[2].IsCompleted) ;
            int ganador;
            if (tareas[0].IsCompleted)
            {
                ganador = 1;
            }
            else if (tareas[1].IsCompleted)
            {
                ganador = 2;
            }
            else
            {
                ganador = 3;
            }
            while (!tareas[0].IsCompleted || !tareas[1].IsCompleted || !tareas[2].IsCompleted) ;
            MessageBox.Show("El corredor: " + ganador + " fue el ganador");

        }
    }
    
}
