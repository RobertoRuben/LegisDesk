using System;
using System.Windows.Forms;
using Negocio.Servicios;
using Presentacion.Usuarios;

namespace Presentacion.Formularios.Trabajadores
{
    public partial class Form_Trabajadores : Form
    {
        public int codUsuario;
        public string operacion;

        public Form_Trabajadores()
        {
            InitializeComponent();
            this.ListarTrabajadores();
            this.FormatoDataGrid();
        }
        public void FormatoDataGrid()
        {
            dgvTrabajadores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTrabajadores.Columns[0].Width = 120;
        }

        private void SeleccionarUltimoElemento()
        {
            if (dgvTrabajadores.Rows.Count > 0)
            {
                dgvTrabajadores.ClearSelection();
                dgvTrabajadores.Rows[dgvTrabajadores.Rows.Count - 1].Selected = true;
                dgvTrabajadores.FirstDisplayedScrollingRowIndex = dgvTrabajadores.Rows.Count - 1;
            }
        }
        public void ListarTrabajadores()
        {
            try
            {
                dgvTrabajadores.DataSource = NTrabajadores.ListarTrabajadores();
                lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvTrabajadores.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BuscarUsuarios()
        {
            try
            {
                dgvTrabajadores.DataSource = NUsuarios.BuscarUsuario(tbxBusqueda.Texts.Trim());
                lblResultados.Text = "Total de Registros: " + Convert.ToString(dgvTrabajadores.Rows.Count);

                if (dgvTrabajadores.Rows.Count < 1)
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
            Frm_RegistroTrabajadores frm_RegistroTrabajadores = new Frm_RegistroTrabajadores();
            frm_RegistroTrabajadores.codUsuario = codUsuario;
            frm_RegistroTrabajadores.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            tbxBusqueda.Texts = "";
        }
    }

}
