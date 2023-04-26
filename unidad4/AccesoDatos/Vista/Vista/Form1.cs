
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
using Modelos;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Conexion con = new Conexion();

            /*MessageBox.Show(con.Conectar()+"");*/
            List<Category> categorias= new CategoryDAO().obtenerTodas();
            dgvCaterorias.DataSource = categorias;

            //Desactivar la adición, eliminación y edición el el gridview
            dgvCaterorias.AllowUserToAddRows = false;
            dgvCaterorias.AllowUserToDeleteRows= false;
            dgvCaterorias.EditMode = DataGridViewEditMode.EditProgrammatically;

            //Activar la selección por fila en lugar de columna
            dgvCaterorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
    }
}
