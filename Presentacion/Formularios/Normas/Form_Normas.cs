using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.Normas
{
    public partial class Form_Normas : Form
    {
        public int codUsuario;
        public string operacion = "";
        public Form_Normas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form_RegistrarNormas frmRegistro = new Form_RegistrarNormas();
            frmRegistro.codUsuario = codUsuario;
            frmRegistro.operacion = "Insertar";
            frmRegistro.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form_RegistrarNormas frmRegistro = new Form_RegistrarNormas();
            frmRegistro.codUsuario = codUsuario;
            frmRegistro.operacion = "Modificar";
            frmRegistro.ShowDialog();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Form_RegistrarArticulos frmRegistroArticulos = new Form_RegistrarArticulos();
            frmRegistroArticulos.ShowDialog();
        }
    }
}
