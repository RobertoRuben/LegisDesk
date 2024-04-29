using Presentacion.Usuarios;
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

namespace Presentacion.Formularios.Usuarios
{
    public partial class Form_Usuarios : Form
    {
        public string operacion;
        public int idUsuarioSesion;
        public Form_Usuarios()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            try
            {
                dgvUsuarios.DataSource = NUsuarios.ListarUsuario();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form_RegistrarUsuario frmRegistro = new Form_RegistrarUsuario();
            frmRegistro.CargarRoles();
            frmRegistro.CargarTrabajadores();
            frmRegistro.operacion = "Registrar";
            frmRegistro.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form_RegistrarUsuario frmRegistro = new Form_RegistrarUsuario();

            if(dgvUsuarios.SelectedRows.Count > 0)
            {
                frmRegistro.operacion = "Actualizar";
                frmRegistro.codTrabajador = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);

                frmRegistro.CargarRoles();
                frmRegistro.CargarTrabajadores();
                frmRegistro.cboxTrabajadores.Texts = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                frmRegistro.cboxTrabajadores.Enabled = false;
                frmRegistro.tboxNombreUsuario.Texts = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                //frmRegistro.tboxContraseña.Texts = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                frmRegistro.cboxRol.Texts = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            }
            frmRegistro.ShowDialog();

        }

        private void Form_Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
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
    }
}
