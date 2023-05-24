using Modelos;
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
    public partial class FrmCategoria : MetroFramework.Forms.MetroForm
    {
        private int idCategoria;
        public bool Actualizado { get; set; }
        public FrmCategoria()
        {
            InitializeComponent();
        }

        public FrmCategoria(int idCategoria):this()
        {
            this.idCategoria = idCategoria;
            Category categoria = new CategoryDAO().obtenerUna(idCategoria);
            if (categoria != null) {
                txtCategoria.Text = categoria.CategoryName;
                txtDescripcion.Text = categoria.Description;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar()) {
                Category c = new Category(idCategoria,
                    txtCategoria.Text.Trim(),
                    txtDescripcion.Text.Trim());
                if (idCategoria ==0)
                {
                    if (new CategoryDAO().agregar(c) > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "La categoría ha sido almacenada correctamente", "Catálogo de categorías", MessageBoxButtons.OK, MessageBoxIcon.Information,120);
                        Actualizado = true;
                        this.Close();
                    }
                }
                else {
                    if (new CategoryDAO().editar(c))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "La categoría ha sido actualizada correctamente", "Catálogo de categorías", MessageBoxButtons.OK, MessageBoxIcon.Information,120);
                        Actualizado = true;
                        this.Close();
                    }
                }
            }
        }

        private bool validar() {
            bool valido = true;
            erpErrores.Clear();
            if (!(txtCategoria.Text.Trim().Length > 0 && txtCategoria.Text.Trim().Length <= 15))
            {
                valido = false;
                erpErrores.SetError(txtCategoria, "El nombre de la categoría es un valor obligatorio que debe tener entre 1 y 15 caracteres");
            }

            if (!(txtDescripcion.Text.Trim().Length > 0 && txtCategoria.Text.Trim().Length <= 500))
            {
                valido = false;
                erpErrores.SetError(txtDescripcion, "La descripción de la categoría es un valor requerido que debe tener entre 1 y 500 caracteres");
            }

            if (!valido) {
                MetroFramework.MetroMessageBox.Show(this, "No se puede realizar la operación, revisa la información proporcionada e intenta de nuevo", "Catálogo de categorías", MessageBoxButtons.OK, MessageBoxIcon.Warning,150);
            }
            return valido;
        }
    }
}
