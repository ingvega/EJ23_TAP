using Datos;
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

namespace Vista
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            Employee emp = employeeDAO.login(txtUsuario.Text, txtContrasenia.Text);

            if (emp != null)
            {
                MessageBox.Show("Bienvenido usuario " + emp.FullName);
            }
            else {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }

        }
    }
}
