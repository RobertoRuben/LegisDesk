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
using Negocio.Seguridad;

namespace Presentacion.Usuarios
{
    public partial class Form_RegistrarUsuario : Form
    {
        public string operacion = "";
        public int codUsuario;

        public Form_RegistrarUsuario()
        {
            InitializeComponent();
        }
        private void Form_RegistrarUsuario_Load(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string ObtenerEstado()
        {
            if (rbtnActivo.Checked)
            {
                return "Activo";
            }
            else if (rbtnInactivo.Checked)
            {
                return "Inactivo";
            }
            else
            {
                return "Estado no definido";
            }
        }

        public void CargarTrabajadores()
        {
            try
            {
                cboxTrabajadores.DataSource = NTrabajadores.ListarTrabajadores();
                cboxTrabajadores.DisplayMember = "Nombres";
                cboxTrabajadores.ValueMember = "CodTrabajador";
                cboxTrabajadores.Texts = "Seleccione un trabajador";

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                Console.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        public void CargarRoles()
        {
            try
            {
                cboxRol.DataSource = NRol.ListarRoles();
                cboxRol.DisplayMember = "Nombre del Rol";
                cboxRol.ValueMember = "CodRol";
                cboxRol.Texts = "Seleccione un Rol";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void Limpiar()
        {
            cboxTrabajadores.SelectedIndex = -1;
            tboxNombreUsuario.Texts = "";
            tboxContraseña.Texts = "";
            tboxConfirmacion.Texts = "";
            cboxRol.SelectedIndex = -1;

        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (operacion.Equals("Registrar"))
            {
                try
                {
                    string rpta = "";
                    if (cboxTrabajadores.SelectedIndex == -1 ||
                        string.IsNullOrWhiteSpace(tboxNombreUsuario.Texts)||
                        string.IsNullOrWhiteSpace(tboxContraseña.Texts)||
                        string.IsNullOrWhiteSpace(tboxConfirmacion.Texts)||
                        cboxRol.SelectedIndex==-1)
                    {
                        rpta = "Verificar, todos los campos obligatorios";
                        MensajeError(rpta);
                    }
                    else if (!tboxContraseña.Texts.Trim().Equals(tboxConfirmacion.Texts.Trim()))
                    {
                        rpta = "La contraseña y la confirmación no coinciden";
                        MensajeError(rpta);
                    }
                    else
                    {
                        string estado = ObtenerEstado();
                        //int codRol = Convert.ToInt32(cboxRol.SelectedValue);

                        rpta = NUsuarios.RegistrarUsuario(
                            Convert.ToInt32(cboxTrabajadores.SelectedValue),
                            tboxNombreUsuario.Texts.Trim(),
                            PasswordEncryptor.Encryptor(tboxContraseña.Texts.Trim()),
                            estado,
                            Convert.ToInt32(cboxRol.SelectedValue)
                            );
                        if (rpta.Equals("Ok"))
                        {
                            this.MensajeOk("Registro exitoso");
                            this.Close();
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else if (operacion.Equals("Actualizar"))
            {
                Console.WriteLine("Operacion: " + operacion);
                Console.WriteLine("Id Trabajador: " + codUsuario);
                try
                {
                    string rpta = "";
                    string estado = ObtenerEstado();
                    // Validación de contraseña no vacía
                    string contraseña = tboxContraseña.Texts.Trim();
                    string contraseñaEncriptada = string.Empty;

                    if (!string.IsNullOrWhiteSpace(contraseña))
                    {
                        // Llamada al método de encriptación solo si la contraseña no está vacía
                        contraseñaEncriptada = PasswordEncryptor.Encryptor(contraseña);
                    }

                    int rolTrabajador = (int)cboxRol.SelectedValue;
                    string nombreUsuario = tboxNombreUsuario.Texts.Trim();

                    // Resto del código de actualización
                    rpta = NUsuarios.ActualizarUsuario(
                        codUsuario,
                        rolTrabajador,
                        nombreUsuario,
                        contraseñaEncriptada,
                        estado
                    );
                    if (rpta.Equals("Ok"))
                    {
                        this.MensajeOk("Se actualizó el registro");
                        this.Close();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                        Console.WriteLine("CodUsuario: " + codUsuario);
                        Console.WriteLine("Rol Trabajador: " + rolTrabajador);
                        Console.WriteLine("Nombre Usuario: " + nombreUsuario);
                        Console.WriteLine("Contraseña: " + contraseña);
                        Console.WriteLine("Estado: " + estado);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }
    }
}
