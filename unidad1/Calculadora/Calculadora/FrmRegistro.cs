using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmRegistro : Form
    {
        List<Municipio> municipios = new List<Municipio>();
        List<Estado> estados = new List<Estado>();

        public FrmRegistro()
        {
            estados.Add(new Estado() { Clave=1, Nombre="Guanajuato"});
            estados.Add(new Estado() { Clave=2, Nombre="Michoacan"});

            municipios.Add(new Municipio() { Clave = 1, Nombre = "Moroleon", ClaveEstado=1 });
            municipios.Add(new Municipio() { Clave = 2, Nombre = "Uriangato", ClaveEstado=1 });
            municipios.Add(new Municipio() { Clave = 3, Nombre = "Yuriria", ClaveEstado=1 });
            municipios.Add(new Municipio() { Clave = 4, Nombre = "Huandacareo", ClaveEstado=2 });
            municipios.Add(new Municipio() { Clave = 5, Nombre = "Cuitzeo", ClaveEstado=2 });
            municipios.Add(new Municipio() { Clave = 6, Nombre = "Morelia", ClaveEstado=2 });

            InitializeComponent();
            cboEstado.Items.Add("Guanajuato");
            for (int i = 0; i < estados.Count; i++)
            {
                cboEstado.Items.Add(estados[i]);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length >= 1)
            {
                epErrores.SetError(txtNombre, "");
            }
            else {
                epErrores.SetError(txtNombre, "El nombre es obligatorio y debería de tener al menos un caracter");
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Length >= 5)
            {
                epErrores.SetError(txtUsuario, "");
            }
            else
            {
                epErrores.SetError(txtUsuario, "El usuario es obligatorio y debería de tener al menos cinco caracteres");
            }
        }

        private void txtContrasenia1_TextChanged(object sender, EventArgs e)
        {
            String mensajes = "";
            if (txtContrasenia1.Text.Trim().Length < 8)
            {
                mensajes = "La contraseña es obligatoria y debería de tener al menos ocho caracteres";
            }

            epErrores.SetError(txtContrasenia1, mensajes);
        }

        private void txtContrasenia2_TextChanged(object sender, EventArgs e)
        {
            String mensajes = "";
            if (txtContrasenia2.Text.Trim().Length < 8)
            {
                mensajes += "La contraseña es obligatoria y debería de tener al menos ocho caracteres";
            }

            if (!txtContrasenia2.Text.Trim().Equals(txtContrasenia2.Text.Trim()))
            {
                mensajes += "\nLas contraseñas no coinciden";
            }

            epErrores.SetError(txtContrasenia2, mensajes);
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object estado = cboEstado.SelectedItem;
            if (estado is String)
            {
                MessageBox.Show("Estado en cadena " + estado);
            }
            else /*if (estado is Estado)*/
            {
                Estado objEstado = (Estado)estado;
                MessageBox.Show("Estado en objeto Clave: " + 
                    objEstado.Clave + "\n Nombre: " +
                    objEstado.Nombre);
            }
        }
    }
}
