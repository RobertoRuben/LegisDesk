using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Formularios.Articulos;
using Presentacion.Formularios.Normas;
using Negocio.Servicios;

namespace Presentacion.Formularios.Articulos
{
    public partial class Form_Articulos : Form
    {
        public string numNorma;
        public string nombreNorma;
        public int idNorma;
        public int idUsuario;
        public string operacion = "";

        public Form_Articulos()
        {
            InitializeComponent();
            this.ListarArticulos();
            this.FormatoDataGrid();
        }
        private void Form_Articulos_Load(object sender, EventArgs e)
        {
            lblnumero.Text = numNorma;
            lblnombre.Text = nombreNorma;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscar()
        {
            try
            {
                dgvArticulos.DataSource = NArticulos.BuscarArticulos(idNorma,tbxBusqueda.Texts.Trim());
                lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvArticulos.Rows.Count);

                if (dgvArticulos.Rows.Count < 1)
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
            Form_RegistrarArticulos form_RegistrarArticulos = new Form_RegistrarArticulos();
            form_RegistrarArticulos.idUsuario = idUsuario;
            form_RegistrarArticulos.codNorma = idNorma;
            form_RegistrarArticulos.operacion = "Registrar";
            form_RegistrarArticulos.ShowDialog();
            this.ListarArticulos();
            this.FormatoDataGrid();
            //this.SeleccionarUltimoElemento();
        }

        public void ListarArticulos()
        {
            try
            {
                dgvArticulos.DataSource = NArticulos.ListarArticulos(Convert.ToInt32(idNorma));
                lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvArticulos.Rows.Count);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            tbxBusqueda.Texts = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form_RegistrarArticulos form_RegistrarArticulos = new Form_RegistrarArticulos();

            form_RegistrarArticulos.idUsuario = idUsuario;
            form_RegistrarArticulos.codNorma = idNorma;
            form_RegistrarArticulos.operacion = "Actualizar";

            if (dgvArticulos.SelectedRows.Count > 0)
            {
                form_RegistrarArticulos.idArticulo = Convert.ToInt32(dgvArticulos.CurrentRow.Cells[0].Value);
                form_RegistrarArticulos.tboxArticulo.Texts = dgvArticulos.CurrentRow.Cells[2].Value.ToString().Trim();
                form_RegistrarArticulos.tboxDenominacion.Texts = dgvArticulos.CurrentRow.Cells[3].Value.ToString().Trim();
                form_RegistrarArticulos.tboxDescripcion.Texts = dgvArticulos.CurrentRow.Cells[4].Value.ToString().Trim();
                form_RegistrarArticulos.numUpDownPagina.Value = Convert.ToDecimal(dgvArticulos.CurrentRow.Cells[5].Value.ToString().Trim());

                // Añadir la lógica para los RadioButtons
                string estado = dgvArticulos.CurrentRow.Cells[6].Value.ToString();
                if (estado.Equals("Vigente", StringComparison.OrdinalIgnoreCase))
                {
                    form_RegistrarArticulos.rbtnVigente.Checked = true;
                    form_RegistrarArticulos.rbtnDerogado.Checked = false;
                }
                else if (estado.Equals("Derogado", StringComparison.OrdinalIgnoreCase))
                {
                    form_RegistrarArticulos.rbtnVigente.Checked = false;
                    form_RegistrarArticulos.rbtnDerogado.Checked = true;
                }

                form_RegistrarArticulos.ShowDialog();

                Console.WriteLine("IdNorma: " + idNorma);
                Console.WriteLine("IdUsuario: " + idUsuario);
            }
            else
            {
                MessageBox.Show("Debes seleccionar al menos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //private void SeleccionarUltimoElemento()
        //{
        //    if (dgvArticulos.Rows.Count > 0)
        //    {
        //        dgvArticulos.ClearSelection();
        //        dgvArticulos.Rows[dgvArticulos.Rows.Count - 1].Selected = true;
        //        dgvArticulos.FirstDisplayedScrollingRowIndex = dgvArticulos.Rows.Count - 1;
        //    }
        //}

        public void FormatoDataGrid()
        {
            dgvArticulos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvArticulos.Columns[2].Width = 120;
            dgvArticulos.Columns[0].Visible = false;
            dgvArticulos.Columns[1].Visible = false;
            dgvArticulos.Columns[4].Visible = false;
            dgvArticulos.Columns[5].Visible = false;
            dgvArticulos.Columns[6].Visible = false;
            //dgvArticulos.Columns[8].Visible = false;
            //dgvArticulos.Columns[9].Visible = false;
            //dgvArticulos.Columns[10].Visible = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count > 0)
            {
                try
                {
                    // Mostrar mensaje de confirmación
                    DialogResult dialogResult = MessageBox.Show("¿Quieres eliminar esta norma?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        string rpta = NArticulos.EliminarArticulo(Convert.ToInt32(dgvArticulos.CurrentRow.Cells[0].Value));
                        if (rpta.Equals("Ok"))
                        {
                            this.MensajeOk("Se eliminó el registro");
                            this.ListarArticulos();
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
            this.Buscar();
            this.FormatoDataGrid();
        }
    }
}
