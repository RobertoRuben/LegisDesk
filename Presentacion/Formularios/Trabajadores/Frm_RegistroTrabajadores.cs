﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Usuarios
{
    public partial class Frm_RegistroTrabajadores : Form
    {
        public int codUsuario;
        public string operacion;

        public Frm_RegistroTrabajadores()
        {
            InitializeComponent();
        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Normas_Load(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ID: " + codUsuario);
        }
    }
}
