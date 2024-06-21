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
using Negocio.Seguridad;

namespace Presentacion.Formularios.Usuarios
{
    public partial class Form_UsuarioActualizarCredenciales : Form
    {
        public int codUsuario;
        public string nombreUsuario;

        public Form_UsuarioActualizarCredenciales()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            Console.WriteLine("Nombre de usuario: " + codUsuario);
            try
            {
                string rpta = "";
                if (string.IsNullOrWhiteSpace(tboxNombreUsuario.Texts))
                {
                    rpta = "El campo nombre de usuario no puede quedar en blanco";
                    MensajeError(rpta);
                }
                else if (!string.IsNullOrWhiteSpace(tboxContraseña.Texts) && tboxContraseña.Texts.Trim().Length < 8)
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
                    string contraseña = tboxContraseña.Texts.Trim();

                    if (contraseña.Equals(""))
                    {
                        rpta = NUsuarios.ActualizarCredenciales(codUsuario,
                        tboxNombreUsuario.Texts.Trim(), contraseña
                        );
                    }
                    else
                    {
                        string contraseñaEncriptada = PasswordEncryptor.Encryptor(contraseña);
                        rpta = NUsuarios.ActualizarCredenciales(codUsuario,
                        tboxNombreUsuario.Texts.Trim(), contraseñaEncriptada
                        );

                    }

                    if (rpta.Equals("Ok"))
                    {
                        this.MensajeOk("Se actualizaron los credenciales" );
                        this.Close();
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
}
