
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
            dgvCaterorias.Columns["CategoryName"].HeaderText = "Categoría";
            dgvCaterorias.Columns["Description"].HeaderText = "Descripción";

            dgvCaterorias.Columns["CategoryId"].Visible = false;

            cargarCombo();
        }

        private void cargarCombo() { 
            cboCategorias.DataSource= new CategoryDAO().obtenerTodas();
            cboCategorias.DisplayMember = "CategoryName";
            cboCategorias.ValueMember = "CategoryId";
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cboCategorias.SelectedIndex+"");
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Category cat = (Category) cboCategorias.SelectedItem;
            MessageBox.Show("Categoria:" + cat.CategoryName + " con clave: " + cat.CategoryId);
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cboCategorias.SelectedValue + "");
        }
    }
}
