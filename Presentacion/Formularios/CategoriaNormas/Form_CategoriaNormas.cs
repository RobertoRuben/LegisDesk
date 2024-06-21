using System;
using System.Windows.Forms;
using Negocio.Servicios;

namespace Presentacion.Formularios.CategoriaNormas
{
    public partial class Form_CategoriaNormas : Form
    {
        public string operacion;
        public int codUsuario;

        public Form_CategoriaNormas()
        {
            InitializeComponent();
            this.ListarCategorias();
            this.FormatoDataGrid();
        }
 
        public void FormatoDataGrid()
        {
            dgvCategoriaNormas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCategoriaNormas.Columns[0].Width = 120;
        }
        public void ListarCategorias()
        {
            try
            {
                dgvCategoriaNormas.DataSource = NCategoriasNormas.ListarCategoriasNormas();
                lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvCategoriaNormas.Rows.Count);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
        private void Buscar()
        {
            try
            {
                dgvCategoriaNormas.DataSource = NCategoriasNormas.BuscarCategoriasNormas(tbxBusqueda.Texts.Trim());
                lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvCategoriaNormas.Rows.Count);

                if (dgvCategoriaNormas.Rows.Count < 1)
                {
                    MessageBox.Show("No se encontraron resultados", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
        private void SeleccionarUltimoElemento()
        {
            if (dgvCategoriaNormas.Rows.Count > 0)
            {
                dgvCategoriaNormas.ClearSelection();
                dgvCategoriaNormas.Rows[dgvCategoriaNormas.Rows.Count - 1].Selected = true;
                dgvCategoriaNormas.FirstDisplayedScrollingRowIndex = dgvCategoriaNormas.Rows.Count - 1;
            }
        }
        private void SeleccionarFilaPorCodigo(int codigo)
        {
            // Deselecciona todas las filas primero
            dgvCategoriaNormas.ClearSelection();

            foreach (DataGridViewRow row in dgvCategoriaNormas.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == codigo)
                {
                    row.Selected = true;
                    dgvCategoriaNormas.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form_RegistroCategoria frmRegistroCategoria = new Form_RegistroCategoria();
            Console.WriteLine("CodUsuario Formulario Categoria Norma: " + codUsuario);
            frmRegistroCategoria.codUsuario = codUsuario;
            frmRegistroCategoria.operacion = "Registrar";
            frmRegistroCategoria.ShowDialog();
            this.ListarCategorias();
            this.FormatoDataGrid();
            this.SeleccionarUltimoElemento();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form_RegistroCategoria frmRegistroCategoria = new Form_RegistroCategoria();

            if (dgvCategoriaNormas.SelectedRows.Count > 0)
            {
                frmRegistroCategoria.codUsuario = codUsuario;
                frmRegistroCategoria.operacion = "Actualizar";
                frmRegistroCategoria.codCategoriaNorma = Convert.ToInt32(dgvCategoriaNormas.CurrentRow.Cells[0].Value);
                frmRegistroCategoria.tboxNombreCategoria.Texts = dgvCategoriaNormas.CurrentRow.Cells[1].Value.ToString().Trim();
                frmRegistroCategoria.ShowDialog();
                this.ListarCategorias();
                this.FormatoDataGrid();
                SeleccionarFilaPorCodigo(frmRegistroCategoria.codCategoriaNorma);
            }
            else
            {
                MessageBox.Show("Debes al menos seleccionar una categoría de norma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategoriaNormas.SelectedRows.Count > 0)
                {
                    int codCategoria = Convert.ToInt32(dgvCategoriaNormas.CurrentRow.Cells[0].Value);

                    // Mostrar MessageBox de confirmación
                    DialogResult result = MessageBox.Show("¿Deseas eliminar este rol?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string rpta = NCategoriasNormas.EliminarCategoriaNormas(codCategoria, codUsuario);

                        if (rpta.Equals("Ok"))
                        {
                            this.MensajeOk("Se elimino la categoria");
                            this.ListarCategorias();
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
