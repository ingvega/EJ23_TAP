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
    public partial class Form1 : Form
    {
        private delegate void Intermediario(int valor, int tarea);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarT1_Click(object sender, EventArgs e)
        {
            iniciarTarea(1);
        }

        private void iniciarTarea(int tarea) {
            Task.Factory.StartNew(() => {
                for (int i = 1; i <= 100; i++)
                {
                    actualizarValor(i, tarea);
                    //Thread.Sleep(500);
                }
            });
        }

        private void actualizarValor(int valor, int tarea) {
            //Verificando si este método se está ejecutando en el contexto
            //del hilo principal (creador de la caja de texto)
            //Cuando es el hilo principal InvokeRequired tiene false
            if (txtValor.InvokeRequired)
            {
                Intermediario delegado = new Intermediario(actualizarValor);
                //Solicita permiso y ejecuta el método actualizarValor y cambia
                //al contexto del hilo principal
                this.Invoke(delegado, new object[] { valor, tarea });
                //También invoca el delegado pero NO cambia de contexto
                //delegado.Invoke(valor, tarea);
            }
            else
            {
                //Estamos ejecutando en el contexto del hilo principal
                txtValor.Text = "Tarea " + tarea + " - Operacion " + valor;
            }
        }

        private void btnIniciarT2_Click(object sender, EventArgs e)
        {
            iniciarTarea(2);
        }
    }
}
