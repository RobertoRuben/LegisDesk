using System;
using System.Windows.Forms;
using Negocio.Servicios;
using Presentacion.Formularios.Articulos;

namespace Presentacion.Formularios.Normas
{
    public partial class Form_Normas : Form
    {
        public int codUsuario;
        public string operacion = "";
        public Form_Normas()
        {
            InitializeComponent();
            this.ListarNormas();
            this.FormatoDataGrid();
        }
        public void FormatoDataGrid()
        {
            dgvNormas.Columns[0].Visible = false;
            dgvNormas.Columns[1].Visible = false;
            dgvNormas.Columns[2].Visible = false;
            dgvNormas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvNormas.Columns[3].Width = 150;
            dgvNormas.Columns[6].Visible = false;
            dgvNormas.Columns[7].Visible = false;
            dgvNormas.Columns[8].Visible = false;
            dgvNormas.Columns[9].Visible = false;
            dgvNormas.Columns[10].Visible = false;
        }
        public void ListarNormas()
        {
            try
            {
                dgvNormas.DataSource = NNormas.ListarNormas();
                lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvNormas.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void SeleccionarUltimoElemento()
        {
            if (dgvNormas.Rows.Count > 0)
            {
                dgvNormas.ClearSelection();
                dgvNormas.Rows[dgvNormas.Rows.Count - 1].Selected = true;
                dgvNormas.FirstDisplayedScrollingRowIndex = dgvNormas.Rows.Count - 1;
            }
        }
        private void NormasBuscar()
        {
            try
            {
                dgvNormas.DataSource = NNormas.BuscarNormas(tbxBusqueda.Texts.Trim());
                lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvNormas.Rows.Count);

                if (dgvNormas.Rows.Count < 1)
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
            Form_RegistrarNormas frmRegistro = new Form_RegistrarNormas();
            frmRegistro.CargarNormas();
            frmRegistro.codUsuario = codUsuario;
            frmRegistro.operacion = "Registrar";
            frmRegistro.ShowDialog();
            this.ListarNormas();
            this.FormatoDataGrid();
            this.SeleccionarUltimoElemento();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form_RegistrarNormas frmRegistro = new Form_RegistrarNormas();

            if(dgvNormas.SelectedRows.Count > 0)
            {
                frmRegistro.codUsuario = codUsuario;
                frmRegistro.codNorma = Convert.ToInt32(dgvNormas.CurrentRow.Cells[0].Value);
                frmRegistro.CargarNormas();

                frmRegistro.operacion = "Modificar";
                frmRegistro.tboxNumNorma.Texts = dgvNormas.CurrentRow.Cells[3].Value.ToString().Trim();
                frmRegistro.tboxNombreNorma.Texts = dgvNormas.CurrentRow.Cells[4].Value.ToString();
                frmRegistro.tboxResumen.Texts = dgvNormas.CurrentRow.Cells[6].Value.ToString().Trim();
                frmRegistro.tboxLink.Texts = dgvNormas.CurrentRow.Cells[10].Value.ToString().Trim();
                frmRegistro.NumUpDownPaginas.Value = Convert.ToDecimal(dgvNormas.CurrentRow.Cells[8].Value.ToString().Trim());
                frmRegistro.cboxMedioPublicacion.Texts = dgvNormas.CurrentRow.Cells["Medio Publicacion"].Value.ToString().Trim();
                frmRegistro.cboxCategoriaNorma.SelectedValue = Convert.ToString(dgvNormas.CurrentRow.Cells[1].Value);
                frmRegistro.cboxCategoriaNorma.Texts = dgvNormas.CurrentRow.Cells["Tipo"].Value.ToString().Trim();

                string estado = dgvNormas.CurrentRow.Cells[11].Value.ToString();
                if (estado.Equals("Vigente", StringComparison.OrdinalIgnoreCase))
                {
                    frmRegistro.rbtnVigente.Checked = true;
                    frmRegistro.rbtnDerogado.Checked = false;
                }
                else if (estado.Equals("Derogada", StringComparison.OrdinalIgnoreCase))
                {
                    frmRegistro.rbtnVigente.Checked = false;
                    frmRegistro.rbtnDerogado.Checked = true;
                }

                string inputFecha = dgvNormas.CurrentRow.Cells[7].Value.ToString().Trim();
                DateTime fecha;
                if (DateTime.TryParse(inputFecha, out fecha))
                {
                    frmRegistro.dtpFechaRegistro.Value = fecha.Date; 
                }
                else
                {
                    MessageBox.Show($"La fecha del registro '{inputFecha}' no es válida o está en un formato incorrecto.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    frmRegistro.dtpFechaRegistro.Value = DateTime.Today;  // Set default or error date
                }

                frmRegistro.ShowDialog();
                this.FormatoDataGrid();
                this.ListarNormas();
            }
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            if(dgvNormas.SelectedRows.Count > 0)
            {
                Form_Articulos frmArticulos = new Form_Articulos();
                frmArticulos.codUsuario = codUsuario;
                frmArticulos.codNorma = Convert.ToInt32(dgvNormas.CurrentRow.Cells[0].Value);
                frmArticulos.ListarArticulos();
                frmArticulos.nombreNorma = dgvNormas.CurrentRow.Cells[4].Value.ToString();
                frmArticulos.numNorma = dgvNormas.CurrentRow.Cells[3].Value.ToString().Trim();
                frmArticulos.ShowDialog();
            }
        }
        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            tbxBusqueda.Texts = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvNormas.SelectedRows.Count > 0)
            {
                try
                {
                    // Mostrar mensaje de confirmación
                    DialogResult dialogResult = MessageBox.Show("¿Quieres eliminar esta norma? Recuerda que también se eliminarán los artículos vinculados a esa norma.", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        string rpta = NNormas.EliminarNormas(Convert.ToInt32(dgvNormas.CurrentRow.Cells[0].Value));
                        if (rpta.Equals("Ok"))
                        {
                            this.MensajeOk("Se eliminó el registro");
                            this.ListarNormas();
                            this.FormatoDataGrid();
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.NormasBuscar();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Codigo Usuario: " + codUsuario);
        }

        private void dgvNormas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_VistaNormas form_VistaNormas = new Form_VistaNormas();

            if (dgvNormas.SelectedRows.Count > 0)
            {
                form_VistaNormas.tboxNumNorma.Texts = dgvNormas.CurrentRow.Cells[3].Value.ToString().Trim();
                form_VistaNormas.tboxNombreNorma.Texts = dgvNormas.CurrentRow.Cells[4].Value.ToString();
                form_VistaNormas.tboxResumen.Texts = dgvNormas.CurrentRow.Cells[6].Value.ToString().Trim();
                form_VistaNormas.linkEnlace.Text = dgvNormas.CurrentRow.Cells[10].Value.ToString().Trim();
                form_VistaNormas.tboxPaginas.Texts = dgvNormas.CurrentRow.Cells[8].Value.ToString().Trim();
                form_VistaNormas.tboxCategoriaNorma.Texts = dgvNormas.CurrentRow.Cells[5].Value.ToString().Trim();
                form_VistaNormas.tboxMedioPublicacion.Texts = dgvNormas.CurrentRow.Cells[9].Value.ToString().Trim();
                form_VistaNormas.tboxEstado.Texts = dgvNormas.CurrentRow.Cells[11].Value.ToString().Trim();

                string inputFecha = dgvNormas.CurrentRow.Cells[7].Value.ToString().Trim();
                DateTime fecha;
                if (DateTime.TryParse(inputFecha, out fecha))
                {
                    form_VistaNormas.tboxFechaPublicacion.Texts = fecha.ToString("dd/MM/yyyy"); // Convertir a cadena en formato de fecha
                }
                else
                {
                    MessageBox.Show($"La fecha del registro '{inputFecha}' no es válida o está en un formato incorrecto.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    form_VistaNormas.tboxFechaPublicacion.Texts = "Fecha no válida";  // Mostrar mensaje en el TextBox si la fecha no es válida
                }

                form_VistaNormas.ShowDialog();
            }
        }
    }
}
