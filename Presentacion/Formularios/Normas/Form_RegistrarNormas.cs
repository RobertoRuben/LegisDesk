using System;
using System.Data;
using System.Windows.Forms;
using Negocio.Servicios;
using Negocio.Manipulaciones;

namespace Presentacion.Formularios.Normas
{
    public partial class Form_RegistrarNormas : Form
    {
        public int codUsuario;
        public int codNorma;
        public string operacion;

        public Form_RegistrarNormas()
        {
            InitializeComponent();
            cboxMedioPublicacion.SelectedIndex = 0;
            tboxNumNorma.SetFocus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string ObtenerEstadoNorma()
        {
            if (rbtnVigente.Checked)
            {
                return "Vigente";
            }
            else if (rbtnDerogado.Checked)
            {
                return "Derogado";
            }
            else
            {
                return ""; 
            }
        }

        public void CargarNormas()
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = NCategoriasNormas.ListarCategoriasNormas();
                cboxCategoriaNorma.DataSource = tabla;

                cboxCategoriaNorma.DisplayMember = "Categoria de Norma";

                cboxCategoriaNorma.ValueMember = "Codigo";
                cboxCategoriaNorma.Texts = "Selecciona la Categoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                Console.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (operacion.Equals("Registrar"))
            {
                Console.WriteLine("La operacion fue registrar");
                try
                {
                    string rpta = "";

                    if (string.IsNullOrWhiteSpace(tboxNumNorma.Texts) ||
                        string.IsNullOrWhiteSpace(tboxNombreNorma.Texts) ||
                        string.IsNullOrWhiteSpace(tboxResumen.Texts) ||
                        cboxCategoriaNorma.SelectedIndex == -1 ||
                        cboxMedioPublicacion.SelectedIndex == -1)
                    {
                        rpta = "Debe completar todos los campos, el campo link de publicacion es opcional";
                        MensajeError(rpta); // Suponiendo que esta función está correctamente implementada para mostrar un mensaje de error
                    }
                    else
                    {
                        int codigoTipoNorma = (int)cboxCategoriaNorma.SelectedValue;
                        string numNorma = TransformarTexto.TransformarText(tboxNumNorma.Texts.Trim());
                        string nombreNorma = TransformarTexto.TransformarText(tboxNombreNorma.Texts.Trim());
                        string resumenNorma = TransformarTexto.TransformarText(tboxResumen.Texts.Trim());
                        string fecha = dtpFechaRegistro.Value.ToString().Trim();
                        int paginas = (int)NumUpDownPaginas.Value;
                        string medioPublicacion = cboxMedioPublicacion.Texts.Trim();
                        string estado = ObtenerEstadoNorma();

                        rpta = NNormas.RegistrarNormas(
                            codUsuario, 
                            codigoTipoNorma, 
                            numNorma,  
                            nombreNorma,
                            resumenNorma,
                            fecha,
                            paginas, 
                            medioPublicacion, 
                            tboxLink.Texts.Trim(), 
                            estado
                            );

                        Console.WriteLine("N Norma: " + numNorma);
                        Console.WriteLine("Nombre: " + nombreNorma);
                        Console.WriteLine("Resumen: " +resumenNorma);
                        Console.WriteLine("Fecha Publicacion: " + fecha);

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
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else if (operacion.Equals("Modificar"))
            {
                Console.WriteLine("La operacion fue modificar");
                Console.WriteLine("Nombre de norma: ");
                Console.WriteLine("Codigo de la norma: " + cboxCategoriaNorma.SelectedValue);

                try
                {
                    string rpta = "";

                    if (string.IsNullOrWhiteSpace(tboxNumNorma.Texts) ||
                        string.IsNullOrWhiteSpace(tboxNombreNorma.Texts) ||
                        string.IsNullOrWhiteSpace(tboxResumen.Texts))
                    { 
                        rpta = "Todos los campos son obligatorios";
                        MensajeError(rpta); // Suponiendo que esta función está correctamente implementada para mostrar un mensaje de error
                    }
                    else
                    {
                        int codigoTipoNorma = (int)cboxCategoriaNorma.SelectedValue;
                        string numNorma = TransformarTexto.TransformarText(tboxNumNorma.Texts.Trim());
                        string nombreNorma = TransformarTexto.TransformarText(tboxNombreNorma.Texts.Trim());
                        string resumenNorma = TransformarTexto.TransformarText(tboxResumen.Texts.Trim());
                        string fecha = dtpFechaRegistro.Value.ToString().Trim();
                        int paginas = (int)NumUpDownPaginas.Value;
                        string medioPublicacion = cboxMedioPublicacion.Texts.Trim();
                        string estado = ObtenerEstadoNorma();

                        rpta = NNormas.ActualizarNormas(
                            codNorma,
                            codigoTipoNorma,
                            numNorma,
                            nombreNorma,
                            resumenNorma,
                            fecha,
                            paginas,
                            medioPublicacion,
                            tboxLink.Texts.Trim(),
                            estado,
                            codUsuario
                            );

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

    }
}
