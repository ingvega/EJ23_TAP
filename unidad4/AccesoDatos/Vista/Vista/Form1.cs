using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Conexion con = new Conexion();

            MessageBox.Show(con.Conectar()+"");
            new CategoryDAO().obtenerTodas();

        }
    }
}
