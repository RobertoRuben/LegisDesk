using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Reportes
{
    public partial class Form_Reporte : Form
    {
        public int codNorma;
        public Form_Reporte()
        {
            InitializeComponent();
        }

        private void Form_Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsNormas.Sp_Listado_Normas_Articulos' Puede moverla o quitarla según sea necesario.
            this.Sp_Listado_Normas_ArticulosTableAdapter.Fill(this.DsNormas.Sp_Listado_Normas_Articulos, codNorma);

            this.reportViewer1.RefreshReport();
        }
    }
}
