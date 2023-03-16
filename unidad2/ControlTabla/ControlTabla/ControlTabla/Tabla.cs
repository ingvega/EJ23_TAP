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

                pintarTabla();
            }
        }

        private String[] columnas;

        public String[] Columnas
        {
            get { return columnas; }
            set { 
                columnas = value;
                
                pintarTabla();
            
            }
        }

        private void pintarTabla() {
            //Reiniciar el layout (quitar los controles ya dibujados)
            //tlpContenido.Controls.Clear();
            this.Controls.Clear();
            tlpContenido=new TableLayoutPanel();
            tlpContenido.Dock=DockStyle.Fill;
            this.Controls.Add(tlpContenido);

            if (columnas != null)
                    tlpContenido.ColumnCount = columnas.Length;
                
            tlpContenido.RowCount = filas+1;
            //Dibujar un botón por cada String en el arreglo
            for (int i = 0; i < tlpContenido.ColumnCount; i++)
            {
                Button btn = new Button();
                btn.Text = columnas[i];
                tlpContenido.Controls.Add(btn);
                //tlpContenido.ColumnStyles[i].SizeType = SizeType.AutoSize;
            }

            for (int i = 0; i < filas; i++)
            {
                //tlpContenido.RowStyles[i].SizeType = SizeType.AutoSize;
                for (int j = 0; j < tlpContenido.ColumnCount; j++)
                {
                    TextBox txt= new TextBox();
                    tlpContenido.Controls.Add(txt);
                }
            }
            //tlpContenido.RowStyles[filas].SizeType = SizeType.AutoSize;

            for (int i = 0; i < tlpContenido.ColumnStyles.Count; i++)
            {
                tlpContenido.ColumnStyles[i].SizeType = SizeType.AutoSize;
            }

            for (int i = 0; i < tlpContenido.RowStyles.Count; i++)
            {
                tlpContenido.RowStyles[i].SizeType = SizeType.AutoSize;
            }

        }


        public Tabla()
        {
            InitializeComponent();
        }

        public String obtenerValor(int fila, int columna) {
            //Verificar que los valores son válidos

            //Acceder a la caja de texto
            TextBox txt=(TextBox) tlpContenido.GetControlFromPosition(columna, fila+1);

            return txt.Text;

        }

        public void asignarValor(int fila, int columna, string valor)
        {

            //Verificar que los valores son válidos

            //Acceder a la caja de texto
            TextBox txt = (TextBox)tlpContenido.GetControlFromPosition(columna, fila + 1);

            txt.Text=valor;

        }
    }
}
