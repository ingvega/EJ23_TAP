using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ControlesDeUsuario
{
    public class FocusableTextBox:TextBox
    {
		private Color focusColor = Color.LightBlue;

		public Color FocusColor
		{
			get { return focusColor; }
			set { focusColor = value; }
		}

		public FocusableTextBox() {
			//Pintar el control cuando adquiera el enfoque
			this.Enter += new EventHandler(marcar);
			//Resetear el color del control al perder el enfoque
            this.Leave += new EventHandler(desmarcar);
        }

		private void marcar(Object sender, EventArgs e) { 
			this.BackColor= focusColor;
		}

        private void desmarcar(Object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
