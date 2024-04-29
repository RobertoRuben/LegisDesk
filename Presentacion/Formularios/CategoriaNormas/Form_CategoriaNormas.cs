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

namespace Presentacion.Formularios.CategoriaNormas
{
    public partial class Form_CategoriaNormas : Form
    {
        public string operacion;
        public int codUsuario;

        public Form_CategoriaNormas()
        {
            InitializeComponent();
        }
        private void Form_CategoriaNormas_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
        public void Listar()
        {
            try
            {
                dgvCategoriaNormas.DataSource = NCategoriasNormas.ListarNormas();
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
            Listar();
            SeleccionarUltimoElemento();
            
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
                Listar();
                SeleccionarFilaPorCodigo(frmRegistroCategoria.codCategoriaNorma);
            }
            else
            {
                MessageBox.Show("Debes al menos seleccionar una categoría de norma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
