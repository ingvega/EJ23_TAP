﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabla1.Columnas = new string[] { "Nombre",
                                "Apellidos",
                                "Direccion",
                                "Semestre"};
        }
    }
}
