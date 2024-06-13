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
using Negocio.Manipulaciones;
using Presentacion.Formularios.Consultas;
using System.Globalization;

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
            Form_VerNormas form_VerNormas = new Form_VerNormas();
            if (dgvNormas.SelectedRows.Count > 0)
            {
                form_VerNormas.codUsuario = codUsuario;
                form_VerNormas.codNorma = Convert.ToInt32(dgvNormas.CurrentRow.Cells[0].Value);

                form_VerNormas.operacion = "Modificar";
                form_VerNormas.tboxNumNorma.Texts = dgvNormas.CurrentRow.Cells[3].Value.ToString().Trim();
                form_VerNormas.tboxNombreNorma.Texts = dgvNormas.CurrentRow.Cells[4].Value.ToString();
                form_VerNormas.tboxResumen.Texts = dgvNormas.CurrentRow.Cells[6].Value.ToString().Trim();
                form_VerNormas.linkEnlace.Text = dgvNormas.CurrentRow.Cells[10].Value.ToString().Trim();
                form_VerNormas.tboxPaginas.Texts = dgvNormas.CurrentRow.Cells[8].Value.ToString().Trim();
                form_VerNormas.tboxCategoriaNorma.Texts = dgvNormas.CurrentRow.Cells[5].Value.ToString().Trim();
                form_VerNormas.tboxMedioPublicacion.Texts = dgvNormas.CurrentRow.Cells[9].Value.ToString().Trim();
                form_VerNormas.tboxEstado.Texts = dgvNormas.CurrentRow.Cells[11].Value.ToString().Trim();

                string inputFecha = dgvNormas.CurrentRow.Cells[7].Value.ToString().Trim();
                DateTime fecha;
                if (DateTime.TryParse(inputFecha, out fecha))
                {
                    form_VerNormas.tboxFechaPublicacion.Texts = fecha.ToString("dd/MM/yyyy"); // Convertir a cadena en formato de fecha
                }
                else
                {
                    MessageBox.Show($"La fecha del registro '{inputFecha}' no es válida o está en un formato incorrecto.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    form_VerNormas.tboxFechaPublicacion.Texts = "Fecha no válida";  // Mostrar mensaje en el TextBox si la fecha no es válida
                }

                form_VerNormas.ShowDialog();
            }
        }

        public void ListarNormas()
        {
            try
            {
                dgvNormas.DataSource = NNormas.ListarNormas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void FormatoDataGrid()
        {
            dgvNormas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvNormas.Columns[0].Width = 120;
            dgvNormas.Columns[1].Visible = false;
            dgvNormas.Columns[2].Visible = false;
            dgvNormas.Columns[7].Visible = false;
            dgvNormas.Columns[8].Visible = false;
            dgvNormas.Columns[9].Visible = false;
            dgvNormas.Columns[10].Visible = false;

        }
    }
}
