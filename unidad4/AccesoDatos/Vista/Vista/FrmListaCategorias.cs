
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
    public partial class FrmListaCategorias : MetroFramework.Forms.MetroForm
    {
        public FrmListaCategorias()
        {
            InitializeComponent();

            actualizarLista();

            //Desactivar la adición, eliminación y edición el el gridview
            dgvCaterorias.AllowUserToAddRows = false;
            dgvCaterorias.AllowUserToDeleteRows= false;
            dgvCaterorias.EditMode = DataGridViewEditMode.EditProgrammatically;

            //Activar la selección por fila en lugar de columna
            dgvCaterorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCaterorias.Columns["CategoryName"].HeaderText = "Categoría";
            dgvCaterorias.Columns["Description"].HeaderText = "Descripción";

            dgvCaterorias.Columns["CategoryId"].Visible = false;
            

        }

        private void actualizarLista() {
            /*MetroFramework.MetroMessageBox(con.Conectar()+"");*/
            List<Category> categorias = new CategoryDAO().obtenerTodas();
            dgvCaterorias.DataSource = categorias;
            foreach (DataGridViewColumn columna in dgvCaterorias.Columns)
            {
                if(columna.Visible)
                    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCaterorias.SelectedRows.Count == 0)                        
            {

                MetroFramework.MetroMessageBox.Show(this, "Se debe seleccionar primero la categoría a editar", "Catálogo de categorías",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, 120);
                return;
            }

            int id = Convert.ToInt32(dgvCaterorias.SelectedRows[0].Cells["CategoryId"].Value);
            try
            {

                if (new CategoryDAO().eliminar(id))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Categoría eliminada exitósamente", "Catálogo de categorías",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, 120);
                    actualizarLista();
                }
                else {
                    MetroFramework.MetroMessageBox.Show(this, "Ha ocurrido un error al intentar eliminar la categoría, intentelo de nuevo más tarde", "Catálogo de categorías",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, 120);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Catálogo de categorías",
                        MessageBoxButtons.OK, MessageBoxIcon.Error,120);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
            frm.ShowDialog();
            if (frm.Actualizado)
                actualizarLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCaterorias.SelectedRows.Count == 0) {
                MetroFramework.MetroMessageBox.Show(null, "Se debe seleccionar primero la categoría a editar", "Catálogo de categorías",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning,120);
                return;
            }
            int id = Convert.ToInt32(dgvCaterorias.SelectedRows[0].Cells["CategoryId"].Value);
            FrmCategoria frm = new FrmCategoria(id);
            frm.ShowDialog();
            if (frm.Actualizado)
                actualizarLista();
        }

        private void dgvCaterorias_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(null, null);
        }
    }
}
