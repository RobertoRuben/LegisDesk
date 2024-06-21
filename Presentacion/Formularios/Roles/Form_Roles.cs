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
            this.FormatoDataGrid();
        }
        public void FormatoDataGrid()
        {
            dgvRoles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvRoles.Columns[0].Width = 120;
        }

        private void SeleccionarUltimoElemento()
        {
            if (dgvRoles.Rows.Count > 0)
            {
                dgvRoles.ClearSelection();
                dgvRoles.Rows[dgvRoles.Rows.Count - 1].Selected = true;
                dgvRoles.FirstDisplayedScrollingRowIndex = dgvRoles.Rows.Count - 1;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form_RegistroRoles form_RegistroRoles = new Form_RegistroRoles();
            form_RegistroRoles.codUsuario = codUsuario;
            form_RegistroRoles.operacion = operacion;
            form_RegistroRoles.ShowDialog();
            this.RolesListar();
            this.SeleccionarUltimoElemento();
        }

        public void RolesListar()
        {
            try
            {
                dgvRoles.DataSource = NRoles.ListarRoles();
                lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvRoles.Rows.Count);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void RolesBuscar()
        {
            try
            {
                dgvRoles.DataSource = NRoles.BuscarRol(tbxBusqueda.Texts.Trim());
                lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvRoles.Rows.Count);

                if (dgvRoles.Rows.Count < 1)
                {
                    MessageBox.Show("No se encontraron resultados", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
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
            this.RolesListar();
            this.FormatoDataGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.RolesBuscar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoles.SelectedRows.Count > 0)
                {
                    int rolId = Convert.ToInt32(dgvRoles.CurrentRow.Cells[0].Value);
                    Console.WriteLine("IdSeleccionado" + rolId);

                    // Mostrar MessageBox de confirmación
                    DialogResult result = MessageBox.Show("¿Deseas eliminar este rol?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string rpta = NRoles.EliminarRol(rolId, codUsuario);

                        if (rpta.Equals("Ok"))
                        {
                            this.MensajeOk("Se elimino el rol");
                            this.RolesListar();
                            this.FormatoDataGrid();
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                    }
                }
                else
                {
                    this.MensajeError("Debes seleccionar un registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            tbxBusqueda.Texts = "";
        }
    }
}
