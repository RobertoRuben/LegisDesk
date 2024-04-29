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

namespace Presentacion.Formularios.Roles
{
    public partial class Form_Roles : Form
    {
        public string operacion = "Registrar";
        public int codUsuario;
        public Form_Roles()
        {
            InitializeComponent();
            this.RolesListar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form_RegistroRoles form_RegistroRoles = new Form_RegistroRoles();
            form_RegistroRoles.codUsuario = codUsuario;
            form_RegistroRoles.operacion = operacion;
            form_RegistroRoles.ShowDialog();
            Console.WriteLine("Idddd: " + codUsuario);
        }

        public void RolesListar()
        {
            try
            {
                dgvRoles.DataSource = NRol.ListarRoles();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Form_Roles_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form_RegistroRoles form_RegistroRoles = new Form_RegistroRoles();

            if (dgvRoles.SelectedRows.Count > 0)
            {
                form_RegistroRoles.codUsuario = codUsuario;
                form_RegistroRoles.operacion = "Actualizar";
                form_RegistroRoles.codRol = Convert.ToInt32(dgvRoles.CurrentRow.Cells[0].Value);

                form_RegistroRoles.tboxNombreRol.Texts = dgvRoles.CurrentRow.Cells[1].Value.ToString().Trim();
            }

            form_RegistroRoles.ShowDialog();
        }
    }
}
