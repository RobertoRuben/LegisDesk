using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Presentacion.Formularios.CategoriaNormas;
using Presentacion.Formularios.Normas;
using Presentacion.Formularios.Usuarios;
using Presentacion.Formularios.Trabajadores;
using Presentacion.Formularios.Roles;
using Presentacion.Formularios.Consultas;

namespace Presentacion
{
    public partial class Form_Principal : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form formularioHijoActual;

        public int IdUsuario;
        public string usuario;
        public string nombre;
        public string rol;

        public Form_Principal()
        {
            InitializeComponent();
            PersonalizarDiseño();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pMenuLateral.Controls.Add(leftBorderBtn);

            this.ControlBox = false;
            //Ocultar barra de titulo
            this.Text = string.Empty;
            
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuario;
            lblRol.Text = rol;
            lblFormularioHijo.Text = "Bienvenido " + nombre;
        }

        private void PersonalizarDiseño()
        {
            pSubMenuNormas.Visible = false;
            pSubMenuUsuarios.Visible = false;
        }
        private void OcultarSubMenu()
        {
            if(pSubMenuNormas.Visible == true)
            {

                pSubMenuNormas.Visible = false;
            }
            if(pSubMenuUsuarios.Visible == true)
            {
                pSubMenuUsuarios.Visible = false;
            }
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private struct RGBColors
        {
            public static Color color = Color.FromArgb(0, 80, 200);
            public static Color color2 = Color.FromArgb(200, 241, 51, 51);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(26, 32, 40);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Form_ConsultasNormas form_ConsultasNormas = new Form_ConsultasNormas();
            ActivateButton(sender, RGBColors.color);
            lblFormularioHijo.Text = "Consulta de Normas";
            MostrarSubMenu(pSubMenuNormas);
            AbrirFormularioHijo(form_ConsultasNormas);
            
        }

        /***Gestion de Normas***/
        private void btnNormas_Click(object sender, EventArgs e)
        {
            Form_Normas form_Normas = new Form_Normas();
            form_Normas.codUsuario = IdUsuario;
            ActivateButton(sender, RGBColors.color);
            lblFormularioHijo.Text = "Gestión de Normas";
            MostrarSubMenu(pSubMenuNormas);
            AbrirFormularioHijo(form_Normas);
            
        }
        //Categoria de Normas
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            //Proximo Codigo
            lblFormularioHijo.Text = "Categorías de Normas";
            Form_CategoriaNormas form_CategoriaNormas = new Form_CategoriaNormas();
            form_CategoriaNormas.codUsuario = IdUsuario;
            AbrirFormularioHijo(form_CategoriaNormas);
            Console.WriteLine("COD USUARIO: " + form_CategoriaNormas.codUsuario);
        }

        /*** Gestion de Usuarios ***/
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            lblFormularioHijo.Text = "Gestión de Usuarios";
            MostrarSubMenu(pSubMenuUsuarios);
            ActivateButton(sender, RGBColors.color);
            Form_Usuarios form_Usuarios = new Form_Usuarios();
            form_Usuarios.idUsuarioSesion = IdUsuario;
            AbrirFormularioHijo(form_Usuarios);
            
        }
        //Roles de Usuario
        private void btnRoles_Click(object sender, EventArgs e)
        {
            lblFormularioHijo.Text = "Gestion de Roles";
            Form_Roles form_Roles = new Form_Roles();
            form_Roles.codUsuario = IdUsuario;
            AbrirFormularioHijo(form_Roles);

        }

        //Trabajadores
        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            lblFormularioHijo.Text = "Gestion de Trabajadores";
            Form_Trabajadores form_Trabajadores = new Form_Trabajadores();
            form_Trabajadores.codUsuario = IdUsuario;
            AbrirFormularioHijo(form_Trabajadores);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OcultarSubMenu();
            Application.Exit();
        }

        //Sub Menu Normas

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }
        private void Reiniciar()
        {
            OcultarSubMenu();
            DisableButton();
            leftBorderBtn.Visible = false;
        }
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formularioHijoActual != null)
            {
                formularioHijoActual.Close();
            }
            formularioHijoActual = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pContenedor.Controls.Add(formularioHijo);
            pContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void timerHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'del' yyyy");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Form_UsuarioActualizarCredenciales form_UsuarioActualizarCredenciales = new Form_UsuarioActualizarCredenciales();
            form_UsuarioActualizarCredenciales.codUsuario = IdUsuario;
            form_UsuarioActualizarCredenciales.tboxNombreUsuario.Texts = usuario;
            form_UsuarioActualizarCredenciales.ShowDialog();
        }
    }
}
