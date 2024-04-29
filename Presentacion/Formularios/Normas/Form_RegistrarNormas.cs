using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.Normas
{
    public partial class Form_RegistrarNormas : Form
    {
        public int codUsuario;
        public string operacion;

        public Form_RegistrarNormas()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CodUsuario: " + codUsuario);
            Console.WriteLine("Operacion: " + operacion);
            if (operacion.Equals("Registrar"))
            {
                Console.WriteLine("La operacion fue registrar");
                try
                {

                }
                catch(Exception ex)
                {

                }
            }
            else if (operacion.Equals("Modificar"))
            {
                Console.WriteLine("La operacion fue modificar");
            }
        }
    }
}
