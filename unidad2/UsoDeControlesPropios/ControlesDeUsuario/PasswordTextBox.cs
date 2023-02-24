using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesDeUsuario
{
    public enum Behavior
    {
        Click, //Click para ocultar, click para mostrar
        ClickPressed //Click para mostrar y soltar para ocultar
    }
    public partial class PasswordTextBox : UserControl
    {
        private Behavior clickBehavior;

        public Behavior behavior
        {
            get { return clickBehavior; }
            set { clickBehavior = value; }
        }


        public PasswordTextBox()
        {
            InitializeComponent();
        }

        private void picShowHide_Click(object sender, EventArgs e)
        {

        }
    }
}
