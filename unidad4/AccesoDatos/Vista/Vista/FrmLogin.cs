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
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
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
                MetroFramework.MetroMessageBox.Show(this, "Bienvenido usuario " + emp.FullName, "Northwind App", MessageBoxButtons.OK, MessageBoxIcon.Information, 120);
                new FrmPrincipal().Show();
                this.Hide();
              
            }
            else {
                MetroFramework.MetroMessageBox.Show(this, "Usuario y/o contraseña incorrectos","Northwind App",MessageBoxButtons.OK, MessageBoxIcon.Error, 120);
                
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
