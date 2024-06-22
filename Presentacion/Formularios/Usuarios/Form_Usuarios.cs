using Presentacion.Usuarios;
using System;
using System.Windows.Forms;
using Negocio.Servicios;

namespace Presentacion.Formularios.Usuarios
{
    public partial class Form_Usuarios : Form
    {
        public string operacion;
        public int idUsuarioSesion;
        public Form_Usuarios()
        {
            InitializeComponent();
            this.ListarUsuarios();
            this.FormatoDataGrid();
        }
        public void FormatoDataGrid()
        {
            //dgvUsuarios.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //dgvUsuarios.Columns[0].Width = 120;
            dgvUsuarios.Columns[0].Visible = false;
            dgvUsuarios.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvUsuarios.Columns[1].Width = 350;
        }

        private void SeleccionarUltimoElemento()
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                dgvUsuarios.ClearSelection();
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Selected = true;
                dgvUsuarios.FirstDisplayedScrollingRowIndex = dgvUsuarios.Rows.Count - 1;
            }
        }

        public void ListarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = NUsuarios.ListarUsuario();
                lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvUsuarios.Rows.Count);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void BuscarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = NUsuarios.BuscarUsuario(tbxBusqueda.Texts.Trim());
                lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvUsuarios.Rows.Count);

                if (dgvUsuarios.Rows.Count < 1)
                {
                    MessageBox.Show("No se encontraron resultados", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form_RegistrarUsuario frmRegistro = new Form_RegistrarUsuario();
            frmRegistro.CargarTrabajadores();
            frmRegistro.CargarRoles();
            frmRegistro.operacion = "Registrar";
            frmRegistro.codUsuario = idUsuarioSesion;
            frmRegistro.ShowDialog();
            this.ListarUsuarios();
            this.FormatoDataGrid();
            this.SeleccionarUltimoElemento();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form_RegistrarUsuario frmRegistro = new Form_RegistrarUsuario();

            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                frmRegistro.operacion = "Actualizar";
                frmRegistro.codUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);

                Console.WriteLine("Trabajador ID: " + frmRegistro.codUsuario);

                frmRegistro.CargarRoles();
                frmRegistro.CargarTrabajadores();
                frmRegistro.cboxTrabajadores.Texts = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                frmRegistro.cboxTrabajadores.Enabled = false;
                frmRegistro.tboxNombreUsuario.Texts = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                //frmRegistro.tboxContraseña.Texts = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                frmRegistro.cboxRol.Texts = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();

                // Añadir la lógica para los RadioButtons
                string estado = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                if (estado.Equals("Activo", StringComparison.OrdinalIgnoreCase))
                {
                    frmRegistro.rbtnActivo.Checked = true;
                    frmRegistro.rbtnInactivo.Checked = false;
                }
                else if (estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                {
                    frmRegistro.rbtnActivo.Checked = false;
                    frmRegistro.rbtnInactivo.Checked = true;
                }

                frmRegistro.ShowDialog();
                this.ListarUsuarios();
                this.FormatoDataGrid();
            }


        }

        private void Form_Usuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count > 0)
                {
                    int usuarioId = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
                    Console.WriteLine("IdSeleccionado" + usuarioId);

                    // Mostrar MessageBox de confirmación
                    DialogResult result = MessageBox.Show("¿Deseas inhabilitar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string rpta = NUsuarios.InhabilitarUsuario(usuarioId, idUsuarioSesion);

                        if (rpta.Equals("Ok"))
                        {
                            this.MensajeOk("Se inhabilitó el trabajador");
                            this.ListarUsuarios();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarUsuarios();
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

        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_VistaUsuarios form_VistaUsuarios = new Form_VistaUsuarios();

            if (dgvUsuarios.SelectedRows.Count > 0)
            {

                form_VistaUsuarios.tboxNombreUsuario.Texts = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                form_VistaUsuarios.tboxTrabajador.Texts = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                form_VistaUsuarios.tboxRol.Texts = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                form_VistaUsuarios.tboxEstado.Texts = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();

                form_VistaUsuarios.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debes seleccionar al menos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
