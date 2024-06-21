using System;
using System.Linq;
using System.Windows.Forms;
using Negocio.Servicios;
using Negocio.Manipulaciones;

namespace Presentacion.Formularios.Roles
{
    public partial class Form_RegistroRoles : Form
    {
        public int codUsuario;
        public int codRol;
        public string operacion="";
        public Form_RegistroRoles()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            if (operacion.Equals("Registrar"))
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(tboxNombreRol.Texts.Trim()))
                    {
                        rpta = "Todos los campos son obligatorios";
                        MensajeError(rpta);
                    }
                    else if (ContieneNumeros(tboxNombreRol.Texts.Trim()))
                    {
                        rpta = "El nombre del rol no debe contener números";
                        MensajeError(rpta);
                    }
                    else
                    {
                        rpta = NRoles.RegistrarRoles(TransformarTexto.TransformarText(tboxNombreRol.Texts.Trim()), codUsuario);

                        if (rpta.Equals("Ok"))
                        {
                            this.MensajeOk("Registro Existoso");
                            this.Close();
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
  
            }
            else if (operacion.Equals("Actualizar"))
            {

                try
                {
                    if (string.IsNullOrWhiteSpace(tboxNombreRol.Texts.Trim()))
                    {
                        rpta = "Para actualizar el registro no debes dejar la casilla en blanco";
                        MensajeError(rpta);
                    }
                    else if (ContieneNumeros(tboxNombreRol.Texts.Trim()))
                    {
                        rpta = "El nombre del rol no debe contener números";
                        MensajeError(rpta);
                    }
                    else
                    {
                        rpta = NRoles.ActulizarRoles(codUsuario, codRol, (TransformarTexto.TransformarText(tboxNombreRol.Texts.Trim())));

                        if (rpta.Equals("Ok"))
                        {
                            this.MensajeOk("Se Actualizo Existoso");
                            this.Close();

                            Console.WriteLine("Codigo Usuario: " + codUsuario);
                            Console.WriteLine("codRol: " + codRol);
                            Console.WriteLine("Operacion: " + operacion);
                        }
                        else
                        {
                            this.MensajeError(rpta);
                            Console.WriteLine("Codigo Usuario: " + codUsuario);
                            Console.WriteLine("codRol: " + codRol);
                            Console.WriteLine("Operacion: " + operacion);
                        }
                    }
                }
                catch(Exception ex)
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

        private bool ContieneNumeros(string texto)
        {
            return texto.Any(char.IsDigit);
        }
    }
}
