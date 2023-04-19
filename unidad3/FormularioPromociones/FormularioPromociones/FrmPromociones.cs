using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioPromociones
{
    
    public partial class FrmPromociones : Form
    {
        private int contImagen = 1;
        private List<Image> imagenes = new List<Image>();
        public FrmPromociones()
        {
            InitializeComponent();
            imagenes.Add(Properties.Resources.img__1_);
            imagenes.Add(Properties.Resources.img__2_);
            imagenes.Add(Properties.Resources.img__3_);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picPromocion.Image = imagenes[contImagen++%3];
        }
    }
}
