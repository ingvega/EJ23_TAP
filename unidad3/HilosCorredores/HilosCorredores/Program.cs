using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HilosCorredores
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Crear 10 tareas y verificar una impresión de 1 a 10000 en cada una (en consola)
            /*
            Task[] tasks = new Task[10];

            for (int ctr = 0; ctr < 10; ctr++) { 
                tasks[ctr] = Task.Factory.StartNew(() => {
                    for (int i = 0; i < 1000; i++)
                    {
                        Console.WriteLine("Tarea {0} corriendo la operación {1} y ejecutandose en el hilo {2}", Task.CurrentId, i, Thread.CurrentThread.ManagedThreadId);
                    }
                });
            }

            */

            //saber qué tarea termina primero
            //bool termino = false;
            int indice=0, idTarea=0;
            //while (true)
            //{
            //    //Contar cuantas tareas han finalizado
            //    int cont = 0;
            //    for (int ctr2 = 0; ctr2 < 10; ctr2++)
            //    {
            //        if (tasks[ctr2].IsCompleted)
            //        {
            //            if (!termino)
            //            {
            //                termino = true;
            //                indice = ctr2;
            //                idTarea = tasks[ctr2].Id;
            //            }
            //            cont++;
            //        }
            //    }
            //    Console.WriteLine("Finalizadas " + cont);
            //    if (cont == 10) break;
            //}
            /*indice = Task.WaitAny(tasks);
            idTarea = tasks[indice].Id;
            Console.WriteLine("Ya terminaron todas " +
                " la primera tarea en terminar es "+
                indice +  " id de tarea= " + idTarea);
            //Espera a que todas las tareas terminen
            Task.WaitAll(tasks);

            */

            //Console.WriteLine("Ya terminaron todas");

            //Se ejecuta mientras no hayan finalizado todas las tareas
            //while (true)
            //{
            //    //Contar cuantas tareas han finalizado
            //    int cont = 0;
            //    for (int ctr2 = 0; ctr2 < 10; ctr2++)
            //    {
            //        if (tasks[ctr2].IsCompleted) cont++;
            //    }
            //    Console.WriteLine("Finalizadas " + cont);
            //    if (cont == 10) break;
            //}

        }

    }
}
