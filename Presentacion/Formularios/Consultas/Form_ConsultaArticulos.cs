using System;
using System.Windows.Forms;
using Negocio.Servicios;

namespace Presentacion.Formularios.Consultas
{
    public partial class Form_ConsultaArticulos : Form
    {
        public string numNorma;
        public string nombreNorma;
        public int codNorma;

        public Form_ConsultaArticulos()
        {
            InitializeComponent();
            this.ListarArticulos();
            this.FormatoDataGrid();
        }
        private void Form_ConsultaArticulos_Load(object sender, EventArgs e)
        {
            lblnumero.Text = numNorma;
            lblnombre.Text = nombreNorma;
        }
        public void ListarArticulos()
        {
            try
            {
                dgvArticulos.DataSource = NArticulos.ListarArticulos(Convert.ToInt32(codNorma));
                lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvArticulos.Rows.Count);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
            this.FormatoDataGrid();
        }

        public void FormatoDataGrid()
        {
            dgvArticulos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvArticulos.Columns[2].Width = 120;
            dgvArticulos.Columns[0].Visible = false;
            dgvArticulos.Columns[1].Visible = false;
            dgvArticulos.Columns[4].Visible = false;
            dgvArticulos.Columns[5].Visible = false;
            dgvArticulos.Columns[6].Visible = false;

        }

        private void Buscar()
        {
            try
            {
                dgvArticulos.DataSource = NArticulos.BuscarArticulos(codNorma, tbxBusqueda.Texts.Trim());
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            tbxBusqueda.Texts = "";
        }
    }
}
