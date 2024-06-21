using System;
using System.Windows.Forms;
using Negocio.Servicios;
using Presentacion.Reportes;
using Presentacion.Formularios.Normas;

namespace Presentacion.Formularios.Consultas
{
    public partial class Form_ConsultasNormas : Form
    {
        public int codUsuario;
        public string operacion = "";

        public Form_ConsultasNormas()
        {
            InitializeComponent();
            this.ListarNormas();
            this.FormatoDataGrid();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Form_VistaNormas form_VistaNormas = new Form_VistaNormas();
        
            if (dgvNormas.SelectedRows.Count > 0)
            {
                form_VistaNormas.codUsuario = codUsuario;
                form_VistaNormas.codNorma = Convert.ToInt32(dgvNormas.CurrentRow.Cells[0].Value);

                form_VistaNormas.operacion = "Modificar";
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
                    form_VistaNormas.tboxFechaPublicacion.Texts = fecha.ToString("dd/MM/yyyy"); 
                }
                else
                {
                    MessageBox.Show($"La fecha del registro '{inputFecha}' no es válida o está en un formato incorrecto.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    form_VistaNormas.tboxFechaPublicacion.Texts = "Fecha no válida";  
                }

                form_VistaNormas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debes seleccionar al menos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if(dgvNormas.SelectedRows.Count > 0)
            {
                Form_Reporte form_Reporte = new Form_Reporte();
                form_Reporte.codNorma = Convert.ToInt32(dgvNormas.CurrentRow.Cells[0].Value);
                form_Reporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debes seleccionar al menos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            if (dgvNormas.SelectedRows.Count > 0)
            {
                Form_ConsultaArticulos form_ConsultaArticulos = new Form_ConsultaArticulos();
                form_ConsultaArticulos.codNorma = Convert.ToInt32(dgvNormas.CurrentRow.Cells[0].Value);
                form_ConsultaArticulos.nombreNorma = dgvNormas.CurrentRow.Cells[4].Value.ToString();
                form_ConsultaArticulos.numNorma = dgvNormas.CurrentRow.Cells[3].Value.ToString().Trim();
                form_ConsultaArticulos.ListarArticulos();
                form_ConsultaArticulos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debes seleccionar al menos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            tbxBusqueda.Texts = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.NormasBuscar();
        }
    }
}
