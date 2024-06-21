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

namespace Presentacion.Formularios.CategoriaNormas
{
    public partial class Form_RegistroCategoria : Form
    {
        public string operacion = "";
        public int codUsuario;
        public int codCategoriaNorma;
        public Form_RegistroCategoria()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form_CategoriaNormas frmCategoriaNormas = new Form_CategoriaNormas();
            frmCategoriaNormas.btnNuevo.BackColor = Color.Black;
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
        
        private bool ContieneNumeros(string texto)
        {
            return texto.Any(char.IsDigit);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (operacion.Equals("Registrar"))
            {
                try
                {
                    string rpta = "";
                    if (string.IsNullOrWhiteSpace(tboxNombreCategoria.Texts))
                    {
                        rpta = "Todos los campos no obligatorios";
                        MensajeError(rpta);

                    }
                    else if (ContieneNumeros(tboxNombreCategoria.Texts.Trim()))
                    {
                        rpta = "El nombre de la cateogoria de una norma no debe contener números";
                        MensajeError(rpta);
                    }
                    else
                    {
                        string nombreCategoria = TransformarTexto.TransformarText(tboxNombreCategoria.Texts.Trim());
                        Console.WriteLine(nombreCategoria);
                        rpta = NCategoriasNormas.RegistrarCategoriaNormas(nombreCategoria, codUsuario);

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
            }else if (operacion.Equals("Actualizar"))
            {
                try
                {
                    string rpta = "";

                    if (string.IsNullOrWhiteSpace(tboxNombreCategoria.Texts))
                    {
                        rpta = "No puede actualizar un registro con un campo en blanco";
                        MensajeError(rpta);
                    }
                    else
                    {
                        string nombreCategoria = TransformarTexto.TransformarText(tboxNombreCategoria.Texts.Trim());
                        rpta = NCategoriasNormas.ActualizarCategoriaNormas(codCategoriaNorma, nombreCategoria, codUsuario);

                        if (rpta.Equals("Ok"))
                        {
                            this.MensajeOk("Registro Existoso");
                            Form_CategoriaNormas frmCategoriaNormas = new Form_CategoriaNormas();
                            frmCategoriaNormas.ListarCategorias();
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
    }
}
