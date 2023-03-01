using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLogin
{
    public partial class Login : UserControl
    {
        private Boolean recordarmeVisible = true;
        public event EventHandler<DatosLogin> ClickIniciar;

        public Boolean RecordarmeVisible
        {
            get {
                return recordarmeVisible; 
            }
            set { 
                recordarmeVisible = value;
                chkRecordarme.Visible = value;
            }
        }

        public Login()
        {
            InitializeComponent();
        }
    }
}
