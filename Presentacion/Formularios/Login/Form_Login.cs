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
using Presentacion.Formularios;
namespace Presentacion.Formularios.Login
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = NUsuarios.Login((tboxUsuario.Texts.Trim()), (tboxContraseña.Texts.Trim()));
                if (tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (Convert.ToBoolean(tabla.Rows[0][2])==false)
                    {
                        MessageBox.Show("Usuario inhabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Form_Principal form_Principal = new Form_Principal();
                        form_Principal.IdUsuario = Convert.ToInt32(tabla.Rows[0][0]);
                        form_Principal.usuario = Convert.ToString(tabla.Rows[0][1]);
                        form_Principal.rol = Convert.ToString(tabla.Rows[0][3]);
                        form_Principal.nombre = Convert.ToString(tabla.Rows[0][4]);

                        form_Principal.ShowDialog();
                        this.Hide();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
