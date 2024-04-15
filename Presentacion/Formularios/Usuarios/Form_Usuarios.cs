using Presentacion.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.Usuarios
{
    public partial class Form_Usuarios : Form
    {
        public Form_Usuarios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form_RegistrarUsuario frmRegsitro = new Form_RegistrarUsuario();
            frmRegsitro.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form_RegistrarUsuario frmRegistro = new Form_RegistrarUsuario();
            frmRegistro.ShowDialog();
        }
    }
}
