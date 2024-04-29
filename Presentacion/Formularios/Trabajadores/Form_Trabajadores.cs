using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Servicios;
using Presentacion.Formularios.Trabajadores;
using Presentacion.Usuarios;

namespace Presentacion.Formularios.Trabajadores
{
    public partial class Form_Trabajadores : Form
    {
        public int codUsuario;
        public string operacion;

        public Form_Trabajadores()
        {
            InitializeComponent();
            this.Listar();
        }

        private void Form_Trabajadores_Load(object sender, EventArgs e)
        {

        }
        public void Listar()
        {
            try
            {
                dgvTrabajadores.DataSource = NTrabajadores.ListarTrabajadores();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_RegistroTrabajadores frm_RegistroTrabajadores = new Frm_RegistroTrabajadores();
            frm_RegistroTrabajadores.codUsuario = codUsuario;
            frm_RegistroTrabajadores.ShowDialog();
        }
    }

}
