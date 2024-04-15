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

namespace Presentacion.Formularios.CategoriaNormas
{
    public partial class Form_CategoriaNormas : Form
    {
        public Form_CategoriaNormas()
        {
            InitializeComponent();
        }
        private void Form_CategoriaNormas_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
        public void Listar()
        {
            try
            {
                dgvCategoriaNormas.DataSource = NCategoriasNormas.ListarNormas();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
    }
}
