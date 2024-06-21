using System;
using System.Windows.Forms;

namespace Presentacion.Formularios.Articulos
{
    public partial class Form_VistaArticulos : Form
    {
        public Form_VistaArticulos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
