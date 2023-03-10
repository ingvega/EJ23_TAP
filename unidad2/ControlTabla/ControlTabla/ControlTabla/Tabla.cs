using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTabla
{
    public partial class Tabla : UserControl
    {
        private int filas;

        public int Filas
        {
            get { return filas; }
            set { filas = value; }
        }

        private String[] columnas;

        public String[] Columnas
        {
            get { return columnas; }
            set { 
                columnas = value;
                tlpContenido.ColumnCount=columnas.Length;
                //Dibujar un botón por cada String en el arreglo
                for (int i = 0; i < columnas.Length; i++)
                {
                    Button btn = new Button();
                    btn.Text = columnas[i];
                    tlpContenido.Controls.Add(btn);
                }
            
            }
        }


        public Tabla()
        {
            InitializeComponent();
        }
    }
}
