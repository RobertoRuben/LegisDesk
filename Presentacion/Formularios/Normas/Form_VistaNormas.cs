using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Presentacion.Formularios.Normas
{
    public partial class Form_VistaNormas : Form
    {
        public int codUsuario;
        public int codNorma;
        public string operacion;

        public Form_VistaNormas()
        {
            InitializeComponent();
        }

        private void linkEnlace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = linkEnlace.Text, // Asumiendo que el texto del LinkLabel es la URL
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace porque no es valido. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
