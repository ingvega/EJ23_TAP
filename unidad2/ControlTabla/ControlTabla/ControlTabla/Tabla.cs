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
            set {
                filas = value;
                if (filas < 0) 
                    filas = 0;

                tlpContenido.RowCount = value+1;
                pintarTabla();
            }
        }

        private String[] columnas;

        public String[] Columnas
        {
            get { return columnas; }
            set { 
                columnas = value;
                if (columnas != null)
                    tlpContenido.ColumnCount = columnas.Length;
                else
                    tlpContenido.ColumnCount = 1;
                pintarTabla();
            
            }
        }

        private void pintarTabla() {
            //Reiniciar el layout (quitar los controles ya dibujados)
            tlpContenido.Controls.Clear();
            //Dibujar un botón por cada String en el arreglo
            for (int i = 0; i < tlpContenido.ColumnCount && columnas!=null; i++)
            {
                Button btn = new Button();
                btn.Text = columnas[i];
                tlpContenido.Controls.Add(btn);
                tlpContenido.ColumnStyles[i].SizeType = SizeType.AutoSize;
            }

            for (int i = 0; i < filas; i++)
            {
                tlpContenido.RowStyles[i].SizeType = SizeType.AutoSize;
                for (int j = 0; j < tlpContenido.ColumnCount; j++)
                {
                    TextBox txt= new TextBox();
                    tlpContenido.Controls.Add(txt);
                }
            }
            //tlpContenido.RowStyles[filas].SizeType = SizeType.AutoSize;

        }


        public Tabla()
        {
            InitializeComponent();
        }
    }
}
