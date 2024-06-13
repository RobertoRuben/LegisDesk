using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Manipulaciones;
using Negocio.Servicios;

namespace Presentacion.Formularios.Normas
{
    public partial class Form_RegistrarArticulos : Form
    {
        public string operacion = "";
        public int codNorma;
        public int idArticulo;
        public int idUsuario;
        public Form_RegistrarArticulos()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_RegistrarArticulos_Load(object sender, EventArgs e)
        {

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
                // Si ninguno está seleccionado, puedes devolver un valor predeterminado o lanzar una excepción
                return ""; // O puedes devolver otro valor predeterminado
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Codigo Norma: " + codNorma);
            Console.WriteLine("Codigo usuario: " + idUsuario);
            Console.WriteLine("Operacion: " + operacion);
            //Form_Principal form_Principal = new Form_Principal();

            if (operacion.Equals("Registrar"))
            {
                try
                {
                    string rpta = "";
                    if (string.IsNullOrWhiteSpace(tboxArticulo.Texts) || string.IsNullOrWhiteSpace(tboxDenominacion.Texts)
                        || string.IsNullOrWhiteSpace(tboxDescripcion.Texts))
                    {
                        rpta = "Todos los campos no obligatorios";
                        MensajeError(rpta);

                    }
                    else
                    {
                        int numArticulo = Convert.ToInt32(tboxArticulo.Texts);
                        string denominacion = TransformarTexto.TransformarText(tboxDenominacion.Texts.Trim());
                        string descripcion = TransformarTexto.TransformarText(tboxDescripcion.Texts.Trim());
                        string estado = ObtenerEstadoNorma();
                        int paginas = (int)numUpDownPagina.Value;

                        Console.WriteLine("-------------Registro------------");
                        Console.WriteLine("CodNorma: " + codNorma);
                        Console.WriteLine("Num articulo: " + numArticulo);
                        Console.WriteLine("Denominacion: " + denominacion);
                        Console.WriteLine("Descripcion: " + descripcion);
                        Console.WriteLine("Estado: " + estado);
                        Console.WriteLine("Paginas: " + paginas);

                        rpta = NArticulos.RegistrarArticulos(codNorma, denominacion, descripcion, estado, numArticulo, paginas);

                        if (rpta.Equals("Ok"))
                        {

                            this.MensajeOk("Registro Existoso");
                            this.Close();
                        }
                        else
                        {
                            this.MensajeError(rpta);
                            Console.WriteLine(rpta);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else if (operacion.Equals("Actualizar"))
            {
                try
                {
                    string rpta = "";

                    if (string.IsNullOrWhiteSpace(tboxArticulo.Texts) || string.IsNullOrWhiteSpace(tboxDenominacion.Texts)
                        || string.IsNullOrWhiteSpace(tboxDescripcion.Texts))
                    {
                        rpta = "Todos los campos no obligatorios";
                        MensajeError(rpta);

                    }
                    else
                    {
                        int numArticulo = Convert.ToInt32(tboxArticulo.Texts);
                        string denominacion = TransformarTexto.TransformarText(tboxDenominacion.Texts.Trim());
                        string descripcion = TransformarTexto.TransformarText(tboxDescripcion.Texts.Trim());
                        string estado = ObtenerEstadoNorma();
                        int paginas = (int)numUpDownPagina.Value;

                        rpta = NArticulos.ActualizarArticulo(idArticulo,codNorma, denominacion, descripcion, estado, numArticulo, paginas);

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
                catch (Exception ex)
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
