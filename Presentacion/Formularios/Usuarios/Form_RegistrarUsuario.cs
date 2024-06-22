using System;
using System.Windows.Forms;
using Negocio.Servicios;
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
                cboxRol.DataSource = NRoles.ListarRoles();
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
                    else if (tboxContraseña.Texts.Trim().Length < 8)
                    {
                        rpta = "La contraseña debe tener al menos 8 caracteres";
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
                            codUsuario,
                            Convert.ToInt32(cboxRol.SelectedValue)
                            );

                        Console.WriteLine("Rpta" + rpta);

                        Console.WriteLine("codUsuario: " + codUsuario);

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
                        if (contraseña.Length >= 8)
                        {
                            if (contraseña.Equals(tboxConfirmacion.Texts.Trim()))
                            {
                                // Llamada al método de encriptación solo si la contraseña no está vacía y es válida
                                contraseñaEncriptada = PasswordEncryptor.Encryptor(contraseña);
                            }
                            else
                            {
                                rpta = "La contraseña y la confirmación no coinciden";
                                MensajeError(rpta);
                                return; // Termina la ejecución del método si la validación falla
                            }
                        }
                        else
                        {
                            rpta = "La contraseña debe tener al menos 8 caracteres";
                            MensajeError(rpta);
                            return; // Termina la ejecución del método si la validación falla
                        }
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
